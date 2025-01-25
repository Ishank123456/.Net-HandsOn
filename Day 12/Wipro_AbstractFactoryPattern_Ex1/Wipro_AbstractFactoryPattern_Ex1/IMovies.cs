using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex1
{
    public interface IHollywoodMovie
    {
        string MovieName { get; }
    }
    public interface IBollywoodMovie
    {
        string MovieName { get; }
    }
    public interface IMovieFactory
    {
        IHollywoodMovie GetHollywoodMovie();
        IBollywoodMovie GetBollywoodMovie();
    }
}
