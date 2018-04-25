# K-ary Tree

**Author**: Arthur Allen

**Version**: 1.0.0 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Exercise in creating a k-ary tree

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017

## Example
<!-- Show them what looks like and how how to use the application.  -->
Hard-coded examples

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
A k-ary tree is a tree which has nodes of any number of children.  The children here are represented by a list.  As a demonstration, this program does a breadth-first traversal, and inserts nodes.  A breadth-first traversal pushes each found child onto a stack so that the children can be found again to traverse their children, and so on.

## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
04-23-2018 7:41pm - Project started by copying over code from the Binary Tree data structure project.
04-24-2018 9:30pm - Made some headway in fixing my queue logic, but I'm running into other problems.  The test for if a queue is empty is if head is null, but I don't know how to do that.  Currently runs an infinite loop.