
using LeanTask.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace LeanTask.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}