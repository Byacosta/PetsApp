using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetsApp.Models
{
    class Usuario
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [MaxLength(150)]
        public string NameUser { get; set; }

        [MaxLength(150)]
        public string Password { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(150)]
        public string Phone { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(150)]
        public string Sex { get; set; }


    }
}
