#include <iostream>
#include <string>
using namespace std;



class Car
{
public:
	Car(void);// default
	Car(string brand, string model, int year, int mileage);
	  //default filled
	void setBrand(string brand);
	void setModel(string model);
	void setyear(int year);
	void setmileage(int mileage);
	void increaseMileage( int add);
	bool isOld(int boundary);
	void printAll();
	~Car() ;


private:
	string brand; //марка	
	string model; //модел
	int year;	  //година на производство
	int mileage;  //пробег

};
Car::Car(void) {
	brand = "unknown";
	model = "unknown";
	year = 0;
	mileage = 0;
}

Car::Car(string brand, string model, int year, int mileage) {
	this->brand = brand;
	this->model = model;
	this->year = year;
	this->mileage = mileage;
}

void Car::printAll() {
	cout << "The car brand is :" << brand << endl;
	cout << "The car model is :" << model << endl;
	cout << "The car year is :" << year << endl;
	cout << "The car mileage is :" << mileage << endl;





}
void  Car::setBrand(string brand) {

	this->brand= brand;

}
void  Car::setModel(string model) {

	this->model = model;

}
void Car::setyear(int year) {

	this->year = year;


};
void Car::setmileage(int mileage) {
	
	this->mileage = mileage;


};
void Car::increaseMileage(int add) {

	Car::mileage += add;





};


bool Car::isOld(int boundary)
{
	if (year < boundary)
		return true;
	else
		return false;
}

Car::~Car() {
	// Имплементация на деструктора
}


int main() {
	// Създаване на обект от класа Car с конструктора с параметри
	Car car1("Toyota", "Yaris", 1992, 52000);

	// Използване на функции за задаване и връщане на стойностите на член-данните
	car1.setBrand("Toyota");
	car1.setModel("Yaris");
	car1.setyear(1992);
	car1.setmileage(52000);

	// Използване на функцията за извеждане на информацията за автомобила
	car1.printAll();

	// Използване на функцията за увеличаване на пробега
	car1.increaseMileage(100);

	// Използване на функцията за проверка на годината на автомобила
	bool isOldCar = car1.isOld(10);
	if (isOldCar) {
		cout << "The car is old." << endl;
	}
	else {
		cout << "The car is not old." << endl;
	}

	return 0;
}
