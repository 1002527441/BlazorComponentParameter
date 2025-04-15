using BlazorApp20.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp20.Pages;
public partial class Counter
{
    private int currentCount = 0;


    [Parameter] 
    public int InitialCount { get; set; } = 5;

    [Parameter]
    public Person? Person { get; set; }

    [Parameter]
    public EventCallback<int> OnUpdated { get; set; }

    [Parameter]
    public EventCallback<Person> OnPersonUpdated { get; set; }

    private void IncrementCount()
    {
        currentCount+= InitialCount;

        if (OnUpdated.HasDelegate)
        {
            OnUpdated.InvokeAsync(currentCount);
        }
    }


    private void UpdatePerson(Person person )
    {
        if (OnPersonUpdated.HasDelegate)
        {
            OnPersonUpdated.InvokeAsync(person);
        }
    }

    private void OnUpdatePerson()
    {
        if (Person != null)
        {
            Person.Age++;
            UpdatePerson(Person);
        }
    }

    private void OnUpdatePersonWithoutCallBack()
    {
        if (Person != null)
        {
            Person.Age++;
        }
    }


    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine($"==============================================");
        Console.WriteLine($"Child---OnInitializedAsync={InitialCount}");

        await Task.Delay(1000);

        Person = new Person { Name = "John", Age = 30 };

        await base.OnInitializedAsync();

    }

    public override Task SetParametersAsync(ParameterView parameters)
    {
        parameters.SetParameterProperties(this);
        Console.WriteLine($"Child---SetParametersAsync={InitialCount}");
        return base.SetParametersAsync(parameters);
    }


    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine($"Child---OnParametersSetAsync={InitialCount}");
        await base.OnParametersSetAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine($"Child---OnAfterRenderAsync={InitialCount}");
        await base.OnAfterRenderAsync(firstRender); 
    }

}
