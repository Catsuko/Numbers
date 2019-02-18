# Numbers
Finally a truly Object-Oriented Numbers library for software architects. No more do you have to wallow like a pig in mud when dealing with numbers whilst the rest of your architecture tries to keep clean. Rest easy sweet prince, heaven has finally arrived!

## Usage

### Getting Started
Import the binary into your project and you are away! Creating a number is as easy as instantiating an object:

```
using Numbers;

Number zero = new Zero();
Number one = zero.Next();
```

### Debugging
Numbers makes debugging a breeze, each Number is capable of describing itself! Spend less time wondering what the hell all the obtuse symbols on your screen mean and more time coding. Simply count the number of `+` symbols and you know exactly what number you are dealing with. Negative numbers will use a `-` instead for obvious reasons.

```
using Numbers;

Number zero = new Zero();
Number one = zero.Next();
Number two = one.Next();

zero.ToString(); --> ""
one.ToString(); --> "+"
two.ToString(); --> "++"

```

## Arithmetic

### Addition

Because the Numbers library is strictly Object-Oriented, naturally it is incredibly semantic. Check out how easily and cleary we can add some Numbers together:

```
using Numbers;

Number one = new Zero().Next();
Number two = new Zero().Next();
Number three = one.Plus(two);

three.ToString(); --> "+++"
```

Of course each Number is immutable too, something to be desired in many libraries that claim to be Object-Oriented. Check this out:

```
Number one = new Zero().Next();
Number two = one.Plus(one);

one.ToString(); --> "+"
two.ToString(); --> "++"
```

### Subtraction

Much like addition, subtraction becomes immensely semantic:

```
Number zero = new Zero();
Number one = zero.Next();
Number negativeOne = zero.Minus(one);

negativeOne.ToString(); --> "-"
```

### Multiplication & Division

Once you have mastered this paradigm shift, you will be ready to move onto some more advanced operations. Here is where we start to see the true power of the Numbers library:

```
using Numbers;

Number zero = new Zero();
Number one = zero.Next();
Number two = one.Next();

two.Times(two).ToString(); --> "++++"
two.DividedBy(one).ToString(); --> "++"
```

### Multiple Operators

You can also chain multiple behaviours together to make advanced expressions. This is not advised for the beginner but grasping it will enhance your skills tenfold:

```
using Numbers;

Number zero = new Zero();
Number one = zero.Next();
Number two = one.Next();

two.Times(two).Plus(one).ToString(); --> "+++++"
```

## Advanced Usage

### Fluent Interfaces

Chain commands together to create semantic one liners that capture powerful behaviour:

```
using Numbers;

Number three = new Zero().Next().Plus(new Zero().Next()).Next();

three.ToString(); --> "+++"
```

### Crisp Abstractions

Create your own Numbers to enable extensible and complex behaviour, simply inherit from the Number class and you will instantly be able to compose intricate webs can be assembled to manufacture any behaviour your project may require. The only limit is your imagination.

Imagine you reuqire a number that when used in an operation, it throws an error. With Numbers, a decorator with such behavious can be easily crafted and integrated into your model.

```
Using Numbers;

Number zero = new Zero();
Number decorated = new RaiseErrorNumberDecorator(zero);

decorated.Plus(zero); --> "System.Exception is raised."

```

