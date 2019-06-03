namespace pap2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cookie_lbl = new System.Windows.Forms.Label();
			this.text_lbl = new System.Windows.Forms.Label();
			this.crack_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cookie_lbl
			// 
			this.cookie_lbl.Image = global::pap2.Properties.Resources.pre;
			this.cookie_lbl.Location = new System.Drawing.Point(0, -2);
			this.cookie_lbl.Name = "cookie_lbl";
			this.cookie_lbl.Size = new System.Drawing.Size(656, 453);
			this.cookie_lbl.TabIndex = 0;
			this.cookie_lbl.Click += new System.EventHandler(this.cookie_lbl_Click);
			// 
			// text_lbl
			// 
			this.text_lbl.BackColor = System.Drawing.Color.Transparent;
			this.text_lbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_lbl.Location = new System.Drawing.Point(252, 165);
			this.text_lbl.Name = "text_lbl";
			this.text_lbl.Size = new System.Drawing.Size(173, 65);
			this.text_lbl.TabIndex = 1;
			this.text_lbl.Visible = false;
			// 
			// crack_button
			// 
			this.crack_button.Location = new System.Drawing.Point(235, 388);
			this.crack_button.Name = "crack_button";
			this.crack_button.Size = new System.Drawing.Size(200, 50);
			this.crack_button.TabIndex = 2;
			this.crack_button.Text = "Crack Cookie!";
			this.crack_button.UseVisualStyleBackColor = true;
			this.crack_button.Click += new System.EventHandler(this.crack_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 450);
			this.Controls.Add(this.crack_button);
			this.Controls.Add(this.text_lbl);
			this.Controls.Add(this.cookie_lbl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label cookie_lbl;
		private System.Windows.Forms.Label text_lbl;
		private System.Windows.Forms.Button crack_button;
	}
}

