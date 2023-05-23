namespace DMS.Data.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public int Department { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string DormitoryNumber { get; set; }
        public bool WhetherLeave { get; set; }
        public DateTime? LeaveDate { get; set; }

        public Room Room { get; set; }
    }
}
