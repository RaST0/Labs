// 3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class MyClass
{
public:
	MyClass()
	{
		str = nullptr;
		length = 0;
	}
	MyClass(char *str)
	{
		length = strlen(str);
		this->str = new char[length + 1];
		for (int i = 0; i < length; i++)
		{
			this->str[i] = str[i];
		}
		this->str[length] = '\0';
	}
	~MyClass()
	{
		delete[] this->str;
	}
	MyClass(const MyClass &other)
	{
		
		length = strlen(other.str);
		this->str = new char[length + 1];
		for (int i = 0; i < length; i++)
		{
			this->str[i] = other.str[i];
		}
		this->str[length] = '\0';
	}
	MyClass& operator=(const MyClass &other)
	{
		if (this->str != nullptr)
		{
			delete[]str;
		}
		length = strlen(other.str);
		this->str = new char[length + 1];
		for (int i = 0; i < length; i++)
		{
			this->str[i] = other.str[i];
		}
		this->str[length] = '\0';
		return *this;
	}
	MyClass operator +(const MyClass &other)
	{
		MyClass newStr;
		int thisLength = strlen(this->str);
		int otherLength = strlen(other.str);

		
		newStr.length = thisLength + otherLength;

		newStr.str = new char[thisLength + otherLength + 1];
		int i = 0;
		for (; i < thisLength; i++)
		{
			newStr.str[i] = this->str[i];
		}
		for (int j = 0; j < otherLength; j++, i++)
		{
			newStr.str[i] = other.str[j];
		}
		newStr.str[thisLength + otherLength] = '\0';
		return newStr;
	}
	int Print()
	{
		cout << str;
		return 0;
	}
	int Length()
	{
		return length;
	}


private:
	char *str;
	int length;
};



int main()
{
	MyClass str ("Privet");
	MyClass str2 ("Nigger");
	MyClass result;
	result = str + str2;
	cout << result.Print() << endl;
	cout << str.Length() << endl;
	cout << str2.Length() << endl;
	cout << result.Length() << endl;
	getchar();
    return 0;
}

