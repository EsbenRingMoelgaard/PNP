namespace Testing {
    public static class Testing {
        public static void AssertEquals<T>(T value, T expected) {
            if (value == expected) { System.Console.WriteLine($"Passed: Expected {expected} and got {value}"); }
            else { System.Console.WriteLine($"Failed: Expected {expected} and got {value}"); }
        }

        public static void AssertApprox(double value, double expected) {
            double roundedValue = Math.Round(value);
            double roundedExpected = Math.Round(expected);
            if (roundedValue == roundedExpected) { 
                System.Console.WriteLine(
                    $"""
                    Passed: Expected {roundedExpected}, and got {roundedValue}
                    Unrounded input: Expected {expected}, and got {value}
                    """); 
            }
            else { 
                System.Console.WriteLine(
                    $"""
                    Failed: Expected {roundedExpected}, and got {roundedValue}
                    Unrounded input: Expected {expected}, and got {value}
                    """); 
            }
        }
        
        public static void AssertThrowsException<U>(Func<object> method)
        where U : Exception
        {
            // Evaluate the passed thunk, and catch any exceptions thrown in the process
            try
            {
                method(); 
            }
            // Attempt to catch an exception of the specific type U, but not exceptions of supertypes of U
            catch (U e) when (e.GetType() == typeof(U)) 
            {
                System.Console.WriteLine($"Passed: Expected {typeof(U)} and caught {e.GetType()}"); 
            }
            catch (Exception e) // Catch any unexpected exceptions and print the test result
            { 
                System.Console.WriteLine($"Failed: Expected {typeof(U)} but caught {e.GetType()}"); 
            } 
        }
    }
}