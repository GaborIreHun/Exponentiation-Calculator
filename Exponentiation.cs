using System;


class Exponentiation
{
    public int baseValue;
    public int exponentValue;
    public int result = 1;


    public void SetBaseValue(int exponentiationBaseValue)
    {
        baseValue = exponentiationBaseValue;
    }

    public int GetBaseValue()
    {
        return baseValue;
    }

    public void SetExponentValue(int expontentiationExponentValue)
    {
        exponentValue = expontentiationExponentValue;
    }

    public int GetExponentValue()
    {
        return exponentValue;
    }

    public int IntegerPower()
    {
        
        for (int i = 1; i<= exponentValue; ++i)
        {
            result *= baseValue;
        }
        return result;
    }


}

