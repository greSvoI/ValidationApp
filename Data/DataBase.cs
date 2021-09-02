using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationApp.Data
{
    public class DataBase:DbContext
    {
        public DataBase(DbContextOptions<DataBase> options) : base(options)
        {

        }
    }
}
