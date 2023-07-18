using NestedObjects;

Advisor compSciAdvisor = new()
{
    Email = "Annemarie@cptc.edu",
    FullName = "Annemarie Smith",
    OfficeLocation = "B17 Rm 150"
};

Student stu1 = new()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "2535895580",
    SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");