using Noplog.Messages;

namespace Noplog.Replica
{
    public interface IRaftServer
    {
        RequestVoteResponse RequestVote(RequestVoteResponse request);
        AppendEntriesResponse AppendEntries(AppendEntriesRequest request);
    }
}