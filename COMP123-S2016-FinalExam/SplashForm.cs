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

    /** <summary>
    * This class defines a form for a splash screen.
    * </summary>
    * 
    * @class SplashForm
    * @extends Form
    */
    public partial class SplashForm : Form
        {

        /** <summary>
        * This is the default constructor.
        * </summary>
        *
        * @method SplashForm
        */
        public SplashForm()
            {
            InitializeComponent();
            }

        /** <summary>
        * This method closes the form after 3 seconds.
        * </summary>
        *
        * @method SplashFormTimer_Tick
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void SplashFormTimer_Tick(object sender, EventArgs e)
            {
            SplashFormTimer.Enabled = false;
            this.Hide();
            Program.generateNameForm.Show();
            }
        }
    }
