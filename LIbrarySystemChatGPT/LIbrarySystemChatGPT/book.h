#include <iostream>
using namespace std;

class Book
{
private:
    string title;
    string author;
    int ISBN;
    bool checkedOut;
    string patronName;

public:
    Book(string title, string author, int ISBN);
    void checkOut(string patronName);
    void returnBook();
    string getTitle();
    string getAuthor();
    int getISBN();
    bool isCheckedOut();
    string getPatronName();
};
