namespace IntegerWebApplication.Models
{
    public class Car
    {
        //[key] Untuk penggunaan ini hanya untuk kata yang tidak ada "ID" nya dan ingin dijadikan primary key
        public int IDRegistration { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Varian { get; set; }
    }
}
