using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Book
    {
        //primary key
        public int Id { get; set; }
        public required string Name { get; set; } = null!;
        public required string Author { get; set; } = null!;
        public required string Genre { get; set; } = null!;
  
        public required byte[] ImageData { get; set; } 
  
        public decimal Price { get; set; } = 0;

   
    }
}
