namespace KnightMoves;

public class Converter 
{
    public decimal ConvertImplicitly(int intValue) 
    {
        return intValue;
    }
    
    public int ConvertExplicitly(decimal decimalValue) 
    {
        return (int)decimalValue;
    }
}
