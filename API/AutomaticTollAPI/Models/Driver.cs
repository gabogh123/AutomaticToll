namespace AutomaticTollAPI.Models
{
    public class Driver
    {
        //Primary keys
        public int userID { get; set; }

        //Entity attributes
        public string passwd { get; set; }
        public string Name { get; set; } = "";
        public string Lastname { get; set; } = "";
        public int? Age { get; set; }

    }
}
