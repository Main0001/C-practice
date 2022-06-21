using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace _30_1.Models
{
    [Table(Name = "Туристы")]

    public class Turist
    {
        [Column(Name = "Код_туриста", IsPrimaryKey = true, IsDbGenerated =true)]
        public int Id { get; set; }
        
        [Column(Name ="Фамилия")]
        public string Surname { get; set; }
        
        [Column(Name ="Имя")]
        public string Name { get; set; }

        [Column(Name ="Отчество")]
        public string Patronymic { get; set; } 

    }
}
