using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;
using WpfAppProyectoIntegrador2026_1.Repositorys;
using WpfAppProyectoIntegrador2026_1.Security;
using WpfAppProyectoIntegrador2026_1.Validators;

namespace WpfAppProyectoIntegrador2026_1.Controllers
{
    class UsuarioController
    {
        private readonly UsuarioRepository usuarioRepository = new UsuarioRepository();

        public string Login(string username, string password)
        {
            Usuario? usuario = usuarioRepository.FindByUsername(username);


            // USER NOT FOUND
            if (usuario == null)
            {
                return "User not found.";
            }

            // USER INACTIVE
            if (!usuario.Activo)
            {
                return "User is inactive.";
            }

            // INVALID PASSWORD
            bool validPassword =
                PasswordHasher.VerifyPassword(
                    password,
                    usuario.PasswordHash
                );

            if (!validPassword)
            {
                return "Invalid password.";
            }

            // SUCCESS
            return "Login successful.";
        }


        public Usuario? Authenticate(string username, string password)
        {
            Usuario? usuario = usuarioRepository.FindByUsername(username);

            if (usuario == null)
            {
                return null;
            }

            if (!usuario.Activo)
            {
                return null;
            }

            if (!PasswordHasher.VerifyPassword(password, usuario.PasswordHash))
            {
                return null;
            }

            return usuario;
        }


        public string Add(Usuario usuario, string password)
        {
            Usuario? existingUser = usuarioRepository.FindByUsername(usuario.Username);

            if (existingUser != null)
            {
                return "Username already exists.";
            }

            usuario.PasswordHash = PasswordHasher.HashPassword(password);


            usuarioRepository.Add(usuario);

            return "User registered successfully.";
        }

        public void Update(Usuario usuario, Guid id)
        {
            usuarioRepository.Update(usuario, id);
        }

        public void ResetPassword(Guid id, string password)
        {
            Usuario? usuario = usuarioRepository.Find(id);


            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            usuario.PasswordHash = PasswordHasher.HashPassword(password);

            usuarioRepository.Update(usuario, id);
        }

        public void ToggleStatus(Guid id)
        {
            Usuario? usuario = usuarioRepository.Find(id);

            if (usuario == null)
            {
                throw new Exception(
                    "Usuario no encontrado."
                );
            }

            usuario.Activo = !usuario.Activo;

            usuarioRepository.Update(usuario, id);
        }

        public void ChangePassword(Guid id, string currentPassword, string newPassword)
        {
            Usuario? usuario =
                usuarioRepository.Find(id);

            if (usuario == null)
            {
                throw new Exception(
                    "Usuario no encontrado."
                );
            }

            bool validPassword =
                PasswordHasher.VerifyPassword(
                    currentPassword,
                    usuario.PasswordHash
                );

            if (!validPassword)
            {
                throw new Exception(
                    "La contraseña actual es incorrecta."
                );
            }

            PasswordValidator.Validate(
                newPassword
            );

            usuario.PasswordHash =
                PasswordHasher.HashPassword(
                    newPassword
                );

            usuarioRepository.Update(usuario, id);
        }

        public List<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }
    }
}
