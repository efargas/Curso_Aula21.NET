
namespace Modbus_Erik
{
    partial class Dialog_Visu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.darkLabel_Property1Name = new DarkUI.Controls.DarkLabel();
            this.ucTextBoxEx_PropertyValue = new HZH_Controls.Controls.UCTextBoxEx();
            this.SuspendLayout();
            // 
            // darkLabel_Property1Name
            // 
            this.darkLabel_Property1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkLabel_Property1Name.AutoSize = true;
            this.darkLabel_Property1Name.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.darkLabel_Property1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel_Property1Name.Location = new System.Drawing.Point(34, 47);
            this.darkLabel_Property1Name.Name = "darkLabel_Property1Name";
            this.darkLabel_Property1Name.Size = new System.Drawing.Size(76, 19);
            this.darkLabel_Property1Name.TabIndex = 2;
            this.darkLabel_Property1Name.Text = "darkLabel1";
            // 
            // ucTextBoxEx_PropertyValue
            // 
            this.ucTextBoxEx_PropertyValue.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_PropertyValue.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_PropertyValue.ConerRadius = 20;
            this.ucTextBoxEx_PropertyValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_PropertyValue.DecLength = 0;
            this.ucTextBoxEx_PropertyValue.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_PropertyValue.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_PropertyValue.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_PropertyValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_PropertyValue.InputText = "1";
            this.ucTextBoxEx_PropertyValue.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx_PropertyValue.IsFocusColor = true;
            this.ucTextBoxEx_PropertyValue.IsRadius = true;
            this.ucTextBoxEx_PropertyValue.IsShowClearBtn = false;
            this.ucTextBoxEx_PropertyValue.IsShowKeyboard = false;
            this.ucTextBoxEx_PropertyValue.IsShowRect = true;
            this.ucTextBoxEx_PropertyValue.IsShowSearchBtn = false;
            this.ucTextBoxEx_PropertyValue.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_PropertyValue.Location = new System.Drawing.Point(187, 43);
            this.ucTextBoxEx_PropertyValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_PropertyValue.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_PropertyValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_PropertyValue.Name = "ucTextBoxEx_PropertyValue";
            this.ucTextBoxEx_PropertyValue.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_PropertyValue.PasswordChar = '\0';
            this.ucTextBoxEx_PropertyValue.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_PropertyValue.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_PropertyValue.PromptText = "0";
            this.ucTextBoxEx_PropertyValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_PropertyValue.RectWidth = 1;
            this.ucTextBoxEx_PropertyValue.RegexPattern = "";
            this.ucTextBoxEx_PropertyValue.Size = new System.Drawing.Size(92, 27);
            this.ucTextBoxEx_PropertyValue.TabIndex = 3;
            // 
            // Dialog_Visu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 143);
            this.ControlBox = false;
            this.Controls.Add(this.ucTextBoxEx_PropertyValue);
            this.Controls.Add(this.darkLabel_Property1Name);
            this.DialogButtons = DarkUI.Forms.DarkDialogButton.OkCancel;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dialog_Visu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dialog_Visu_Load);
            this.Controls.SetChildIndex(this.darkLabel_Property1Name, 0);
            this.Controls.SetChildIndex(this.ucTextBoxEx_PropertyValue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel darkLabel_Property1Name;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_PropertyValue;
    }
}
