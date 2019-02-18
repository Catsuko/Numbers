namespace NumbersTests.Numbers
{
    public abstract class Number
    {
        public abstract Number Plus(Number other);
        public abstract Number Minus(Number other);
        public abstract Number Times(Number other);
        public abstract Number DividedBy(Number other);
        public abstract Number Next();
        public abstract Number Previous();
        public abstract Number Invert();
        public abstract Number Sign();
        public abstract Number Absolute();
        public abstract bool IsZero();
        public abstract bool GreaterThanZero();
        public abstract bool GreaterThan(Number other);

        public static Number operator + (Number a, Number b)
        {
            return a.Plus(b);
        }

        public static Number operator - (Number a, Number b)
        {
            return a.Minus(b);
        }

        public static Number operator * (Number a, Number b)
        {
            return a.Times(b);
        }

        public static bool operator > (Number a, Number b)
        {
            return a.GreaterThan(b);
        }

        public static bool operator < (Number a, Number b)
        {
            return b.GreaterThan(a);
        }
    }
}
