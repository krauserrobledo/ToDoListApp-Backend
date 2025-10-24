namespace Domain.Constants
{
    /// <summary>
    /// Task Status constant
    /// </summary>
    /// <remarks>This class Sets and validate statuses for tasks</remarks>
    public static class TaskStatus
    {

        public const string NonStarted = "Non Started";

        public const string InProgress = "In Progress";

        public const string Paused = "Paused";

        public const string Late = "Late";

        public const string Finished = "Finished";
<<<<<<< HEAD
=======

>>>>>>> 3b811eb (refactor: improve code organization)
        // Valid statuses array
        public static readonly string[] All =
        [
            NonStarted,
            InProgress,
            Paused,
            Late,
            Finished
        ];
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> 9b74040 (refactor: clean code and documentation)
=======

>>>>>>> 3b811eb (refactor: improve code organization)
        // Validate if a status is valid
        public static bool IsValid(string status)
        {
            return All.Contains(status, StringComparer.OrdinalIgnoreCase);
        }
    }
}
