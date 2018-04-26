# Print Level Order

**Author**: Arthur Allen

**Version**: 1.0.0 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Exercise in creating a level order printing of a K-ary Tree

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017

## Example
<!-- Show them what looks like and how how to use the application.  -->
Hard coded example

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
![Whiteboard Photo](PrintLevelOrder/assets/.jpg)
Written in C#, using built-in queue method.  Do a breadth-first traversal of a tree.  Seed a queue with the first node, and a flag node.  Then, while there is greater than one node in the queue (normally greater than zero, but you have to account for the flag node) dequeue a node, print the node's value without a carriage return, and enqueue the node's children.  If you encounter the flag (which has just been dequeued), reenqueue a new flag on the other end of the queue to flag the next carriage return.

## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
04-25-2018 5:43pm - Project started
04-25-2018 9:00pm - Project completed