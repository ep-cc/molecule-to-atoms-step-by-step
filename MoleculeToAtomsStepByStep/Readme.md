# Steps

## Step 1.

Molecule strings only contain capital letters, one atom is always one letter. We need to count the 
occurrences of different letters.

### Examples
| input | output |
| --- | --- |
| "" | {} |
| "HHH" | { "H": 3 } | 




# How to run tests

- All: `dotnet test` inside the solution folder
- Some:
    - `dotnet test --filter "Name=TestSingleCharacter"`
    - `dotnet test --filter "FullyQualifiedName=MoleculeToAtomsStepByStep.Step1.TestSingleCharacter"`