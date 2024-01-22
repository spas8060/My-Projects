#pragma once
#include <iostream>
using namespace std;
class Vehicle
{
public:
	Vehicle(string make,string model, int year,int numWheels);
	~Vehicle();
	void	displayInfo();
	void getMake();
	void getModel();
	void getYear();
	void getWheels();



private:
	string make;
	string model;
	int year;
	int numWheels;

};
