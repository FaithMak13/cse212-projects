Question 1: What is an advantage of dynamic arrays?

One advantage of a dynamic array is that it can automatically increase in size when more space is needed.

For example:

Suppose I have a list of student names.

A static array might be created like this:

Student Names:
[Alice] [Bob] [Carol]

Its size is 3. If another student named David joins the class, there is no room to add him. I would have to create a new, larger array and copy all the names into it.

With a dynamic array, I can simply add David:

Before:
[Alice] [Bob] [Carol]

After:
[Alice] [Bob] [Carol] [David]

The dynamic array automatically grows, making it much easier to work with data when I don't know how many items I'll need.

Question 2: What is a disadvantage of dynamic arrays?

One disadvantage is that when a dynamic array becomes full, it must create a larger array and copy all the existing data into the new one. This takes extra time and memory.

For example:

Suppose the dynamic array can hold only 4 numbers.

[10] [20] [30] [40]

Now I want to add 50.

The dynamic array must:

Create a new, larger array.
New Array:
[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]
Copy the old values.
[10] [20] [30] [40] [ ] [ ] [ ] [ ]
Add the new value.
[10] [20] [30] [40] [50] [ ] [ ] [ ]

Although this happens automatically, copying all the data takes extra processing time compared to a static array.

Conclusion

In summary, dynamic arrays are more flexible because they can grow as needed, making them ideal when the amount of data is unknown. Static arrays are more efficient because they do not need to resize, but their size cannot be changed after they are created.

Thank you.