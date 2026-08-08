W05 Interview Video Script – Recursion Pitfalls 

Introduction (10-15 seconds) 

  

Hi there. I am Faith. In this video, I will discuss two pitfalls of recursion and how to avoid them. Furthermore, I will briefly explain why recursion is a good programming approach if used properly. 

  

Question 1: Stack Overflow (About 1 minute) 

  

One of the most common pitfalls of recursion is stack overflow. 

  

In order for a function to work recursively, it should keep calling itself until the base case occurs. This will stop the function. If there is no base case or the base case is wrong, the function will go into an infinite loop and continue calling itself. When too many function calls happen in the call stack, the program will run out of memory and crash due to stack overflow. 

  

In order to prevent this problem, I will ensure that the recursive function has the right base case and that each recursion step brings the function closer to the base case. For problems that need very many recursive calls, I will use an iterative approach with loops. 

 

Question 2: Poor Performance (Approximately 1 minute) 

  

The second issue is poor performance because of multiple computations. 

  

There exist recursive algorithms that compute the same sub-problem more than once. A typical example is the recursive computation of the Fibonacci sequence, during which the same Fibonacci numbers are computed again. As a result, such an algorithm becomes inefficient, and the execution time increases substantially. 

  

The first approach to overcoming this problem is memorization, where the already-computed results are stored for future use. The second approach is dynamic programming, which means constructing the solution of the problem from solutions to its sub-problems. Sometimes, it is possible to rewrite the recursion as an iterative algorithm. 

  

Conclusion (10-15 seconds) 

  

In conclusion, the technique of recursion is very effective for solving complicated tasks, dividing them into simple sub-problems. Nonetheless, developers need to be careful about stack overflow and poor performance issues. Using a correct base case, the progress towards it, as well as memorization, dynamic programming, or iteration approaches, when necessary, will help to make recursion efficient and reliable.