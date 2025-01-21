using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHub.Application.Exceptions.CarroExceptions
{
    internal class NullCarroException(int id) : ApplicationException($"El carro con este ID: {id} no existe.")
    {
    }
}
