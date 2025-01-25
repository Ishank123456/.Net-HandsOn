using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimationMovieFactory objAnimationMovieFactory = new AnimationMovieFactory();

            IHollywoodMovie hAnimation = objAnimationMovieFactory.GetHollywoodMovie();
            IBollywoodMovie bAnimation = objAnimationMovieFactory.GetBollywoodMovie();
            Console.WriteLine($"Animation Movies from Hollywood: {hAnimation.MovieName}");
            Console.WriteLine($"Animation Movies from Bollywood: {bAnimation.MovieName}");
            Console.WriteLine();

            ComedyMovieFactory objComedyMovieFactory = new ComedyMovieFactory();

            IHollywoodMovie hComedy = objComedyMovieFactory.GetHollywoodMovie();
            IBollywoodMovie bComedy = objComedyMovieFactory.GetBollywoodMovie();
            Console.WriteLine($"Comedy Movies from Hollywood: {hComedy.MovieName}");
            Console.WriteLine($"Comedy Movies from Bollywood: {bComedy.MovieName}");
            Console.WriteLine();


            HorrorMovieFactory objHorrorMovieFactory = new HorrorMovieFactory();

            IHollywoodMovie hHorror = objHorrorMovieFactory.GetHollywoodMovie();
            IBollywoodMovie bHorror = objHorrorMovieFactory.GetBollywoodMovie();
            Console.WriteLine($"Horror Movies from Hollywood: {hHorror.MovieName}");
            Console.WriteLine($"Horror Movies from Bollywood: {bHorror.MovieName}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
