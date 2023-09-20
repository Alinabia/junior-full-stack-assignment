using LeanTask.Shared.Settings;
using System.Threading.Tasks;
using LeanTask.Shared.Wrapper;

namespace LeanTask.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}