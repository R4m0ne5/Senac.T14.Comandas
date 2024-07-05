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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            /// metodo que vai inserir o usuario no banco
            CriarUsuario();

            //AtualizarUsuario();
        }

        private void CriarUsuario()
        {
            // acessar o banco
            using(var banco = new AppDbContext())
            {
                // criar um novo usuario
                var novoUsuario = new Usuario();
                // atribuir propiedades
                novoUsuario.Nome = "Ramon";
                novoUsuario.Email = "nunesramon2007@gmail.com";
                novoUsuario.Senha = "123";
                // salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
            


        }
    }
}
