namespace Reports.Models
{
    public class Report
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Report(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
