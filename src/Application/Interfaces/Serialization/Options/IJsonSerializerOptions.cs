using System.Text.Json;

namespace LeanTask.Application.Interfaces.Serialization.Options
{
    public interface IJsonSerializerOptions
    { 
        public JsonSerializerOptions JsonSerializerOptions { get; }
    }
}