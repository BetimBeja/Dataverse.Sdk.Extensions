﻿using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Dataverse.Sdk.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// Get value of an attribute from a linked entity
        /// </summary>
        /// <typeparam name="T">Type of the attribute to get</typeparam>
        /// <param name="record">Record containing the attribute</param>
        /// <param name="alias">Alias of the linked entity</param>
        /// <param name="attribute">Logical name of the attribute</param>
        /// <returns>Value of the attribute</returns>
        public static T GetAliasedValue<T>(this Entity record, string alias, string attribute)
        {
            var aliasedAttribute = $"{alias}.{attribute}";

            if (!record.Contains(aliasedAttribute))
            {
                return default(T);
            }

            var aliasedValue = record.GetAttributeValue<AliasedValue>(aliasedAttribute);

            if (!(aliasedValue.Value is T))
            {
                var message = $"The attribute {aliasedValue.AttributeLogicalName} in entity {aliasedValue.EntityLogicalName} is not of type {typeof(T)}";
                throw new InvalidCastException(message);
            }

            return (T)aliasedValue.Value;
        }

        /// <summary>
        /// Adds a party to the activity entity
        /// </summary>
        /// <param name="record">Activity entity</param>
        /// <param name="columnName">Logical name of the party list column</param>
        /// <param name="partyReference">Reference to the record to add as a party</param>
        public static void AddParty(this Entity record, string columnName, EntityReference partyReference)
        {
            if (!record.Contains(columnName))
            {
                record[columnName] = new EntityCollection();
            }

            record.GetAttributeValue<EntityCollection>(columnName).Entities.Add(
                new Entity("activityparty")
                {
                    Attributes =
                    {
                        {"partyid", partyReference }
                    }
                });
        }

        /// <summary>
        /// Adds parties to the activity entity
        /// </summary>
        /// <param name="record">Activity entity</param>
        /// <param name="columnName">Logical name of the party list column</param>
        /// <param name="partiesReferences">Reference to the record to add as a party</param>
        public static void AddParties(this Entity record, string columnName, params EntityReference[] partiesReferences)
        {
            if (!partiesReferences.Any())
            {
                throw new ArgumentException("AddParties requires at least one item", nameof(partiesReferences));
            }

            foreach (var partyReference in partiesReferences)
            {
                record.AddParty(columnName, partyReference);
            }
        }

        /// <summary>
        /// Set a party to the activity entity
        /// </summary>
        /// <remarks>
        /// This method replaces existing party list with the specified party
        /// reference
        /// </remarks>
        /// <param name="record">Activity entity</param>
        /// <param name="columnName">Logical name of the party list column</param>
        /// <param name="partyReference">Reference to the record to add as a party</param>
        public static void SetParty(this Entity record, string columnName, EntityReference partyReference)
        {
            record[columnName] = new EntityCollection(new List<Entity>{
                new Entity("activityparty")
                {
                     Attributes =
                    {
                        {"partyid", partyReference }
                    }
                }
            });
        }

        /// <summary>
        /// Adds parties to the activity entity
        /// </summary>
        /// <param name="record">Activity entity</param>
        /// <param name="columnName">Logical name of the party list column</param>
        /// <param name="partiesReferences">References to the records to add as a party</param>
        public static void SetParties(this Entity record, string columnName, params EntityReference[] partiesReferences)
        {
            if (!partiesReferences.Any())
            {
                throw new ArgumentException("SetParties requires at least one item", nameof(partiesReferences));
            }

            record.SetParty(columnName, partiesReferences.First());

            foreach (var partyReference in partiesReferences.Skip(1))
            {
                record.AddParty(columnName, partyReference);
            }
        }

        /// <summary>
        /// Clone a row
        /// </summary>
        /// <param name="row">Dataverse row</param>
        /// <param name="service">Dataverse Organization Service</param>
        /// <param name="addCloneLabel">Indicates if a "(clone)" text must be added in the newly created row name</param>
        /// <param name="columnsToRemove">Specific columns to exclude when cloning the row</param>
        /// <returns>Cloned row</returns>
        public static Entity Clone(this Entity row, IOrganizationService service, bool addCloneLabel = true, params string[] columnsToRemove)
        {
            // There are specific columns we don't want to clone anyway
            var standardToRemove = new[] { "createdon", "createdonbehalfby", "createdby", "modifiedon", "modifiedonbehalfby", "modifiedby", "overridencreatedon", "overridencreatedby", "ownerid" };
            var toRemove = standardToRemove.Concat(columnsToRemove).ToArray();

            // Query metadata for the table to understand what columns are valid for create
            var mdQuery = new EntityQueryExpression
            {
                Properties = new MetadataPropertiesExpression("Attributes", "PrimaryIdAttribute", "PrimaryNameAttribute"),
                Criteria = new MetadataFilterExpression
                {
                    Conditions =
                    {
                        new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals,
                            row.LogicalName)
                    }
                },
                AttributeQuery = new AttributeQueryExpression
                {
                    Properties = new MetadataPropertiesExpression("IsValidForCreate", "LogicalName")
                }
            };

            var response = (RetrieveMetadataChangesResponse)service.Execute(new RetrieveMetadataChangesRequest
            {
                Query = mdQuery,
                ClientVersionStamp = null
            });

            var cloned = new Entity(row.LogicalName);

            // Processing columns
            foreach (var column in response.EntityMetadata.First().Attributes)
            {
                // Do not add columns to remove
                if (toRemove.Contains(column.LogicalName))
                {
                    continue;
                }

                // Do not add primary column, which is the unique identifier
                if (column.LogicalName == response.EntityMetadata.First().PrimaryIdAttribute)
                {
                    continue;
                }

                // If the column is the primary column, process adding additional "(clone)" text
                if (column.LogicalName == response.EntityMetadata.First().PrimaryNameAttribute)
                {
                    cloned[column.LogicalName] = $"{row.GetAttributeValue<string>(column.LogicalName)}{(addCloneLabel ? " (clone)" : "")}";
                    continue;
                }

                // Process column only if it's valid for create
                if ((column.IsValidForCreate ?? false) && row.Contains(column.LogicalName))
                {
                    if (row[column.LogicalName] is Guid)
                    {
                        continue;
                    }

                    cloned[column.LogicalName] = row[column.LogicalName];
                }
            }

            return cloned;
        }

        /// <summary>
        /// Indicates if the table row contains columns that have been reseted
        /// </summary>
        /// <example>
        /// bool containsNullValue = account.ContainsNullValue(a => a.Name, a => a.AccountNumber);
        /// </example>
        /// <typeparam name="T">Type of the table</typeparam>
        /// <param name="record">Table row</param>
        /// <param name="columns">Columns to check for null value</param>
        /// <returns>True if all columns specified are present in the table row with a null value</returns>
        public static bool ContainsNullValue<T>(this T record, params Expression<Func<T, object>>[] columns) where T : Entity
        {
            return record.ContainsNullValue(columns.Select(c => GetLogicalName(c.Body)).ToArray());
        }

        /// <summary>
        /// Indicates if the table row contains columns that have been reseted
        /// </summary>
        /// <example>
        /// bool containsNullValue = account.ContainsNullValue("name", "accountnumber");
        /// </example>
        /// <param name="record">Table row</param>
        /// <param name="columns">Columns to check for null value</param>
        /// <returns>True if all columns specified are present in the table row with a null value</returns>
        public static bool ContainsNullValue(this Entity record, params string[] columns)
        {
            bool result = true;

            foreach (var column in columns)
            {
                result &= record.Contains(column) && record[column] == null;
            }

            return result;
        }

        /// <summary>
        /// Indicates if the table row contains columns that have a value not null
        /// </summary>
        /// <example>
        /// bool containsNullValue = account.ContainsValue(a => a.Name, a => a.AccountNumber);
        /// </example>
        /// <typeparam name="T">Type of the table</typeparam>
        /// <param name="record">Table row</param>
        /// <param name="columns">Columns to check for not null value</param>
        /// <returns>True if all columns specified are present in the table row with a value different from null</returns>
        public static bool ContainsValue<T>(this T record, params Expression<Func<T, object>>[] columns) where T : Entity
        {
            return record.ContainsValue(columns.Select(c => GetLogicalName(c.Body)).ToArray());
        }

        /// <summary>
        /// Indicates if the table row contains columns that have a value not null
        /// </summary>
        /// <example>
        /// bool containsNullValue = account.ContainsValue("name", "accountnumber");
        /// </example>
        /// <param name="record">Table row</param>
        /// <param name="columns">Columns to check for not null value</param>
        /// <returns>True if all columns specified are present in the table row with a value different from null</returns>
        public static bool ContainsValue(this Entity record, params string[] columns)
        {
            bool result = true;

            foreach (var column in columns)
            {
                result &= record.Contains(column) && record[column] != null;
            }

            return result;
        }

        private static string GetLogicalName(Expression expr)
        {
            MemberExpression me = expr as MemberExpression;
            var pi = (PropertyInfo)me.Member;
            return pi.GetCustomAttribute<AttributeLogicalNameAttribute>().LogicalName;
        }
    }
}