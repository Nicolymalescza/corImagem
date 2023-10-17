using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorPorImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_mostrarImagem_Click_1(object sender, EventArgs e)
        {
            //Mostra a caixa de diálogo Abrir arquivo. Se o usuário clicar em OK, carregue o
            //imagem que o usuário escolheu.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            // Limpa a imagem.
            pictureBox1.Image = null;
        }

        private void bt_corFundo_Click(object sender, EventArgs e)
        {
            //Mostra a caixa de diálogo de cores. Se o usuário clicar em OK, altere o
            // Fundo do controle PictureBox na cor escolhida pelo usuário.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            // Feche o formulário.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o usuário marcar a caixa de seleção Estender(Stretch) ,
            // altera o PictureBox
            // Propriedade SizeMode para "Estender(Stretch)". Se o usuário limpar
            // a caixa de seleção, altere-a para "Normal".
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }      
    }
}
