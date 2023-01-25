namespace TaskSystem.Models
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public string Progress { get; set; }
        public DateTime DueDate { get; set; }

    }
}
