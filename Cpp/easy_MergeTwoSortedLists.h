#pragma once
#include <string>
#include <iostream>
#include "Node.h"

// Linked list class to
// implement a linked list.
class Linkedlist {
	Node* head;

public:
	// Default constructor
	Linkedlist() { head = NULL; }

	// Function to insert a
	// node at the end of the
	// linked list.
	void insertNode(int);

	// Function to print the
	// linked list.
	void printList();

	// Function to delete the
	// node at given position
	void deleteNode(int);
};

Node* MergeTwoSortedLists(Node* l1, Node* l2);