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
            toolStripButtonCancel.Enabled = true;
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
            labelCode.Enabled = true;
            labelName.Enabled = true;
            labelPrice.Enabled = true;
            labelQuantity.Enabled = true;
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

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();  
            about.ShowDialog();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonLast_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
