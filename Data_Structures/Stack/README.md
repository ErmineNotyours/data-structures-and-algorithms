# Stacks and Queues

**Author**: Arthur Allen

**Version**: 1.1.1 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Exercise for creating and working with stacks

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017

## Example
<!-- Show them what looks like and how to use the application.  -->
Hardcoded examples

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
A stack is a list where the first item entered is the last  item out (FILO).  The last item in is the first item out.  Declare the Stack type by pointing the head to the node.  A Push adds an item onto a stack.  Simply point this new node to what the head was pointing at, making that the next item.  Then point the head to this new node.  This is the same code used to Enqueue an item onto a queue.  A Peek looks at the top node without Popping it.  Simply return access to the Head node.  A Pop removes the node from the top of the list and returns it.  Use the Head to find this node.  Store it in a temporary node, so you can delete it, by setting the head to the location this top node was pointing to.  Then return the node in the method return.  Attempts to Pop an empty stack results in an exception being thrown.
A queue is a list where the first item entered is the first item removed (FIFO). Declare the MyQueue type and point it to the Head.  An Enqueue adds a node to the queue.  Simply point this new node to what the head was pointing at, making that the next item.  Then point the head to this new node.  This is the same code used to Push an item onto a stack.  A Dequeue removes an item from the list.  You have to traverse the list to find the last node, keeping track of the previous node along the way.  When you've reached the end, you have the last node and its previous node.  Store this current node so you can delete it and return it.  Set the current node to the memory location of the previous node.  Set the Next location of this new current node to null.  Now return the stored last/current node to the return state of the method.  If Enqueue encounters an empty queue, it will throw and excption, return null, and indicate that it can't be dequeued.


## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
04-02-2018 9:35am - Initial commit.
04-02-2018 8:15pm - Program works.  Try/catch used and unit tests, although CanDequeueEmpty2 is a rigged positive test.  It should equal null like CanPopEmpty2.
04-04-2018 9:35am - Seperate out the queue code per the instructions.  Write more details on the architecutre in the readme.
04-04-2018 10:23am - Rerefactor to reincorporate Queues back into this project.  Solved problem of non-working unit test CanDequeueEmpty2: point the last enqueued item to point to null.  Changed the Queue type to MyQueue due to conflicts in the unit test.
04-04-2018 10:36am - Changed name on top of readme to Stacks and Queues.