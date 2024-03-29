#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Logging.Logging
File: ILogListener.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Logging
{
	using System;
	using System.Collections.Generic;

	using Ecng.Serialization;

	/// <summary>
	/// The class interface that monitors the event <see cref="ILogSource.Log"/> and saves to some storage.
	/// </summary>
	public interface ILogListener : IPersistable, IDisposable
	{
		/// <summary>
		/// Can save listener.
		/// </summary>
		bool CanSave { get; }

		/// <summary>
		/// To record messages.
		/// </summary>
		/// <param name="messages">Debug messages.</param>
		void WriteMessages(IEnumerable<LogMessage> messages);
	}
}