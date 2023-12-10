using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public class Contacto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }


        //Validando si los campos del registro cumplen con el formato especificado en los comentarios
        public bool Validar()
        {
            // Nombre: Debe ser una cadena de caracteres con al menos dos letras
            Regex regexNombre = new Regex(@"^[a-zA-Z\s]{2,}$");
            if (!regexNombre.IsMatch(Nombre)) throw new InvalidContactException("Nombre", "El nombre debe ser una cadena de caracteres con al menos dos letras, ej: \"Ana\"");

            // Apellido: Debe ser una cadena de caracteres con al menos tres letras
            Regex regexApellido = new Regex(@"^[a-zA-Z\s]{3,}$");
            if (!regexApellido.IsMatch(Apellido)) throw new InvalidContactException("Apellido", "El apellido debe ser una cadena de caracteres con al menos tres letras, ej: \"Cruz\"");

            // Telefono: Deben ser caracteres numericos y contener al menos 9 caracteres incluyendo uno o mas guiones, los cuales no pueden ser colocados consecutivamente
            Regex regexTelefono = new Regex(@"^(?!.*--)[0-9-]*-{1}[0-9-]*$");
            if (!regexTelefono.IsMatch(Telefono)) throw new InvalidContactException("Telefono", "El telefono debe ser una cadena de caracteres numericos y contener al menos 9 caracteres incluyendo uno o mas guiones, los cuales no pueden ser colocados consecutivamente, ej: 849-587-8747");

            // Correo: Debe ser el formato de un correo electronico con @ y . seguido de un dominio y al menos dos caracteres
            Regex regexCorreo = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,}$");
            if (!regexCorreo.IsMatch(Correo)) throw new InvalidContactException("Correo", "El correo debe ser el formato de un correo electronico con @ y . seguido de un dominio y al menos dos caracteres");

            // Empresa: Debe ser una cadena de caracteres con al menos dos letras
            Regex regexEmpresa = new Regex(@"^[a-zA-Z\s]{2,}$");
            if (!regexEmpresa.IsMatch(Empresa)) throw new InvalidContactException("Empresa", "El nombre de la empresa debe ser una cadena de caracteres con al menos dos letras, ej: \"Pepsi\"");

            //Todos los campos son validos
            return true;
        }

    }
}
