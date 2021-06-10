using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore3.Models 
{
    public class User : BaseModel
    {
        //[Key]
        public int Id { get; set; }
    }
}
