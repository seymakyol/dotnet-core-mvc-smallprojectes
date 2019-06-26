using MoviApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviApp.Data
{
    public static class ProductRepository
    {
        private static List<Movie> _movies = null;
        static ProductRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                Id =1,
                Name ="Tubitak",
                Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                ShortDescription ="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",
                ImageUrl ="1.jpg",
                CategoryId=1
                },
                new Movie()
                {
                    Id =2,
                    Name ="Aselsan",
                     Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    ShortDescription ="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",
                    ImageUrl ="2.jpg",
                    CategoryId=2
                },
                new Movie()
                {
                    Id =3,
                    Name ="Havelsan",
                     Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    ShortDescription ="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",
                    ImageUrl ="3.png",
                    CategoryId=2
                },
                new Movie()
                {
                    Id =4,
                    Name ="Roketsan",
                     Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    ShortDescription ="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",
                    ImageUrl ="4.jpg",
                    CategoryId=5
                }
            };
        }
        public static List<Movie> Movies
            {
            get{
            return _movies;
            } }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }

    }
}
