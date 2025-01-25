using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex1
{
    public class HollywoodAnimation : IHollywoodMovie
    {
        public string MovieName { get { return "Kung Fu Panda"; } }
    }
    public class HollywoodComedy : IHollywoodMovie
    {
        public string MovieName { get { return "The Fall Guy"; } }
    }
    public class HollywoodHorror : IHollywoodMovie
    {
        public string MovieName { get { return "The Conjuring"; } }
    }


    public class BollywoodAnimation : IBollywoodMovie
    {
        public string MovieName { get { return "Kalki 2898 AD"; } }
    }
    public class BollywoodComedy : IBollywoodMovie
    {
        public string MovieName { get { return "Dhamaal"; } }
    }
    public class BollywoodHorror : IBollywoodMovie
    {
        public string MovieName { get { return "1920"; } }
    }
}
