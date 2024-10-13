public class Fractions
{
   private int _numerator;
   private int _denominator;


   public Fractions()
   {
    _numerator=1;
    _denominator=1;
   }

   public Fractions(int wholeNumber)
   {
     _numerator=wholeNumber;
     _denominator=1;
   }

   public Fractions(int numerator, int denominator)
   {
      _numerator=numerator;
      _denominator=denominator;
   }

   public int GetNumerator()
   {
    return _numerator;
   }
   public int GetDenominator()
   {
    return _denominator;
   }
   public void SetNumerator(int numerator )
   {
    _numerator=numerator;
   }
    public void SetDenominator(int denominator )
   {
    _denominator=denominator;
   }

   public string GetFractionString()
   {
     string fraction=$"{_numerator}/{_denominator}";
     return fraction;
   }
   public double GetDecimalValue()
   {
     double value=_numerator/_denominator;
     return value;
   }


}