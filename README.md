CS 435 C# Program – Simple To-Do List

Purpose:
This console application lets the user manage a basic in-memory to-do list. You can add tasks, view all tasks with their completion status, mark tasks as complete, and remove tasks. It demonstrates C# fundamentals: console I/O, Lists, classes, and control flow.

Sample Data Used for Testing:
1) Start the program (no tasks shown).
2) Add three tasks:
   - “Buy groceries”
   - “Finish report”
   - “Call Alice”
3) Mark task #2 complete.
4) Remove task #1.

Expected Console Sequence:
=== To-Do List ===
 (no tasks yet)

Menu:
 1) Add task
 2) Mark complete
 3) Remove task
 4) Exit

[After adding tasks]
=== To-Do List ===
 1. [ ] Buy groceries
 2. [ ] Finish report
 3. [ ] Call Alice

[After marking #2 complete]
=== To-Do List ===
 1. [ ] Buy groceries
 2. [✓] Finish report
 3. [ ] Call Alice

[After removing #1]
=== To-Do List ===
 1. [✓] Finish report
 2. [ ] Call Alice
