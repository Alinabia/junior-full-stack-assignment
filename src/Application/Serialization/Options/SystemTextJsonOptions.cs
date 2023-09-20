using System.Text.Json;
using LeanTask.Application.Interfaces.Serialization.Options;

namespace LeanTask.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}