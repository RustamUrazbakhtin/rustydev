namespace rustydev.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }
        public int CategoryId { get; set; } // "Учебные", "Коммерческие"
        public string GitHubLink { get; set; }
        public string ImagePath { get; set; }
        public string Details { get; set; } // подробное описание
    }
}
