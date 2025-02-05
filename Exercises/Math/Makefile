CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

Out.txt: Main.exe
	mono Main.exe > $@

Main.exe: MainClass.cs SFuns.dll; $(MKEXE)

SFuns.dll: SFuns.cs; $(MKLIB)

clean : 
	rm Out.txt Main.exe SFuns.dll