using PracticeOne.Clases;
using PracticeOne.Dialogs;

namespace PracticeOne
{
    public partial class Form1 : Form
    {
        List<CProducts> products = new List<CProducts>();
        private int lastCode = 0;
        public Form1()
        {
            //Disable all the options at start and initilize the component
            InitializeComponent();
            DisableInputs();
            DisableOptions();
            DisableButtons();
        }

        private void DisableOptions()
        {
            orderSave.Enabled = false;
            orderCancel.Enabled = false;
            toolStripButtonCancel.Enabled = false;
            toolStripButtonSave.Enabled = false;
        }

        private void EnableOptions()
        {
            orderSave.Enabled = true;
            orderCancel.Enabled = true;
            toolStripButtonNew.Enabled = true;
            toolStripButtonSave.Enabled = true;
            toolStripButtonCancel.Enabled = true;
            toolStripButtonSearch.Enabled = true;
            toolStripTextBoxSearch.Enabled = true;
        }

        private void DisableInputs()
        {
            textBoxCode.Enabled = false;
            textBoxName.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxQuantity.Enabled = false;
        }

        private void EnableInputs()
        {
            textBoxCode.Enabled = true;
            textBoxName.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxQuantity.Enabled = true;
        }

        private void EnableButtons()
        {
            buttonFirst.Enabled = true;
            buttonBack.Enabled = true;
            buttonNext.Enabled = true;
            buttonLast.Enabled = true;
        }

        private void DisableButtons()
        {
            buttonFirst.Enabled = false;
            buttonBack.Enabled = false;
            buttonNext.Enabled = false;
            buttonLast.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStringWellcome_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void orderNew_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = lastCode.ToString();
            textBoxName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;

            EnableInputs();
            EnableOptions();
            DisableButtons();
        }
        private void ClearInputs()
        {
            textBoxCode.Text = String.Empty;
            textBoxName.Text = String.Empty;
            textBoxPrice.Text = String.Empty;
            textBoxQuantity.Text = String.Empty;
        }

        private void orderSave_Click(object sender, EventArgs e)
        {
            // Verificar si los tres inputs tienen contenido
            if (!string.IsNullOrEmpty(textBoxName.Text) &&
                !string.IsNullOrEmpty(textBoxPrice.Text) &&
                !string.IsNullOrEmpty(textBoxQuantity.Text))
            {
                if (!int.TryParse(textBoxQuantity.Text, out _) || !int.TryParse(textBoxPrice.Text, out _))
                {
                    MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Crear un nuevo objeto CProducto
                    CProducts nuevoProducto = new CProducts(lastCode, textBoxName.Text, Convert.ToDecimal(textBoxPrice.Text), Convert.ToInt32(textBoxQuantity.Text));

                    // Agregar el producto a la lista
                    products.Add(nuevoProducto);
                    lastCode++;

                    // Mostrar un mensaje de confirmación
                    MessageBox.Show("Products save sucessfull.");

                    // Limpiar los campos
                    ClearInputs();
                    DisableOptions();
                    EnableButtons();
                }

            }
            else
            {
                // Deshabilitar el botón guardar si los inputs están vacíos
                DisableButtons();
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void orderCancel_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                EnableButtons();
                EnableInputs();
                DisableOptions();
            }
            else
            {
                DisableOptions();
                DisableInputs();
                DisableButtons();
            }
            ClearInputs();
        }
        private int index = 0;

        private void orderTotal_Click(object sender, EventArgs e)
        {
            Decimal total = 0;
            foreach (CProducts producto in products)
            {
                total += producto.Quantity * producto.Price;
            }
            MessageBox.Show("Total is: " + total);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            orderNew_Click((object)sender, e);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            orderSave_Click((object)sender, e);
        }
        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            orderCancel_Click((object)sender, e);
        }

