using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NSede
    {
        private DSede dSede = new DSede();

        public String Registrar(Sedes sede)
        {
            return dSede.Registrar(sede);
        }

        public String Modificar(Sedes sede)
        {
            return dSede.Modificar(sede);
        }

        public String Eliminar(int id_Sede)
        {
            return dSede.Eliminar(id_Sede);
        }

        public List<Sedes> ListarTodo()
        {
            return dSede.ListarTodo();
        }

    }
}
