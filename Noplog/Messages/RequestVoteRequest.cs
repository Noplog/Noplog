using Noplog.Log;

namespace Noplog.Messages
{
    public struct RequestVoteRequest
    {
        public RequestVoteRequest(long term, string candidateId, EntryId lastEntryId)
        {
            Term = term;
            CandidateId = candidateId;
            LastEntryId = lastEntryId;
        }

        public long Term { get; }
        public string CandidateId { get; }
        public EntryId LastEntryId { get; }
    }
}