using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CassiaMall.Localization
{
    public static class CassiaMallLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CassiaMallConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CassiaMallLocalizationConfigurer).GetAssembly(),
                        "CassiaMall.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
