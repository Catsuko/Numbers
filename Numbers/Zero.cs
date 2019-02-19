namespace Numbers
{
    public class Zero : Number
    {
        public override Number Invert()
        {
            return this;
        }

        public override Number Sign()
        {
            return this;
        }

        public override Number Absolute()
        {
            return this;
        }

        public override bool GreaterThan(Number other)
        {
            return Minus(other).Sign().Previous().Equals(this);
        }

        //TODO: Can Equals be implemented without a type check or an IsZero method?
        public override bool Equals(object obj)
        {
            return obj is Zero;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override Number Minus(Number other)
        {
            return other.Invert();
        }

        public override Number Next()
        {
            return new PositiveNumber(this);
        }

        public override Number Plus(Number other)
        {
            return other;
        }

        public override Number Previous()
        {
            return new NegativeNumber(this);
        }

        public override string ToString()
        {
            return string.Empty;
        }

        public override Number Times(Number other)
        {
            return this;
        }

        public override Number DividedBy(Number other)
        {
            return this;
        }
    }
}
