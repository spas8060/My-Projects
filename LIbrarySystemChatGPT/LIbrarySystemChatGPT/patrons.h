#pragma once
#include "book.h"

class patrons
{
private:
	string name;
	string id;
	string currentBooks;
public:
	patrons(string name,string id,string currentBooks);
	~patrons();
};


