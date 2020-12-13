using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double resultado = 0;
        string operacion = "";
        int b = 10;
        bool operacionRealizada = false;
        bool shift = false;
        public Form1()
        {
            InitializeComponent();
        }
     
        private void btn_ClearEmpty_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "0";
            txt_Resultado.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "0";
            lbl_Operacion.Text = "";
            resultado = 0;
            operacion = "";
            txt_Resultado.Focus();
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text.Length > 0)
            {
                txt_Resultado.Text = txt_Resultado.Text.Remove(txt_Resultado.Text.Length - 1, 1);
            }
            if (txt_Resultado.Text == "") { txt_Resultado.Text = "0"; };
            txt_Resultado.Focus();
        }

        private void btn_Pi_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = Math.PI.ToString();
            txt_Resultado.Focus();
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txt_Resultado.Text);
            ilog = Math.Log10(ilog);
            lbl_Operacion.Text = "Log(" + txt_Resultado.Text + ") = ";
            txt_Resultado.Text = Convert.ToString(ilog);
            txt_Resultado.Focus();
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(txt_Resultado.Text);
            sqrt = Math.Sqrt(sqrt);
            lbl_Operacion.Text = "√" + Double.Parse(txt_Resultado.Text) + " = ";
            txt_Resultado.Text = Convert.ToString(sqrt);
            txt_Resultado.Focus();
        }

        private void btn_Pow2_Click(object sender, EventArgs e)
        {
            double pow2 = Double.Parse(txt_Resultado.Text);
            pow2 = Math.Pow(pow2, 2);
            lbl_Operacion.Text = Double.Parse(txt_Resultado.Text) + "^2 =";
            txt_Resultado.Text = Convert.ToString(pow2);
            txt_Resultado.Focus();
        }

        private void btn_Pow3_Click(object sender, EventArgs e)
        {
            double pow3 = Double.Parse(txt_Resultado.Text);
            pow3 = Math.Pow(pow3, 3);
            lbl_Operacion.Text = Double.Parse(txt_Resultado.Text) + "^3 =";
            txt_Resultado.Text = Convert.ToString(pow3);
            txt_Resultado.Focus();
        }

        private void btn_Reciproc_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txt_Resultado.Text));
            lbl_Operacion.Text = "reciproc(" + Double.Parse(txt_Resultado.Text) + ") =";
            txt_Resultado.Text = Convert.ToString(a);
        }

        private void btn_Ln_Click(object sender, EventArgs e)
        {
            double iln = Double.Parse(txt_Resultado.Text);
            iln = Math.Log(iln);
            lbl_Operacion.Text = "Ln(" + txt_Resultado.Text + ") = ";
            txt_Resultado.Text = Convert.ToString(iln);
            txt_Resultado.Focus();
        }

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            double percent;
            percent = Convert.ToDouble(txt_Resultado.Text) / Convert.ToDouble(100);
            txt_Resultado.Text = Convert.ToString(percent);
            lbl_Operacion.Text = "";
            txt_Resultado.Focus();
        }

        private void btn_Sign_Click(object sender, EventArgs e)
        {
            double num;
            num = double.Parse(txt_Resultado.Text) * -1;
            txt_Resultado.Text = Convert.ToString(num);
            txt_Resultado.Focus();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Text = "";

            operacionRealizada = false;

            if (btn.Text == ",")
            {
                if (!txt_Resultado.Text.Contains(","))
                    txt_Resultado.Text = txt_Resultado.Text + btn.Text;
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + btn.Text;
            }
            txt_Resultado.Focus();
        }

        #region Interfaz
        private void Form1_Load(object sender, EventArgs e)
        {
            standardTSMI.Checked = true;
            scientificTSMI.Checked = false;
            if (standardTSMI.Checked == true)
            {
                this.Width = 270;
                tSSlbl_Estado.Text = "Calculadora Estándar";
                txt_Resultado.Width = 230;
                txt_Resultado.Height = 70;
                txt_Resultado.MaxLength = 9;
            }
            else if (scientificTSMI.Checked == true)
            {
                this.Width = 530;
                tSSlbl_Estado.Text = "Calculadora Científica";
                txt_Resultado.Width = 485;
                txt_Resultado.Height = 70;
                txt_Resultado.MaxLength = 20;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult res = MessageBox.Show("¿Deseas salir de la aplicación?", "Salir",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Deseas salir de la aplicación?", "Salir",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void standardTSMI_Click(object sender, EventArgs e)
        {
            standardTSMI.Checked = true;
            scientificTSMI.Checked = false;
            tSSlbl_Estado.Text = "Calculadora Básica";
            txt_Resultado.Width = 230;
            txt_Resultado.Height = 70;
            txt_Resultado.MaxLength = 9;
            this.Width = 270;
        }

        private void scientificTSMI_Click(object sender, EventArgs e)
        {
            standardTSMI.Checked = false;
            scientificTSMI.Checked = true;
            tSSlbl_Estado.Text = "Calculadora Científica";
            txt_Resultado.Width = 485;
            txt_Resultado.Height = 70;
            txt_Resultado.MaxLength = 20;
            this.Width = 530;
        }

        private void btn_Shift_click(object sender, EventArgs e)
        {
            if (shift == false) { shift = true; } else { shift = false; }
            if (shift == true)
            {
                btn_Shift.BackColor = Color.LightSalmon;
                btn_Tan.Text = "Atan";
                btn_Cos.Text = "Acos";
                btn_Sin.Text = "Asin";
            }
            else
            {
                btn_Shift.BackColor = Color.LightGreen;
                btn_Tan.Text = "Tan";
                btn_Cos.Text = "Cos";
                btn_Sin.Text = "Sin";
            }
            txt_Resultado.Focus();

        }

        private void txt_Resultado_KeyUp(object sender, KeyEventArgs e) //Teclas
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                case Keys.D1:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "1";
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "2";
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "3";
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "4";
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "5";
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "6";
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "7";
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "8";
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "9";
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    if ((txt_Resultado.Text == "0") || (operacionRealizada))
                        txt_Resultado.Clear();

                    operacionRealizada = false;
                    txt_Resultado.Text += "0";
                    break;
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                case Keys.Decimal:
                    btn_Coma.PerformClick();
                    break;
                case Keys.Enter:
                    btn_Igual.PerformClick();
                    break;
                case Keys.Add:
                    btn_Suma.PerformClick();
                    break;
                case Keys.Subtract:
                    btn_Resta.PerformClick();
                    break;
                case Keys.Multiply:
                    btn_Mul.PerformClick();
                    break;
                case Keys.Divide:
                    btn_Div.PerformClick();
                    break;
                case Keys.Delete:
                case Keys.Back:
                    btn_Backspace.PerformClick();
                    break;
                case Keys.Capital:
                    btn_Shift.PerformClick();
                    break;
            }
            txt_Resultado.Focus();

        }

        #endregion

        #region Operaciones
        private void arithmetic_OPS_Click(object sender, EventArgs e)
        {
            Button btOp = (Button)sender;
            if (resultado != 0)
            {
                btn_Igual.PerformClick();
                operacionRealizada = true;
                operacion = btOp.Text;
                lbl_Operacion.Text = resultado + " " + operacion;
            }
            else
            {
                operacion = btOp.Text;
                resultado = Double.Parse(txt_Resultado.Text);
                operacionRealizada = true;
                lbl_Operacion.Text = lbl_Operacion.Text + " " + resultado + " " + operacion;
            }
            txt_Resultado.Focus();
        }

        private void trigonometric_OPs_click(object sender, EventArgs e)
        {
            Button btOp = (Button)sender;
            operacion = btOp.Text;

            switch (operacion)
            {
                case "Tanh":
                    double tanh = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("tanh(" + txt_Resultado.Text + ") =");
                    tanh = Math.Tanh(tanh);
                    txt_Resultado.Text = Convert.ToString(tanh);
                    break;
                case "Tan":
                    double tan = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("tand(" + txt_Resultado.Text + ") =");
                    tan = Math.Tan(tan);
                    txt_Resultado.Text = Convert.ToString(tan);
                    break;
                case "Atan":
                    double atan = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("atan(" + txt_Resultado.Text + ") =");
                    atan = Math.Atan(atan);
                    txt_Resultado.Text = Convert.ToString(atan);
                    break;

                case "Cosh":
                    double cosh = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("cosh(" + txt_Resultado.Text + ") =");
                    cosh = Math.Cosh(cosh);
                    txt_Resultado.Text = Convert.ToString(cosh);
                    break;
                case "Cos":
                    double cos = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("cosd(" + txt_Resultado.Text + ") =");
                    cos = Math.Cos(cos);
                    txt_Resultado.Text = Convert.ToString(cos);
                    break;
                case "Acos":
                    double acos = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("acos(" + txt_Resultado.Text + ") =");
                    acos = Math.Acos(acos);
                    txt_Resultado.Text = Convert.ToString(acos);
                    break;

                case "Sinh":
                    double sinh = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("sinh(" + txt_Resultado.Text + ") =");
                    sinh = Math.Sinh(sinh);
                    txt_Resultado.Text = Convert.ToString(sinh);
                    break;
                case "Sin":
                    double sin = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("sind(" + txt_Resultado.Text + ") =");
                    sin = Math.Sin(sin);
                    txt_Resultado.Text = Convert.ToString(sin);
                    break;
                case "Asin":
                    double asin = Double.Parse(txt_Resultado.Text);
                    lbl_Operacion.Text = Convert.ToString("asin(" + txt_Resultado.Text + ") =");
                    asin = Math.Asin(asin);
                    txt_Resultado.Text = Convert.ToString(asin);
                    break;
            }
            operacion = "";
            operacionRealizada = true;
            txt_Resultado.Focus();
        }

        private void binary_OPs_Click(object sender, EventArgs e)
        {
            Button btOp = (Button)sender;
            operacion = btOp.Text;
            // A esto le queda faena....
            switch (operacion)
            {
                case "HEX":
                    int hex = int.Parse(txt_Resultado.Text);
                    txt_Resultado.Text = Convert.ToString(hex, 16);
                    b = 16;
                    break;
                case "BIN":
                    int bin = int.Parse(txt_Resultado.Text);
                    txt_Resultado.Text = Convert.ToString(bin, 2);
                    b = 2;
                    break;
                case "OCT":
                    int oct = int.Parse(txt_Resultado.Text);
                    txt_Resultado.Text = Convert.ToString(oct, 8);
                    b = 8;
                    break;
                case "DEC":
                    int dec = int.Parse(txt_Resultado.Text);
                    txt_Resultado.Text = Convert.ToString(dec,10);
                    b = 10;
                    break;
            }
            operacion = "";
            operacionRealizada = true;
            txt_Resultado.Focus();

        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    lbl_Operacion.Text = lbl_Operacion.Text + " " + txt_Resultado.Text + " = ";
                    txt_Resultado.Text = (resultado + Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "-":
                    lbl_Operacion.Text = lbl_Operacion.Text + " " + txt_Resultado.Text + " = ";
                    txt_Resultado.Text = (resultado - Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "X":
                    lbl_Operacion.Text = lbl_Operacion.Text + " " + txt_Resultado.Text + " = ";
                    txt_Resultado.Text = (resultado * Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "/":
                    lbl_Operacion.Text = lbl_Operacion.Text + " " + txt_Resultado.Text + " = ";
                    txt_Resultado.Text = (resultado / Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "Mod":
                    lbl_Operacion.Text = lbl_Operacion.Text + "(" + txt_Resultado.Text + ") = ";
                    txt_Resultado.Text = (resultado % Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "Exp":
                    lbl_Operacion.Text = lbl_Operacion.Text + "(" + txt_Resultado.Text + ") = ";
                    double i = Double.Parse(txt_Resultado.Text);
                    double q = resultado;
                    txt_Resultado.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                default:
                    break;
            }
            lbl_Operacion.Text = lbl_Operacion.Text + txt_Resultado.Text;
            resultado = Double.Parse(txt_Resultado.Text);
            operacion = "";
            txt_Resultado.Focus();
        }
        #endregion

    }
}