// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Microsoft.AzureIntegrationMigration.ApplicationModel.Source;
using Microsoft.AzureIntegrationMigration.BizTalk.Types.Entities.Filters;
using Microsoft.AzureIntegrationMigration.BizTalk.Types.Entities.Pipelines;
using Microsoft.AzureIntegrationMigration.BizTalk.Types.Interfaces;
using Newtonsoft.Json;

namespace Microsoft.AzureIntegrationMigration.BizTalk.Types.Entities.Bindings
{
    /// <summary>
    /// Extensions for the send port.
    /// </summary>
    public partial class SendPort : ISourceResource
    {
        #region ISourceResource Implementation

        /// <summary>
        /// A pointer to the associated resource created from this object.
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        public ResourceItem Resource { get; set; }

        /// <summary>
        /// The resource key for the associated resource.
        /// </summary>
        [XmlIgnore]
        public string ResourceKey { get; set; }

        #endregion

        /// <summary>
        /// Gets or sets the deserialized <see cref="FilterExpression"/> associated with the send port.
        /// </summary>
        [XmlIgnore]
        public Filter FilterExpression { get; set; }

        /// <summary>
        /// Gets or sets the deserialized <see cref="Root"/> detailing the custom configuration for this instance of the receive pipeline.
        /// </summary>
        [XmlIgnore]
        public Root SendPipelineCustomConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the deserialized <see cref="Root"/> detailing the custom configuration for this instance of the send pipeline.
        /// </summary>
        [XmlIgnore]
        public Root ReceivePipelineCustomConfiguration { get; set; }
    }
}
