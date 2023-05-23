namespace DMS.Data.Entities
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public string Dormitory { get; set; }
        public int SumBed { get; set; }
        public int AvailableBed { get; set; }
        public string DeviceStatus { get; set; }

        public Dormitory dormitory { get; set; }
        public List<Student> Students { get; set; }
        public List<RepairRequest> RepairRequests { get; set; }
    }
}
