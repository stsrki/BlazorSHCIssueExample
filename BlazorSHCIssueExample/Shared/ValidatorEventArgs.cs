using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSHCIssueExample.Shared
{
    public class ValidatorEventArgs : EventArgs
    {
        public ValidatorEventArgs( object value )
        {
            Value = value;
        }

        /// <summary>
        /// Gets the value to check for validation.
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        public ValidationStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the validation custom error message.
        /// </summary>
        public string ErrorText { get; set; }
    }

    /// <summary>
    /// Defines the validation results.
    /// </summary>
    public enum ValidationStatus
    {
        /// <summary>
        /// No validation.
        /// </summary>
        None,

        /// <summary>
        /// Validation has passed the check.
        /// </summary>
        Success,

        /// <summary>
        /// Validation has failed.
        /// </summary>
        Error,
    }
}
