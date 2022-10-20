using System.Runtime.InteropServices;
using TrattoriApi.Model;

namespace TrattoriApi.Service
{
    public interface IServiceTrattore
    {
        public Trattore Insert(PostTrattoreModel trattore);

        public Trattore GetDetail(int id);

        public Trattore Update(Trattore trattore, int id);

        public void Delete(int id);

        public IList<Trattore> GetAllByFilter(string value);
    }
}
