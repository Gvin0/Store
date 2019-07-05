using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
  [Table("Users")]
  public abstract class User {

    [Key]
    public int ID { get; set; }

    [Required, MaxLength(20)]
    public string Username { get; set; }

    //[Required]
    public byte[] Password { get; set; }//ToDo: davaHashirot paroli


  }
}
