using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Accelerate
{
    /// <summary>
    /// Represent an error that occur for a security issue.
    /// </summary>
    [Serializable]
    public class SecurityException : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SecurityException" /> class.
        /// </summary>
        public SecurityException() : base()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public SecurityException(string message) : base(message)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public SecurityException(string message, Exception innerException) : base(message, innerException)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityException" /> class with serialized data.
        /// </summary>
        /// <param name="info">
        /// The <see cref="SerializationInfo" /> that holds the serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext" /> that contains contextual information about the source or destination.
        /// </param>
        [ExcludeFromCodeCoverage]
        [Obsolete("This constructor is obsolete for security reasons")]
        protected SecurityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}