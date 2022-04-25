# DotNetPatterns
A set of classes and interfaces to help with applying coding patterns.

## General Patterns

### Build Pattern

Example:

```csharp
using DotNetPatterns;

class CarBuilder : IBuilder<Car>
{
    public Car Build()
    {
        // create a new car
        return new Car();
    }
}
```

### Command Pattern

```csharp
public class ClickCommand : ICommand
{
    public void Execute()
    {
        // perform the action
    }
}
```

### Decorator Pattern

```csharp
public class ConcreteComponent
{
}

public class ConcreteDecorator<ConcreteComponent>
{
}

var item = new ConcreteComponent();
var decorator = new ConcreteDecorator(item);
```

### Factory Pattern

```csharp
public class CarFactory : IFactory<Car>
{
    public Car Create()
    {
        return new Car();
    }
}
```

## MVVM Patterns

### ViewModelBase

```csharp
public class MyViewModel : ViewModelBase
{
}
```
