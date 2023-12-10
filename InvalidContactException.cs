using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class InvalidContactException: Exception
    {
        public InvalidContactException(string field, string requirementMessage): base($"Campo con formato invalido: {field}. Causa de la excepción: {requirementMessage}") {
            
        }
    }
}
