namespace Noplog.State
{
    /// <summary>
    /// Represents the progress of a replica as seen by a leader.
    /// </summary>
    public class ReplicaProgress
    {
        public long NextIndex { get; set; }
        public long MatchIndex { get; set; }
    }
}