using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.MVVM.Models
{
	[AddINotifyPropertyChangedInterface]
	public class BMI
	{
		private float result;

		public float Height { get; set; }
		public float Weight { get; set; }
		public float Result
		{
			get
			{
				return ((Weight / Height) / Height) * 10000;
			}
		}
		public string ResultText
		{
			get
			{
				string template = "BMI: #";
				if (Result <= 16)
				{
					return template.Replace("#", "Severe Thinness");
				}
				else if (Result > 16 && Result <= 17)
				{
					return template.Replace("#", "Moderate Thinness");
				}
				else if (Result > 17 && Result <= 18.5)
				{
					return template.Replace("#", "Mild Thinness");
				}
				else if (Result > 18.5 && Result <= 25)
				{
					return template.Replace("#", "Normal");
				}
				else if (Result > 25 && Result <= 30)
				{
					return template.Replace("#", "Overweight");
				}
				else if (Result > 30 && Result <= 35)
				{
					return template.Replace("#", "Obese Class I");
				}
				else if (Result > 35 && Result <= 40)
				{
					return template.Replace("#", "Obese Class II");
				}
				else
				{
					return template.Replace("#", "Obese Class III");
				}

			}
		}
	}
}
