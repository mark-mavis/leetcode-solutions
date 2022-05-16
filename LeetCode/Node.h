#pragma once
#include <string>

class Node {
public:
	int data;
	Node* next;

	// Default constructor
	Node();

	// Parameterised Constructor
	Node(int data);
};