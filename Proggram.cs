using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tesks;

namespace Responsixx
{
	class Program
	{
		static void Main(string [] args)
		{
			Karyawan karyawan1 = new Karyawan(1, "19112838", "Dila", 5000000);
			Karyawan karyawan2 = new Karyawan(2, "19112837", "Arya", 7000000);
			
			Console.WriteLine("No Nik/Nama\tGajiBulanan");
			Console.WriteLine("--------------------------------");
			Gaji(karyawan1);
			Gaji(karyawan2);
			
			Console.WriteLine("\nKenaikan Gaji 10%");
			Console.WriteLine("No Nik/Nama\tGajiBulanan");
			Console.WriteLine("--------------------------------");
			NaikGaji (karyawan1);
			NaikGaji (karyawan2);
			Console.ReadKey();
		}
		static void Gaji(Karyawan pgw)
		{
			Console.WriteLine(pgw.No + "   "+ pgw.NIK + "  "  + pgw.Nama + "  " + pgw.GajiBulanan);
		}
		static void NaikGaji(Karyawan pgw)
		{
			double naik;
			naik = pgw.GajiBulanan * 0,1;
			pgw.GajiBulanan = pgw.GajiBulanan + naik;
			Console.WriteLine(pgw.NIK + " " + pgw.Nama + "  " + pgw.GajiBulanan);
		}
	}
}
			
	