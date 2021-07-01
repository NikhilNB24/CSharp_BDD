Feature: Calculator
	Simple calculator for adding two numbers

Scenario: Add two numbers
	Given the first number is <num1>
	And the second number is <num2>
	When the two numbers are added
	Then the result should be <output>

	Examples:
	| num1 | num2 | output |
	|  10  |  10  |   20   |
	|  05  |  00  |   05   |
	|  27  |  14  |   41   |

Scenario: Subtract two numbers
	Given the first number is <num1>
	And the second number is <num2>
	When the two numbers are subtracted
	Then the result should be <output>

	Examples:
	| num1 | num2 | output |
	|  35  |  15  |  20    |
	|  12  |  04  |  08    |
	|  55  |  55  |  00    |

Scenario: Multiply two numbers
	Given the first number is <num1>
	And the second number is <num2>
	When the two numbers are multiplied
	Then the result should be <output>

	Examples:
	| num1 | num2 | output |
	|  05  |  08  |   40   |
	|  06  |  06  |   36   |
	|  11  |  00  |   00   |


Scenario: Divide two numbers
	Given the first number is <num1>
	And the second number is <num2>
	When the two numbers are divided
	Then the result should be <output>

	Examples:
	| num1 | num2 | output |
	|  14  |  02  |   07   |
	|  57  |  03  |   19   |
	|  00  |  15  |   00   |