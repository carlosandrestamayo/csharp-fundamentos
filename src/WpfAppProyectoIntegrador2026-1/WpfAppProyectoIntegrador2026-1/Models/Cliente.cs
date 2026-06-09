using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Cliente: Persona
    {
        public Cliente(Guid id, string nombre, string identificacion, string telefono, string correo) : base(id, nombre, identificacion, telefono, correo)
        {
            
        }

    }
}
