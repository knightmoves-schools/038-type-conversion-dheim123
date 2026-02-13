namespace KnightMoves;

public class Converter {
    public decimal ConvertImplicitly(int intValue) {
        decimal decimalValue = intValue; 
        return decimalValue;
    }

    public int ConvertExplicitly(decimal decimalValue) {
        int intValue = (int)decimalValue;
        return intValue;
    }

}

