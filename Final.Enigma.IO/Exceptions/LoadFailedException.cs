﻿using System;

namespace WJLCS.Enigma.IO {
	/// <summary>
	/// An exception thrown when loading something has failed for some reason.
	/// </summary>
	public class LoadFailedException : Exception {
		/// <summary>
		/// Constructs the <see cref="LoadFailedException"/>.
		/// </summary>
		/// <param name="message">The text message of the exception.</param>
		public LoadFailedException(string message) : base(message) { }
		/// <summary>
		/// Constructs the <see cref="LoadFailedException"/>.
		/// </summary>
		/// <param name="message">The inner exception of the exception.</param>
		public LoadFailedException(Exception ex) : base(ex.Message, ex) { }
		/// <summary>
		/// Constructs the <see cref="LoadFailedException"/>.
		/// </summary>
		/// <param name="message">The text message of the exception.</param>
		/// <param name="ex">The inner exception of the exception.</param>
		public LoadFailedException(string message, Exception ex) : base($"{message}\n{ex.Message}", ex) { }
	}
}
