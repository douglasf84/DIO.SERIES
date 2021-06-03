using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.SERIES.Interfaces;

namespace DIO.SERIES.Classes
{
    public class SeriesRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            try
            {
                ListaSerie[id] = objeto;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Excluir(int id)
        {
            try
            {
                ListaSerie[id].Excluir();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Insere(Serie entidade)
        {
            try
            {
                ListaSerie.Add(entidade);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
