namespace DMS.Data.Entities
{
    public class Visitor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IDNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string DormitoryNumber { get; set; }

        public Dormitory Dormitory { get; set; }
    }
}
