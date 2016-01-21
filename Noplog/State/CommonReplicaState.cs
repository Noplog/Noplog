namespace Noplog.State
{
    public class CommonReplicaState
    {
        public long CommitIndex { get; set; }
        public long LastAppliedIndex { get; set; }
    }
}