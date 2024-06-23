using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVeterinario
    {
        public String Registrar(Veterinarios veterinario)
        {
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    context.Veterinarios.Add(veterinario);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Veterinarios veterinario)
        {
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    Veterinarios veterinarioTemp = context.Veterinarios.Find(veterinario.VeterinarioId);
                    veterinarioTemp.NombreCompleto = veterinario.NombreCompleto;
                    veterinarioTemp.Especialidad = veterinario.Especialidad;
                    veterinarioTemp.CodigoColegiatura = veterinario.CodigoColegiatura;
                    veterinarioTemp.Genero = veterinario.Genero;
                    veterinarioTemp.CorreoElectronico = veterinario.CorreoElectronico;
                    veterinarioTemp.NumeroTelefonico = veterinario.NumeroTelefonico;

                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Veterinarios)
        {
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    Veterinarios veterinarioTemp = context.Veterinarios.Find(id_Veterinarios);
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

        public List<Veterinarios> ListarTodo(int id_sede)
        {
            List<Veterinarios> veterinarios = new List<Veterinarios>();
            try
            {
                using (var context = new BDEFPatitasFelices())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    veterinarios = context.Veterinarios.Where(v => v.VeterinarioId == id_sede).ToList();
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
