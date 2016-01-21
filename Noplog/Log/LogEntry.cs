namespace Noplog.Log
{
    public struct LogEntry
    {
        public LogEntry(EntryId id, object value)
        {
            this.Id = id;
            this.Value = value;
        }

        public EntryId Id { get; }

        public object Value { get; }
    }
}