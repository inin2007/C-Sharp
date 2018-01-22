* Primary

|||
|-|-|
|`x.m`:|Member access|
|`x(...)`:|Method and delegate invocation|
|`x[...]`:|Array and indexer access|
|`x++`:|Post-increment|
|`x--`:|Post-decrement|
|`new T(...)`:|Object and delegate creation|
|`new T(...){...}`:|Object creation with initializer |
|`new {...}`:|Anonymous object initializer |
|`new T[...]`:|Array creation |
|`typeof(T)`:|Obtain Type object for `T` |
|`checked(x)`:|Evaluate expression in checked context |
|`unchecked(x)`:|Evaluate expression in unchecked context |
|`default(T)`:|Obtain default value of type `T` |
|`delegate {...}`:|Anonymous function (anonymous method) |

* Unary

|||
|-|-|
|`+x`:|Identity|
|`-x`:|Negation |
|`!x`:|Logical negation |
|`~x`:|Bitwise negation|
|`++x`:|Pre-increment|
|`--x`:|Pre-decrement|
|`(T)x`:|Explicitly convert `x` to type `T`|
|`await x`:|Asynchronously wait for `x` to complete|

* Multiplicative

|||
|-|-|
|`x * y`:|Multiplication|
|`x / y`:|Division |
|`x % y`:|Remainder |

* Additive

|||
|-|-|
|`x + y`:|Addition, string concatenation, delegate combination|
|`x – y`:|Subtraction, delegate removal |

* Shift

|||
|-|-|
|`x << y`:|Shift left|
|`x >> y`:|Shift right|

* Relational and type testing

|||
|-|-|
|`x < y`:|Less than|
|`x > y`:|Greater than|
|`x <= y`:|Less than or equal|
|`x >= y`:|Greater than or equal|
|`x is T`:|Return `true` if `x` is a `T`, `false` otherwise|
|`x as T`:|Return `x` typed as `T`, or `null` if `x` is not a `T`|

* Equality

|||
|-|-|
|`x == y`:|Equal|
|`x != y`:|Not equal|

* Logical AND

|||
|-|-|
|`x & y`:|Integer bitwise AND, boolean logical AND|

* Logical XOR

|||
|-|-|
|`x ^ y`:|Integer bitwise XOR, boolean logical XOR|

* Logical OR

|||
|-|-|
|`x | y`:|Integer bitwise OR, boolean logical OR|

* Null coalescing

|||
|-|-|
|`x ?? y`:|Evaluates to `y` if `x` is null, to `x` otherwise|

* Conditional

|||
|-|-|
|`x ? y : z`:|Evaluates `y` if `x` is true, `z` if `x` is `false`|

* Assignment or anonymous function

|||
|-|-|
|`x = y`:|Assignment|
|`x op= y`:|Compound assignment; supported operators are `*=` `/=` `%=` `+=` `-=` `<<=` `>>=` `&=` `^=` ``|=`|
