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

## Step 3.

Atoms and counts can be longer than one letter.
- Atoms are either described by a single uppercase letter or an uppercase letter followed by a single lowercase letter.
- Numbers can have multiple digits.

### Examples
| input | output |
| --- | --- |
| "MgO2H2" | { "H": 2, "Mg": 1, "O": 2 } | 
| "NaCl" | { "Cl": 1, "Na": 1 } |
| "Na2CO3" | { "C": 1, "Na": 2, "O": 3 } |


# How to run tests from the command line

- All: `dotnet test` inside the solution folder
- Some:
    - `dotnet test --filter "Name=TestSingleCharacter"`
    - `dotnet test --filter "FullyQualifiedName=MoleculeToAtomsStepByStep.Step1.TestSingleCharacter"`