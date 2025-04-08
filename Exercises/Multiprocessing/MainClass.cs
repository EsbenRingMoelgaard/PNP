using System.Threading;

public class Data 
{ 
	public Data(long a, long b) {
		this.a = a;
		this.b = b;
	}

	public long a { get; }
	public long b { get; } 
	public double sum { get; set; }
}



class MainClass {
	public static void harmonic(object arg)
	{	
		Data data = (Data)arg;
		data.sum=0;
		for(long i = data.a; i < data.b; i++) { data.sum += 1.0 / i; }
	}

	public static void Main(string[] args) {
		int threadCount = 1;
		long termCount = (long)1e8;

		foreach(string arg in args) {
			string[] elements = arg.Split(":");
			if(elements[0] == "-threads") threadCount = int.Parse(elements[1]);
			if(elements[0] == "-terms") termCount = (long)double.Parse(elements[1]);
		}

		Data[] threadArgs = new Data[threadCount];
		for(int i=0; i<threadCount; i++) {
			threadArgs[i] = new Data(
				1 + termCount/threadCount * i,
				1 + termCount/threadCount * (i + 1));
		}

		Thread[] threads = new Thread[threadCount];

		for(int i=0; i<threadCount; i++) {
			threads[i] = new Thread(harmonic);
			threads[i].Start(threadArgs[i]);
		}

		foreach(Thread thread in threads) { thread.Join(); }

		double sum = 0;
		foreach(Data data in threadArgs) { sum += data.sum; }

		System.Console.WriteLine($"Harmonic sum of {termCount} terms: {sum}");
		System.Console.WriteLine($"ln({termCount}) + 0.577: {System.Math.Log(termCount) + 0.577}");
	}
}

