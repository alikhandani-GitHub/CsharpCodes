#include <iostream>
#include <string>
using namespace std;
//=====================================prototipe
int culcolate(string number, string number2, int, int);
//===================================
int main()
{
	string number1, number2;
	cin >> number1;
	cin >> number2;
	culcolate(number1, number2, 0, 0);

	return 0;
}
//===============================
int culcolate(string number1, string number2, int h, int l)
{
	int sum = l, i = h;
	string maxNumber, minNumber;
	if (number1.length() < number2.length())
		maxNumber = number2;
	else
		maxNumber = number1;
	if (number1.length() > number2.length())
		minNumber = number2;
	else
		minNumber = number1;
	//---------------------------
	if (maxNumber.length() == i && l == 1)
	{
		cout << 1;
		return 0;

	}
	if (maxNumber.length() == i)
		return 0;
	if (number1[number1.length() - i - 1] - 48 + number2[number2.length() - i - 1] - 48 >= 10 && (h < minNumber.length()))
	{
		sum += number1[number1.length() - i - 1] - 48 + number2[number2.length() - i - 1] - 58;
		culcolate(number1, number2, ++i, 1);
		cout << sum;

	}
	else if (number1[number1.length() - i - 1] - 48 + number2[number2.length() - i - 1] - 48 < 10 && (h < minNumber.length()))
	{
		sum += number1[number1.length() - i - 1] - 48 + number2[number2.length() - i - 1] - 48;
		culcolate(number1, number2, ++i, 0);
		cout << sum;

	}
	else if (h >= minNumber.length())
	{
		sum += maxNumber[maxNumber.length() - i - 1] - '0';
		culcolate(number1, number2, ++i, 0);
		cout << sum;
	}

	return 0;
}
