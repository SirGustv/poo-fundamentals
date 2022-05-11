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
            listSeries[id].Excluir();
        }

        public void Insert(Series entity)
        {
            listSeries.Add(entity);
        }

        public List<Series> Lista()
        {
            return listSeries;
        }

        public int NextId()
        {
            return listSeries.Count;
        }

        public Series ReturnById(int id)
        {
            return listSeries[id];
        }

        public void Update(int id, Series entity)
        {
            listSeries[id] = entity;
        }
    }
}