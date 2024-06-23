using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMascota
    {
        public String Registrar(Mascotas mascotas)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    context.Mascotas.Add(mascotas);
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

        public String Modificar(Mascotas mascotas)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    Mascotas mascotaTemp = context.Mascotas.Find(mascotas.MascotaId);
                    mascotaTemp.NombreMascota = mascotas.NombreMascota;
                    mascotaTemp.Especie = mascotas.Especie;
                    mascotaTemp.Raza = mascotas.Raza;
                    mascotaTemp.Sexo = mascotas.Sexo;
                    mascotaTemp.Peso = mascotas.Peso;
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

        public String Eliminar(int id_mascota)
        {
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    Mascotas mascotaTemp = context.Mascotas.Find(id_mascota);
                    context.Mascotas.Remove(mascotaTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Mascotas> ListarTodo()
        {
            List<Mascotas> mascotas = new List<Mascotas>();
            try
            {
                using (var context = new PatitasFelicesDBEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    mascotas = context.Mascotas.ToList();
                }
                return mascotas;
            }
            catch (Exception ex)
            {
                return mascotas;
            }
        }
    }
}
