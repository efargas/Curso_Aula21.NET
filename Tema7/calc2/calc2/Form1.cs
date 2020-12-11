using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double resultado = 0;
        String operacion = "";
        bool operacionRealizada = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "0";
            lbl_Operacion.Text = "";
            resultado = 0;
            txt_Resultado.Focus();
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "0";
            txt_Resultado.Focus();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) //Teclas
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                case Keys.D1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    btn9.PerformClick();
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    btn0.PerformClick();
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
                    operacion = "+";
                    btn_Suma.PerformClick();
                    break;
                case Keys.Subtract:
                    operacion = "-";
                    btn_Resta.PerformClick();
                    break;
                case Keys.Multiply:
                    operacion = "*";
                    btn_Mul.PerformClick();
                    break;
                case Keys.Divide:
                    operacion = "/";
                    btn_Div.PerformClick();
                    break;

            }
            txt_Resultado.Focus();
            
        }
        #region Botones Numéricos
        private void btn1_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "1";
            txt_Resultado.Focus();
        }

        private void btn2_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "2";
            txt_Resultado.Focus();
        }

        private void btn3_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "3";
            txt_Resultado.Focus();
        }

        private void btn4_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "4";
            txt_Resultado.Focus();
        }
       
        private void btn5_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "5";
            txt_Resultado.Focus();
        }

        private void btn6_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "6";
            txt_Resultado.Focus();
        }
        
        private void btn7_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "7";
            txt_Resultado.Focus();
        }
        
        private void btn8_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "8";
            txt_Resultado.Focus();
        }
      
        private void btn9_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "9";
            txt_Resultado.Focus();
        }
       
        private void btn0_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            txt_Resultado.Text += "0";
            txt_Resultado.Focus();
        }
       
        private void btnComa_click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text == "0") || (operacionRealizada))
                txt_Resultado.Clear();

            operacionRealizada = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!txt_Resultado.Text.Contains(","))
                    txt_Resultado.Text = txt_Resultado.Text + button.Text;

            }
            else
                txt_Resultado.Text = txt_Resultado.Text + button.Text;
        }

        #endregion
        #region Botones Operaciones
        private void btn_Suma_Click(object sender, EventArgs e)
        {
            if (resultado != 0)
            {
                btn_Igual.PerformClick();
                operacionRealizada = true;
            }
            else
            {
                operacion = "+";
                resultado = Double.Parse(txt_Resultado.Text);
                lbl_Operacion.Text = resultado + " " + operacion;
                operacionRealizada = true;
            }
            txt_Resultado.Focus();
            
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            if (resultado != 0)
            {
                btn_Igual.PerformClick();
                operacionRealizada = true;
            }
            else
            {
                operacion = "-";
                resultado = Double.Parse(txt_Resultado.Text);
                lbl_Operacion.Text = resultado + " " + operacion;
                operacionRealizada = true;
            }
            txt_Resultado.Focus();
            
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            if (resultado != 0)
            {
                btn_Igual.PerformClick();
                operacionRealizada = true;
            }
            else
            {
                operacion = "*";
                resultado = Double.Parse(txt_Resultado.Text);
                lbl_Operacion.Text = resultado + " " + operacion;
                operacionRealizada = true;
            }
            txt_Resultado.Focus();
            
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            if (resultado != 0)
            {
                btn_Igual.PerformClick();
                operacionRealizada = true;
            }
            else
            {
                operacion = "/";
                resultado = Double.Parse(txt_Resultado.Text);
                lbl_Operacion.Text = resultado + " " + operacion;
                operacionRealizada = true;
            }
            txt_Resultado.Focus();
            
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    txt_Resultado.Text = (resultado + Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "-":
                    txt_Resultado.Text = (resultado - Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "*":
                    txt_Resultado.Text = (resultado * Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "/":
                    txt_Resultado.Text = (resultado / Double.Parse(txt_Resultado.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultado = 0;
            lbl_Operacion.Text = "";
            txt_Resultado.Focus();
            
        }
        #endregion

    }
}
