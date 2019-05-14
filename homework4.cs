using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Homework_04
{
	public class Calculator
	{
		//
		// Properties
		//
		public double Height {
			get {
				return this._HeightDouble;
			}
			set {
				this._HeightDouble = value;
			}
		}

		public string HeightUnit {
			get {
				return this._HeightUnit;
			}
			set {
				this._HeightUnit = value.Trim ().ToLower ();
			}
		}

		public double Weight {
			get {
				return this._WeightDouble;
			}
			set {
				this._WeightDouble = value;
			}
		}

		public string WeightUnit {
			get {
				return this._WeightUnit;
			}
			set {
				this._WeightUnit = value.ToLower ();
			}
		}

		//
		// Constructors
		//
		public Calculator (double HeightDouble, string HeightUnitString, double WeightDouble, string WeightUnitString)
		{
			this.Height = HeightDouble;
			this.HeightUnit = HeightUnitString;
			this.Weight = WeightDouble;
			this.WeightUnit = WeightUnitString;
			this.BMI ();
		}

		//
		// Methods
		//
		public double BMI ()
		{
			bool flag = Operators.CompareString (this.WeightUnit, "kg", false) == 0;
			double num;
			if (flag) {
				num = this.Weight;
			} else {
				num = this.Weight * 0.44999998807907104;
			}
			bool flag2 = Operators.CompareString (this.HeightUnit, "m", false) == 0;
			double x;
			if (flag2) {
				x = this.Height;
			} else {
				x = this.Height * 0.02500000037252903;
			}
			return num / Math.Pow (x, 2.0);
		}
	}
}
