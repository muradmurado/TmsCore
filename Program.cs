// SESSION 1
string? region = null;

string? upperRegion = region?.ToUpper();
Console.WriteLine($"Region(condiional): {upperRegion}"); 

string displayRegion = region ?? "Unassigned";
Console.WriteLine($"Region(coalescing): {displayRegion}");

region ??= "Addis Ababa";
Console.WriteLine($"Region(assigned): {region}");



string studentName = "Abeba"; 
string studentId = "STU-001"; 
int enrollmentCount = 3; 
decimal grantAmount = 1999.99m; 
DateTime enrolledAt = DateTime.UtcNow; 
string? campusRegion = null; 
Console.WriteLine($"Student: {studentName} ({studentId})"); 
Console.WriteLine($"Courses: {enrollmentCount}"); 
Console.WriteLine($"Grant: {grantAmount:F2}"); 
Console.WriteLine($"Enrolled: {enrolledAt:yyyy-MM-dd}"); 
Console.WriteLine($"Campus: {campusRegion ?? "Not assigned"}"); 


 decimal grantPerStudent = 1999.99m; 
decimal totalAllocation = grantPerStudent * 100_000; 
Console.WriteLine($"Total allocated (decimal): {totalAllocation}"); 
Console.WriteLine($"Total allocated (formatted): {totalAllocation:F2}"); 


var enrollment = new EnrollmentRecord("STU-001", "CS401",DateTime.UtcNow);

Console.WriteLine(enrollment);

var corrected=enrollment with { CourseCode = "CS402" };
Console.WriteLine(corrected);

var duplicate = new EnrollmentRecord("STU-001", "CS401", enrollment.EnrolledAt);
Console.WriteLine($"Same data? {enrollment == duplicate}");

var course = new Course
{
    Code = "CS401",
    Title = "Advanced C#",
    Capacity = 30
};

Console.WriteLine($"Course:{course.Title} (Capacity: {course.Capacity})");

try
{
    course.Capacity = -5; 
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Caught: {ex.Message}");
}

try
{
    course.Title = "   "; 
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Caught: {ex.Message}");
}

var s = new Student { Id = "S1", Name ="Abeba",Age = 20, GPA= 3.8m };
Console.WriteLine($"Student: {s.Name}, GPA: {s.GPA}");

// Polymorphic Report
void PrintGradeReport(IEnumerable<IGradable> assessments)
{
Console.WriteLine("--- Grade Report---");
foreach (var item in assessments)
{
Console.WriteLine($"{item.Title}: {item.CalculateGrade():F2}%");
}
}
// Test it — one array holds two completely different types
IGradable[] cohortAssessments = [new Quiz { Title = "C# Basics", CorrectAnswers = 18, TotalQuestions = 20 },new LabAssignment { Title = "Registration API", FunctionalityScore = 90m, CodeQualityScore =85m}
];
PrintGradeReport(cohortAssessments);




//SESSION 2

var service = new EnrollmentService();



