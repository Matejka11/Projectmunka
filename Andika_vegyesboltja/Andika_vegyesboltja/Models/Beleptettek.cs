namespace Andika_vegyesboltja.Models
{
    public class Beleptettek
    {
        public int Id { get; set; }
        public string Neve { get; set; }
        public Boolean IsRegistered { get; set; }
        public string email { get; set; }
        public int telefonszam { get; set; }
        public string password { get; set; }
        public string city { get; set; }
        public int iranyitoszam { get; set; }
        public string utca { get; set; }
        public int hazsyam { get; set; }
    }
}
