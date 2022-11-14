﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fShop : Form
    {
        public fShop()
        {
            InitializeComponent();
            Render();
        }

        private void Render()
        {
            MyData data = new MyData();
            DataRowCollection plants = data.Plants.Rows;
            for (int id = 0; id < plants.Count; id++)
            {
                Item item = new Item(plants[id]);
                flpItems.Controls.Add(item);
            }
        }
    }
}
