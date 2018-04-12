# Find Maximum Value Binary Tree

**Author**: Arthur Allen

**Version**: 1.0.0 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Exercise in traversing a binary tree and finding the maximum value

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017

## Example
<!-- Show them what looks like and how to use the application.  -->
Hard coded example, unit tests

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
Using the standard in-order tree traversal, look at each node and compare them to a candidate variable.  If the particular node is higher than the candidate node, the candidate is set to this higher value.  At the end of the search, the candidate variable should have the highest value.  Seed the candidate with a value from the tree.  This is in case all the values in the trees are negative numbers.  If seeded with zero, that number would return as the highest number, and it would be impractical to find a sufficiently low negative number to seed it otherwise.
Whiteboard:
![alt = ""](/../../data-structures-and-algorithms/assets/find-maximum-value.jpg)

## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
04-12-2018 8:30am - Project written.  Need to add unit tests.
04-12-2018 9:00am - All tests work.  Pushing up.