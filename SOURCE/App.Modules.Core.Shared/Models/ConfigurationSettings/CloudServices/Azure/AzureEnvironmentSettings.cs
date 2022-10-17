namespace App.Base.Shared.Models.ConfigurationSettings
{
    using App.Base.Shared.Attributes;

    /// <summary>
    /// A 
    /// </summary>
    public class AzureEnvironmentSettings : IHostSettingsBasedConfigurationObject, IKeyVaultBasedConfigurationObject
    {

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreEnvironmentSubscriptionId)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreEnvironmentTenantId)]
        public string TenantId { get; set; }

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreEnvironmentResourceGroupName)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreEnvironmentResourceGroupLocation)]
        public string ResourceGroupLocation { get; set; }
    }

}
