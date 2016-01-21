namespace Noplog.State
{
    public interface IPersistentState
    {
        /// <summary>
        /// This node's id.
        /// </summary>
        string Identity { get; set; }

        /// <summary>
        /// The current term identifier.
        /// </summary>
        long CurrentTerm { get; set; }

        /// <summary>
        /// The id of the node this node voted for in the current term.
        /// </summary>
        string VotedFor { get; set; }
    }
}