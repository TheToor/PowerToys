// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.PowerToys.Settings.UI.Library.Interfaces;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class EnterpriseSettings : ISettingsConfig
    {
        public const string EnterpriseModuleName = "Enterprise";

        // Gets or sets a value indicating whether enterprise settings should be used
        [JsonPropertyName("enableEnterpriseSettings")]
        public bool EnableEnterpriseSettings { get; set; }

        // Gets or sets a value indicating whether run powertoys on start-up.
        [JsonPropertyName("enableAutoUpdate")]
        public bool EnableAutoUpdate { get; set; }

        [JsonPropertyName("enabled")]
        public EnabledModules EnabledModules { get; set; }

        public string GetModuleName()
        {
            return EnterpriseModuleName;
        }

        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }

        public bool UpgradeSettingsConfiguration()
        {
            return false;
        }
    }
}
