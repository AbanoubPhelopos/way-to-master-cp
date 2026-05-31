# 📁 01 — Recursion & Backtracking

This module covers the foundational techniques of **Recursion** and **Backtracking** — the building blocks for solving problems that involve exploring decision spaces, breaking problems into smaller subproblems, and systematically searching for solutions.

---

## 🔄 What is Recursion?

**Recursion** is a technique where a function calls itself to solve smaller instances of the same problem, until it reaches a **base case** that can be solved directly.

Every recursive solution has two essential parts:

| Part            | Role                                                     |
| :-------------- | :------------------------------------------------------- |
| **Base Case**   | The simplest instance — stops the recursion               |
| **Recursive Case** | Breaks the problem into a smaller subproblem and recurses |

### How Recursion Works — Call Stack

When a recursive function is called, each call is pushed onto the **call stack**. Once a base case is reached, the calls begin returning (unwinding) in reverse order.

```mermaid
flowchart TD
    classDef default fill:#1a1b26,stroke:#7aa2f7,stroke-width:2px,color:#c0caf5
    classDef base fill:#2d6a4f,stroke:#95d5b2,stroke-width:2px,color:#d8f3dc,font-weight:bold
    classDef arrow fill:none,stroke:none,color:#565f89

    A["factorial(4)"] --> B["factorial(3)"]
    B --> C["factorial(2)"]
    C --> D["factorial(1)"]
    D --> E["return 1 ✅"]:::base

    E -- "× 2 = 2" --> F["return 2"]:::base
    F -- "× 3 = 6" --> G["return 6"]:::base
    G -- "× 4 = 24" --> H["return 24"]:::base
```

### Example — Factorial

```csharp
static int Factorial(int n)
{
    if (n <= 1) return 1;       // Base case
    return n * Factorial(n - 1); // Recursive case
}
```

### Common Recursion Patterns

| Pattern                  | Description                                      | Example                    |
| :----------------------- | :----------------------------------------------- | :------------------------- |
| **Linear Recursion**     | One recursive call per level                     | Factorial, LinkedList walk |
| **Binary Recursion**     | Two recursive calls per level (binary tree)      | Fibonacci, Merge Sort      |
| **Multiple Recursion**   | More than two calls per level                    | Generating permutations    |
| **Tail Recursion**       | Recursive call is the last operation             | Optimizable by compilers   |

---

## 🔙 What is Backtracking?

**Backtracking** is a refined form of recursion used to solve **constraint satisfaction** and **combinatorial search** problems. It builds solutions incrementally, and **abandons (backtracks)** a path as soon as it determines that path cannot lead to a valid solution.

### The Core Idea

```
1. CHOOSE   → Make a choice (pick an option)
2. EXPLORE  → Recurse with that choice
3. UNCHOOSE → Undo the choice (backtrack) and try the next option
```

### Decision Tree — Backtracking with Pruning

Consider finding all subsets of `{1, 2, 3}`. At each element, we decide: **include it** or **skip it**. Backtracking explores this tree, pruning invalid branches early.

```mermaid
graph TD
    classDef default fill:#1a1b26,stroke:#7aa2f7,stroke-width:2px,color:#c0caf5
    classDef leaf fill:#24283b,stroke:#bb9af7,stroke-width:2px,color:#bb9af7,font-weight:bold
    classDef pruned fill:#6c1d1d,stroke:#e76f6f,stroke-width:2px,color:#ffdada

    ROOT["{ }"] --> A1["Include 1"]
    ROOT --> A2["Skip 1"]

    A1 --> B1["Include 2"]
    A1 --> B2["Skip 2"]
    A2 --> B3["Include 2"]
    A2 --> B4["Skip 2"]

    B1 --> C1["Include 3 → {1,2,3}"]:::leaf
    B1 --> C2["Skip 3 → {1,2}"]:::leaf
    B2 --> C3["Include 3 → {1,3}"]:::leaf
    B2 --> C4["Skip 3 → {1}"]:::leaf
    B3 --> C5["Include 3 → {2,3}"]:::leaf
    B3 --> C6["Skip 3 → {2}"]:::leaf
    B4 --> C7["Include 3 → {3}"]:::leaf
    B4 --> C8["Skip 3 → { }"]:::leaf
```

### Backtracking Template

```csharp
static void Backtrack(List<int> current, int start, int[] options)
{
    // Process or record the current solution
    ProcessSolution(current);

    for (int i = start; i < options.Length; i++)
    {
        // 1. CHOOSE
        current.Add(options[i]);

        // 2. EXPLORE
        Backtrack(current, i + 1, options);

        // 3. UNCHOOSE (backtrack)
        current.RemoveAt(current.Count - 1);
    }
}
```

---

## 🔄 vs 🔙 Recursion vs Backtracking

```mermaid
flowchart LR
    classDef rec fill:#1a1b26,stroke:#7aa2f7,stroke-width:3px,color:#c0caf5,font-weight:bold
    classDef bt fill:#24283b,stroke:#f7768e,stroke-width:3px,color:#f7768e,font-weight:bold

    R["🔄 Recursion"]:::rec
    B["🔙 Backtracking"]:::bt

    R -- "is the mechanism" --> B
    B -- "adds pruning &\nchoice undoing to" --> R
```

| Aspect           | Recursion                          | Backtracking                            |
| :--------------- | :--------------------------------- | :-------------------------------------- |
| **Purpose**      | Solve subproblems                  | Search for valid configurations         |
| **Exploration**  | Explores all subproblems           | Prunes invalid branches early           |
| **State**        | Usually implicit (parameters)      | Explicit (choose → explore → unchoose)  |
| **When to use**  | Problem decomposes naturally       | Need to find/count valid arrangements   |

---

## 📂 Sheets & Practice

| Sheet                                                | Description                     |
| :--------------------------------------------------- | :------------------------------ |
| 📁 [acm-level-2-sheet](acm-level-2-sheet/)          | ACM Level 2 practice problems   |
