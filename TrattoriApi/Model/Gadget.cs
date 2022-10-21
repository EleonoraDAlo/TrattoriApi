namespace TrattoriApi.Model
{
    public class Gadget
    {
        public int Id { get; set; }

        public string Description { get; set; }

       

        public Trattore trattore { get; set; }
    }
}
