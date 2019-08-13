using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDisenioIterator
{
 public  class iterator_concreto: iterator
  {
    private agregarConcreto agregar;
    private int actual = 0;

    public iterator_concreto(agregarConcreto agregar)
    {
      this.agregar = agregar;
    }

    public override object Primero()
    {
      return agregar[0];
     
    }

    public override object Siguiente()
    {
      object ret = null;
      if (actual < agregar.Count - 1)
      {
        ret = agregar[++actual];

      }
      return ret;

    }

    public override object ElementoActual()
    {
      return agregar[actual];

    }
    public override bool EstaHecho()
    {
      return actual >= agregar.Count ? true : false; 
    }

  }
}
