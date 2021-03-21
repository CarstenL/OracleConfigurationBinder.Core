namespace OracleConfigurationBinder.Core.Model
{
    public class CommandModel
    {
        /// <summary>
        /// This property specifies whether the binding method used for the parameter collection is by name or by position. 
        /// Default value (false) is bind by position.
        /// </summary>
        public bool BindByName { get; set; }

        /// <summary>
        /// This property specifies the number of seconds the command is allowed to execute before terminating the execution with an exception. Default value is 0 seconds, which results in no time limit.
        /// </summary>
        public int CommandTimeout { get; set; }

    }
}
