using BMICalculator.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.MVVM.ViewModels
{
	public class BMIViewModel
	{
		public BMI BMI { get; set; }
		public BMIViewModel() { 
			BMI = new BMI();
			BMI.Height = 100;
			BMI.Weight = 72;
		}
	}
}
