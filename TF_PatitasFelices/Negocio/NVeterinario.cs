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
        private DVeterinario dVeterinarios = new DVeterinario();

        public String Registrar(Veterinarios veterinario)
        {
            return dVeterinarios.Registrar(veterinario);
        }

        public String Modificar(Veterinarios veterinario)
        {
            return dVeterinarios.Modificar(veterinario);
        }

        public String Eliminar(int id_Veterinarios)
        {
            return dVeterinarios.Eliminar(id_Veterinarios);
        }

        public List<Veterinarios> ListarTodo(int id_veterinarios)
        {
            return dVeterinarios.ListarTodo(id_veterinarios);
        }
    }
}
