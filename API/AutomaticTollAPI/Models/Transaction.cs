namespace AutomaticTollAPI.Models
{
    public class Transaction
    {
        public string TollID { get; set; }
        public string LicensePlate { get; set; }
        public DateTime Time { get; set; }
        public float? Price { get; set; }
    }
}
