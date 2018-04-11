# Breadth-First Traversal

**Author**: Arthur Allen

**Version**: 1.0.0 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Exercise in making a breadth-first traversal of a tree.

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017

## Example
<!-- Show them what looks like and how how to use the application.  -->
Hard coded examples

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
<!-- One of these ought to work -->
!(\..\data-structures-and-algorithms\assets\breadth-first-traversal.jpg)
!(\..\..\data-structures-and-algorithms\assets\breadth-first-traversal.jpg)
!(\..\..\..\data-structures-and-algorithms\assets\breadth-first-traversal.jpg)
!(/../data-structures-and-algorithms/assets/breadth-first-traversal.jpg)
!(/../../data-structures-and-algorithms/assets/breadth-first-traversal.jpg)
!(/../../../data-structures-and-algorithms/assets/breadth-first-traversal.jpg)
To do a breadth-traversal of a tree, this program starts at the root, and enqueues it onto a queue.  Then we use a while loop that runs until the queue is empty.  The value from the current node is printed.  If the node on the queue has left and/or right children nodes, they are enqueued onto the queue, and the node just printed is dequeued.


## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
01-10-2018 1:30pm - Project started.
01-10-2018 8:30pm - Project built out, but still doen't work.  I'm having trouble enqueueing data from the tree onto a queue so I can run the program.
01-10-2018 9:00pm - The problem is traced to the original construction of queues several weeks ago.  Unless the last item on the list is explicitly pointed to null, the dequeue goes on an infinite loop.  There is no way so far to dynamically enter a null to whatever node is last on the list.