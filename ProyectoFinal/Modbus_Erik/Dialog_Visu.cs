using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Modbus_Erik
{
    public partial class Dialog_Visu : DarkUI.Forms.DarkDialog
    {
        public string PropertyValue => ucTextBoxEx_PropertyValue.InputText;
        public Dialog_Visu(ToolStripItemClickedEventArgs e)
        {
            InitializeComponent();
            switch (e.ClickedItem.Name)
            {
                case "_Degree":
                    this.Text = "Propiedades: Ángulo";
                    darkLabel_Property1Name.Text = "Ángulo del Control";
                    ucTextBoxEx_PropertyValue.InputType = (HZH_Controls.TextInputType)32;
                    break;
                case "_Divisions":
                    this.Text = "Propiedades: Divisiones";
                    darkLabel_Property1Name.Text = "Divisiones";
                    ucTextBoxEx_PropertyValue.InputType = (HZH_Controls.TextInputType)32;
                    break;
                case "_MinValue":
                    this.Text = "Propiedades: Valor Mínimo";
                    darkLabel_Property1Name.Text = "Valor Mínimo";
                    ucTextBoxEx_PropertyValue.InputType = (HZH_Controls.TextInputType)1;
                    break;
                case "_MaxValue":
                    this.Text = "Propiedades: Valor Máximo";
                    darkLabel_Property1Name.Text = "Valor Máximo";
                    ucTextBoxEx_PropertyValue.InputType = (HZH_Controls.TextInputType)32;
                    break;
                case "_TagName":
                    ucTextBoxEx_PropertyValue.InputType = (HZH_Controls.TextInputType)1;
                    this.Text = "Propiedades: Nombre de Variable";
                    darkLabel_Property1Name.Text = "Nombre";
                    break;
            }

        }

        private void Dialog_Visu_Load(object sender, EventArgs e)
        {

        }

    }
}
