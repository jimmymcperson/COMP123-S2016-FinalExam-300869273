using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ==================================================================================================
 * App Name: Character Creation
 * Author's Name: Jonathan Hao
 * Student#: 300869273
 * Creation Date: August 19, 2016
 * Description: This program creates a fantasy character with traits.
 * Version: 0.0.1 - Initial commit.
 * ==================================================================================================
 */

namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();
        public static SplashForm splashForm = new SplashForm();
        public static GenerateNameForm generateNameForm = new GenerateNameForm();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(splashForm);
        }
    }
}
