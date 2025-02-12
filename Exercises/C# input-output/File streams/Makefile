CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

Out.txt: Main.exe
	mono Main.exe -input:In.txt -output:Out.txt

# Sample recipe to run program with another input file
OtherInput: Main.exe
	mono Main.exe -input:OtherInputFile.txt -output:Out.txt


Main.exe: MainClass.cs; $(MKEXE)

clean : 
	rm Out.txt Main.exe