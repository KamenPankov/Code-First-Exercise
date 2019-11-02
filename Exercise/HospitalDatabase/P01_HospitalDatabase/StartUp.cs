using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            HospitalDbContext hospitalDbContext = new HospitalDbContext();

            hospitalDbContext.Database.Migrate();

            
        }
    }
}
