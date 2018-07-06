//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace Vue2Spa.Service
//{
//    public class applicationDbContext : IdentityDbContext
//    {
//        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseMySql(GetConnectionString());
//        }

//        private static string GetConnectionString()
//        {
//            const string databaseName = "webapijwt";
//            const string databaseUser = "";
//            const string databasePass = "";

//            return $"Server=localhost;" +
//                   $"database={databaseName};" +
//                   $"uid={databaseUser};" +
//                   $"pwd={databasePass};" +
//                   $"pooling=true;";
//        }
//    }
//}
