// Test1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

void mat_add(int ** mat1,
	int n1,
	int m1,
	int ** mat2,
	int n2,
	int m2,
	int ** mat_out,
	int &n_out,
	int &m_out)
{
	if (n1 == n2 && m1 == m2)// проверка размерностей
	{
		n_out = n1;
		m_out = m1;
		for (int i = 0; i < n1; i++) // цикл по строкам ( по вертикали)
		{
			for (int j = 0; j < m1; j++) // цикл по горизонтали ( по столбцам или по элементам одной строки )
			{
				mat_out[i][j] = mat1[i][j] + mat2[i][j];
			}
		}
	}
	else
	{
		//cообщение об ошибке "размерности не равны"
	}
}

int main()
{
	


	//void mat_add(int)
	//{
	//	// проверка размерностей
	//	for () // цикл сложения
	//	{
	//		for ()
	//		{

	//		}
	//	}
	//}

	void  mat_mat_multiply(int **mat1,
			int n1,
			int m1,
			int **mat2,
			int n2,
			int m2,
			int **mat_out,
			int &n3,
			int &m3);
		int n1 = 6;
		int m1 = 6;
		int ** mat1 = new  int*[n1];
		for (int i = 0; i < n1 - 1; i++)
		{
			mat1[i] = new int[m1];
		}

		std::cout << " " << mat1 << std::endl;



		getchar();
    return 0;
}

