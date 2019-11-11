using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Shared
{
  public interface IDataLayer
  {
    IList<Trophy> AllTrophies();
    Trophy TrophyById(int id);
    Trophy TrophyForEditing(int id);
    void SubmitChanges(Trophy trophy);
  }

  public class DataLayer : IDataLayer
  {
    public IList<Trophy> AllTrophies() => trophies;
    public Trophy TrophyById(int id) => trophies.SingleOrDefault(t => t.Id == id);
    public Trophy CloneTrophy(Trophy source) => new Trophy
    {
      Id = source.Id,
      Name = source.Name,
      Source = source.Source,
      CoolFactor = source.CoolFactor
    };
    public Trophy TrophyForEditing(int id) => CloneTrophy(TrophyById(id));

    public void SubmitChanges(Trophy changed)
    {
      var original = TrophyById(changed.Id);
      original.Name = changed.Name;
      original.Source = changed.Source;
      original.CoolFactor = changed.CoolFactor;
    }

    List<Trophy> trophies = new List<Trophy>
    {
      new Trophy{
        Id =1,
        Name ="Rubber Chicken",
        Source ="Monkey Island",
        CoolFactor =CoolFactor.Fierce
      },
      new Trophy{
        Id =2,
        Name ="Pulley",
        Source ="Monkey Island",
        CoolFactor =CoolFactor.PrettyFly
      },
      new Trophy{
        Id =3,
        Name ="Black Marble",
        Source ="Oxyd",
        CoolFactor =CoolFactor.Mediocre
      },
      new Trophy{
        Id =4,
        Name ="A White",
        Source ="The Pawn",
        CoolFactor =CoolFactor.MrT
      }
    };

  }
}
