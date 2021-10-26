using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCalculatorMVP.Views;
using SimpleCalculatorMVP.Presenters;

namespace SimpleCalculatorMVP
{
	public partial class Form1 : Form, ICalculator
	{
		CalculatorPresenter _presenter;

		public Form1()
		{
			InitializeComponent();

			_presenter = new CalculatorPresenter(this);
		}

		public string TxtNumberOne { get => tbNumberOne.Text; set => tbNumberOne.Text = value; }
		public string TxtNumberTwo { get => tbNumberTwo.Text; set => tbNumberTwo.Text = value; }
		public string TxtResult { get => tbResult.Text; set => tbResult.Text = value; }

		private void btnSumation_Click(object sender, EventArgs e)
		{
			_presenter.CalcSum();
		}

		private void btnSubstraction_Click(object sender, EventArgs e)
		{
			_presenter.CalcSub();
		}

		private void btnMultiplication_Click(object sender, EventArgs e)
		{
			_presenter.CalcMult();
		}

		private void btnDivition_Click(object sender, EventArgs e)
		{
			_presenter.CalcDiv();
		}
	}
}
