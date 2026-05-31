using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Security
{
    public class SessionManager
    {
        public static Usuario? CurrentUser { get; set; }
    }
}
