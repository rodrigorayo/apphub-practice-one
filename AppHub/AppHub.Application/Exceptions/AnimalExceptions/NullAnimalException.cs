using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHub.Application.Exceptions
{
    public class NullAnimalException : ApplicationException
    {
        public NullAnimalException(int id) : base($"El animal con este ID: {id} no existe.")
        {
        }
    }
}
