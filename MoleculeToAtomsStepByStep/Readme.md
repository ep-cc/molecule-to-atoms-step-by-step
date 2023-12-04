# Steps

## Step 1.

Molecule strings only contain capital letters, one atom is always one letter. We need to count the 
occurrences of different letters.

### Examples
| input | output |
| --- | --- |
| "" | {} |
| "HHH" | { "H": 3 } | 

## Step 2.

Molecule strings only contain capital letters and digits. If a single digit follows a letter,
it is a multiplier.

### Examples
| input | output |
| --- | --- |
| "H2O" | { "H": 2, "O": 1 } | 
| "H2O3H4" | { "H": 6, "O": 3 } |
| "CHNO" | { "C": 1, "H": 1, "N": 1, "O": 1 } |






# How to run tests

- All: `dotnet test` inside the solution folder
- Some:
    - `dotnet test --filter "Name=TestSingleCharacter"`
    - `dotnet test --filter "FullyQualifiedName=MoleculeToAtomsStepByStep.Step1.TestSingleCharacter"`