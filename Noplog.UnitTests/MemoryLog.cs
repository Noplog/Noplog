using System.Collections.Generic;
using System.Linq;
using Noplog.Log;

namespace Noplog.UnitTests
{
    public class MemoryLog : IPersistentLog
    {
        private readonly List<LogEntry> log = new List<LogEntry>();

        public LogEntry GetLastLogEntry()
        {
            return log.LastOrDefault();
        }

        public void AppendEntry(LogEntry entry)
        {
            log.Add(entry);
        }

        public void RemoveLastEntry()
        {
            log.RemoveAt(log.Count - 1);
        }

        public void Clear()
        {
            log.Clear();
        }
    }
}