using System.Collections.Generic;

namespace Noplog.State
{
    public class LeaderState
    {
        public Dictionary<string, ReplicaProgress> ReplicaProgresses { get; } =
            new Dictionary<string, ReplicaProgress>();

        public void InitializeReplicaProgresses(long nextIndex)
        {
            foreach (var replica in ReplicaProgresses.Values)
            {
                replica.MatchIndex = 0;
                replica.NextIndex = nextIndex;
            }
        }
    }
}