using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TooGame.MapEngine;

namespace TooGame
{
    public partial class GenSettings : Form
    {
        public GenSettings()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            MapType mapType;
            MapType.MapTypes.TryGetValue((string)this.comboMapType.SelectedValue, out mapType);
            MapGenerator.CreateMap(
                (int)this.numericWidth.Value,
                (int)this.numericHeight.Value,
                mapType,
                (int)this.numericNeighbors.Value,
                this.checkCarve.Checked,
                (int)this.numericIterations.Value,
                (int)this.numericProbability.Value
                );
        }
    }
}
