using System;

namespace Bird
{
    public interface IBird
    {
        Egg Lay();
    }

    public class Chicken : IBird
    {

        public Chicken()
        {
        }

        public Egg Lay() => new Egg(() => new Chicken());
    }

    public class Crow : IBird
    {

        public Crow()
        {
        }

        public Egg Lay() => new Egg(() => new Crow());
    }

    public class Egg
    {
        private bool _hasLaidEgg;
        private readonly Func<IBird> _newBird;

        public Egg(Func<IBird> createBird)
        {
            _newBird = createBird;
        }

        public IBird Hatch()
        {
            if (_hasLaidEgg)
                throw new InvalidOperationException();

            _hasLaidEgg = true;

            return _newBird();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
                  var chicken1 = new Chicken();
                  var egg = chicken1.Lay();
                  var childChicken = egg.Hatch();
        }
    }
}
