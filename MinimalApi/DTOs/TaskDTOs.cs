namespace MinimalApi.DTOs
{
    // Task DTOs
    public record TaskCreateDTO(
        string Title,
        string Description,
        DateTime? DueDate,
        string Status
        );

    public record TaskUpdateDTO(
<<<<<<< HEAD
        string Id,
=======
        int Id,
>>>>>>> 869890a (fix(endpoints): Category endpoints bug fix)
        string Title,
        string Description,
        DateTime? DueDate,
        string Status,
<<<<<<< HEAD
<<<<<<< HEAD
        List<string> TagIds,
        List<string> CategoryIds);
=======
        List<int> TagIds,
        List<int> CategoryIds);
>>>>>>> 5210ae3 (fix(endpoints):bug fix and OpenApi implementation)
=======
        List<int> TagIds,
        List<int> CategoryIds);
>>>>>>> 869890a (fix(endpoints): Category endpoints bug fix)
}
