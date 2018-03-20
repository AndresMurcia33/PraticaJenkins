using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica2LinqClass.Models
{
    public class areaModels
    {
        DataEmpresaDataContext dataEmpr = new DataEmpresaDataContext();

        public List<area> listaAreas()
        {
            List<area> lista = new List<area>();

            var query = dataEmpr.ListarArea();

            foreach (var items in query)
            {
                area a = new area();
                a.areaCod = items.areaCod;
                a.areaDes = items.areaDes;
                lista.Add(a);
            }
            return lista;
        }

        public area buscarArea(int codArea)
        {
            area a = new area();

            try
            {
                var reultQuery = dataEmpr.BuscarArea(codArea);
                foreach (var item in reultQuery)
                {
                    a.areaDes = item.areaDes;
                }
            }catch(Exception e)
            {
                
            }
            return a;
        }

        public string insertarArea(string valor)
        {
            area a = new area();
            string resultado = string.Empty;
            try
            {
                dataEmpr.CrearArea(valor);
                resultado = "ok";
            }
            catch (Exception e)
            {
                resultado = e.Message;
            }
            return resultado;
        }

        public string actualizarArea(int condArea, string valor)
        {
            area a = new area();
            // representa en una cadena vacia

            string resultado = string.Empty;
            try
            {
                dataEmpr.ActulaizarArea(condArea, valor);
                resultado = "ok";
            }
            catch (Exception e)
            {
                resultado = e.Message;
            }
            return resultado;
        }

        public string eliminarArea(int codArea)
        {
            string resultado = string.Empty;
            try
            {
                dataEmpr.EliminarArea(codArea);
                resultado = "ok";
            }
            catch (Exception e)
            {

                resultado = e.Message;
            }
            return resultado;
        }
    }
}