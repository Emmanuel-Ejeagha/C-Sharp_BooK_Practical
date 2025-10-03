using System;

namespace Chpt24SampleProgrammingExamTopic_1.MotorPartsShop;

public class Car
{
    private string brand;
    private string model;
    private int productionYear;

    public Car(string brand, string model, int productionYear)
    {
        this.brand = brand;
        this.model = model;
        this.productionYear = productionYear;
    }

    public override string ToString()
    {
        return $"<{brand},{model},{productionYear}>";
    }

    // The Equals(...) and GetHashCode() methods for the class Car

    public override bool Equals(object obj)
    {
        Car otherCar = obj as Car;
        if (otherCar == null)
        {
            return false;
        }
        bool equals =
          Equals(brand, otherCar.brand) &&
          Equals(model, otherCar.model) &&
          Equals(productionYear, otherCar.productionYear);
        return equals;
    }

    public override int GetHashCode()
    {
        const int prime = 31;
        int result = 1;
        result = prime * result + ((brand == null) ? 0 : brand.GetHashCode());
        result = prime * result + ((model == null) ? 0 : model.GetHashCode());
        result = prime * result + productionYear;
        return result;
    }
}
