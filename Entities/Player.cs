using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public  class Player:IEntities
    {
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set;}
        public string NationalityID { get; set; }
        public int BirthYear{ get; set; }

        
    }
}
