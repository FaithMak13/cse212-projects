Interview Video Script 

Introduction (10–15 seconds) 

Hello everyone. My name is Faith. In this video, I'll explain how I would write a function to find the intersection and the union of two sets without using the built-in methods. I'll explain my approach, walk through how each function works, discuss the time complexity, and share three test cases for each. 

 

Question 1: Finding the Intersection of Two Sets 

To find the intersection of two sets, my goal is to return only the elements that appear in both sets. 

My approach is to create an empty result set. Then I go through each element in the first set. For every element, I check if it also exists in the second set. If it does, I add it to the result set. Because a set only stores unique values, I don't have to worry about duplicates. 

Step-by-step 

First, I create an empty result set. 

Next, I look at each element in the first set one at a time. 

For each element, I check whether it exists in the second set. 

If it does, I add it to the result set. 

After I've checked every element, I return the result set, which contains only the elements that both sets have in common. 

Big O Performance 

The membership check in a set is typically very fast, taking constant time, or O(1). Since I only loop through the first set once, the overall time complexity is O(n), where n is the number of elements in the first set. 

Test Cases 

My first test case uses a first set containing 1, 2, 3, and 4, and a second set containing 3, 4, 5, and 6. I expect the result to contain 3 and 4, because those are the elements that appear in both sets. 

My second test case uses a first set containing 10, 20, and 30, and a second set containing 40, 50, and 60. Since there are no common elements, I expect the result to be an empty set. 

My third test case uses an empty first set and a second set containing 1, 2, and 3. Since one of the sets is empty, I expect the result to also be an empty set. 

 

Question 2: Finding the Union of Two Sets 

To find the union of two sets, my goal is to return every unique element that appears in either set. 

My approach is to create an empty result set. First, I add every element from the first set. Then I add every element from the second set. Since sets automatically ignore duplicates, each value will appear only once in the final result. 

Step-by-step 

First, I create an empty result set. 

Then I add every element from the first set. 

Next, I add every element from the second set. 

Finally, I return the result set, which now contains every unique element from both sets. 

Big O Performance 

I only loop through each set once, and adding an element to a set usually takes constant time, or O(1). Because of that, the overall time complexity is O(n + m), where n is the number of elements in the first set and m is the number of elements in the second set. 

Test Cases 

My first test case uses a first set containing 1, 2, and 3, and a second set containing 3, 4, and 5. I expect the result to contain 1, 2, 3, 4, and 5, because the union includes every unique element from both sets. 

My second test case uses two sets that both contain 7 and 8. I expect the result to contain 7 and 8, because duplicate values are only stored once. 

My third test case uses an empty first set and a second set containing 9 and 10. I expect the result to contain 9 and 10, because the union includes all elements from both sets. 

 

Conclusion (10 seconds) 

In summary, both functions are efficient because they make good use of the properties of sets. The intersection function returns only the elements that both sets have in common, while the union function returns every unique element from both sets. These approaches are efficient, easy to understand, and have time complexities of O(n) for the intersection and O(n + m) for the union. 