namespace WindowsFormsCatamaran
{
	partial class FormPort
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
			this.pictureBoxPort = new System.Windows.Forms.PictureBox();
			this.buttonSetBoat = new System.Windows.Forms.Button();
			this.buttonSetCatamaran = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTakeBoat = new System.Windows.Forms.Button();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxPort
			// 
			this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxPort.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxPort.Name = "pictureBoxPort";
			this.pictureBoxPort.Size = new System.Drawing.Size(680, 450);
			this.pictureBoxPort.TabIndex = 0;
			this.pictureBoxPort.TabStop = false;
			// 
			// buttonSetBoat
			// 
			this.buttonSetBoat.Location = new System.Drawing.Point(690, 12);
			this.buttonSetBoat.Name = "buttonSetBoat";
			this.buttonSetBoat.Size = new System.Drawing.Size(100, 36);
			this.buttonSetBoat.TabIndex = 1;
			this.buttonSetBoat.Text = "Пришвартовать лодку";
			this.buttonSetBoat.UseVisualStyleBackColor = true;
			this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
			// 
			// buttonSetCatamaran
			// 
			this.buttonSetCatamaran.Location = new System.Drawing.Point(690, 54);
			this.buttonSetCatamaran.Name = "buttonSetCatamaran";
			this.buttonSetCatamaran.Size = new System.Drawing.Size(100, 36);
			this.buttonSetCatamaran.TabIndex = 2;
			this.buttonSetCatamaran.Text = "Пришвартовать катамаран";
			this.buttonSetCatamaran.UseVisualStyleBackColor = true;
			this.buttonSetCatamaran.Click += new System.EventHandler(this.buttonSetCatamaran_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTakeBoat);
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(690, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(100, 80);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать лодку";
			// 
			// buttonTakeBoat
			// 
			this.buttonTakeBoat.Location = new System.Drawing.Point(12, 51);
			this.buttonTakeBoat.Name = "buttonTakeBoat";
			this.buttonTakeBoat.Size = new System.Drawing.Size(75, 20);
			this.buttonTakeBoat.TabIndex = 2;
			this.buttonTakeBoat.Text = "Забрать";
			this.buttonTakeBoat.UseVisualStyleBackColor = true;
			this.buttonTakeBoat.Click += new System.EventHandler(this.buttonTakeBoat_Click);
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(56, 22);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(30, 20);
			this.maskedTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Место:";
			// 
			// FormPort
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSetCatamaran);
			this.Controls.Add(this.buttonSetBoat);
			this.Controls.Add(this.pictureBoxPort);
			this.Name = "FormPort";
			this.Text = "Парковка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxPort;
		private System.Windows.Forms.Button buttonSetBoat;
		private System.Windows.Forms.Button buttonSetCatamaran;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonTakeBoat;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
	}
}