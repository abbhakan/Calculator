using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Santander.MvcCalc.Extensions
{
    public enum EnumMath
    {
        [Display(Name= "Add")]
        Add,
        [Display(Name = "Sub")]
        Sub,
        [Display(Name = "Mult")]
        Mult,
        [Display(Name = "Div")]
        Div,
        [Display(Name = "Mod")]
        Mod

    }
}