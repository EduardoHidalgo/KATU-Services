using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Estandar : UserControl
    {
        static int CheckboxTotal;
        static CheckBox[] ArrayCheckbox;
        static TextBox[] ArrayTextbox;
        static int[] CheckboxInt;
        static bool ClearTextboxs;
        static bool Verifier1, Verifier2, Verifier3;
        static bool temp1, temp2, temp3, temp4, temp5;
        static int INTtemp1, INTtemp2, INTtemp3, INTtemp4, INTtemp5;
        static int Percent;
        static int count = 0;

        //variables para los botones de páginas
        static int Pagina = 0;

        public Estandar()
        {
            InitializeComponent();
            CheckboxTotal = 0;
            ArrayCheckbox = new CheckBox[11];
            CheckboxInt = new int[3];
            ArrayCheckbox[0] = checkBox4;
            ArrayCheckbox[1] = checkBox5;
            ArrayCheckbox[2] = checkBox6;
            ArrayCheckbox[3] = checkBox9;
            ArrayCheckbox[4] = checkBox10;
            ArrayCheckbox[5] = checkBox11;
            ArrayCheckbox[6] = checkBox12;
            ArrayCheckbox[7] = checkBox13;
            ArrayCheckbox[8] = checkBox15;
            ArrayCheckbox[9] = checkBox16;
            ArrayCheckbox[10] = checkBox17;
            ArrayTextbox = new TextBox[5];
            ArrayTextbox[0] = TextboxPRO_P;
            ArrayTextbox[1] = TextboxLIP_P;
            ArrayTextbox[2] = TextboxCHO_P;
            ArrayTextbox[3] = TextboxMin;
            ArrayTextbox[4] = TextboxMax;
            ClearTextboxs = true;
            temp1 = false;
            temp2 = false;
            temp3 = false;
            Verifier1 = false;
            Verifier2 = false;
        }

        private void Estandar_Load(object sender, EventArgs e)
        {

        }

        static void TextBoxMethod()
        {
            if (ClearTextboxs == true)
            {
                for (int i = 0; i < ArrayTextbox.Length; i++)
                {
                    ArrayTextbox[i].ForeColor = Color.Black;
                    ArrayTextbox[i].ResetText();
                }
                ClearTextboxs = false;
            }
        }
        static void CheckboxMethod()
        {
            if (CheckboxTotal >= 3)
            {
                for (int i = 0; i < ArrayCheckbox.Length; i++)
                {
                    if (ArrayCheckbox[i].Checked == false)
                    {
                        ArrayCheckbox[i].Enabled = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ArrayCheckbox.Length - 1; i++)
                {
                    if (ArrayCheckbox[i].Checked == false)
                    {
                        ArrayCheckbox[i].Enabled = true;
                    }
                }
            }
        }

        #region Checkbox de Grupos
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                CheckboxTotal++;
            }
            else
            {
                CheckboxTotal--;
            }
            CheckboxMethod();
        }
        #endregion

        #region Textbox Group
        private void TextboxPRO_P_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxMethod();
        }
        private void TextboxLIP_P_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxMethod();
        }
        private void TextboxCHO_P_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxMethod();
        }

        private void TextboxMax_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxMethod();
        }
        private void TextboxMin_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxMethod();
        }
        #endregion

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ArrayTextbox.Length; i++)
            {
                ArrayTextbox[i].ResetText();
            }
            Percent = 0;
        }

        private void ButtonEquivalencias_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ArrayTextbox.Length; i++)
            {
                ArrayTextbox[i].ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(ArrayTextbox[0].Text) == false)
            {
                temp1 = true;
                try
                {
                    INTtemp1 = Convert.ToInt32(ArrayTextbox[0].Text);
                }
                catch
                {
                    MessageBox.Show("Inserte un valor porcentual correcto de Proteínas.");
                }
            }
            else
            {
                temp1 = false;
            }
            if (string.IsNullOrWhiteSpace(ArrayTextbox[1].Text) == false)
            {
                temp2 = true;
                try
                {
                    INTtemp2 = Convert.ToInt32(ArrayTextbox[1].Text);
                }
                catch
                {
                    MessageBox.Show("Inserte un valor porcentual correcto de Lípidos.");
                }
            }
            else
            {
                temp2 = false;
            }
            if (string.IsNullOrWhiteSpace(ArrayTextbox[2].Text) == false)
            {
                temp3 = true;
                try
                {
                    INTtemp3 = Convert.ToInt32(ArrayTextbox[2].Text);
                }
                catch
                {
                    MessageBox.Show("Inserte un valor porcentual correcto de Carbohidratos.");
                }
            }
            else
            {
                temp3 = false;
            }
            if(temp1 == true && temp2 == true && temp3 == true)
            {
                Percent = INTtemp1 + INTtemp2 + INTtemp3;
                if (Percent == 100)
                {
                    Verifier1 = true;
                }
                else
                {
                    MessageBox.Show("Los porcentajes de Macronutrientes no equivalen a un 100%");
                }

            }
            else
            {
                MessageBox.Show("Rellene todos los campos correctamente.");
            }
            if (string.IsNullOrWhiteSpace(ArrayTextbox[3].Text) == false)
            {
                temp4 = true;
                try
                {
                    INTtemp4 = Convert.ToInt32(ArrayTextbox[3].Text);
                }
                catch
                {
                    MessageBox.Show("Inserte un valor numérico correcto de Calorías Mínimas.");
                }
            }
            else
            {
                temp4 = false;
            }
            if (string.IsNullOrWhiteSpace(ArrayTextbox[4].Text) == false)
            {
                temp5 = true;
                try
                {
                    INTtemp5 = Convert.ToInt32(ArrayTextbox[4].Text);
                }
                catch
                {
                    MessageBox.Show("Inserte un valor numérico correcto de Calorías Máximas.");
                }
            }
            else
            {
                temp5 = false;
            }
            if (temp4 == true && temp5 == true)
            {

                if (INTtemp4 >= 1200 && INTtemp5 <=2400)
                {
                    Verifier2 = true;
                }
                else
                {
                    MessageBox.Show("Los Máximos y Mínimos no son correctos.\nInserte valores entre 1200 y 2400.");
                }

            }
            else
            {
                MessageBox.Show("Rellene todos los campos correctamente.");
            }
            if (CheckboxTotal == 3)
            {
                Verifier3 = true;
                for (int i = 0; i < ArrayCheckbox.Length; i++)
                {
                    if (ArrayCheckbox[i].Checked == true)
                    {
                        CheckboxInt[count] = i;
                        count++;
                    }
                }
                count = 0;
            }
            else
            {
                MessageBox.Show("Selecciona 3 grupos.");
            }
            if (Verifier1 == true && Verifier2 == true && Verifier3 == true)
            {
                AlgoritmoBasico.SetMinimoKcal = INTtemp4;
                AlgoritmoBasico.SetMaximoKcal = INTtemp5;
                AlgoritmoBasico.SetPorcentajePRO = INTtemp1;
                AlgoritmoBasico.SetPorcentajeLIP = INTtemp2;
                AlgoritmoBasico.SetPorcentajeCHO = INTtemp3;
                AlgoritmoBasico.SetCalculos = 0;
                AlgoritmoBasico.SetRangoKcal = 35;
                AlgoritmoBasico.AlgoritmoEquivalencias(DatagridEquiv);
                LabelPáginaTotal.Text = Convert.ToString(AlgoritmoBasico.SetAciertos);
                LabelCalorías.Text = Convert.ToString(INTtemp4);
            }
            else
            {
                MessageBox.Show("Rellene todos los campos necesarios.");
            }
        }
    }
}