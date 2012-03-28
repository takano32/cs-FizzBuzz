using System;

class FizzBuzz {
	public const string f = "Fizz";
	public const string b = "Buzz";
	public void fb(int n) {
		if (n == 0) return;
		fb(n - 1);
		if (n % 15 == 0) {
			Console.WriteLine(f + b);
		} else if (n % 5 == 0) {
			Console.WriteLine(b);
		} else if (n % 3 == 0) {
			Console.WriteLine(f);
		} else {
			Console.WriteLine(n);
		}
	}
	public static void Main(string[] args) {
		FizzBuzz fb = new FizzBuzz();
		fb.fb(100);
	}
}


