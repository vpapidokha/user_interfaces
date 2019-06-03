using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pap2
{
	public partial class Form1 : Form
	{
		#region Declaration

		bool isCoocieCracked = false;
		string[] wishes =
		{
			"Make a wish, it would happens!",
			"blalala",
			"aloha!!",
			"i love u!",
			"heeeey, have a nice day!"
		};
		Random rand = new Random();

		#endregion

		#region Methods: Public

		public Form1()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods: Private

		private void cookie_lbl_Click(object sender, EventArgs e)
		{

		}

		private void crack_button_Click(object sender, EventArgs e)
		{
			if (isCoocieCracked)
			{
				CreateNewCookie();
			}
			else
			{
				CrackCookie();
			}
		}

		protected virtual void CrackCookie()
		{
			crack_button.Text = "Add one more Cookie!";
			cookie_lbl.Image = Properties.Resources.post;
			text_lbl.Text = wishes[rand.Next(1, wishes.Length)];
			text_lbl.Visible = true;
			isCoocieCracked = true;
		}

		protected virtual void CreateNewCookie()
		{
			text_lbl.Visible = false;
			crack_button.Text = "Crack Cookie!";
			cookie_lbl.Image = Properties.Resources.pre;
			isCoocieCracked = false;
		}

		#endregion
	}
}
