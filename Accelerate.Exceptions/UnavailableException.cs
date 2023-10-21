﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Accelerate
{
    /// <summary>
    /// Represent an error that occur when a remote endpoint is unavailable.
    /// </summary>
    [Serializable]
    public class UnavailableException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableException" /> class.
        /// </summary>
        public UnavailableException() : base()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public UnavailableException(String message) : base(message)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public UnavailableException(String message, Exception innerException) : base(message, innerException)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableException" /> class with serialized data.
        /// </summary>
        /// <param name="info">
        /// The <see cref="SerializationInfo" /> that holds the serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext" /> that contains contextual information about the source or destination.
        /// </param>
        [ExcludeFromCodeCoverage]
        [Obsolete("This constructor is obsolete for security reasons")]
        protected UnavailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
