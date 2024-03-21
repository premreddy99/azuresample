using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
namespace Repositories
{
    public class Repo2:IRepo
    {
        public async Task<List<Student>> getAll()
        {
            List<Student> cities = new List<Student>();
            return cities;
        }
    }
}
