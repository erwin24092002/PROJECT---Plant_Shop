﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fCart : Form
    {
        public fCart()
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
                CartItem item = new CartItem(plants[id]["id"].ToString(), id);
                flpCart.Controls.Add(item);
            }
        }
    }
}
