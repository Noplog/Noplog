namespace Noplog.Messages
{
    public struct RequestVoteResponse
    {
        public RequestVoteResponse(bool voteGranted, long term)
        {
            VoteGranted = voteGranted;
            Term = term;
        }

        private bool VoteGranted { get; }
        private long Term { get; }
    }
}