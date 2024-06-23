using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDueño
    {
        public String Registrar(Dueños dueños)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    context.Dueños.Add(dueños);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String Modificar(Dueños dueños)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    Dueños dueñoTemp = context.Dueños.Find(dueños.DueñoId);
                    dueñoTemp.NombreCompleto = dueños.NombreCompleto;
                    dueñoTemp.DNI = dueños.DNI;
                    dueñoTemp.Direccion = dueños.Direccion;
                    dueñoTemp.CorreoElectronico = dueños.CorreoElectronico;
                    dueñoTemp.NumeroTelefonico = dueños.NumeroTelefonico;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String Eliminar(int id_dueño)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    Dueños dueñoTemp = context.Dueños.Find(id_dueño);
                    context.Dueños.Remove(dueñoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Dueños> ListarTodo()
        {
            List<Dueños> dueños = new List<Dueños>();
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    dueños = context.Dueños.ToList();
                }
                return dueños;
            }
            catch (Exception ex)
            {
                return dueños;
            }
        }
    }
}
