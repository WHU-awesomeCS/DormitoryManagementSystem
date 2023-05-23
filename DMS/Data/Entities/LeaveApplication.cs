namespace DMS.Data.Entities
{
    public class LeaveApplication
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Reason { get; set; }
        public string ApplicationStatus { get; set; }
        public string Applicant { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
