using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDisenioIterator
{
  public abstract class iterator
  {

    public abstract object Primero();
    public abstract object Siguiente();
    public abstract bool EstaHecho();
    public abstract object ElementoActual();
  }
}
