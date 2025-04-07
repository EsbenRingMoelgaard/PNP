CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)
TIME = time --portability --append --output $@
N = 1e10

Out.txt: Main.exe
	$(TIME) mono Main.exe -terms:$N -threads:1 >> $@
	$(TIME) mono Main.exe -terms:$N -threads:2 >> $@
	$(TIME) mono Main.exe -terms:$N -threads:5 >> $@
	$(TIME) mono Main.exe -terms:$N -threads:10 >> $@

Main.exe: MainClass.cs; $(MKEXE)

clean: 
	rm Out.txt Main.exe