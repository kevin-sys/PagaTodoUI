using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class ConsignacionRepository
    {
        String FileName = @"Consignacion.txt";
        List<Consignacion> Consignaciones;
        public ConsignacionRepository()
        {
            Consignaciones = new List<Consignacion>();
        }

        public void Guardar(Consignacion consignacion)
        {
            FileStream origen = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(origen); writer.WriteLine(consignacion.EntidadServicios + ";"
                + consignacion.NumeroRecibo + ";" + consignacion.FechaPago.ToString("dd/MM/yyyy") + ";" +
                consignacion.ValorPagado);
            writer.Close();
            origen.Close();
        }

        
        public List<Consignacion> ConsultarTodos()
        {
            Consignaciones.Clear();
          
            FileStream origen = new FileStream(FileName, FileMode.Open);
            StreamReader reader = new StreamReader(origen);

            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Consignacion consignacion1 = Mapear(linea);
                Consignaciones.Add(consignacion1);
            }
            reader.Close();
            origen.Close();
            return Consignaciones;
        }


        private static Consignacion Mapear(string linea)
        {
            string[] datos = linea.Split(';');
            Consignacion consignacion = new Consignacion();
            consignacion.EntidadServicios = datos[0];
            consignacion.NumeroRecibo = Int32.Parse(datos[1]);
            consignacion.FechaPago = DateTime.Parse(datos[2]);
            consignacion.ValorPagado = float.Parse(datos[3]);
            return consignacion;
        }
        public Consignacion Buscar(int numeroFactura)
        {
            Consignaciones.Clear();
            Consignaciones = ConsultarTodos();
            return Consignaciones.Find(P => P.NumeroRecibo.Equals(numeroFactura));
        }
    }
}
