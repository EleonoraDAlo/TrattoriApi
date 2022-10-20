namespace TrattoriApi.Model
{
    public class Trattore
    {
        public int Id { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }


        public List<Gadget> gadgets = new List<Gadget>();
    }

}
