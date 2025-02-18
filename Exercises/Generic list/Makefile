CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

Out.txt: Main.exe
	cat Input.txt | mono Main.exe > $@

Main.exe: MainClass.cs GenList.dll; $(MKEXE)

GenList.dll: GenList.cs; $(MKLIB)

clean: 
	rm Out.txt Main.exe