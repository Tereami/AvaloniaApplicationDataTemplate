using System.Collections.Generic;
using AvaloniaApplicationDataTemplate.Models;

namespace AvaloniaApplicationDataTemplate.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public List<Person> People { get; } = new List<Person>()
    {
        new Teacher
        {
            FirstName = "Mrr.",
            LastName = "Tea cher",
            Age = 55,
            Sex = Sex.Diverse,
            Subject = "Math"
        },
        new Student()
        {
            FirstName = "Hello",
            LastName = "Stu dent",
            Age = 15,
            Sex = Sex.Male,
            Grade = 2
        },
        new Student()
        {
            FirstName = "Hello",
            LastName = "Masha",
            Age = 18,
            Sex = Sex.Female,
            Grade = 3
        },
        new Student()
        {
            FirstName = "Hello2",
            LastName = "Masha2",
            Age = 18,
            Sex = Sex.Female,
            Grade = 3
        },
        new Student()
        {
            FirstName = "Hello33",
            LastName = "Masha3",
            Age = 18,
            Sex = Sex.Female,
            Grade = 3
        },
    };
}