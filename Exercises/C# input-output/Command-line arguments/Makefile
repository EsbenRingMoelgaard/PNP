CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

Out.txt: Main.exe
	mono Main.exe -numbers:1,2,3,4,5 > $@

Main.exe: MainClass.cs; $(MKEXE)

clean : 
	rm Out.txt Main.exe