namespace BugTracker.Shared.Models
{
    public class Bug
    {
        public enum BugState { Requested, InProgress, Closed };

        public int Id { get; set; }

        public BugState State { get; set; } = BugState.Requested;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? AssignedUserId { get; set; } = null;
    }
}
