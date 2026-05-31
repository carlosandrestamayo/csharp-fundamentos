using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Repositorys;

namespace WpfAppProyectoIntegrador2026_1.Security
{
    public class SeedData
    {
        public static void SeedAdmin()
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();


            List<Usuario> usuarios =
                usuarioRepository.GetAll();

            if (usuarios.Any())
            {
                return;
            }

            Usuario admin = new Usuario(
                Guid.NewGuid(),
                "Administrador",
                "000000000",
                "0000000000",
                "admin@sistema.com",
                "admin",
                PasswordHasher.HashPassword("admin123"),
                true,
                Rol.Administrador
            );

            usuarioRepository.Add(admin);
        }
    }
}
