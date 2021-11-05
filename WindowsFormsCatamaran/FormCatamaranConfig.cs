using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCatamaran
{
    public partial class FormCatamaranConfig : Form
    {
        ITransport boat = null;

        private Action<Vehicle> eventAddBoat; 

        public FormCatamaranConfig()
        {
            InitializeComponent();
            panelBlue.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelFuchsia.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        // Отрисовать лодку
        private void DrawBoat() 
        { 
            if (boat != null) 
            { 
                Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height); 
                Graphics gr = Graphics.FromImage(bmp); 
                boat.SetPosition(5, 5, pictureBoxBoat.Width, pictureBoxBoat.Height); 
                boat.DrawTransport(gr); 
                pictureBoxBoat.Image = bmp; 
            } 
        }

        // Добавление события
        public void AddEvent(Action<Vehicle> ev) 
        { 
            if (eventAddBoat == null) 
            { 
                eventAddBoat = new Action<Vehicle>(ev);
            } 
            else 
            { 
                eventAddBoat += ev; 
            } 
        }

        // Передаем информацию при нажатии на Label
        private void labelBoat_MouseDown(object sender, MouseEventArgs e)
        {
            labelBoat.DoDragDrop(labelBoat.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelCatamaran_MouseDown(object sender, MouseEventArgs e)
        {
            labelCatamaran.DoDragDrop(labelCatamaran.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому) 
        private void panelBoat_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) 
            { 
                e.Effect = DragDropEffects.Copy; 
            } 
            else 
            { 
                e.Effect = DragDropEffects.None; 
            }
        }

        // Действия при приеме перетаскиваемой информации
        private void panelBoat_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString()) 
            {
                case "Лодка": 
                    boat = new Boat((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White); 
                    break; 
                case "Катамаран":
                    boat = new Catamaran((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.White, true, checkBoxLeftCorpus.Checked, checkBoxRightCorpus.Checked, checkBoxSeat.Checked); 
                    break; 
            }
            DrawBoat();
        }

        // Отправляем цвет с панели
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (boat != null)
                (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Принимаем основной цвет
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            boat.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawBoat();
        }

        // Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        { 
           /* if (boat.GetType() != typeof(Catamaran)) 
                return;
            Color DopColor = (Color)e.Data.GetData(typeof(Color));
            Catamaran catamaran= (Catamaran)boat;
            catamaran.SetDopColor(DopColor);*/
            if (boat is Catamaran)
            {
                (boat as Catamaran).SetDopColor((Color)e.Data.GetData(typeof(Color)));
            }
            DrawBoat();
        }

        // Добавление лодки
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddBoat?.Invoke((Vehicle)boat);
            Close();
        }

    }
}
