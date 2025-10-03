using System;
using System.Text;

namespace Chpt24SampleProgrammingExamTopic_1.MotorPartsShop;

public class Part
{
    private string name;
    private string code;
    private PartCategory category;
    private HashSet<Car> supportedCars;
    private decimal buyPrice;
    private decimal sellPrice;
    private Manufacturer manufacturer;

    public Part(string name, decimal buyPrice, decimal sellPrice, Manufacturer manufacturer, string code, PartCategory category)
    {
        this.name = name;
        this.buyPrice = buyPrice;
        this.sellPrice = sellPrice;
        this.manufacturer = manufacturer;
        this.code = code;
        this.category = category;
        supportedCars = new HashSet<Car>();
    }

    public void AddSupportedCar(Car car)
    {
        supportedCars.Add(car);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append($"Part: {name}\n");
        result.Append($"-code: {code}\n");
        result.Append($"-category: {category}\n");
        result.Append($"-buyPrice: {buyPrice}\n");
        result.Append($"-sellPrice: {sellPrice}\n");
        result.Append($"-manufacturer: {manufacturer}\n");
        result.Append($"---Supported cars----\n");
        foreach (Car car in supportedCars)
        {
            result.Append(car);
            result.Append("\n");
        }
        result.Append("------------------------\n");
        return result.ToString();
    }


}
