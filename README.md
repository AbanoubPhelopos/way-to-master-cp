# 🚀 Way to Master CP (Competitive Programming)

<table align="center" border="0" cellpadding="10" cellspacing="0" width="100%">
  <tr>
    <td width="60%" valign="top" style="border: none;">
      <p>
        Welcome to the ultimate <strong>Way to Master CP</strong> roadmap and solution archive! 
        This repository tracks my journey in solving challenging problems on <strong>Codeforces</strong> and <strong>VJudge</strong> using <strong>C#</strong>. 
      </p>
      <p>
        🎯 <strong>Goal:</strong> Master core algorithms, advanced data structures, and mathematical concepts required for competitive programming and high-performance problem solving.
      </p>
      <h3>🔗 Connect & Follow</h3>
      <ul>
        <li>
          <strong>Codeforces:</strong> 
          <a href="https://codeforces.com/profile/__PoP__">__PoP__</a>
        </li>
        <li>
          <strong>VJudge:</strong> 
          <a href="https://vjudge.net/user/uncle_pop">uncle_pop</a>
        </li>
        <li>
          <strong>LinkedIn:</strong> 
          <a href="https://www.linkedin.com/in/abanoub-saweris/">abanoub-saweris</a>
        </li>
        <li>
          <strong>Email:</strong> 
          <a href="mailto:abanoub.saweris02@gmail.com">abanoub.saweris02@gmail.com</a>
        </li>
        <li>
          <strong>Phone:</strong> 
          <code>+20 1274782728</code>
        </li>
      </ul>
    </td>
    <td width="40%" valign="top" style="border: none;">
      <img src="assets/banner.png" alt="Way to Master CP Banner" width="100%" style="border-radius: 10px; box-shadow: 0 4px 20px rgba(0,0,0,0.3);">
    </td>
  </tr>
</table>

---

## 🗺️ Topic Progression Roadmap

Here is the learning path and relationship between the topics covered in this repository:

```mermaid
flowchart LR
    %% Styling Definitions
    classDef default fill:#1a1b26,stroke:#7aa2f7,stroke-width:2px,color:#c0caf5;
    classDef startNode fill:#24283b,stroke:#bb9af7,stroke-width:3px,color:#bb9af7,font-weight:bold;
    classDef endNode fill:#24283b,stroke:#f7768e,stroke-width:3px,color:#f7768e,font-weight:bold;

    %% Nodes
    R["01. Recursion & Backtracking"]:::startNode
    G["02. Graph"]
    N["03. Number Theory"]
    C["04. Combinatorics"]
    DP["05. Dynamic Programming"]:::endNode

    %% Relationships
    R --> G
    G --> DP
    N --> C
    C --> DP
```

---

## 📚 Curriculum & Track Structure

Rather than packing all sheets and contests in this main README, the repository is organized hierarchically. Each topic folder contains its own localized documentation, and every problem is fully self-documented.

### Directory Structure Layout

Here is how the directory structure is organized:

```text
src/
├── 01-RecursionAndBacktracking/
│   ├── README.md               <-- Main topic overview, sheets list & links
│   └── Sheet_01/               <-- Folder for a specific sheet/practice
│       └── Problem_A/          <-- Folder for a specific problem
│           ├── Solution.cs     <-- C# Solution Code
│           └── README.md       <-- Problem statement link & solution explanation
│
├── 02-Graph/
│   ├── README.md
│   ...
```

### Track Overview

| Target Folder                                                          | Description                                                                                 |
| :--------------------------------------------------------------------- | :------------------------------------------------------------------------------------------ |
| 📁 **[01-RecursionAndBacktracking](src/01-RecursionAndBacktracking/)** | Recursion, Backtracking & Search space exploration.                                         |
| 📁 **[02-Graph](src/02-Graph/)**                                       | Graph Traversals (DFS, BFS), Shortest Paths (Dijkstra), MST, and Support helper structures. |
| 📁 **[03-NumberTheory](src/03-NumberTheory/)**                         | Primality testing, Sieve, GCD/LCM, Modular Arithmetic.                                      |
| 📁 **[04-Combinatorics](src/04-Combinatorics/)**                       | Permutations, Combinations, and Counting principles.                                        |
| 📁 **[05-DynamicProgramming](src/05-DynamicProgramming/)**             | Iterative & Recursive DP optimization techniques.                                           |

---

## 🛠️ Project Structure & C# Environment

This repository is configured as a standard `.NET 10` solution, allowing easy building, execution, and local debugging.

### Prerequisites

Ensure you have the **.NET SDK 10** installed:

- [Download .NET SDK](https://dotnet.microsoft.com/download)

### How to Run Solutions

Since each problem has its own `solution.cs` with top-level statements, the project uses an **MSBuild property** to select which solution to compile and run. All `solution.cs` files are excluded from compilation by default — you pass the path of the one you want to run.

#### Step-by-step

1. Clone the repository:

   ```bash
   git clone https://github.com/AbanoubPhelopos/way-to-master-cp.git
   cd way-to-master-cp
   ```

2. Run a **specific** solution by passing its path (relative to `src/`) via `-p:Solution=`:

   ```bash
   dotnet run --project src/WayToMasterCP.csproj \
     -p:Solution="01-RecursionAndBacktracking/acm-level-2-sheet/Gold Rush/solution.cs"
   ```

3. Pipe input for automated testing:

   ```bash
   echo "3
   6 4
   9 4
   4 2" | dotnet run --project src/WayToMasterCP.csproj \
     -p:Solution="01-RecursionAndBacktracking/acm-level-2-sheet/Gold Rush/solution.cs"
   ```

#### How it works

```mermaid
flowchart LR
    classDef default fill:#1a1b26,stroke:#7aa2f7,stroke-width:2px,color:#c0caf5
    classDef highlight fill:#24283b,stroke:#bb9af7,stroke-width:3px,color:#bb9af7,font-weight:bold

    A[".csproj excludes all solution.cs"]:::default
    B["-p:Solution=path includes ONE file"]:::highlight
    C["dotnet run compiles & executes it"]:::default

    A --> B --> C
```

> **💡 Tip:** The `Solution` path is **relative to `src/`** (the folder where `WayToMasterCP.csproj` lives). You only need the path starting from the topic folder.
