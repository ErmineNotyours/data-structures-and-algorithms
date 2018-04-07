# Binary Tree

**Author**: Arthur Allen

**Version**: 1.0.0 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
Demonstrates a binary tree construction and three traversal methods.

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Visual Studio 2017

## Example
<!-- Show them what looks like and how to use the application.  -->
Hard coded examples, unit tests.

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
The binary tree is constructed manually, with no Push method.  The contents of each node is put in when the node is declared, and the nodes are manually linked in the appropriate way. node1 is linked to node2 and node3, etc.
The in-order traversal is performed this way: 1. Check that the current node is empty or null. If not, traverse the left subtree by recursively calling the in-order method. 2. Display the data part of the root (or current node). 3. Check that the current node is empty or null.  If not, traverse the right subtree by calling the in-order method.
The pre-order traversal is performed this way: 1. Display the data part of the root (or current node). 2. Check if the current node is empty or null.  If not, traverse the left subtree by resursively calling the pre-order method. 3. Check if the current node is empty or null.  If not, traverse the right subtree by recursively calling the pre-order method.
The post-order traversal is performed this way: 1. Check if the current node is empty or null.  If not, traverse the left subtree by recursively calling the post-order method. 2. Check if the current node is empty or null.  If not, traverse the right subtree by recursively calling the post-order method. 3. Display the data part of the root (or current node.)

## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->
04-07-2018 1:55pm - Project built out.  Readme written with detailed archetecture.  Need to include unit tests.
04-07-2018 4:10pm -  Implimented unit tests.