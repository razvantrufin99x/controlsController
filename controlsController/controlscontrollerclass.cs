using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlsController
{
    public class controlscontrollerclass
    {
        public List<Control> controlsControllerList = new List<Control>();
        public controlscontrollerclass() { }
        public controlscontrollerclass(Control control) { 
            this.controlsControllerList.Add(control);
        }
        public void addControlInListOfControls(Control control)
        {
            this.controlsControllerList.Add(control);
        }
        public void setTextOfControl(int index, string s)
        {
            this.controlsControllerList[index].Text = s;
        }
        public void setVisibilityOfControl(int index, bool yn)
        {
            this.controlsControllerList[index].Visible = yn;
        }
        public void setPositionOfControl(int index, int x, int y)
        {
            this.controlsControllerList[index].Left = x;
            this.controlsControllerList[index].Top = y;
        }
        public void addControlToForm(Form f, int index)
        {
            f.Controls.Add(controlsControllerList[index]);

        }
    }
}
