using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVeterinario
    {
        private DVeterinario dVeterinario = new DVeterinario();

        public String Registrar(Veterinarios veterinarios)
        {
            return dVeterinario.Registrar(veterinarios);
        }

        public String Modificar(Veterinarios veterinarios)
        {
            return dVeterinario.Modificar(veterinarios);
        }

        public String Eliminar(int id_veterinario)
        {
            return dVeterinario.Eliminar(id_veterinario);
        }

        public List<Veterinarios> ListarTodo()
        {
            return dVeterinario.ListarTodo();
        }
    }
}
