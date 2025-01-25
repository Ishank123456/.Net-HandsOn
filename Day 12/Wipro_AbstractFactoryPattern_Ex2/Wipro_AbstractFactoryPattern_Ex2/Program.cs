using System;

namespace Wipro_AbstractFactoryPattern_Ex2
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
            Console.WriteLine($"Animation Movies from Hollywood: {hComedy.MovieName}");
            Console.WriteLine($"Animation Movies from Bollywood: {bComedy.MovieName}");
            Console.WriteLine();


            HorrorMovieFactory objHorrorMovieFactory = new HorrorMovieFactory();

            IHollywoodMovie hHorror = objHorrorMovieFactory.GetHollywoodMovie();
            IBollywoodMovie bHorror = objHorrorMovieFactory.GetBollywoodMovie();
            Console.WriteLine($"Animation Movies from Hollywood: {hHorror.MovieName}");
            Console.WriteLine($"Animation Movies from Bollywood: {bHorror.MovieName}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
