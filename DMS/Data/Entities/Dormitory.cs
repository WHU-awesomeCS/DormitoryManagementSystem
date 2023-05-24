namespace DMS.Data.Entities
{
    public class Dormitory
    {
        public string? DormitoryNumber { get; set; }
        public int FloorNumber { get; set; }
        public int AvailableBed { get; set; }
        public int SumBed { get; set; }

        public List<Room>? Rooms { get; set; }
        public List<Staff>? Staffs { get; set; }
        public List<Teacher>? Teachers { get; set; }
    }
}
