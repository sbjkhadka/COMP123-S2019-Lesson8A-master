using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace COMP123_S2019_Lesson8A
{
    public partial class Lab08Form : Form
    {
        
        public string UserName { get; set; }
        public float UserAge { get; set; }
        public Lab08Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
            
        }

       
        private void ClearForm()
        {
            SubmitButton.Enabled = false;
            NameTextBox.Clear();
            AgeTextBox.Clear();
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {

            UserName = NameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text);
            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();

        }

        /// <summary>
        /// age textbox: text change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch 
            {
                SubmitButton.Enabled = false;
            } 
        }
        /// <summary>
        /// event handler for name textbox text change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2) ? true : false;
        }
    }
}
