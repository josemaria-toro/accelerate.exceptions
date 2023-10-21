using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Accelerate
{
    /// <summary>
    /// Represent an error that occur when a business rule was not completed successfully.
    /// </summary>
    [Serializable]
    public class BusinessException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException" /> class.
        /// </summary>
        public BusinessException() : base()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public BusinessException(String message) : base(message)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="rule">
        /// Name or id of business rule.
        /// </param>
        public BusinessException(String message, String rule) : base(message)
        {
            Rule = rule;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public BusinessException(String message, Exception innerException) : base(message, innerException)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        /// <param name="rule">
        /// Name or id of business rule.
        /// </param>
        public BusinessException(String message, Exception innerException, String rule) : base(message, innerException)
        {
            Rule = rule;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException" /> class with serialized data.
        /// </summary>
        /// <param name="info">
        /// The System<see cref="SerializationInfo" /> that holds the serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext" /> that contains contextual information about the source or destination.
        /// </param>
        [ExcludeFromCodeCoverage]
        [Obsolete("This constructor is obsolete for security reasons")]
        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Name or id of business rule.
        /// </summary>
        public String Rule { get; private set; }
    }
}
