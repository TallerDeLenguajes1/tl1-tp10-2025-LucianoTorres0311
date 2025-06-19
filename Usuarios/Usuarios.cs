namespace creadorUsuarios
{
    public class Usuarios
    {
        public string name { get; set; }
        public string email { get; set; }
        public Address address { get; set; }

    }
    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }

    }
}
