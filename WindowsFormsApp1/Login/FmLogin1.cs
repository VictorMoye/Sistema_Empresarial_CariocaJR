
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Marketing;
using WindowsFormsApp1.Tecnologia;
using WindowsFormsApp1.Gestao;


namespace WindowsFormsApp1
{
	public partial class FmLogin1 : Form
	{
		public FmLogin1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//User objetoConsulta = new User();
			gestao_tela_inicial tec = new gestao_tela_inicial();
			tec.Show();
			/*int result = objetoConsulta.FindOne(textBox1.Text, textBox2.Text);

			//lblMsg.Text = result;
			FmMenu frm = new FmMenu();
			frm.Show();
			if (result == 1)
				label3.Text = "Usuário encontrado!";
			else
				label3.Text = "Usuário ou/e senha incorretos!";*/
			//lblMsg.Text = rows;
		}
	}
}
