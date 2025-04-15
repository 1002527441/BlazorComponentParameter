using BlazorApp20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp20.Pages;
public partial class Test 
{
    private int _count = 7;

    private Person _person = new Person { Name = "John", Age = 30 };

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine($"Parent---OnInitializedAsync={_count}");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine($"Parent---OnAfterRenderAsync={_count}");
    }

    void OnUpdate(Person person)
    {
        _person = person;
    }

    void OnChange(int count)
    {
        _count = count;
        
    }

}
