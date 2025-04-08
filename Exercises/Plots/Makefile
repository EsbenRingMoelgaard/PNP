CODE = $(filter %.cs,$^)
DLLS = $(addprefix -reference:,$(filter %.dll,$^))
MKLIB = mcs -out:$@ -target:library $(DLLS) $(CODE)
MKEXE = mcs -out:$@ -target:exe $(DLLS) $(CODE)

make: Out.txt
	gnuplot -p Erf/Erf_plot.gpi
	gnuplot -p Gamma/Gamma_plot.gpi
	gnuplot -p lnGamma/lnGamma_plot.gpi

Out.txt: Main.exe
	mono Main.exe > $@

Main.exe: MainClass.cs; $(MKEXE)

clean: 

	rm Out.txt Main.exe Erf/Erf_plot.png Gamma/Gamma_plot.png lnGamma/lnGamma_plot.png