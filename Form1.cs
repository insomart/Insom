using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Insomart;
using System.Threading;

namespace Insomiris
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class mainScreen : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox origIm;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox rIm;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;

		private UIVars vars;
        private ExecuterThread executer;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
        private SplitContainer splitContainer1;
        private Panel panel3;
        private Label statusLabel;
		private SetVariables setVariables;

		public mainScreen()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			vars = new UIVars();
			setVariables = new SetVariables();
            this.executer = new ExecuterThread(this.origIm.Image, this.rIm.Image,this);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.origIm = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.rIm = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.origIm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rIm)).BeginInit();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // origIm
            // 
            this.origIm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.origIm, "origIm");
            this.origIm.Name = "origIm";
            this.origIm.TabStop = false;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem10});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem16,
            this.menuItem6,
            this.menuItem9,
            this.menuItem7,
            this.menuItem8});
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 1;
            resources.ApplyResources(this.menuItem16, "menuItem16");
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            resources.ApplyResources(this.menuItem6, "menuItem6");
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            resources.ApplyResources(this.menuItem9, "menuItem9");
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            resources.ApplyResources(this.menuItem7, "menuItem7");
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 5;
            resources.ApplyResources(this.menuItem8, "menuItem8");
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11});
            resources.ApplyResources(this.menuItem2, "menuItem2");
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            resources.ApplyResources(this.menuItem11, "menuItem11");
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15,
            this.menuItem14,
            this.menuItem19,
            this.menuItem12,
            this.menuItem22,
            this.menuItem13});
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 0;
            resources.ApplyResources(this.menuItem15, "menuItem15");
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem17,
            this.menuItem18});
            resources.ApplyResources(this.menuItem14, "menuItem14");
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 0;
            resources.ApplyResources(this.menuItem17, "menuItem17");
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 1;
            resources.ApplyResources(this.menuItem18, "menuItem18");
            this.menuItem18.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 2;
            resources.ApplyResources(this.menuItem19, "menuItem19");
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            resources.ApplyResources(this.menuItem12, "menuItem12");
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 4;
            resources.ApplyResources(this.menuItem22, "menuItem22");
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 5;
            resources.ApplyResources(this.menuItem13, "menuItem13");
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem20,
            this.menuItem21});
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 0;
            resources.ApplyResources(this.menuItem20, "menuItem20");
            this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 1;
            resources.ApplyResources(this.menuItem21, "menuItem21");
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 4;
            resources.ApplyResources(this.menuItem10, "menuItem10");
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rIm);
            this.panel2.Name = "panel2";
            // 
            // rIm
            // 
            this.rIm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.rIm, "rIm");
            this.rIm.Name = "rIm";
            this.rIm.TabStop = false;
            this.rIm.Click += new System.EventHandler(this.rIm_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.origIm);
            this.panel1.Name = "panel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusLabel);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // mainScreen
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Menu = this.mainMenu;
            this.Name = "mainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.origIm)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rIm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new mainScreen());
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			origIm.Image = Image.FromStream(UIToolset.LoadImage(openFileDialog1));
			rIm.Image = origIm.Image;
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			try
			{
				Stream iStream = UIToolset.LoadImage(openFileDialog1);
				vars.FileName = openFileDialog1.FileName;
				origIm.Image = Image.FromStream(iStream);
				iStream.Close();
				rIm.Image = origIm.Image;
			}
			catch
			{}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
		
		}

		private void rIm_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
            if (origIm.Image != null && !executer.IsRunning())
            {
                SetBusyStatus();
                executer.OriginalImage = this.origIm.Image;
                executer.Action = new TransformAction(Insom.ApplyTransform);
                executer.Data = new TransformData(setVariables);
                executer.Rotate = false;
                Thread execThread = new Thread(executer.Run);
                execThread.Start();
            }
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			UIToolset.SaveImage(new FileStream(vars.FileName,FileMode.Create),rIm.Image);
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
            if (origIm.Image != null && !executer.IsRunning())
            {
                SetBusyStatus();
                executer.OriginalImage = this.origIm.Image;
                executer.Action = new TransformAction(Insom.ApplyTransformBeta);
                executer.Data = new TransformDataBeta(setVariables);
                executer.Rotate = false;
                Thread execThread = new Thread(executer.Run);
                execThread.Start();
            }
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			UIToolset.SaveImage(saveFileDialog1,rIm.Image);
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			ImageSequence sequence = UIToolset.LoadSequence(openFileDialog1);
			String file = sequence.NextFile;
			TransformData trData = new TransformData();
			while(File.Exists(file))
			{
				Stream iStream = UIToolset.LoadImage(file);
				origIm.Image = Image.FromStream(iStream);
				iStream.Close();
				rIm.Image = Insomart.Insom.Transform(origIm.Image,new TransformAction(Insom.ApplyTransform),trData);
				UIToolset.SaveImage(new FileStream(sequence.CurrentCovertedFile,FileMode.Create),rIm.Image);
				file = sequence.NextFile;
			}
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			SetBetaWindow window = new SetBetaWindow(this.setVariables);
			window.Show();
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			if(origIm.Image!=null && !executer.IsRunning())
			{
                SetBusyStatus();
                executer.OriginalImage = this.origIm.Image;
                executer.Action = new TransformAction(Insom.ApplyTransformAlpha);
                executer.Data = new TransformDataBeta(setVariables);
                executer.Rotate = false;
                Thread execThread = new Thread(executer.Run);
                execThread.Start();
            }
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			try
			{
				Stream iStream = UIToolset.LoadImage(openFileDialog1);
				this.setVariables.filter = new Bitmap(Image.FromStream(iStream));
				iStream.Close();
			}
			catch
			{}
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			this.setVariables.filter = null;
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
            if (origIm.Image != null && !executer.IsRunning())
			{
                SetBusyStatus();
                executer.OriginalImage = this.origIm.Image;
                executer.Action = new TransformAction(Insom.ApplyTransformFFT);
                executer.Data = new TransformDataBeta(setVariables);
                executer.Rotate = true;
                Thread execThread = new Thread(executer.Run);
                execThread.Start();
            }
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			if(rIm.Image!=null)
			{
				rIm.Image = Insomart.Insom.Rearrange(rIm.Image);
			}
		}

		private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
		
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
            if (origIm.Image != null && !executer.IsRunning())
			{
                SetBusyStatus();
                executer.OriginalImage = this.origIm.Image;
                executer.Action = new TransformAction(Insom.ApplyTransformGamma);
                executer.Data = new TransformDataBeta(setVariables);
                executer.Rotate = true;
                Thread execThread = new Thread(executer.Run);
                execThread.Start();
			}
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			if(origIm.Image!=null && !executer.IsRunning())
			{
                SetBusyStatus();
                executer.OriginalImage = this.origIm.Image;
                executer.Action = new TransformAction(Insom.ApplyTransformDelta);
                executer.Data = new TransformDataBeta(setVariables);
                executer.Rotate = true;
                Thread execThread = new Thread(executer.Run);
                execThread.Start();
			}
		}

        private void SetBusyStatus()
        {
            this.statusLabel.Text = "Processing";
        }

        internal void RefreshUI()
        {
            if (this.InvokeRequired)
            {
                RefreshCallback r = new RefreshCallback(this.RefreshImages);
                this.Invoke(r);
            }
            else
            {
                this.Refresh();
            }
        }

        internal void RefreshImages()
        {
            this.rIm.Image = executer.Result;
            SetReadyStatus();
            this.Refresh();
        }

        private void SetReadyStatus()
        {
            this.statusLabel.Text = "Ready";
            this.Refresh();
        }
    }

	public delegate void RefreshCallback();
}
