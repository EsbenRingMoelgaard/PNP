CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

Out.txt: Main.exe
	mono Main.exe > $@

Main.exe: MainClass.cs
	mcs -reference:System.Numerics.dll -out:$@ -target:exe $(DLLS) $(CODE) 