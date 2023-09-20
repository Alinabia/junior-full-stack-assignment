using LeanTask.Application.Interfaces.Services;
using System;

namespace LeanTask.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}