using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Biblioteca_ofc1
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cas = new Cadastro();
            cas.Show();
            this.Hide();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.Show();
            this.Hide();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
