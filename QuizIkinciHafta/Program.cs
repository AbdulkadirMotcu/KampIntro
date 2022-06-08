using System;
using System.Linq;

namespace QuizIkinciHafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
			film film1 = new film();
			film1.filmAdi = "Buz Devri";
			film1.imbd = 7.7;

			film film2 = new film();
			film2.filmAdi = "Hababam Sınıfı";
			film2.imbd = 9.7;

			film film3 = new film();
			film3.filmAdi = "Yenilmezler";
			film3.imbd = 7.9;

			film film4 = new film();
			film4.filmAdi = "Kutupta Macera";
			film4.imbd = 8.7;

			film film5 = new film();
			film5.filmAdi = "Maske";
			film5.imbd = 9.7;
			film[] filmler = new film[] { film1, film2, film3, film4, film5 };


            foreach (var film in filmler.OrderBy(f => f.imbd))
			{
				Console.WriteLine(film.filmAdi + " " + film.imbd);
			}

		}
	}
	class film
	{
		public string filmAdi { get; set; }
		public double imbd { get; set; }

	}
}