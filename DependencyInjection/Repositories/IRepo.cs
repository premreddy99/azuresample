﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Common.Models;

namespace Repositories
{
    public interface IRepo
    {
        public Task<List<Student>> getAll();

    }
}
