using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentCoordinated.Shared
{
  public interface ICard
  {
    void SetHeader(CardHeader header);
    void SetFooter(CardFooter footer);
    void AddBody(CardBody body);
    void ChildStateChanged();
  }
}
