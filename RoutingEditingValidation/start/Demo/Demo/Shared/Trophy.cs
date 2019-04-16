using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Shared
{
  public enum CoolFactor
  {
    Mediocre,
    PrettyFly,
    Fierce,
    MrT
  }

  public class Trophy
  {
    public int Id { get; set; }
    [Required(AllowEmptyStrings=false, ErrorMessage="Please enter a name")]
    public string Name { get; set; }
    public string Source { get; set; }
    public CoolFactor CoolFactor { get; set; } = CoolFactor.Mediocre;
  }
}
