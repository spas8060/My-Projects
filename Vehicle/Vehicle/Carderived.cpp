#include"Vehicle.h"
#include"Carderived.h"

car::car(string make, string model, int year, int numWheels, int numberOfDoors):Vehicle(make,model,year,numWheels)
{
	this->numberOfDoors = numberOfDoors;
}

void car::displayInfo()
{
	Vehicle::displayInfo();
	cout << "The number of doors is : " << numberOfDoors<<endl;

}
void car::getDoors()

{

	cout << "This is the number of the Doors: " << numberOfDoors << endl;


}
