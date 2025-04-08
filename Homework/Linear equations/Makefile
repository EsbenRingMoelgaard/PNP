CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

Out.txt: Main.exe
	mono Main.exe > $@

Main.exe: MainClass.cs Vector.dll Matrix.dll; $(MKEXE)

Matrix.dll: Matrix.cs Vector.dll; $(MKLIB)

Vector.dll: Vector.cs; $(MKLIB)

clean: 
	rm Out.txt Main.exe