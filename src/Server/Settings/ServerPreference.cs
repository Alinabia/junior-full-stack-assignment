using System.Linq;
using LeanTask.Shared.Constants.Localization;
using LeanTask.Shared.Settings;

namespace LeanTask.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";
    }
}