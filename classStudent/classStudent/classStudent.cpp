#include <iostream>
#include <string>

using namespace std;

class Student {
private:
    string name;
    string facultyNumber;
    int* grades;
    int numGrades;

public:
    Student() {
        cout << "Моля, въведете името на студента: ";
        cin >> name;
        cout << "Моля, въведете факултетния номер: ";
        cin >> facultyNumber;

        cout << "Моля, въведете броя на оценките: ";
        cin >> numGrades;

        grades = new int[numGrades];

        cout << "Моля, въведете оценките:\n";
        for (int i = 0; i < numGrades; i++) {
            cout << "Оценка " << (i + 1) << ": ";
            cin >> grades[i];
        }
    }

    ~Student() {
        delete[] grades;
    }

    double getAverageGrade() const {
        if (numGrades == 0) {
            return 0.0;
        }

        int sum = 0;
        for (int i = 0; i < numGrades; i++) {
            sum += grades[i];
        }

        return static_cast<double>(sum) / numGrades;
    }

    bool hasPassed() const {
        for (int i = 0; i < numGrades; i++) {
            if (grades[i] > 2) {
                return true;
            }
        }
        return false;
    }

    void printInfo() const {
        cout << "Име: " << name << endl;
        cout << "Факултетен номер: " << facultyNumber << endl;
        cout << "Среден успех: " << getAverageGrade() << endl;
    }
};

int main() {
    Student s1;
    s1.printInfo();

    return 0;
}
