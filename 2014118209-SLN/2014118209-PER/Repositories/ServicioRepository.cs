﻿using _2014118209_ENT.Entities;
using _2014118209_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_PER.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {
        public ServicioRepository(_2014118209DbContext context) : base(context)
        {

        }
    }
}
