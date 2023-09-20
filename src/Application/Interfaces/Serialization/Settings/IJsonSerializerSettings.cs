using Newtonsoft.Json;

namespace LeanTask.Application.Interfaces.Serialization.Settings
{
    public interface IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; }
    }
}