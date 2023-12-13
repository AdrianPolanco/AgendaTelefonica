using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public class SearchEngine
    {
        private Database _database;
        public SearchEngine(Database database) {
            _database = database;
     
        }
        public async Task<Contacto> SearchById(string value) {
            try {
                this.Validate(value);
                int.TryParse(value, out int id);
                Contacto contacto = await _database.ReadContactById(id);
                return contacto;
            }catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public bool Validate(string value)
        {
            // Expresión regular que permite solo dígitos
            string patron = "^[0-9]+$";

            // Verificar si la cadena cumple con la expresión regular
            bool esNumero = Regex.IsMatch(value, patron);

            if (!esNumero) { throw new Exception("Los ID solo pueden ser numericos."); }
            return true;
        }

        public void NotFound(string campo, string valor)
        {
            MessageBox.Show($"No se encontro ningún contacto que cumpla con las caracteristicas que especificaste. {campo}: {valor}", "Contacto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async void Search(RadioButton radioButton, string value, MainForm _mainForm)
        {
            if(radioButton.Name == "RadioButtonNombre")
            {
                List<Contacto>? contactos = await _database.ReadContactByName(value);
                if(contactos.Count == 0)
                {
                    NotFound("Nombre", value);
                    return;
                }
                Data.Update(contactos, _mainForm);
            }else if(radioButton.Name == "RadioButtonTelefono")
            {
                List<Contacto> contactos = await _database.ReadContactByPhoneNumber(value);
                if (contactos.Count == 0)
                {
                    NotFound("Telefono", value);
                    return;
                }
                Data.Update(contactos, _mainForm);
            }
            else if( radioButton.Name == "RadioButtonEmpresa")
            {
                List<Contacto> contactos = await _database.ReadContactByCompany(value);
                if(contactos.Count == 0)
                {
                    NotFound("Empresa", value);
                    return;
                }
                Data.Update(contactos, _mainForm);
            }
        }

    }
}
