#include "book.h"

Book::Book(string title, string author, string isbn, string checkedout)
{
	this->title = title;
	this->author = author;
	this->isbn = isbn;
	this->checkedout = checkedout;

}

Book::~Book()
{
}