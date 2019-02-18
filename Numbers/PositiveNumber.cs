namespace Numbers
{
    public class PositiveNumber : Number
    {
        private readonly Number _previous;

        public PositiveNumber(Number previous)
        {
            _previous = previous;
        }

        public override Number Invert()
        {
            return _previous.Invert().Previous();
        }

        public override Number Minus(Number other)
        {
            return Plus(other.Invert());
        }

        public override Number Next()
        {
            return new PositiveNumber(this);
        }

        public override Number Plus(Number addend)
        {
            return _previous.Plus(addend).Next();
        }

        public override Number Previous()
        {
            return _previous;
        }

        public override string ToString()
        {
            return _previous.ToString() + "+";
        }

        public override Number Times(Number other)
        {
            return _previous.Times(other).Plus(other);
        }

        public override bool GreaterThanZero()
        {
            return true;
        }

        public override bool IsZero()
        {
            return false;
        }

        public override Number Absolute()
        {
            return this;
        }

        public override bool GreaterThan(Number other)
        {
            return Minus(other).GreaterThanZero();
        }

        public override Number Sign()
        {
            return Minus(_previous);
        }

        public override Number DividedBy(Number other)
        {
            Number counter = new Zero();
            Number step = other.Absolute();
            Number current = step;

            if (other.IsZero())
                throw new System.Exception("Cannot divide by zero!");

            while (GreaterThan(current) || Equals(current))
            {
                counter = counter.Next();
                current = current.Plus(step);
            }

            return counter.Times(other.Sign());
        }

        public override bool Equals(object obj)
        {
            return obj is Number otherNum && otherNum.Minus(this).IsZero();
        }

        public override int GetHashCode()
        {
            return Previous().GetHashCode();
        }
    }
}
