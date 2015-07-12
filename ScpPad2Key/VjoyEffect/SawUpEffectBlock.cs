﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScpPad2vJoy.VjoyEffect
{
    class SawUpEffectBlock : PeriodBaseEffectBlock
    {
        protected override float ComputePeriodicEffectMult(Double phaseTime)
        {
            //Effect starts at -Magnitude
            //And rises over the whole period
            //to + Magnitude
            Double riseRate = (Double)(2 * periodEffect.Magnitude) / (Double)periodEffect.Period;
            return (float)((phaseTime * riseRate) - (Double)periodEffect.Magnitude);
        }
    }
}
