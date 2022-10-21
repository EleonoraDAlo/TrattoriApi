using TrattoriApi.Model;

namespace TrattoriApi.Service
{
    public interface IServiceGadget
    {
        public Gadget Insert(int TrattoreId, Gadget gadget);
    }
}
