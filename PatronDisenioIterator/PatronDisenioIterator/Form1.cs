using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronDisenioIterator
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    agregarConcreto oAgregar = new agregarConcreto();
    int c = 0;
    public void ingresar()
    {
      oAgregar[c] = txtElemento.Text;
    }

    public void mostrar()
    {
      iterator_concreto oIterador = new iterator_concreto(oAgregar);
      object lista = oIterador.Primero();
      dgv_elemento.Rows.Clear();
      while (lista!= null)
      {
        dgv_elemento.Rows.Add(lista);
        lista = oIterador.Siguiente();
      }
    }

    public void LIMPIAR()
    {
      txtElemento.Clear();
    }


    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
      ingresar();
      c++;
      LIMPIAR();
    }

    private void btn_mostrar_Click(object sender, EventArgs e)
    {
      mostrar();
    }
  }
}
