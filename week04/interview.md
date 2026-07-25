W04 Interview Video Script 

Introduction (10–15 seconds) 

Hello everyone. My name is Faith. In this video, I'll explain how I would use a linked list to implement a stack and a queue. I'll also explain the time complexity for each operation. 

 

Question 1: Using a Linked List to Implement a Stack (About 1½ minutes) 

A stack works using the Last In, First Out, or LIFO, principle. This means the last item added is the first item removed. 

To implement a stack using a linked list, I would use the head of the linked list as the top of the stack. This is the most efficient approach because adding or removing the head does not require moving through the rest of the list. 

Operations 

Push means adding a new item to the top of the stack. I would insert the new node at the head of the linked list. This takes O(1) time because it only changes a few pointers. 

Pop means removing the top item from the stack. I would remove the head node and update the head to point to the next node. This also takes O(1) time. 

GetTop returns the value at the top of the stack without removing it. Since the top is always the head node, this takes O(1) time. 

IsEmpty checks whether the stack has any elements. I simply check if the head is null. This also takes O(1) time. 

 

Question 2: Using a Linked List to Implement a Queue (About 1½ minutes) 

A queue works using the First In, First Out, or FIFO, principle. This means the first item added is the first item removed. 

To implement a queue efficiently, I would keep both a head pointer and a tail pointer. The head points to the front of the queue, and the tail points to the end. 

Operations 

Enqueue means adding a new item to the end of the queue. I would add the new node after the tail and then move the tail pointer to the new node. This takes O(1) time. 

Dequeue means removing the item at the front of the queue. I would remove the head node and move the head pointer to the next node. This also takes O(1) time. 

Size returns the number of elements in the queue. If I keep a counter that is updated whenever items are added or removed, getting the size takes O(1) time. 

IsEmpty checks whether the queue contains any elements. I simply check whether the head is null, so this also takes O(1) time. 

 

Conclusion (10–15 seconds) 

In summary, using a linked list is an efficient way to implement both a stack and a queue. Most operations take O(1) time because they only involve updating the head, the tail, or a counter, without needing to go through the entire list. Thank you for watching. 

 

Quick Memory Tips 

Stack = LIFO 

Push → Add at the head → O(1)  

Pop → Remove from the head → O(1)  

GetTop → Look at the head → O(1)  

IsEmpty → Check if head is null → O(1)  

Queue = FIFO 

Enqueue → Add at the tail → O(1)  

Dequeue → Remove from the head → O(1)  

Size → Return the counter → O(1)  

IsEmpty → Check if head is null → O(1) 