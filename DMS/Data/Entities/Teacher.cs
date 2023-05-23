namespace DMS.Data.Entities
{
    public class Teacher
    {
        public string Name { get; set; }
        public string WorkId { get; set; }
        public string PhoneNumber { get; set; }
        public int Department { get; set; }
        public string Email { get; set; }
        public string DormitoryInCharge { get; set; }

        public Dormitory Dormitory { get; set; }
    }
}
