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
    }
}
