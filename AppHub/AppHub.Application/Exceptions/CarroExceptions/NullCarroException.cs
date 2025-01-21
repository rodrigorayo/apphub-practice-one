using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHub.Application.Exceptions.CarroExceptions
{
    internal class NullCarroException : ApplicationException
    {
        public NullCarroException(int id) : base($"El carro con este ID: {id} no existe.")
        {
    }
}
