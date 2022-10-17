using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace crudtest.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public UserModel()
        {
            Id = -1;
            Name = "nothing";
        }

        public UserModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}