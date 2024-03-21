using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Repositories;
namespace Services
{
    public class Service1:IService
    {
        private readonly IRepo Repo;

        public Service1(IRepo _Repo)
        {
            Repo = _Repo;   
        }
        public async Task<List<Student>> getAll()
        {
               List<Student> cities = await Repo.getAll();
               return cities;   
        }

    }
}
