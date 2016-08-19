using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * ==================================================================================================
 * App Name: Character Creation
 * Author's Name: Jonathan Hao
 * Student#: 300869273
 * Creation Date: August 19, 2016
 * Description: This program creates a fantasy character with traits.
 * Version: 0.0.3 - Added functionality to FinalForm.
 * ==================================================================================================
 */
namespace COMP123_S2016_FinalExam
{

    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        /**<summary>
         * This method randomly selects names from FirstNameListBox and LastNameListBox
         * and sets the corresponding text boxes to these values.
         * <summary>
         * 
         * @method GenerateNames
         * @private
         * @returns {void}
         */
        private void GenerateNames()
            {
            Random random = new Random();
            //uses random number between 0 and list size as an index to select name
            FirstNameTextBox.Text = (Convert.ToString(FirstNameListBox.Items[random.Next(0, ((FirstNameListBox.Items.Count)))]));
            LastNameTextBox.Text = (Convert.ToString(LastNameListBox.Items[random.Next(0, ((LastNameListBox.Items.Count)))]));          
            }

        /** <summary>
        * This method generates random names when GenerateNameForm is loaded.
        * </summary>
        *
        * @method GenerateNameForm_Load
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void GenerateNameForm_Load(object sender, EventArgs e)
            {
            GenerateNames();

            }

        /** <summary>
        * This method generates random names when GenerateButton is clicked.
        * </summary>
        *
        * @method GenerateButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void GenerateButton_Click(object sender, EventArgs e)
            {
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
            }

        /** <summary>
        * This method hides the current form and shows the next form.
        * </summary>
        *
        * @method NextButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void NextButton_Click(object sender, EventArgs e)
            {
            this.Hide();
            Program.abilityGeneratorForm.Show();
            }
    }
}
