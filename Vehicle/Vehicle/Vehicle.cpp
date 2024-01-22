#include "Vehicle.h"


Vehicle::Vehicle(string make, string model, int year, int numWheels)
{
	this->make = make;
	this->model = model;
	this->year = year;
	this->numWheels = numWheels;

}
Vehicle::~Vehicle(){}
void	Vehicle::displayInfo()
{
	cout << "This is the make: " << make <<endl;
	cout << "This is the model: " << model<<endl;
	cout << "This is the year: " << year<<endl;
	cout << "This is the number of Wheels: " << numWheels << endl;
	

}
void Vehicle::getMake() 
{
	cout << "This is the make: " << make << endl;

}
void Vehicle::getModel()
{
	cout << "This is the model: " << model << endl;
}
void Vehicle::getYear()
{
	cout << "This is the year: " << year << endl;

}
void Vehicle::getWheels()

{

	cout << "This is the number of Wheels: " << numWheels << endl;

}