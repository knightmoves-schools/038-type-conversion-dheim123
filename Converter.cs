namespace KnightMoves;

public class Converter 
{
    public decimal ConvertImplicitly(int intValue) => intValue;
    
    public int ConvertExplicitly(decimal decimalValue) => (int)decimalValue;
}

