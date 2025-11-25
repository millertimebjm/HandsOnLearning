# Magic Strings

## Solution

1. Create a new enum for the four types of cards
1. Update all occurrences of the magic strings of card types to the enum
1. Change the GetSymbol parameter to the enum type
1. Fix the tests to use the enum, notice you don't need the "Nonexistant card type test" because it's not an enum value
1. Bonus if you replaced CLI with either a variable for multiple uses, or a loop over each enum value