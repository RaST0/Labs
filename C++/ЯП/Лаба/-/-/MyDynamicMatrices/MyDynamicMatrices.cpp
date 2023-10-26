// MyDynamicMatrices.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
namespace std
{
}
int main()
{

    return 0;
}
void mat_multiply(int **mat1,
	int n1,
	int m1,
	int **mat2,
	int n2,
	int m2,
	int ** mat_out,
	int &n_out,
	int &m_out)
{
	if (n1 == n2 && m1 == m2)
	{
		n_out = n1;
		m_out = m1;
		for (int i = 0; i < n1; i++) // цикл по строкам
		{
			for (int j = 0; j < m1; j++) // цикл по столбцам
			{
				mat_out[i][j] = 0;
				for (int k = 0; k < m1; k++)
				{
					mat_out[i][j] = mat1[i][k] + mat2[k][j];
				}
				std::cout << mat_out[i][j] << " " << std::endl;

			}
		}
	}
};

void mat_vec_multiply(int **mat3,
	int n1,
	int m1,
	int **vec,
	int n2,
	int m2,
	int ** vec_out,
	int &n_out,
	int &m_out)
{
	if (n1 != m1 && m1 == m2)
	{
		n_out = n1;
		m_out = m1;
		for (int i = 0; i < n1; i++) // проходим по всем строкам финальной матрицы
		{
			for (int j = 0; j < m1; j++) // проходим по всем столбцам финальной матрицы
			{
				vec_out[i][j] = 0;
				for (int k = 0; k < m1; k++) // прописывается сумма для одного элемента финальной матрицы
				{
					vec_out[i][j] += mat3[i][k] * vec[k][j];
				}
				std::cout << vec_out[i][j] << " " << std::endl;
			}
		}
	}
};



void mat_add(int **mat4,
	int n1,
	int m1,
	int **mat5,
	int n2,
	int m2,
	int ** mat_out,
	int &n_out,
	int &m_out)
{
	if (n1 == n2 && m1 == m2)
	{
		n_out = n1;
		m_out = m1;
		for (int i = 0; i < n1; i++) // цикл по строкам
		{
			for (int j = 0; j < m1; j++) // цикл по столбцам
			{
				{
					mat_out[i][j] = mat4[i][j] + mat5[i][j];
				}
				std::cout << mat_out[i][j] << " " << std::endl;
			}
		}

	}
};


void vec_add(int **vec4,
	int n1,
	int m1,
	int **vec5,
	int n2,
	int m2,
	int ** vec_out,
	int &n_out,
	int &m_out)
{
	if (n1 == n2 && m1 == m2)
	{
		n_out = n1;
		m_out = m1;
		for (int i = 0; i < n1; i++) // цикл по строкам
		{
			for (int j = 0; j < m1; j++) // цикл по столбцам
			{
				{
					vec_out[i][j] = vec4[i][j] + vec5[i][j];
				}
				std::cout << vec_out[i][j] << " " << std::endl;
			}
		}

	}
};



void vec_multiply(int **vec7,
	int n1,
	int m1,
	int **vec8,
	int n2,
	int m2,
	int ** vec_out,
	int &n_out,
	int &m_out)
{
	if (n1 == n2 && m1 == m2)
	{
		n_out = n1;
		m_out = m1;

		std::cout << "vec7 = ";
		for (int i = 0; i < m1; i++);
		//Ввод элементов второго вектора:
		std::cout << "vec8 = ";
		for (int i = 0; i < m1; i++);
		//Вычисление результата:
		for (int i = 0; i < m1; i++);
		//Отображение результата:
		std::cout << "[vec7.vec8] =";
		for (int i = 0; i < 3; i++)
			std::cout << " " << vec_out[i];
	}
}