namespace DMS.Data.Entities
{
    public class Room
    {
        public int 房间号 { get; set; }
        public int 所属宿舍 { get; set; }
        public int 床位数 { get; set; }
        public int 可用床位数 { get; set; }
        public int 房间内设备状态 { get; set; }
    }
}
