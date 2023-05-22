namespace DMS.Data.Entities
{
    public class Notification
    {
        public int id { get; set; }
        public int 标题 { get; set; }
        public int 内容 { get; set; }
        public int 发布时间 { get; set; }
        public int 接收对象 { get; set; }
    }
}
