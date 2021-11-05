
namespace WindowsFormsCatamaran
{
    partial class FormCatamaranConfig
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
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxRightCorpus = new System.Windows.Forms.CheckBox();
            this.checkBoxSeat = new System.Windows.Forms.CheckBox();
            this.checkBoxLeftCorpus = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelCatamaran = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelBoat.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.checkBoxRightCorpus);
            this.groupBoxParametrs.Controls.Add(this.checkBoxSeat);
            this.groupBoxParametrs.Controls.Add(this.checkBoxLeftCorpus);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParametrs.Controls.Add(this.labelWeight);
            this.groupBoxParametrs.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 118);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(316, 120);
            this.groupBoxParametrs.TabIndex = 0;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры";
            // 
            // checkBoxRightCorpus
            // 
            this.checkBoxRightCorpus.AutoSize = true;
            this.checkBoxRightCorpus.Location = new System.Drawing.Point(150, 55);
            this.checkBoxRightCorpus.Name = "checkBoxRightCorpus";
            this.checkBoxRightCorpus.Size = new System.Drawing.Size(164, 17);
            this.checkBoxRightCorpus.TabIndex = 6;
            this.checkBoxRightCorpus.Text = "Наличие правого поплавка";
            this.checkBoxRightCorpus.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeat
            // 
            this.checkBoxSeat.AutoSize = true;
            this.checkBoxSeat.Location = new System.Drawing.Point(150, 85);
            this.checkBoxSeat.Name = "checkBoxSeat";
            this.checkBoxSeat.Size = new System.Drawing.Size(114, 17);
            this.checkBoxSeat.TabIndex = 5;
            this.checkBoxSeat.Text = "Наличие сидения";
            this.checkBoxSeat.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeftCorpus
            // 
            this.checkBoxLeftCorpus.AutoSize = true;
            this.checkBoxLeftCorpus.Location = new System.Drawing.Point(150, 25);
            this.checkBoxLeftCorpus.Name = "checkBoxLeftCorpus";
            this.checkBoxLeftCorpus.Size = new System.Drawing.Size(158, 17);
            this.checkBoxLeftCorpus.TabIndex = 4;
            this.checkBoxLeftCorpus.Text = "Наличие левого поплавка";
            this.checkBoxLeftCorpus.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(65, 85);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(65, 40);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(10, 65);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(62, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес лодки:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(10, 20);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBoat.Location = new System.Drawing.Point(10, 9);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxBoat.TabIndex = 1;
            this.pictureBoxBoat.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelCatamaran);
            this.groupBoxType.Controls.Add(this.labelBoat);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(140, 100);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип транспорта";
            // 
            // labelCatamaran
            // 
            this.labelCatamaran.AllowDrop = true;
            this.labelCatamaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCatamaran.Location = new System.Drawing.Point(19, 60);
            this.labelCatamaran.Name = "labelCatamaran";
            this.labelCatamaran.Size = new System.Drawing.Size(100, 23);
            this.labelCatamaran.TabIndex = 1;
            this.labelCatamaran.Text = "Катамаран";
            this.labelCatamaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCatamaran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCatamaran_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.AllowDrop = true;
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(19, 25);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(100, 23);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Лодка";
            this.labelBoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.Controls.Add(this.pictureBoxBoat);
            this.panelBoat.Location = new System.Drawing.Point(158, 2);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(170, 117);
            this.panelBoat.TabIndex = 3;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.MediumBlue;
            this.panelBlue.Location = new System.Drawing.Point(30, 60);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 4;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(15, 25);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 23);
            this.labelMainColor.TabIndex = 5;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(135, 25);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 23);
            this.labelDopColor.TabIndex = 6;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(70, 60);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 7;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(30, 100);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 8;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.Location = new System.Drawing.Point(70, 100);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(30, 30);
            this.panelFuchsia.TabIndex = 9;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(150, 60);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 10;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(190, 60);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 11;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(150, 100);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 12;
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(190, 100);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(30, 30);
            this.panelPurple.TabIndex = 13;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelFuchsia);
            this.groupBoxColor.Location = new System.Drawing.Point(334, 12);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(253, 153);
            this.groupBoxColor.TabIndex = 14;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(494, 178);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(494, 215);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCatamaranConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 251);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.groupBoxType);
            this.Name = "FormCatamaranConfig";
            this.Text = "FormCatamaranConfig";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelBoat.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxSeat;
        private System.Windows.Forms.CheckBox checkBoxLeftCorpus;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelCatamaran;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxRightCorpus;
    }
}