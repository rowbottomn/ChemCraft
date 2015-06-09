using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class SiO2 : Compounds
    {

        public SiO2()
        {
            elementnum = 3;
            state = 0;
            damage = 4;
            name = "Quartz";
            formula = "SiO₂";
            a = type.Undetermined;
            elements = new int[3] { 14, 8, 8 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary>
        override public void ability()
        {

        }
        
    }
}