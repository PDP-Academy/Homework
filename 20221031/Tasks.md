# Tasks

## Task 1
- 1. Write a program that creates an array of 100 Tasks, runs them and waits till all of them are completed. Each Task should iterate from 1 to 1000 and print to the console the following string:
"Task #0 – {iteration number}".

## Task 2. 
Create a program that recursively creates 10 threads. Each thread should be with the same body and receive a state with an integer number, decrement it, print and pass as a state into the newly created thread. Implement all the following options:
- Use Thread class for this task and Join for waiting threads.

## Task 3.
Write a program that creates two threads and a shared collection:
- The 1st task should add 10 elements to the collection
- The 2nd task should print all elements in the collection after each adding (in other words, if the collection contains elements from 1 to 10, the second thread should print something like [1], [1, 2], [1, 2, 3], …, [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], the number of elements should increase).
