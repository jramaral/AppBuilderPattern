namespace AppBuilderPattern.Builder;

public class CarBuilder
{
    private string make;
    private string model;
    private int year;
    private string color;

    public CarBuilder SetMake(string make)
    {
        this.make = make;
        return this;
    }

    public CarBuilder SetModel(string model)
    {
        this.model = model;
        return this;
    }

    public CarBuilder SetYear(int year)
    {
        this.year = year;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        this.color = color;
        return this;
    }

    public Car Build()
    {
        return new Car(make, model, year, color);
    }
}