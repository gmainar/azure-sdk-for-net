// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents the properties of a Azure SQL Recommended Elastic Pool
    /// being upgraded.
    /// </summary>
    public partial class UpgradeRecommendedElasticPoolProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpgradeRecommendedElasticPoolProperties class.
        /// </summary>
        public UpgradeRecommendedElasticPoolProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpgradeRecommendedElasticPoolProperties class.
        /// </summary>
        /// <param name="name">The name of the Azure SQL Recommended Elastic
        /// Pool being upgraded.</param>
        /// <param name="edition">The target edition for the Azure SQL
        /// Recommended Elastic Pool being upgraded. Possible values include:
        /// 'Basic', 'Standard', 'Premium'</param>
        /// <param name="dtu">The DTU guarantee for the Azure SQL Recommended
        /// Elastic Pool being upgraded.</param>
        /// <param name="storageMb">The storage limit in MB for the Azure SQL
        /// Recommended Elastic Pool being upgraded.</param>
        /// <param name="databaseDtuMin">The DTU guarantee for database for
        /// the Azure SQL Recommended Elastic Pool being upgraded.</param>
        /// <param name="databaseDtuMax">The DTU cap for database for the
        /// Azure SQL Recommended Elastic Pool being upgraded.</param>
        /// <param name="databaseCollection">The list of database names to be
        /// put in the Azure SQL Recommended Elastic Pool being
        /// upgraded.</param>
        /// <param name="includeAllDatabases">Gets or sets whether all
        /// databases to be put in the Azure SQL Recommended Elastic Pool
        /// being upgraded.</param>
        public UpgradeRecommendedElasticPoolProperties(string name, string edition, int? dtu = default(int?), int? storageMb = default(int?), int? databaseDtuMin = default(int?), int? databaseDtuMax = default(int?), System.Collections.Generic.IList<string> databaseCollection = default(System.Collections.Generic.IList<string>), bool? includeAllDatabases = default(bool?))
        {
            Name = name;
            Edition = edition;
            Dtu = dtu;
            StorageMb = storageMb;
            DatabaseDtuMin = databaseDtuMin;
            DatabaseDtuMax = databaseDtuMax;
            DatabaseCollection = databaseCollection;
            IncludeAllDatabases = includeAllDatabases;
        }

        /// <summary>
        /// Gets or sets the name of the Azure SQL Recommended Elastic Pool
        /// being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the target edition for the Azure SQL Recommended
        /// Elastic Pool being upgraded. Possible values are enumerated in 
        /// ElasticPoolEditions
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the DTU guarantee for the Azure SQL Recommended
        /// Elastic Pool being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Dtu")]
        public int? Dtu { get; set; }

        /// <summary>
        /// Gets or sets the storage limit in MB for the Azure SQL Recommended
        /// Elastic Pool being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "StorageMb")]
        public int? StorageMb { get; set; }

        /// <summary>
        /// Gets or sets the DTU guarantee for database for the Azure SQL
        /// Recommended Elastic Pool being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DatabaseDtuMin")]
        public int? DatabaseDtuMin { get; set; }

        /// <summary>
        /// Gets or sets the DTU cap for database for the Azure SQL
        /// Recommended Elastic Pool being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DatabaseDtuMax")]
        public int? DatabaseDtuMax { get; set; }

        /// <summary>
        /// Gets or sets the list of database names to be put in the Azure SQL
        /// Recommended Elastic Pool being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DatabaseCollection")]
        public System.Collections.Generic.IList<string> DatabaseCollection { get; set; }

        /// <summary>
        /// Gets or sets whether all databases to be put in the Azure SQL
        /// Recommended Elastic Pool being upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "IncludeAllDatabases")]
        public bool? IncludeAllDatabases { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}