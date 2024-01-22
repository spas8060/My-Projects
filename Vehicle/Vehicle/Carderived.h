#pragma once
#include "Vehicle.h"


class car : public Vehicle
{
public:
	car(string make, string model, int year, int numWheels,int numberOfDoors);
	void displayInfo();
	void getDoors();

private:
	int numberOfDoors;
};

