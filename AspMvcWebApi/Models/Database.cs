using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcWebApi.Models
{
    public static class Database
    {
     
        private static List<User> _database;
        

         static Database()
        {
            _database=new List<User>(){
            new User() {Id=1,Name="Mehmetcan",Age="23" },
            new User() {Id=2,Name="Ahmet",Age="24" }
        };

        }



        public static List<User>_Database
        {

            get { return _database; }
        }

        public static void AddUser(User entity)
        {
            _database.Add(entity);
        }






    }
}