        private void toolStripTextBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(toolStripTextBoxSearch.Text))
            {
                CProducts result = products.Find(x => x.Name.ToLower().Equals(toolStripTextBoxSearch.Text.ToLower()));
                if (result != null)
                {
                    textBoxCode.Text = result.Code.ToString();
                    textBoxName.Text = result.Name;
                    textBoxPrice.Text = result.Price.ToString();
                    textBoxQuantity.Text = result.Quantity.ToString();

                    return;
                }

                MessageBox.Show("Nothing there...");
            }
            else
            {
                MessageBox.Show("Isert the name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            if (products.Count > 0)
            {
                CProducts actualProducts = products.ElementAtOrDefault(index);
                index++;
                if (actualProducts != null)
                {
                    // Asignar los valores del producto actual a los inputs
                    textBoxCode.Text = actualProducts.Code.ToString();
                    textBoxName.Text = actualProducts.Name;
                    textBoxPrice.Text = actualProducts.Price.ToString();
                    textBoxQuantity.Text = actualProducts.Quantity.ToString();

                    buttonFirst.Enabled = true;
                    buttonBack.Enabled = false;
                    buttonNext.Enabled = true;
                    buttonLast.Enabled = true;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                // Obtener el producto actual
                CProducts actualProducts = products.ElementAtOrDefault(index - 1);

                // Verificar si el producto actual no es nulo
                if (actualProducts != null)
                {
                    // Asignar los valores del producto actual a los inputs
                    textBoxCode.Text = actualProducts.Code.ToString();
                    textBoxName.Text = actualProducts.Name;
                    textBoxPrice.Text = actualProducts.Price.ToString();
                    textBoxQuantity.Text = actualProducts.Quantity.ToString();

                    // Decrementar el índice
                    index--;

                    // Verificar si hemos llegado al principio de la lista
                    if (index <= 0)
                    {
                        // Deshabilitar el botón anterior y primero
                        buttonBack.Enabled = false;
                        buttonFirst.Enabled = false;

                        // Habilitar el botón siguiente y ultimo
                        buttonNext.Enabled = true;
                        buttonLast.Enabled = true;
                    }
                    else
                    {
                        // Habilitar los botones siguiente y primero
                        buttonNext.Enabled = true;
                        buttonLast.Enabled = true;
                        buttonFirst.Enabled = true;
                    }
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                CProducts actualProducts = products.ElementAtOrDefault(index - 1);

                // Verificar si el producto actual no es nulo
                if (actualProducts != null)
                {
                    // Asignar los valores del producto actual a los inputs
                    textBoxCode.Text = actualProducts.Code.ToString();
                    textBoxName.Text = actualProducts.Name;
                    textBoxPrice.Text = actualProducts.Price.ToString();
                    textBoxQuantity.Text = actualProducts.Quantity.ToString();

                    // Decrementar el índice
                    index++;

                    // Verificar si hemos llegado al principio de la lista
                    if (index >= 0)
                    {
                        // Deshabilitar el botón anterior y primero
                        buttonBack.Enabled = false;
                        buttonFirst.Enabled = false;

                        // Habilitar el botón siguiente y ultimo
                        buttonNext.Enabled = true;
                        buttonLast.Enabled = true;
                    }
                    else
                    {
                        // Habilitar los botones siguiente y primero
                        buttonNext.Enabled = true;
                        buttonLast.Enabled = true;
                        buttonFirst.Enabled = true;
                    }
                }
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                index = products.Count;
                // Obtener el producto actual
                CProducts actualProducts = products.ElementAtOrDefault(index - 1);

                index--;

                // Verificar si el producto actual no es nulo
                if (actualProducts != null)
                {
                    // Asignar los valores del producto actual a los inputs
                    textBoxCode.Text = actualProducts.Code.ToString();
                    textBoxName.Text = actualProducts.Name;
                    textBoxPrice.Text = actualProducts.Price.ToString();
                    textBoxQuantity.Text = actualProducts.Quantity.ToString();

                    buttonLast.Enabled = true;
                    buttonBack.Enabled = true;
                    buttonNext.Enabled = false;
                    buttonFirst.Enabled = true;
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderShowToolBar_Click(object sender, EventArgs e)
        {
            if (orderShowToolBar.Checked)
            {
                toolStrip1.Visible = true;
            }
            else
            {
                toolStrip1.Visible = false;
            }
        }

        private void orderShowStatusBar_Click(object sender, EventArgs e)
        {
            if (orderShowStatusBar.Checked)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }

        private void orderShowAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
