﻿using System;
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
 * Version: 0.0.5 - Added extra functionality (can click name to select) to GenerateNameForm.
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
            //I think it would be better to set values in this event I pasted the code here as well
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;

            this.Hide();
            Program.abilityGeneratorForm.Show();
            }

        /** <summary>
        * This method changes the value of FirstNameTextBox when a first name is clicked.
        * </summary>
        *
        * @method FirstNameListBox_SelectedValueChanged
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void FirstNameListBox_SelectedValueChanged(object sender, EventArgs e)
            {
            FirstNameTextBox.Text = FirstNameListBox.SelectedItem.ToString();
            }

        /** <summary>
        * This method changes the value of LastNameTextBox when a last name is clicked.
        * </summary>
        *
        * @method LastNameListBox_SelectedValueChanged
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void LastNameListBox_SelectedValueChanged(object sender, EventArgs e)
            {
            LastNameTextBox.Text = LastNameListBox.SelectedItem.ToString();
            }
    }
}
