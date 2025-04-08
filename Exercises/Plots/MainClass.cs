using System;

public static class MainClass {

    private static void calculate(Func<double, double> function, double start, double stop, int samples) {
        double[] xs = new double[samples];
        double intervalWidth = (stop - start) / (samples -1);
        
        for(int i=0; i < samples; i++) 
        { 
            xs[i] = i * intervalWidth + start; 
            Console.WriteLine($"{xs[i]}, {function(xs[i])}");
        }
    }


    public static void Main() {
        calculate(erf, 0, 4, 10000);
        
        Console.WriteLine("\n"); // Double whitespace to break data for GNUplot

        calculate(fGamma, -5, 5, 10000);
        
        Console.WriteLine("\n"); // Double whitespace to break data for GNUplot

        calculate(lnFGamma, 0.1, 5, 10000);
    }

    static double erf(double x) {
        if(x < 0) return -erf(-x);

        double[] a = {0.254829592, -0.284496736, 1.421413741, -1.453152027, 1.061405429};
        double t = t=1/(1+0.3275911*x);
        double sum = t * (a[0] + t*(a[1]+t*(a[2]+t*(a[3]+t*a[4]))));
        return 1-sum*Math.Exp(-x*x);
    } 

    private static double fGamma(double x) {
        ///single precision gamma function (formula from Wikipedia)
        if(x<0)return Math.PI/Math.Sin(Math.PI*x)/fGamma(1-x); // Euler's reflection formula
        if(x<9)return fGamma(x+1)/x; // Recurrence relation

        double lnFGamma=x*Math.Log(x+1/(12*x-1/x/10))-x+Math.Log(2*Math.PI/x)/2;
        return Math.Exp(lnFGamma);
    }

    private static double lnFGamma(double x) {
        ///single precision gamma function (formula from Wikipedia)
        if(x <= 0) throw new ArgumentOutOfRangeException("Logarithmic function is undefined for x <= 0");
        if(x < 9) return lnFGamma(x+1) - Math.Log(x); // Recurrence relation

        return x*Math.Log(x+1/(12*x-1/x/10))-x+Math.Log(2*Math.PI/x)/2;
    }
}