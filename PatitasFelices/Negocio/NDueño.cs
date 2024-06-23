using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDueño
    {
        private DDueño dDueño = new DDueño();

        public String Registrar(Dueños dueños)
        {
            return dDueño.Registrar(dueños);
        }

        public String Modificar(Dueños dueños)
        {
            return dDueño.Modificar(dueños);
        }

        public String Eliminar(int id_dueño)
        {
            return dDueño.Eliminar(id_dueño);
        }

        public List<Dueños> ListarTodo()
        {
            return dDueño.ListarTodo();
        }
    }
}
