namespace FerreMaster
{
	partial class Login
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(574, 123);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.btnIngresar);
			this.panel2.Controls.Add(this.txtContraseña);
			this.panel2.Controls.Add(this.txtUsuario);
			this.panel2.Controls.Add(this.lblContraseña);
			this.panel2.Controls.Add(this.lblUsuario);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(1, 132);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(574, 287);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(98, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(381, 73);
			this.label1.TabIndex = 1;
			this.label1.Text = "FerreMaster";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.Location = new System.Drawing.Point(188, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(212, 37);
			this.label4.TabIndex = 5;
			this.label4.Text = "Bienvenido/a";
			// 
			// btnIngresar
			// 
			this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnIngresar.BackColor = System.Drawing.Color.Cyan;
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnIngresar.Location = new System.Drawing.Point(195, 199);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(164, 49);
			this.btnIngresar.TabIndex = 12;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContraseña.Location = new System.Drawing.Point(303, 136);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(178, 26);
			this.txtContraseña.TabIndex = 11;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(303, 69);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(178, 26);
			this.txtUsuario.TabIndex = 10;
			// 
			// lblContraseña
			// 
			this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblContraseña.AutoSize = true;
			this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContraseña.Location = new System.Drawing.Point(86, 125);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(203, 37);
			this.lblContraseña.TabIndex = 9;
			this.lblContraseña.Text = "Contraseña:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.lblUsuario.Location = new System.Drawing.Point(86, 59);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(145, 37);
			this.lblUsuario.TabIndex = 8;
			this.lblUsuario.Text = "Usuario:";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 417);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Login";
			this.Text = "Login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label label4;
	}
}

