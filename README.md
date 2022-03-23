# Espresso <!-- omit in toc -->

Espresso is a mathematical expression evaluator in .NET based on ANTLR4.

</br>

## Quick Start

```CSharp
using Espresso;

Expression expression = new ("3E2+3*2^(1+1)");
double result = expression.Eval();
Debug.Assert(result == 312);
```

## Table Of Content <!-- omit in toc -->

- [Quick Start](#quick-start)
- [Summary](#summary)
  - [Operators](#operators)
- [Values](#values)
- [Basic Arithmetic Operations](#basic-arithmetic-operations)
  

## Summary

---

### Operators

---

Listed from higher priority to lower priority

Operator | Description | Usage
|---|---|---|
|Standard Operators|
`^` | exponentiation (power) | `exp ^ exp`
`E` | exponential notation | `exp E exp`
`%` | modulo or percentage | `exp % exp` or `exp%`
`!` | factorial | `exp!`
`*` or `×` | multiplication | `exp * exp`
`/` or `÷` | division | `exp / exp`
`+` | positive sign or addition | `+exp` or `exp + exp`
`-` or `−` | negative sign or subtraction | `-exp` or `exp - exp`
|\* exp; expression|

## Values

---

Espresso suppports **exponential notation** and **floats**, both are handled as double.

```
.2 &nbsp; *is equivalent to* &nbsp; 0.2  
\>\> 0.2
```

```
2E3  
\>\> 2000  
2E3E2  
\>\> 2E+300
```

Note that exponential notation is right-associative i.e, evaluates from right to left.

&nbsp;

## Basic Arithmetic Operations

---

Espresso follows standard order of evaluation and supports overriding order with **parentheses**.  
Espresso can and will ignore whitespaces, including `\n`, `\r\n`, `\t`, and `\u000C`.  

```
5 + 1 - 2 * 3 / 4 % 5 &nbsp; *is equivalent to* &nbsp; 5 + (1 - (2 * (3 / (4 % 5))))
```

```
2^3^2 &nbsp; *is equivalent to* &nbsp; 2^(3^2)  
\>\> 512
```

Note that exponentiation operator (`^`) is right-associative i.e, evaluates from right to left.
