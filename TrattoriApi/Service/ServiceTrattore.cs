using TrattoriApi.Model;

namespace TrattoriApi.Service
{
    public class ServiceTrattore : IServiceTrattore
    {
        //private IDal _dalTrattore;
        private IList<Trattore> _trattoreList;

        public ServiceTrattore(IList<Trattore> trattoreList)
        {
         
            _trattoreList = trattoreList;
        }


        public void Delete(int id)
        {
           Trattore trattore = GetDetail(id);
           _trattoreList.Remove(trattore);
        }

        public IList<Trattore> GetAllByFilter(string color)
        {
           List<Trattore> filterTrattori = _trattoreList.Where(trattore => trattore.Color == color).ToList();
            return filterTrattori;
        }


        public Trattore GetDetail(int id)
        {
            //var trattore = _trattoreList.FirstOrDefault(trattore => trattore.Id == id);
            //return trattore;
            
            foreach(Trattore trattore in _trattoreList)
                if(trattore.Id == id)
                    return trattore;

            throw new ArgumentException("Id non valido");

            
        }

        public Trattore Insert(PostTrattoreModel trattore)
        {
            Trattore trattoreToAdd = MappingWithId(trattore);
            if (trattoreToAdd == null)
                throw new ArgumentException("Bad Error");

            _trattoreList.Add(trattoreToAdd);
            return trattoreToAdd;

        }

        private Trattore MappingWithId(PostTrattoreModel trattoreNoId)
        {
            var trattoreWithId = new Trattore();
            trattoreWithId.Id = GetId();
            trattoreWithId.Color = trattoreNoId.Color;
            trattoreWithId.Brand = trattoreNoId.Brand;
            

            return trattoreWithId;


        }

        public Trattore Update(Trattore trattore, int id)
        {
            var toUpdate = GetDetail(id);
            if (toUpdate != null)
            {
                var indexOf = _trattoreList.IndexOf(toUpdate);
                _trattoreList[indexOf] = trattore;
                return trattore;
            }
            _trattoreList.Add(trattore);
            return trattore;
        }

        private int GetId()
        {
            if (_trattoreList.Count == 0)
                return 1;

            return _trattoreList.Max(trattore => trattore.Id) + 1;
        }
    }
}
