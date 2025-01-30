Out.txt : Main.exe
	mono Main.exe > Out.txt

Main.exe : MainClass.cs HelloWorld.dll
	mcs -target:exe -reference:HelloWorld -out:Main.exe MainClass.cs

HelloWorld.dll : HelloWorld.cs
	mcs -target:library -out:HelloWorld.dll HelloWorld.cs