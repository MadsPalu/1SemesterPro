﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterProAlpha
{
    public class MotorBåd : Båd
    {
        public string _motor { get; set; }
        public int _hestekræfter { get; set; }
        public double _liter { get; set; }

        public MotorBåd(string navn, string model, int byggeÅr, string mål, string motor, int hestekræfter, double liter) 
            : base(navn, "Motorbåd", model, byggeÅr, mål)
        {
            _motor = motor;
            _hestekræfter = hestekræfter;
            _liter = liter;
        }

        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Motor: {_motor}, Hestekræfter: {_hestekræfter}, Liter: {_liter}";
        }
    }
}
