#include <iostream>
#include <vector>
#include <string>
#include "patrons.h"
class library {
public:
    // Constructor
    library() {}

    // Destructor
    ~library() {}

    // Function to add a book to the library
    void addBook(std::string title, std::string author) {
        books.push_back({ title, author });
    }

    // Function to remove a book from the library
    void removeBook(std::string title) {
        for (auto it = books.begin(); it != books.end(); it++) {
            if (it->title == title) {
                books.erase(it);
                break;
            }
        }
    }

    // Function to check out a book
    void checkOutBook(std::string title, std::string patron) {
        for (auto& book : books) {
            if (book.title == title) {
                if (book.patron.empty()) {
                    book.patron = patron;
                    std::cout << "Book " << title << " checked out to " << patron << std::endl;
                }
                else {
                    std::cout << "Book " << title << " is already checked out to " << book.patron << std::endl;
                }
                break;
            }
        }
    }

    // Function to return a book
    void returnBook(std::string title) {
        for (auto& book : books) {
            if (book.title == title) {
                if (book.patron.empty()) {
                    std::cout << "Book " << title << " is not checked out" << std::endl;
                }
                else {
                    std::cout << "Book " << title << " returned by " << book.patron << std::endl;
                    book.patron.clear();
                }
                break;
            }
        }
    }
}