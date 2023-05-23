namespace DMS.Data.Entities
{
    public class RepairRequest
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string DormitoryNumber { get; set; }
        public string RoomNumber { get; set; }
        public string RequestType { get; set; }
        public string QuestionDescribe { get; set; }
        public DateTime RequestTime { get; set; }
        public string ProcessStatus { get; set; }

        public Student Student { get; set; }
        public Room Room { get; set; }
    }
}
