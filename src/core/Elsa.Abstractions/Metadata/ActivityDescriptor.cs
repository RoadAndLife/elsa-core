namespace Elsa.Metadata
{
    public class ActivityDescriptor
    {
        public ActivityDescriptor()
        {
            Type = "Activity";
            Properties = new ActivityPropertyDescriptor[0];
            Category = "Miscellaneous";
            DisplayName = "Activity";
            Properties = new ActivityPropertyDescriptor[0];
            Outcomes = new string[0];
        }
        
        public string Type { get; set; }
        public string DisplayName { get; set; }
        public string? Description { get; set; }
        public string RuntimeDescription { get; set; }
        public string Category { get; set; }
        public string? Icon { get; set; }
        public string[] Outcomes { get; set; }
        public ActivityPropertyDescriptor[] Properties { get; set; }
    }
}