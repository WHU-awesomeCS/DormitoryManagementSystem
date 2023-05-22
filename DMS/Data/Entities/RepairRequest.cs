namespace DMS.Data.Entities
{
    public class RepairRequest
    {
        public int id { get; set; }
        public int 学生学号 { get; set; }
        public int 宿舍号 { get; set; }
        public int 房间号 { get; set; }
        public int 报修类型 { get; set; }
        public int 问题描述 { get; set; }
        public int 报修时间 { get; set; }
        public int 处理状态 { get; set; }
    }
}
