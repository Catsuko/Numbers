namespace NumbersTests.Numbers
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
            return Minus(other).GreaterThanZero();
        }

        public override bool Equals(object obj)
        {
            return obj is Number && ((Number)obj).IsZero();
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool IsZero()
        {
            return true;
        }

        public override bool GreaterThanZero()
        {
            return false;
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
