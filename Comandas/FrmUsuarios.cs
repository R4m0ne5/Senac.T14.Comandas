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
        private bool novo;

        public FrmUsuarios()
        {
            InitializeComponent();
            ListarUsuarios();
        }
        // conectar no banco
        private void ListarUsuarios()
        {

            using (var banco = new AppDbContext())
            {   // SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                // Popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (novo) // usar chaves apenas quando é mais de uma linha
                /// metodo que vai inserir o usuario no banco
                CriarUsuario();

            else
                //AtualizarUsuario();
                AtualizarUsuario();
            DesabilitarCampos();
            ListarUsuarios();
            LimparCampos();
            BtnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnExcluir.Enabled = false;

        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        // Ctrl+K e Ctrl+D formatar certo!!
        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton)).FirstOrDefault();
                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            // acessar o banco
            using (var banco = new AppDbContext())
            {
                // criar um novo usuario
                var novoUsuario = new Usuario();
                // atribuir propiedades
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                // salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso.");
            }


        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {   // indiaca que esta editando o usuario
            novo = false;
            HabilitarCampos();
            BtnNovo.Enabled = false;
            btnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {   // obtem o id do usuario da tela
            var idUsuario = Convert.ToInt32(txtId.TextButton);
            // Chama o método que exclui da tabela usuario
            ExcluirUsuario(idUsuario);
            LimparCampos();
            BtnNovo.Enabled = true;
            btnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
            MessageBox.Show("Usuário excluido com sucesso");
        }

        private void ExcluirUsuario(object idUsuario)
        {
            // conectar no banco de dados
            using (var banco = new AppDbContext())
            {
                // consultar o usuario
                // SELECT * FROM usuario WHERE id = ?
                var usuario = banco.Usuarios.First(u => u.Id.Equals(idUsuario));

                // avisar o banco que estou excluindo
                // DELETE FROM usuarios WHERE id = ?
                banco.Usuarios.Remove(usuario);

                // confirmar a exclusão
                // COMMIT
                banco.SaveChanges();
            }

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            carregarUsuarios();
        }

        private void carregarUsuarios()
        {
            // conectar o banco
            using (var banco = new AppDbContext())
            {
                //realizar consulta na tabela usuarios
                var usuarios = banco.Usuarios.ToList();
                //popular os dados do grid
                dgvUsuarios.DataSource = usuarios;
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //verifica se uma lista esta selecionada existe
            if (e.RowIndex >= 0)
            {//mensagem mostra a linha selecionada 
             //MessageBox.Show("Linha selecionada " + (e.RowIndex + 1));

                var id = dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["senha"].Value.ToString();

                txtId.TextButton = id;
                txtNome.TextButton = nome;
                txtEmail.TextButton = email;
                txtSenha.TextButton = senha;

                BtnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = false;
                BtnExcluir.Enabled = true;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;   
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnCancelar.Enabled = false;
            LimparCampos();
        }
    }
}
