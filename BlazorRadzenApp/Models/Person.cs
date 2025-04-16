using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorRadzenApp.Models;
public class Person
{

    public Person(string name, int age)
    {
             Id = Guid.NewGuid().ToString();
             Name = name;
             Age = age;
    }
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
