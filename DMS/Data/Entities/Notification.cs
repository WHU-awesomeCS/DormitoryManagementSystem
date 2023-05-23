namespace DMS.Data.Entities
{
    public class Notification
    {
        public string Id { get; set; }
        public string Caption { get; set; }
        public string Content { get; set; }
        public DateTime PublishTime { get; set; }
        public string Receiver { get; set; }
    }
}
