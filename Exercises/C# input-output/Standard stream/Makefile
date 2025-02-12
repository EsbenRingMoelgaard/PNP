CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

# Included random tabs and extraneous spaces in the input to test delimiter handling.
Out.txt: Main.exe
	echo 1 2	3 	 4  5 | mono Main.exe 2> $@

Main.exe: MainClass.cs; $(MKEXE)

clean : 
	rm Out.txt Main.exe