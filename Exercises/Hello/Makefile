CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

Out.txt: Main.exe
	mono Main.exe > $@

Main.exe: MainClass.cs HelloWorld.dll; $(MKEXE)

HelloWorld.dll: HelloWorld.cs; $(MKLIB)

clean : 
	rm Out.txt Main.exe HelloWorld.dll