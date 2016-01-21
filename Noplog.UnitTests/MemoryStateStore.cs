using Noplog.State;

namespace Noplog.UnitTests
{
    public class MemoryStateStore : IPersistentState
    {
        public long CurrentTerm { get; set; }
        public string VotedFor { get; set; }
    }
}