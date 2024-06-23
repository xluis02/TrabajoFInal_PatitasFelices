using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMascota
    {
        private DMascota dMascota = new DMascota();

        public String Registrar(Mascotas mascotas)
        {
            return dMascota.Registrar(mascotas);
        }

        public String Modificar(Mascotas mascotas)
        {
            return dMascota.Modificar(mascotas);
        }

        public String Eliminar(int id_mascota)
        {
            return dMascota.Eliminar(id_mascota);
        }

        public List<Mascotas> ListarTodo()
        {
            return dMascota.ListarTodo();
        }
    }
}
