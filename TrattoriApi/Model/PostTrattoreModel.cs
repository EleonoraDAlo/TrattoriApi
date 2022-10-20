namespace TrattoriApi.Model
{
    public class PostTrattoreModel
    {
        public string Color { get; set; }

        public string Brand { get; set; }

        public List<Gadget> gadgets = new List<Gadget>();
    }
}
