namespace RecruitApp.Models.Jobs
{
    public class Job
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public DateTime PostDate { get; set; }

        public decimal? Salary { get; set; }
        public decimal? SuperannuactionRate { get; set; }
        public string? JobDescription { get; set; }
        public string? BasedLocation { get; set; }
        public string? Category { get; set; }

    }
}
