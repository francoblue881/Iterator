using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDisenioIterator
{
   public class agregarConcreto:agregar
  {
    private ArrayList elementos = new ArrayList();

    public override iterator crearIterator()
    {
      return new iterator_concreto(this);

    }

    public int Count {
      get { return elementos.Count;  }
    }

    public object this[int tamanio]
    {
      get { return elementos[tamanio]; }
      set { elementos.Insert(tamanio, value); }
    }


  }
}
