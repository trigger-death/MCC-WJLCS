﻿
namespace WJLCS.Screens {
	/// <summary>
	/// The screen for configuring the rotors.
	/// </summary>
	public class RotorConfigureScreen : InterpreterScreen {

		#region Constructors

		/// <summary>
		/// Constructs the <see cref="RotorConfigureScreen"/>.
		/// </summary>
		/// <param name="filePath">The filepath of the screen text.</param>
		public RotorConfigureScreen(string fileName) : base(fileName) { }

		#endregion

		#region RunScreen Override

		/// <summary>
		/// Runs the interpreter screen.
		/// </summary>
		protected override void RunScreen(Interpreter interpreter) {
			interpreter.ConfigureRotors();
		}

		#endregion
	}
}
