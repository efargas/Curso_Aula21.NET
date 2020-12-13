namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Mul = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn_Igual = new System.Windows.Forms.Button();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Coma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Operacion = new System.Windows.Forms.Label();
            this.main_MS = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSlbl_Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Backspace = new System.Windows.Forms.Button();
            this.btn_Sign = new System.Windows.Forms.Button();
            this.btn_ClearEmpty = new System.Windows.Forms.Button();
            this.btn_Sinh = new System.Windows.Forms.Button();
            this.btn_PI = new System.Windows.Forms.Button();
            this.btn_Sin = new System.Windows.Forms.Button();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.btn_Pow3 = new System.Windows.Forms.Button();
            this.btn_Pow2 = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_Cosh = new System.Windows.Forms.Button();
            this.btn_Cos = new System.Windows.Forms.Button();
            this.btn_Bin = new System.Windows.Forms.Button();
            this.btn_Reciproc = new System.Windows.Forms.Button();
            this.btn_Sqrt = new System.Windows.Forms.Button();
            this.btn_Tanh = new System.Windows.Forms.Button();
            this.btn_Tan = new System.Windows.Forms.Button();
            this.btn_Hex = new System.Windows.Forms.Button();
            this.btn_Ln = new System.Windows.Forms.Button();
            this.btn_Exp = new System.Windows.Forms.Button();
            this.btn_Mod = new System.Windows.Forms.Button();
            this.btn_Percent = new System.Windows.Forms.Button();
            this.btn_Oct = new System.Windows.Forms.Button();
            this.btn_Shift = new System.Windows.Forms.Button();
            this.tt_Shift = new System.Windows.Forms.ToolTip(this.components);
            this.main_MS.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(13, 219);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn8.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(73, 219);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(133, 219);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btn_Div
            // 
            this.btn_Div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Div.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Div.Location = new System.Drawing.Point(193, 220);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(50, 50);
            this.btn_Div.TabIndex = 16;
            this.btn_Div.Text = "/";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.arithmetic_OPS_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(133, 162);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(50, 50);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Mul
            // 
            this.btn_Mul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Mul.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Mul.Location = new System.Drawing.Point(193, 276);
            this.btn_Mul.Name = "btn_Mul";
            this.btn_Mul.Size = new System.Drawing.Size(50, 50);
            this.btn_Mul.TabIndex = 15;
            this.btn_Mul.Text = "X";
            this.btn_Mul.UseVisualStyleBackColor = true;
            this.btn_Mul.Click += new System.EventHandler(this.arithmetic_OPS_Click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(133, 276);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(73, 276);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(13, 276);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Resta.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Resta.Location = new System.Drawing.Point(193, 333);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(50, 50);
            this.btn_Resta.TabIndex = 14;
            this.btn_Resta.Text = "-";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.arithmetic_OPS_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(133, 333);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(73, 333);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(13, 333);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btn_Igual
            // 
            this.btn_Igual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Igual.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Igual.Location = new System.Drawing.Point(133, 390);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(50, 50);
            this.btn_Igual.TabIndex = 12;
            this.btn_Igual.Text = "=";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // btn_Suma
            // 
            this.btn_Suma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Suma.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Suma.Location = new System.Drawing.Point(193, 390);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(50, 50);
            this.btn_Suma.TabIndex = 13;
            this.btn_Suma.Text = "+";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.arithmetic_OPS_Click);
            // 
            // btn_Coma
            // 
            this.btn_Coma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Coma.Location = new System.Drawing.Point(73, 390);
            this.btn_Coma.Name = "btn_Coma";
            this.btn_Coma.Size = new System.Drawing.Size(50, 50);
            this.btn_Coma.TabIndex = 11;
            this.btn_Coma.Text = ",";
            this.btn_Coma.UseVisualStyleBackColor = true;
            this.btn_Coma.Click += new System.EventHandler(this.button_click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn0.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(13, 390);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_click);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Resultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txt_Resultado.Location = new System.Drawing.Point(13, 54);
            this.txt_Resultado.MaxLength = 9;
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(485, 70);
            this.txt_Resultado.TabIndex = 0;
            this.txt_Resultado.Text = "0";
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Resultado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Resultado_KeyUp);
            // 
            // lbl_Operacion
            // 
            this.lbl_Operacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Operacion.AutoSize = true;
            this.lbl_Operacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Operacion.Location = new System.Drawing.Point(12, 36);
            this.lbl_Operacion.Name = "lbl_Operacion";
            this.lbl_Operacion.Size = new System.Drawing.Size(0, 15);
            this.lbl_Operacion.TabIndex = 100;
            this.lbl_Operacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_MS
            // 
            this.main_MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tipoToolStripMenuItem});
            this.main_MS.Location = new System.Drawing.Point(0, 0);
            this.main_MS.Name = "main_MS";
            this.main_MS.Size = new System.Drawing.Size(514, 24);
            this.main_MS.TabIndex = 22;
            this.main_MS.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardTSMI,
            this.scientificTSMI});
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tipoToolStripMenuItem.Text = "&Tipo";
            // 
            // standardTSMI
            // 
            this.standardTSMI.Name = "standardTSMI";
            this.standardTSMI.Size = new System.Drawing.Size(124, 22);
            this.standardTSMI.Text = "&Estándar";
            this.standardTSMI.Click += new System.EventHandler(this.standardTSMI_Click);
            // 
            // scientificTSMI
            // 
            this.scientificTSMI.Name = "scientificTSMI";
            this.scientificTSMI.Size = new System.Drawing.Size(124, 22);
            this.scientificTSMI.Text = "&Científica";
            this.scientificTSMI.Click += new System.EventHandler(this.scientificTSMI_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSlbl_Estado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSlbl_Estado
            // 
            this.tSSlbl_Estado.Name = "tSSlbl_Estado";
            this.tSSlbl_Estado.Size = new System.Drawing.Size(118, 17);
            this.tSSlbl_Estado.Text = "toolStripStatusLabel1";
            // 
            // btn_Backspace
            // 
            this.btn_Backspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backspace.Location = new System.Drawing.Point(13, 162);
            this.btn_Backspace.Name = "btn_Backspace";
            this.btn_Backspace.Size = new System.Drawing.Size(50, 50);
            this.btn_Backspace.TabIndex = 20;
            this.btn_Backspace.Text = "⌫";
            this.btn_Backspace.UseVisualStyleBackColor = true;
            this.btn_Backspace.Click += new System.EventHandler(this.btn_Backspace_Click);
            // 
            // btn_Sign
            // 
            this.btn_Sign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign.Location = new System.Drawing.Point(193, 162);
            this.btn_Sign.Name = "btn_Sign";
            this.btn_Sign.Size = new System.Drawing.Size(50, 50);
            this.btn_Sign.TabIndex = 17;
            this.btn_Sign.Text = "±";
            this.btn_Sign.UseVisualStyleBackColor = true;
            this.btn_Sign.Click += new System.EventHandler(this.btn_Sign_Click);
            // 
            // btn_ClearEmpty
            // 
            this.btn_ClearEmpty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_ClearEmpty.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ClearEmpty.Location = new System.Drawing.Point(73, 162);
            this.btn_ClearEmpty.Name = "btn_ClearEmpty";
            this.btn_ClearEmpty.Size = new System.Drawing.Size(50, 50);
            this.btn_ClearEmpty.TabIndex = 19;
            this.btn_ClearEmpty.Text = "CE";
            this.btn_ClearEmpty.UseVisualStyleBackColor = true;
            this.btn_ClearEmpty.Click += new System.EventHandler(this.btn_ClearEmpty_Click);
            // 
            // btn_Sinh
            // 
            this.btn_Sinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Sinh.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Sinh.Location = new System.Drawing.Point(268, 219);
            this.btn_Sinh.Name = "btn_Sinh";
            this.btn_Sinh.Size = new System.Drawing.Size(50, 50);
            this.btn_Sinh.TabIndex = 24;
            this.btn_Sinh.Text = "Sinh";
            this.btn_Sinh.UseVisualStyleBackColor = true;
            this.btn_Sinh.Click += new System.EventHandler(this.trigonometric_OPs_click);
            // 
            // btn_PI
            // 
            this.btn_PI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_PI.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PI.Location = new System.Drawing.Point(268, 162);
            this.btn_PI.Name = "btn_PI";
            this.btn_PI.Size = new System.Drawing.Size(50, 50);
            this.btn_PI.TabIndex = 25;
            this.btn_PI.Text = "𝝅";
            this.btn_PI.UseVisualStyleBackColor = true;
            this.btn_PI.Click += new System.EventHandler(this.btn_Pi_Click);
            // 
            // btn_Sin
            // 
            this.btn_Sin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Sin.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Sin.Location = new System.Drawing.Point(328, 219);
            this.btn_Sin.Name = "btn_Sin";
            this.btn_Sin.Size = new System.Drawing.Size(50, 50);
            this.btn_Sin.TabIndex = 27;
            this.btn_Sin.Text = "Sin";
            this.btn_Sin.UseVisualStyleBackColor = true;
            this.btn_Sin.Click += new System.EventHandler(this.trigonometric_OPs_click);
            // 
            // btn_Dec
            // 
            this.btn_Dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Dec.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Dec.Location = new System.Drawing.Point(388, 219);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(50, 50);
            this.btn_Dec.TabIndex = 34;
            this.btn_Dec.Text = "DEC";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.binary_OPs_Click);
            // 
            // btn_Pow3
            // 
            this.btn_Pow3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Pow3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Pow3.Location = new System.Drawing.Point(448, 220);
            this.btn_Pow3.Name = "btn_Pow3";
            this.btn_Pow3.Size = new System.Drawing.Size(50, 50);
            this.btn_Pow3.TabIndex = 37;
            this.btn_Pow3.Text = "x^3";
            this.btn_Pow3.UseVisualStyleBackColor = true;
            this.btn_Pow3.Click += new System.EventHandler(this.btn_Pow3_Click);
            // 
            // btn_Pow2
            // 
            this.btn_Pow2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Pow2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Pow2.Location = new System.Drawing.Point(448, 162);
            this.btn_Pow2.Name = "btn_Pow2";
            this.btn_Pow2.Size = new System.Drawing.Size(50, 50);
            this.btn_Pow2.TabIndex = 36;
            this.btn_Pow2.Text = "x^2";
            this.btn_Pow2.UseVisualStyleBackColor = true;
            this.btn_Pow2.Click += new System.EventHandler(this.btn_Pow2_Click);
            // 
            // btn_Log
            // 
            this.btn_Log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Log.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Log.Location = new System.Drawing.Point(328, 162);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(50, 50);
            this.btn_Log.TabIndex = 26;
            this.btn_Log.Text = "Log";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_Cosh
            // 
            this.btn_Cosh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Cosh.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Cosh.Location = new System.Drawing.Point(268, 276);
            this.btn_Cosh.Name = "btn_Cosh";
            this.btn_Cosh.Size = new System.Drawing.Size(50, 50);
            this.btn_Cosh.TabIndex = 23;
            this.btn_Cosh.Text = "Cosh";
            this.btn_Cosh.UseVisualStyleBackColor = true;
            this.btn_Cosh.Click += new System.EventHandler(this.trigonometric_OPs_click);
            // 
            // btn_Cos
            // 
            this.btn_Cos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Cos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Cos.Location = new System.Drawing.Point(328, 276);
            this.btn_Cos.Name = "btn_Cos";
            this.btn_Cos.Size = new System.Drawing.Size(50, 50);
            this.btn_Cos.TabIndex = 28;
            this.btn_Cos.Text = "Cos";
            this.btn_Cos.UseVisualStyleBackColor = true;
            this.btn_Cos.Click += new System.EventHandler(this.trigonometric_OPs_click);
            // 
            // btn_Bin
            // 
            this.btn_Bin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Bin.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Bin.Location = new System.Drawing.Point(388, 276);
            this.btn_Bin.Name = "btn_Bin";
            this.btn_Bin.Size = new System.Drawing.Size(50, 50);
            this.btn_Bin.TabIndex = 33;
            this.btn_Bin.Text = "BIN";
            this.btn_Bin.UseVisualStyleBackColor = true;
            this.btn_Bin.Click += new System.EventHandler(this.binary_OPs_Click);
            // 
            // btn_Reciproc
            // 
            this.btn_Reciproc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Reciproc.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Reciproc.Location = new System.Drawing.Point(448, 276);
            this.btn_Reciproc.Name = "btn_Reciproc";
            this.btn_Reciproc.Size = new System.Drawing.Size(50, 50);
            this.btn_Reciproc.TabIndex = 38;
            this.btn_Reciproc.Text = "1/x";
            this.btn_Reciproc.UseVisualStyleBackColor = true;
            this.btn_Reciproc.Click += new System.EventHandler(this.btn_Reciproc_Click);
            // 
            // btn_Sqrt
            // 
            this.btn_Sqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Sqrt.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sqrt.Location = new System.Drawing.Point(388, 162);
            this.btn_Sqrt.Name = "btn_Sqrt";
            this.btn_Sqrt.Size = new System.Drawing.Size(50, 50);
            this.btn_Sqrt.TabIndex = 35;
            this.btn_Sqrt.Text = "√";
            this.btn_Sqrt.UseVisualStyleBackColor = true;
            this.btn_Sqrt.Click += new System.EventHandler(this.btn_Sqrt_Click);
            // 
            // btn_Tanh
            // 
            this.btn_Tanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Tanh.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Tanh.Location = new System.Drawing.Point(268, 333);
            this.btn_Tanh.Name = "btn_Tanh";
            this.btn_Tanh.Size = new System.Drawing.Size(50, 50);
            this.btn_Tanh.TabIndex = 22;
            this.btn_Tanh.Text = "Tanh";
            this.btn_Tanh.UseVisualStyleBackColor = true;
            this.btn_Tanh.Click += new System.EventHandler(this.trigonometric_OPs_click);
            // 
            // btn_Tan
            // 
            this.btn_Tan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Tan.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Tan.Location = new System.Drawing.Point(328, 333);
            this.btn_Tan.Name = "btn_Tan";
            this.btn_Tan.Size = new System.Drawing.Size(50, 50);
            this.btn_Tan.TabIndex = 29;
            this.btn_Tan.Text = "Tan";
            this.btn_Tan.UseVisualStyleBackColor = true;
            this.btn_Tan.Click += new System.EventHandler(this.trigonometric_OPs_click);
            // 
            // btn_Hex
            // 
            this.btn_Hex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Hex.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Hex.Location = new System.Drawing.Point(388, 333);
            this.btn_Hex.Name = "btn_Hex";
            this.btn_Hex.Size = new System.Drawing.Size(50, 50);
            this.btn_Hex.TabIndex = 32;
            this.btn_Hex.Text = "HEX";
            this.btn_Hex.UseVisualStyleBackColor = true;
            this.btn_Hex.Click += new System.EventHandler(this.binary_OPs_Click);
            // 
            // btn_Ln
            // 
            this.btn_Ln.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Ln.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Ln.Location = new System.Drawing.Point(448, 333);
            this.btn_Ln.Name = "btn_Ln";
            this.btn_Ln.Size = new System.Drawing.Size(50, 50);
            this.btn_Ln.TabIndex = 39;
            this.btn_Ln.TabStop = false;
            this.btn_Ln.Text = "Ln x";
            this.btn_Ln.UseVisualStyleBackColor = true;
            this.btn_Ln.Click += new System.EventHandler(this.btn_Ln_Click);
            // 
            // btn_Exp
            // 
            this.btn_Exp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Exp.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Exp.Location = new System.Drawing.Point(268, 390);
            this.btn_Exp.Name = "btn_Exp";
            this.btn_Exp.Size = new System.Drawing.Size(50, 50);
            this.btn_Exp.TabIndex = 21;
            this.btn_Exp.Text = "Exp";
            this.btn_Exp.UseVisualStyleBackColor = true;
            this.btn_Exp.Click += new System.EventHandler(this.arithmetic_OPS_Click);
            // 
            // btn_Mod
            // 
            this.btn_Mod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Mod.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Mod.Location = new System.Drawing.Point(328, 390);
            this.btn_Mod.Name = "btn_Mod";
            this.btn_Mod.Size = new System.Drawing.Size(50, 50);
            this.btn_Mod.TabIndex = 30;
            this.btn_Mod.Text = "Mod";
            this.btn_Mod.UseVisualStyleBackColor = true;
            this.btn_Mod.Click += new System.EventHandler(this.arithmetic_OPS_Click);
            // 
            // btn_Percent
            // 
            this.btn_Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Percent.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Percent.Location = new System.Drawing.Point(448, 390);
            this.btn_Percent.Name = "btn_Percent";
            this.btn_Percent.Size = new System.Drawing.Size(50, 50);
            this.btn_Percent.TabIndex = 40;
            this.btn_Percent.Text = "%";
            this.btn_Percent.UseVisualStyleBackColor = true;
            this.btn_Percent.Click += new System.EventHandler(this.btn_Percent_Click);
            // 
            // btn_Oct
            // 
            this.btn_Oct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Oct.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Oct.Location = new System.Drawing.Point(388, 390);
            this.btn_Oct.Name = "btn_Oct";
            this.btn_Oct.Size = new System.Drawing.Size(50, 50);
            this.btn_Oct.TabIndex = 31;
            this.btn_Oct.Text = "OCT";
            this.btn_Oct.UseVisualStyleBackColor = true;
            this.btn_Oct.Click += new System.EventHandler(this.binary_OPs_Click);
            // 
            // btn_Shift
            // 
            this.btn_Shift.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Shift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Shift.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Shift.Location = new System.Drawing.Point(268, 132);
            this.btn_Shift.Name = "btn_Shift";
            this.btn_Shift.Size = new System.Drawing.Size(110, 24);
            this.btn_Shift.TabIndex = 101;
            this.btn_Shift.Text = "SHIFT...";
            this.tt_Shift.SetToolTip(this.btn_Shift, "BLOQ MAYUS");
            this.btn_Shift.UseVisualStyleBackColor = false;
            this.btn_Shift.Click += new System.EventHandler(this.btn_Shift_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 469);
            this.Controls.Add(this.btn_Shift);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_Operacion);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.btn_Oct);
            this.Controls.Add(this.btn_Igual);
            this.Controls.Add(this.btn_Percent);
            this.Controls.Add(this.btn_Mod);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.btn_Exp);
            this.Controls.Add(this.btn_Coma);
            this.Controls.Add(this.btn_Ln);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn_Hex);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.btn_Tan);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn_Tanh);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn_Sqrt);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn_Reciproc);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Bin);
            this.Controls.Add(this.btn_Mul);
            this.Controls.Add(this.btn_Cos);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn_Cosh);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn_Pow2);
            this.Controls.Add(this.btn_ClearEmpty);
            this.Controls.Add(this.btn_Pow3);
            this.Controls.Add(this.btn_Sign);
            this.Controls.Add(this.btn_Dec);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Sin);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn_PI);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn_Sinh);
            this.Controls.Add(this.btn_Backspace);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.main_MS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.main_MS;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_MS.ResumeLayout(false);
            this.main_MS.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Mul;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Coma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Operacion;
        private System.Windows.Forms.MenuStrip main_MS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardTSMI;
        private System.Windows.Forms.ToolStripMenuItem scientificTSMI;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSlbl_Estado;
        private System.Windows.Forms.Button btn_Backspace;
        private System.Windows.Forms.Button btn_Sign;
        private System.Windows.Forms.Button btn_ClearEmpty;
        private System.Windows.Forms.Button btn_Sinh;
        private System.Windows.Forms.Button btn_PI;
        private System.Windows.Forms.Button btn_Sin;
        private System.Windows.Forms.Button btn_Dec;
        private System.Windows.Forms.Button btn_Pow3;
        private System.Windows.Forms.Button btn_Pow2;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.Button btn_Cosh;
        private System.Windows.Forms.Button btn_Cos;
        private System.Windows.Forms.Button btn_Bin;
        private System.Windows.Forms.Button btn_Reciproc;
        private System.Windows.Forms.Button btn_Sqrt;
        private System.Windows.Forms.Button btn_Tanh;
        private System.Windows.Forms.Button btn_Tan;
        private System.Windows.Forms.Button btn_Hex;
        private System.Windows.Forms.Button btn_Ln;
        private System.Windows.Forms.Button btn_Exp;
        private System.Windows.Forms.Button btn_Mod;
        private System.Windows.Forms.Button btn_Percent;
        private System.Windows.Forms.Button btn_Oct;
        private System.Windows.Forms.Button btn_Shift;
        private System.Windows.Forms.ToolTip tt_Shift;
    }
}