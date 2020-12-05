using ADID6_GU3002284_API.Entidades;
using System.Collections.Generic;

namespace ADID6_GU3002284_API.Repositorios.Interfaces
{
    public interface IMockRepo
    {
        bool Add(Item item);
        bool Update(Item item);
        bool Delete(int id);
        Item GetById(int id);
        List<Item> GetAll();
    }
}
