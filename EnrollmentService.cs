// built in session 2
public class EnrollmentService
{
    public EnrollmentRecord ProcessRegistration(Student? student, Course? course)
    {
        // TODO1: Guard clauses
        if (student is null)
            throw new ArgumentNullException(nameof(student));

        if (course is null)
            throw new ArgumentNullException(nameof(course));

        if (course.Capacity <= 0)
            throw new InvalidOperationException("Course is full.");

        // TODO2: GPA classification using switch expression
        string standing = student.GPA switch
        {
            >= 3.5m => "Honors",
            >= 2.5m => "GoodStanding",
            < 2.5m => "AcademicWarning"
        };

        Console.WriteLine($"{student.Name} is in {standing}.");

        // TODO3: Return EnrollmentRecord
       return new EnrollmentRecord(
         student.Id,
         course.Code,
         DateTime.UtcNow);
    }
}