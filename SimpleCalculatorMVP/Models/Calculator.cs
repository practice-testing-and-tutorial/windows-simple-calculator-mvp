using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorMVP.Models
{
	public class Calculator
	{
		public double NumberOne { get; set; }
		public double NumberTwo { get; set; }

		public double CalculateSumation() => NumberOne + NumberTwo;
		public double CalculateSubtraction() => NumberOne - NumberTwo;
		public double CalculateMultiplication() => NumberOne * NumberTwo;
		public double CalculateDivition() => NumberOne / NumberTwo;
	}
}
