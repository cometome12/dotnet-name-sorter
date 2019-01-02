# dotnet-name-sorter
This is a simple .net core app that takes a text file of names and sort them by last name, then any given names and output them in the console as well as to a text file.

### Run
Clone the project, in the root directory, run <br>
```dotnet run --project ./NameSorter ./unsorted-names-list.txt``` <br>
This will takes in the sample txt file and generate a `sorted-names-list.txt` in the same directory and output the results in the terminal.
The test input is:
```
Janet Parsons
Vaughn Lewis
Adonis Julius Archer Shelby Nathan Yoder
Marin Alvarez
London Lindsey
Beau Tristan Bentley
Leo Gardner
Hunter Uriah Mathew Clarke Mikayla Lopez
Frankie Conner Ritter
```
The outcome would be:
```
Marin Alvarez
Adonis Julius Archer
Beau Tristan Bentley Hunter Uriah Mathew Clarke Leo Gardner
Vaughn Lewis
London Lindsey
Mikayla Lopez
Janet Parsons
Frankie Conner Ritter Shelby Nathan Yoder
```

### Test
In the root directory, run <br>
```dotnet test``` <br>
There are two tests exist, one is check the args input number, the other one is to take in the `test-names-list.txt` and sorts the name, compare it with a list of string. Originally it should be:<br>
```
Janet Wow Parsons
Janet Parsons
James Wob Parsons
Janet Wob Parsons
James Wow Parsons
John Parsons
John Pooobo
Wood Pooobo
Colin Wise
Ah Ara
Ba Aca Lava
```
It should return: <br>
```
{"Ah Ara", "Ba Aca Lava", "James Wob Parsons", "James Wow Parsons", "Janet Parsons", "Janet Wob Parsons", "Janet Wow Parsons", "John Parsons", "John Pooobo", "Wood Pooobo","Colin Wise"}
```
