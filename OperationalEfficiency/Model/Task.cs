namespace OperationalEfficiency.Model
{
    public class Task
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime LimitDataTime { get; set; }
        public bool IsDone { get; set; }
        public bool Deleted { get; set; }

        public Task(long id, string? name, DateTime limitDataTime)
        {
            Id = id;
            Name = name;
            LimitDataTime = limitDataTime;
            IsDone = false;
            Deleted = false;
        }
    }
}
