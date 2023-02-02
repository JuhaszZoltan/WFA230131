using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230131
{
    public partial class ColorUserControl : UserControl
    {
        public MainForm MainForm { get; set; }

        public ColorUserControl(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            changeColorButton.Click += OnChangeColorButtonClick;
            redTrackBar.ValueChanged += OnColorTrackBarValueChanged;
            greenTrackBar.ValueChanged += OnColorTrackBarValueChanged;
            blueTrackBar.ValueChanged += OnColorTrackBarValueChanged;

        }

        private void OnColorTrackBarValueChanged(object? sender, EventArgs e)
        {
            changeColorButton.BackColor = Color.FromArgb(
                red: redTrackBar.Value,
                green: greenTrackBar.Value,
                blue: blueTrackBar.Value);
        }

        private void OnChangeColorButtonClick(object? sender, EventArgs e)
        {
            MainForm.mainPanel.BackColor = Color.FromArgb(
                red: redTrackBar.Value,
                green: greenTrackBar.Value,
                blue: blueTrackBar.Value);
        }
    }
}
