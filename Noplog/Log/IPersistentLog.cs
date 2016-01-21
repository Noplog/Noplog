namespace Noplog.Log
{
    public interface IPersistentLog
    {
        LogEntry GetLastLogEntry();
        void AppendEntry(LogEntry entry);
        void RemoveLastEntry();
        void Clear();
    }
}