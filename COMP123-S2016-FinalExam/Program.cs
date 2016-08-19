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
 * Version: 0.0.3 - Added functionality to FinalForm.
 * ==================================================================================================
 */

namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character;
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        public static AbilityGeneratorForm abilityGeneratorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            character = new Character();
            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            abilityGeneratorForm = new AbilityGeneratorForm();

            Application.Run(splashForm);
        }
    }
}
