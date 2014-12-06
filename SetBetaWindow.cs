using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Insomart;

namespace Insomiris
{
	/// <summary>
	/// Summary description for SetBetaWindow.
	/// </summary>
	public class SetBetaWindow : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox beta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SetVariables setVariables;

		public SetBetaWindow(SetVariables setVariables)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			this.setVariables = setVariables;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.beta = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// beta
			// 
			this.beta.Location = new System.Drawing.Point(16, 32);
			this.beta.Name = "beta";
			this.beta.Size = new System.Drawing.Size(128, 20);
			this.beta.TabIndex = 0;
			this.beta.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Beta";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SetBetaWindow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(160, 102);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.label1,
																		  this.beta});
			this.Name = "SetBetaWindow";
			this.Text = "SetBetaWindow";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.setVariables.beta = double.Parse(this.beta.Text);
				this.Dispose(true);
			}
			catch
			{
				
			}
		}
	}
}
