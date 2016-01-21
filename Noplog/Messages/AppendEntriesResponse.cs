namespace Noplog.Messages
{
    public struct AppendEntriesResponse
    {
        public AppendEntriesResponse(long term, bool success)
        {
            Term = term;
            Success = success;
        }

        public long Term { get; }
        public bool Success { get; }
    }
}