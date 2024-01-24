public class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int singleNumber){
        _top = singleNumber;
        _bottom = 5;
    }

    public Fraction(int numerator, int denomerator){
        _top = numerator;
        _bottom = denomerator;
    }

    //Getters
    public string GetFractionString(){
        string text = ($" {_top}/{_bottom}");
        return text;
    }

    public double GetDouble(){
        return(double)_top / (double) _bottom;
    }
}