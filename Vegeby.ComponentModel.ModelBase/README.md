# Vegeby.ComponentModel.ModelBase

## About
I found myself rewriting this code in a lot of projects. So i thought I'll try to create a nuget package.

The package can be found at [here](https://www.nuget.org/packages/Vegeby.ComponentModel.ModelBase/).

# Example code
```csharp
  using Vegeby.ComponentModel;

  class MyModel : ModelBase
  {
    // Uncomment line below to disable advertising property changing.
    //protected override bool AdvertiseChanging => false;

    // Uncomment line below to disable advertising property changed.
    //protected override bool AdvertiseChanged => false;

    private string _name;
    public string Name { get => _name; set => SetProperty(ref _name, value); }
  }
```
