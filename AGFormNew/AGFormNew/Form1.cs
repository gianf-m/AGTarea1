using AGFormNew.Inputs;

namespace AGFormNew
{
    public partial class Form1 : Form
    {
        private double mPrecision = 0;
        private double mLimIzq = 0;
        private double mLimDer = 0;
        private string mCromosomaTotal = string.Empty;
        private double mNroBitsTotales = 0;
        private List<GridViewItem> mItems = new List<GridViewItem>();
        public Form1()
        {
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = mItems;

            GV_Variables.DataSource = bindingSource;
        }

        private void btn_AgregarVariable_Click(object sender, EventArgs e)
        {
            LimpiarVariablesGlobales();
            if (string.IsNullOrEmpty(txt_Precision.Text) || string.IsNullOrEmpty(txt_LimIzq.Text) || string.IsNullOrEmpty(txt_LimDer.Text))
            {
                return;
            }

            mPrecision = Convert.ToDouble(txt_Precision.Text);
            mLimIzq = Convert.ToDouble(txt_LimIzq.Text);
            mLimDer = Convert.ToDouble(txt_LimDer.Text);
            if (GV_Variables.Rows.Count >= 3)
            {
                return;
            }
            var vGridItem = new GridViewItem { Precision = mPrecision, LimiteDerecho = mLimDer, LimiteIzquierdo = mLimIzq };
            mItems.Add(vGridItem);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = mItems;

            GV_Variables.DataSource = bindingSource;
            LimpiarCombosDeTexto();

            mNroBitsTotales += vGridItem.NroBits;
            mCromosomaTotal += vGridItem.Substring;
            CalcularTotales();
        }

        private void textBoxDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // 1. Permitir números y Backspace
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            // 2. Permitir el separador decimal (solo uno)
            if (e.KeyChar.ToString() == separator)
            {
                if (textBox.Text.Contains(separator) || textBox.SelectionStart == 0)
                {
                    e.Handled = true; // Bloquea si ya tiene uno o si intenta ponerlo al inicio
                }
                return;
            }

            // 3. Permitir el signo negativo (solo al principio)
            if (e.KeyChar == '-')
            {
                if (textBox.Text.Contains("-") || textBox.SelectionStart != 0)
                {
                    e.Handled = true; // Bloquea si ya existe o si no está en la primera posición
                }
                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }

        private void txt_Precision_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (e.KeyChar >= '1' && e.KeyChar <= '6')
            {
                if (textBox.Text.Length >= 1 && textBox.SelectionLength == 0)
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LimpiarVariablesGlobales()
        {
            mPrecision = 0;
            mLimIzq = 0;
            mLimDer = 0;
        }
        private void LimpiarVariablesGlobalesResultados()
        {
            mNroBitsTotales = 0;
            mCromosomaTotal = string.Empty;
        }

        private void LimpiarCombosDeTexto()
        {
            txt_Precision.Text = string.Empty;
            txt_LimIzq.Text = string.Empty;
            txt_LimDer.Text = string.Empty;
        }
        private void LimpiarCombosDeTextoResultados()
        {
            txt_NroBitsTotales.Text = string.Empty;
            txt_CromosomaTotal.Text = string.Empty;
        }


        private void CalcularTotales()
        {
            txt_NroBitsTotales.Text = mNroBitsTotales.ToString();
            txt_CromosomaTotal.Text = mCromosomaTotal;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCombosDeTexto();
            LimpiarVariablesGlobales();
            LimpiarVariablesGlobalesResultados();
            LimpiarCombosDeTextoResultados();
            GV_Variables.Rows.Clear();
        }
    }
}
