﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.NavDarck
{
    public partial class UCHerramientasNav : UserControl
    {
        private FormHomeDarck formHomeDarck;

        public UCHerramientasNav()
        {
            InitializeComponent();
        }

        public UCHerramientasNav(FormHomeDarck formHomeDarck)
        {
            InitializeComponent();
            this.formHomeDarck = formHomeDarck;
        }
    }
}
