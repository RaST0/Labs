// MyString1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class MyString
{
public:

	MyString() // Конструктор по умолчанию, не принемает параметров
	{
		str = nullptr;
	}
	MyString(const MyString &other) // Перегруженный оператор присваивания
	{
		
		int length = strlen(other.str);
		this->str = new char[length + 1]; // В конструкторе стр и в классе , это нужно для того чтобы мы работали с другим стр, не из конструктора

		for (int i = 0; i < length; i++)
		{
			this->str[i] = other.str[i];
		}
		this->str[length] = '\0';// терминирующий ноль
		 
	}
	MyString(char *str) // конструктор
	{
		int length = strlen(str);
		this->str = new char[length + 1]; // В конструкторе стр и в классе , это нужно для того чтобы мы работали с другим стр, не из конструктора
		for (int i = 0; i < length; i++)
		{
			this->str[i] = str[i];
		}
		this->str[length] = '\0';
	}
	~MyString() // деструктор
	{
		delete[] this->str; // для очистки динамической памяти ( для избежания утечки памяти)
	}

	MyString& operator =(const MyString &other) // Перегруженный оператор присваивания
	{
		if (this->str!= nullptr) // проверка на выделенные ресурсы
		{
			delete[]str;
		}
		int length = strlen(other.str);
		this->str = new char[length + 1]; // В конструкторе стр и в классе , это нужно для того чтобы мы работали с другим стр, не из конструктора
		for (int i = 0; i < length; i++)
		{
			this->str[i] = other.str[i];
		}
		this->str[length] = '\0';// терминирующий ноль
		return *this; // т.к мы возвращаем ссылку на текущий объект класса
	}
	MyString operator +(const MyString &other)// перегруженный оператор + , для выполнение конкатонации ( соединения)
	{
		MyString newStr;

		int thislength = strlen(this->str);
		int otherlength = strlen(other.str);
		int i = 0; // итератор, для того, чтобы можно было видеть его в другом цикле с j
		newStr.str = new char[thislength + otherlength + 1];
		for (; i < thislength; i++)
		{
			newStr.str[i] = this->str[i];

		}
		for (int j = 0; j < otherlength;j++, j++)
		{
			newStr.str[i] = other.str[j];
		}
		newStr.str[thislength + otherlength] = '\0'; // терминирующий ноль
		
		return newStr; // Возвращение обьекта
	}
	void Print()
	{
		cout <<str;
	}

private:
	char *str; // Т.к надо хранить строчку в динамической памяти, т.к мы не знаем заранее сколько будет символов в строке
};



int main()
{
	MyString str("Hello");
	MyString str2("World");

	MyString result;
	result = str;
	
	
	return 0;
}

