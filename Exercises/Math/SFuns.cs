using System;
using static System.Math;

public static class SFuns {    
    public static double FGamma(double x) {
        ///single precision gamma function (formula from Wikipedia)
        if(x<0)return PI/Sin(PI*x)/FGamma(1-x); // Euler's reflection formula
        if(x<9)return FGamma(x+1)/x; // Recurrence relation

        double lnFGamma=x*Log(x+1/(12*x-1/x/10))-x+Log(2*PI/x)/2;
        return Exp(lnFGamma);
    }

    public static double LnFGamma(double x) {
        ///single precision gamma function (formula from Wikipedia)
        if(x <= 0) throw new ArgumentOutOfRangeException("Logarithmic function is undefined for x <= 0");
        if(x < 9) return LnFGamma(x+1) - Log(x); // Recurrence relation

        return x*Log(x+1/(12*x-1/x/10))-x+Log(2*PI/x)/2;
    }
    
    public static int IntFactorial(int x) {
        if (x < 0) throw new ArgumentOutOfRangeException("Factorial function undefined for negative numbers");
        if (x <= 1) return 1;

        return x*IntFactorial(x-1);
    }
}