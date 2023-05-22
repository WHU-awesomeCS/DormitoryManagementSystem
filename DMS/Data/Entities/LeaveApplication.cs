namespace DMS.Data.Entities
{
    public class LeaveApplication
    {
        public int id { get; set; }
        public int 学生id { get; set; }
        public int 开始时间 { get; set; }
        public int 结束时间 { get; set; }
        public int 请假事由 { get; set; }
        public int 审批状态 { get; set; }
        public int 审批人 { get; set; }
    }
}
