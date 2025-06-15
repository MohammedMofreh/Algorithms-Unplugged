# Algorithms Unplugged - Simple C# Demo

This is a simple C# Console Application demonstrating three fundamental algorithms from the book **Algorithms Unplugged**:

✅ **Binary Search**  
✅ **Insertion Sort**  
✅ **Merge Sort**

---

## 📌 What is implemented?

### 1️⃣ Binary Search

- Performs a fast search inside a **sorted array of strings** (CD names).
- Example: Finding a CD name in an alphabetically sorted list.

#### 🔍 Logic:

- Compare the middle element.
- If match, return index.
- Else move to left or right half recursively or iteratively.
- **Time complexity:** `O(log n)`.

---

### 2️⃣ Insertion Sort

- Sorts an array of integers using the **insertion sort algorithm**.
- Example: Sorting a small list of numbers.

#### 🔧 Logic:

- Start from the second element.
- Pick the current element (key).
- Shift larger elements to the right.
- Insert the key in its correct position.

#### ⏱️ Time complexity:
- Worst case: `O(n²)`
- Best case (sorted): `O(n)`
- Average: `O(n²)`

---

### 3️⃣ Merge Sort

- Sorts an array of integers using the **merge sort algorithm**.
- Example: Sorting a large dataset efficiently.

#### ⚙️ Logic (Divide & Conquer):

1. Divide the array into two halves.
2. Recursively sort both halves.
3. Merge them in sorted order.

#### ⏱️ Time complexity:
- Worst case: `O(n log n)`
- Best case: `O(n log n)`
- Stable sort ✅

---

## 📝 Example Output

```text
Found 'Nelly' at position 6.
Sorted array (Insertion Sort):
1 3 5 6 7 9 11

Sorted array (Merge Sort):
1 3 5 6 7 9 11
```

---

## 💡 Notes

- Binary Search works **only on sorted data**.
- Merge Sort is more efficient than Insertion Sort for **large datasets**.
- Insertion Sort is simple and good for **small or nearly sorted arrays**.

---
