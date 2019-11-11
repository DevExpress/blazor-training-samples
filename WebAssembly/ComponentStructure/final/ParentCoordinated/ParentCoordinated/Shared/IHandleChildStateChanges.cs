using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentCoordinated.Shared
{
  public interface IHandleChildStateChanges
  {
    void ChildStateChanged();
  }
}
