# Changelog

## Espresso v1.1.0 (In-Progress)

- Supports unary operators: percent (`%`) and factorial (`!`)
- Supports trigonometry functions: 
  - `sin`, `cos`, `tan`
  - The reciprocals: `csc`, `sec`, `cot`
  - The inverses: `asin` or `arcsin`,  `acos` or `arccos`,  `atan` or `arctan`
  - The reciprocals of the inverses: `acsc` or `arccsc`, `asec` or `arcsec`, `acot` or `arccot`
  - The hyperbolics of above: `sinh`, `cosh`, `tanh` ; `csch`, `sech`, `coth` ; `asinh` or `arcsinh`,  `acosh` or `arccosh`,  `atanh` or `arctanh` ; `acsch` or `arccsch`, `asech` or `arcsech`, `acoth` or `arccoth`
- Supports exponential functions: exponential (`exp`), logarithm (`log(a)` for base 10 and `log(a, base)`), base 2 logarithm (`log2`), and base e logarithm (`ln`).
- Supports statistical functions: 
  - Maximum (`max`), minimum (`min`), and range (`range`)
  - "typical" values: average or arithmetic mean (`avg` or `average` or `mean`), geometric mean (`geomean`), harmonic mean (`harmean`), median (`med`)
- Suppoers constants: Euler's constant (`e`), Pi (`pi` or `π`)
- Supports floats without decimal, e.g., `.25`
- Added syntax: `×` for multiplication, `÷` for division, `−` for subtraction and negative sign.
- Rename method Expression.Eval() to `Expression.Evaluate()`
- Fixed exponential and power parsing orders
- Now using Math.NET Numerics to evaluate functions!

## Espresso v1.0.1

- Fixed exponential in parentheses parsing error
- Added ANTLR4 dependency to build file

## Espresso v1.0

- Supports binary operators: exponentiation (power; `^`), modulo (`%`), multiplication (`*`), division (`/`), addition (`+`), and subtraction (`-`)
- Supports positive/negative signs unary operators for expressions e.g., `+4`, `-2`, `-(5*3)`
- Supports parentheses (`( )`)
- Supports exponential notation e.g., `2E3`, `3E8`
