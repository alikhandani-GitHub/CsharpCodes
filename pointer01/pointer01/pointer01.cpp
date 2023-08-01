// pointer01.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <time.h>
using namespace std;

int main()
{
	/*
	int test [] = { 1,3,4,2 };
	int *ptr1 = &test[3];
	cout << *ptr1 << "\t" << ptr1;
	cout << endl;
	*/
	srand(time(0));
	int *ptr2,len;
	int i;
	cout << "LOTFAN YEK ADAD VARED KONID: ";
	cin >> len;
	ptr2 = new int[len];
	for (i = 0;i < len;i++)
	{
		ptr2[i] = rand();
	}
	for (i = 0;i < len;i++)
		cout << ptr2[i] << endl;
}


