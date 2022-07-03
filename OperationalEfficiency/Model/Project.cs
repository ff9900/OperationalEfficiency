namespace OperationalEfficiency.Model
{
    public class Project
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime LimitDataTime { get; set; }
        public bool IsDone { get; set; }
        public bool Deleted { get; set; }

        public Project(long id, string? name, DateTime limitDataTime)
        {
            Id = id;
            Name = name;
            LimitDataTime = limitDataTime;
            IsDone = false;
            Deleted = false;
        }
    }
}
