using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSede
    {
        public String Registrar(Sedes sede)
        {
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    context.Sedes.Add(sede);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Sedes sede)
        {
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    Sedes sedeTemp = context.Sedes.Find(sede.SedeId);
                    sedeTemp.NombreSede = sede.NombreSede;
                    sedeTemp.Direccion = sede.Direccion;
                    sedeTemp.Telefono = sede.Telefono;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Sedes)
        {
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    Sedes sedeTemp = context.Sedes.Find(id_Sedes);
                    context.Sedes.Remove(sedeTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Sedes> ListarTodo()
        {
            List<Sedes> sedes = new List<Sedes>();
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    sedes = context.Sedes.ToList();
                }
                return sedes;
            }
            catch (Exception ex)
            {
                return sedes;
            }
        }
    }
}
