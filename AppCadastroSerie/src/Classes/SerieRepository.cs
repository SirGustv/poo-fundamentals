using System;
using System.Collections.Generic;
using AppCadastroSerie.Interface;

namespace AppCadastroSerie.Classes
{
    public class SerieRepository : iRepository<Series>
    {
        private List<Series> listSeries = new List<Series>();
        public void Exclude(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Series entity)
        {
            throw new NotImplementedException();
        }

        public List<Series> Lista()
        {
            throw new NotImplementedException();
        }

        public int NextId()
        {
            throw new NotImplementedException();
        }

        public Series ReturnById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Series entity)
        {
            throw new NotImplementedException();
        }
    }
}