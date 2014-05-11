using System;
namespace cloudfileserver
{	[Serializable ]
	public class VersionNumberConflictException : Exception
	{
		public VersionNumberConflictException() : base() { }
		public VersionNumberConflictException (string message) : base(message) {}
		public VersionNumberConflictException (string message, System.Exception inner) : base(message, inner) { }
	}
}

