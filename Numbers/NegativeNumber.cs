namespace NumbersTests.Numbers
{
    public class NegativeNumber : Number
    {
        private readonly Number _next;

        public NegativeNumber(Number next)
        {
            _next = next;
        }

        public override bool IsZero()
        {
            return false;
        }

        public override bool GreaterThanZero()
        {
            return false;
        }

        public override bool GreaterThan(Number other)
        {
            return Minus(other).GreaterThanZero();
        }

        public override Number Invert()
        {
            return _next.Invert().Next();
        }

        public override Number Minus(Number other)
        {
            return _next.Minus(other).Previous();
        }

        public override Number Next()
        {
            return _next;
        }

        public override Number Plus(Number other)
        {
            return _next.Plus(other).Previous();
        }

        public override Number Previous()
        {
            return new NegativeNumber(this);
        }

        public override string ToString()
        {
            return _next.ToString() + "-";
        }

        public override Number Times(Number other)
        {
            return _next.Times(other).Minus(other);
        }

        public override Number DividedBy(Number other)
        {
            return Invert().DividedBy(other).Invert();
        }

        public override Number Sign()
        {
            return Minus(_next);
        }

        public override Number Absolute()
        {
            return Invert();
        }

        public override bool Equals(object obj)
        {
            return obj is Number otherNum && otherNum.Minus(this).IsZero();
        }

        public override int GetHashCode()
        {
            return Next().GetHashCode() - 1;
        }
    }
}
