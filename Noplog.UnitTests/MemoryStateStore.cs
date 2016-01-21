using Noplog.State;

namespace Noplog.UnitTests
{
    public class MemoryStateStore : IPersistentState
    {
        public string Identity { get; set; }
        public long CurrentTerm { get; set; }
        public string VotedFor { get; set; }
    }
}