# League Standings 

## How to run the project

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (Make sure the version is compatible with the application)
- [Git](https://git-scm.com/downloads) (for version control)
- [Visual Studio](https://visualstudio.microsoft.com/) (Recommended) or [Visual Studio Code](https://code.visualstudio.com/) with the C## extension

### Clone the Repo

If you haven't already, clone the repository to your local machine.

```bash
git clone https://github.com/JacoboDB/StandingsChallenge.git
```

### Build the Application

```bash
cd Standings
dotnet build
```

### Run the Application

Once the application is built, you can run it using the following command:

```bash
cd Standings/Standings
dotnet run
```

Alternatively, you can run the compiled executable directly from the bin folder:

```bash
cd bin/Debug/net8.0
./Standings.exe   ## Windows
./Standings    ## macOS/Linux
```

## Challenge

### The problem

Create command-line application that will calculate the ranking table for a league.

### Input/output

The input and output will be text. Either using stdin/stdout or taking filenames on the command
line is fine.
The input contains results of games, one per line. See next for details.

```bash
Lions 3, Snakes 3
Tarantulas 1, FC Awesome 0
Lions 1, FC Awesome 1
Tarantulas 3, Snakes 1
Lions 4, Grouches 0
```

The output should be ordered from most to least points, following the format specified in next line.

```bash
1. Tarantulas, 6 pts
2. Lions, 5 pts
3. FC Awesome, 1 pt
3. Snakes, 1 pt
5. Grouches, 0 pts
```

### The rules

In this league, a draw (tie) is worth 1 point and a win is worth 3 points. A loss is worth 0 points.
If two or more teams have the same number of points, they should have the same rank and be
printed in alphabetical order (as in the tie for 3rd place in the sample data).