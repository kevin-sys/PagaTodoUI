using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
    public  class ConsignacionService
    {
        private static ConsignacionRepository repositorio = new ConsignacionRepository();
        public static string Guardar(Consignacion consignacion)
        {
            try
            {
               
                    repositorio.Guardar(consignacion);
                    return ($"consignacion guardada, {consignacion.EntidadServicios}");
               
            }
            catch (Exception e)
            {

                return ($"error de la aplicacion, {e.Message}");
            }
        }

       

        public static List<Consignacion>Consultar()
        {
            return repositorio.ConsultarTodos();
        }

    }
}
