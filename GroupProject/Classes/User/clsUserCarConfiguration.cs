using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Classes.User
{
  class ClsUserCarConfiguration
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public int Modification { get; set; }
    public int ConfigurationId { get; set; }
    public string ModificationName { get; set; }
    public float Price { get; set; }
  }
}
