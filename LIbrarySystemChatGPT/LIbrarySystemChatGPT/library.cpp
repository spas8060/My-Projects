#include "library.h"

library::library(string listOfBooks, string listOfPatrons)
{
	this->listOfBooks = listOfBooks;
	this->listOfPatrons = listOfPatrons;

}
library::~library() {};
void library::checkautBook()
{
	string title, patron;
	cout << "Enter the title of the book: ";
	cin >> title;
	cout << "Enter the name of the patron: ";
	cin >> patron;
	bool found = false;
	for (int i=0;i<listOfBooks.size();i++)
	{
		if (books[i].title == title && books[i].availability) {
			found = true;
			break;
		}
	}
	if (found) {
		for (int i = 0; i < books.size(); i++) {
			if (books[i].title == title) {
				books[i].availability = false;
				books[i].patron = patron;
				break;
			}
		}
		cout << "Book checked out successfully." << endl;
	}
	else {
		cout << "Book is not available or not found." << endl;
	}


