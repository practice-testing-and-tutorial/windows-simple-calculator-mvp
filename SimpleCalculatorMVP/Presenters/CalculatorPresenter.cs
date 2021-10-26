using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCalculatorMVP.Models;
using SimpleCalculatorMVP.Views;

namespace SimpleCalculatorMVP.Presenters
{
	class CalculatorPresenter
	{
		Calculator _calculator = new Calculator();
		ICalculator _calculatorView;

		public CalculatorPresenter(ICalculator view)
		{
			_calculatorView = view;
		}

		private void ConnectModelAndView()
		{
			_calculator.NumberOne = Convert.ToDouble(_calculatorView.TxtNumberOne);
			_calculator.NumberTwo = Convert.ToDouble(_calculatorView.TxtNumberTwo);
		}

		public void CalcSum()
		{
			ConnectModelAndView();
			_calculatorView.TxtResult = _calculator.CalculateSumation().ToString();
		}

		public void CalcSub()
		{
			ConnectModelAndView();
			_calculatorView.TxtResult = _calculator.CalculateSubtraction().ToString();
		}

		public void CalcMult()
		{
			ConnectModelAndView();
			_calculatorView.TxtResult = _calculator.CalculateMultiplication().ToString();
		}

		public void CalcDiv()
		{
			ConnectModelAndView();

			if (_calculator.NumberTwo == 0)
			{
				MessageBox.Show("Cannot divide by zero");
				return;
			}

			_calculatorView.TxtResult = _calculator.CalculateDivition().ToString();
		}
	}
}
