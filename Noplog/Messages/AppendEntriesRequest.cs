using Noplog.Log;

namespace Noplog.Messages
{
    public struct AppendEntriesRequest
    {
        public AppendEntriesRequest(long term, string leaderId, EntryId previousEntryId, object[] entries,
            long leaderCommit)
        {
            Term = term;
            LeaderId = leaderId;
            PreviousEntryId = previousEntryId;
            Entries = entries;
            LeaderCommit = leaderCommit;
        }

        public long Term { get; }
        public string LeaderId { get; }
        public EntryId PreviousEntryId { get; }

        public object[] Entries { get; }

        public long LeaderCommit { get; }
    }
}