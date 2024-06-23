using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVeterinario
    {
        public String Registrar(Veterinarios veterinarios)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    context.Veterinarios.Add(veterinarios);
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

        public String Modificar(Veterinarios veterinarios)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    Veterinarios veterinarioTemp = context.Veterinarios.Find(veterinarios.VeterinarioId);
                    veterinarioTemp.NombreCompleto = veterinarios.NombreCompleto;
                    veterinarioTemp.Especialidad = veterinarios.Especialidad;
                    veterinarioTemp.CodigoColegiatura = veterinarios.CodigoColegiatura;
                    veterinarioTemp.Genero = veterinarios.Genero;
                    veterinarioTemp.CorreoElectronico = veterinarios.CorreoElectronico;
                    veterinarioTemp.NumeroTelefonico = veterinarios.NumeroTelefonico;
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

        public String Eliminar(int id_veterinario)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    Veterinarios veterinarioTemp = context.Veterinarios.Find(id_veterinario);
                    context.Veterinarios.Remove(veterinarioTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Veterinarios> ListarTodo()
        {
            List<Veterinarios> veterinarios = new List<Veterinarios>();
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    veterinarios = context.Veterinarios.ToList();
                }
                return veterinarios;
            }
            catch (Exception ex)
            {
                return veterinarios;
            }
        }
    }
}
