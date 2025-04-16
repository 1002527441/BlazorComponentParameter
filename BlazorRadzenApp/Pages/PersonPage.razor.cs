using BlazorRadzenApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorRadzenApp.Pages;
public partial class PersonPage
{
    public List<Person> Persons { get; set; } = new List<Person>();

   protected override  async Task OnInitializedAsync()
    {
        Persons.Add(new Person("john", 28));
        Persons.Add(new Person("Henry", 28));
    }

    public void EditPerson(Person person)
    {
        person.Name = "";
        person.Age = 30;
    }

    public void ValidatorPerson(Person person)
    {
        var validator = new PersonValidator();
        var result = validator.Validate(person);

        bool success  = result.IsValid;

        var errors = result.Errors;


        Console.WriteLine(errors);
    }


    public void DeletePerson(Person person)
    {

    }
}
