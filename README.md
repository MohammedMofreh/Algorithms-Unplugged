# Algorithms Unplugged - Simple C# Demo

This is a simple C# Console Application demonstrating two fundamental algorithms from the book **Algorithms Unplugged**:

✅ **Binary Search**  
✅ **Insertion Sort**

---

## 📌 What is implemented?

### 1️⃣ Binary Search

- Performs a fast search inside a **sorted array of strings** (CD names).
- Example: Finding a CD name in an alphabetically sorted list.

#### Logic:

- Compare middle element.
- Move left or right accordingly.
- Time complexity: `O(log n)`.

---

### 2️⃣ Insertion Sort

- Sorts an array of integers using **insertion sort algorithm**.
- Example: Sorting a small list of numbers.

#### Logic:

- Pick the next element.
- Shift all greater elements to the right.
- Insert the picked element in the correct position.
- Time complexity:
  - Worst: `O(n²)`
  - Best: `O(n)` (already sorted list)

---

## 📝 Example Run

```text
Found 'Nelly' at position 6.
Sorted array:
1 3 5 6 7 9 11
