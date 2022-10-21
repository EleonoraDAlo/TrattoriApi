using TrattoriApi.Model;

namespace TrattoriApi.Service
{
    public class ServiceGadget : IServiceGadget
    {
        private IList<Gadget> _gadgets;
        private IServiceTrattore _serviceTrattore;
        public ServiceGadget(IList<Gadget> gadget, IServiceTrattore serviceTrattore)
        {
            _gadgets = gadget;
            _serviceTrattore = serviceTrattore;
        }

        public Gadget Insert(int TrattoreId, Gadget gadget)
        {
            Trattore trattore = _serviceTrattore.GetDetail(TrattoreId);
            
            trattore.gadgets.Add(gadget);
            
            return gadget;
        }
    }
}
