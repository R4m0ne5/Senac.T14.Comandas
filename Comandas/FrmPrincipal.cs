using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        //método (visibilidade=´private, retorno = void
        private void CriarBancoDeDados()
        {
            // criar uma variavel do tipo appDbContextx
            // usar a var e acessar o contexto
            // executar a migração == F5
            using (var banco = new AppDbContext())
            { // executa a migração(CREATE TABLE Usuarios)
                banco.Database.Migrate();
            }
        }

        private void crownGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void airButton2_Click(object sender, EventArgs e)
        {

        }

        private void gpxPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnCardapio_DoubleClick(object sender, EventArgs e)
        {
            new FrmCardapio().ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidoCozinha_DoubleClick(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btncomanda_DoubleClick(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnUsuarios_DoubleClick(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }
    }
}
