using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServiciuDeAlerte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListaAlerte la = new ListaAlerte();
        private void Form1_Load(object sender, EventArgs e)
        {
               la.alerte.Add(new alerta("1", new DateTime(2021/03/29)));

               la.alerte.Add(new alerta("2", new DateTime(2021/03/28)));

               la.alerte.Add(new alerta("3", new DateTime(2021/03/30)));

               la.alerte.Add(new alerta("4", new DateTime(2020/03/27)));

               la.alerte.Add(new alerta("5", new DateTime(2021/03/29)));

               la.alerte.Add(new alerta("6", new DateTime(2021/03/29)));

               la.urmatoareaalerta = la.findFirstAlerte();
               string alerteaza = la.verificaalertaurmatoare();
               Text = alerteaza.ToString();
        }
    }
}
