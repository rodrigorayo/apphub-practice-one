using AppHub.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHub.Domain.Repositories.Modules
{
    public interface IAnimalRepository : IGenericRepository<AnimalModel>
    {
    }
}
