using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDUsers.Models
{
    //user is a Domain Model(ties to a data base)/ Model is another name for class
    //view models is for front end, domain models are for the back end
    public class User  
    {
        public int Id { get; set; }  //Primary key column
        public required string Name { get; set; }  //User's name column 


    }
}
