namespace Noplog.Log
{
    public struct EntryId
    {
        public EntryId(long term, long index)
        {
            Term = term;
            Index = index;
        }

        public long Term { get; }
        public long Index { get; }
    }
}