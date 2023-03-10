using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlsController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public controlscontrollerclass cc = new controlscontrollerclass();

        public UserControl uc = new UserControl();

        private void Form1_Load(object sender, EventArgs e)
        {
            cc.addControlInListOfControls(new Button());
            cc.setPositionOfControl(0, 10, 10);
            cc.setTextOfControl(0, "OK");
            cc.addControlToForm(this, 0);
            cc.setVisibilityOfControl(0, true);

            uc.Width = 500;
            uc.Height = 500;
            uc.Left = 200;
            uc.Top = 200;
            uc.BackColor = Color.White;
            uc.Visible = true;
            this.Controls.Add(uc);
            uc.Controls.Add(cc.controlsControllerList[0]);
        }
    }
}
