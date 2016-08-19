using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * ==================================================================================================
 * App Name: Character Creation
 * Author's Name: Jonathan Hao
 * Student#: 300869273
 * Creation Date: August 19, 2016
 * Description: This program creates a fantasy character with traits.
 * Version: 0.0.4 - Debugging.
 * ==================================================================================================
 */


namespace COMP123_S2016_FinalExam
{
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}