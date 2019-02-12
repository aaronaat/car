using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Description;

    public Car(string makeModel, int price, int miles, string desc)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Description = desc;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }


    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetDesc()
    {
      return Description;
    }
    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return ((Price < maxPrice) && (Miles < maxMiles));
    }
  }
}
