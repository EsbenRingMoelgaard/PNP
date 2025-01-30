Out.txt : Main.exe
	mono Main.exe > Out.txt

Main.exe : MainClass.cs SFuns.dll
	mcs -target:exe -reference:SFuns -out:Main.exe MainClass.cs

SFuns.dll : SFuns.cs
	mcs -target:library -out:SFuns.dll SFuns.cs

clean : 
	rm Out.txt Main.exe SFuns.dll