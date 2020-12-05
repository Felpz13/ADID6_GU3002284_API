using ADID6_GU3002284_API.Entidades;
using ADID6_GU3002284_API.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADID6_GU3002284_API.Repositorios
{
    public class MockRepo : IMockRepo
    {
        public List<Item> Repo { get; set; }

        public MockRepo()
        {
            Repo = new List<Item>();
        }

        public bool Add(Item item)
        {
            try
            {
                var ultimoItem = GetAll()?.Last();
                item.Id = ultimoItem != null ? ultimoItem.Id + 1 : 0;

                Repo.Add(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                var item = GetById(id);
                Repo.Remove(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Item> GetAll()
        {
            try
            {             
                return Repo.Count > 0 ? Repo : null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Item GetById(int id)
        {
            try
            {                
                return Repo.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(Item item)
        {
            try
            {
                var itemRepo = GetById(item.Id);

                if(item.Nome != null && item.Nome != string.Empty && item.Nome != itemRepo.Nome)
                    itemRepo.Nome = item.Nome;

                if(item.Valor != default(int) && item.Valor != itemRepo.Valor)
                    itemRepo.Valor = item.Valor;

                if (item.Descricao != null && item.Descricao != string.Empty && item.Descricao != itemRepo.Descricao)
                    itemRepo.Descricao = item.Descricao;

                if (item.Ingredientes != null && item.Ingredientes != string.Empty && item.Ingredientes != itemRepo.Ingredientes)
                    itemRepo.Ingredientes = item.Ingredientes;

                if(item.CategoriaId != itemRepo.CategoriaId)
                    itemRepo.CategoriaId = item.CategoriaId;

                if(item.Imagem != null && item.Imagem != itemRepo.Imagem)
                    itemRepo.Imagem = item.Imagem;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
