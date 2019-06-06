﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hero_Designer
{


    public partial class FrmInputLevel : Form
    {

    
    
        internal virtual Button btnOK
        {
            get
            {
                return this._btnOK;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnOK_Click);
                if (this._btnOK != null)
                {
                    this._btnOK.Click -= eventHandler;
                }
                this._btnOK = value;
                if (this._btnOK != null)
                {
                    this._btnOK.Click += eventHandler;
                }
            }
        }


    
    
        internal virtual Label Label1
        {
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label1 = value;
            }
        }


    
    
        internal virtual NumericUpDown udLevel
        {
            get
            {
                return this._udLevel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.udLevel_Leave);
                if (this._udLevel != null)
                {
                    this._udLevel.Leave -= eventHandler;
                }
                this._udLevel = value;
                if (this._udLevel != null)
                {
                    this._udLevel.Leave += eventHandler;
                }
            }
        }


        public FrmInputLevel(ref frmMain iParent, bool iLF, bool iMode2)
        {
            base.Load += this.FrmInputLevel_Load;
            this.InitializeComponent();
            this.myparent = iParent;
            this.LongFormat = iLF;
            this.Mode2 = iMode2;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            int num;
            if (Conversion.Val(this.udLevel.Text) != Convert.ToDouble(this.udLevel.Value))
            {
                num = (int)Math.Round(Conversion.Val(this.udLevel.Text));
                if (decimal.Compare(new decimal(num), this.udLevel.Minimum) < 0)
                {
                    num = Convert.ToInt32(this.udLevel.Minimum);
                }
                if (decimal.Compare(new decimal(num), this.udLevel.Maximum) > 0)
                {
                    num = Convert.ToInt32(this.udLevel.Maximum);
                }
            }
            else
            {
                num = Convert.ToInt32(this.udLevel.Value);
            }
            if (this.LongFormat)
            {
                this.myparent.smlRespecLong(num - 1, this.Mode2);
            }
            else
            {
                this.myparent.smlRespecShort(num - 1, this.Mode2);
            }
            base.Close();
        }


        private void FrmInputLevel_Load(object sender, EventArgs e)
        {
        }


        private void udLevel_Leave(object sender, EventArgs e)
        {
            this.udLevel.Validate();
        }


        [AccessedThroughProperty("btnOK")]
        private Button _btnOK;


        [AccessedThroughProperty("Label1")]
        private Label _Label1;


        [AccessedThroughProperty("udLevel")]
        private NumericUpDown _udLevel;


        private bool LongFormat;


        private bool Mode2;


        private frmMain myparent;
    }
}
