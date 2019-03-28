using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentCoordinated.Shared
{
  public interface ICardBody
  {
    void SetTitle(CardTitle title);
    void AddText(CardText text);
    void AddLink(CardLink link);
  }
}
