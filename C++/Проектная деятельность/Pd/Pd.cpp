//������ �.� ������� �.� 171-362
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <locale.h>
#include <stdlib.h>
#include <string>
#include <fstream>
#include <iomanip>
#include <vector>
#include<windows.h>
#include <conio.h>
#include <random>
#include<ctime>
#include <time.h>
#include <dos.h>
#include <math.h>

// ����������
using std::cin;
using std::cout;
using std::ofstream;
using std::endl;
using std::ifstream;
using std::string;
using std::vector;
using std::ios_base;
using std::setw;


// ����������
bool security, auth, auth2;
string login, password, alogin, apassword, ulogin, upassword, surname, name, secondname, mobile, data, gender, city, passport, polis, inn, number, payday, job , credit , snils, education , social, adress, choose;



// ��������� ��
void Create()
{
	setlocale(LC_ALL, "RUS");
	std::ofstream fout("clients.txt");
	fout << "�����" << std::setw(15) << "�������" << std::setw(15) << "���" << std::setw(15) << "��������" << std::setw(24) << "����� ���." << std::setw(23) << "���� ���." << std::setw(15) << "���" << std::setw(30) << "�����" << std::setw(24) << "�������" << std::setw(22) << "���" << std::setw(21) << "���" << std::setw(15) << "�����" << std::setw(20) << "���������" << std::setw(22) << "������� ��������" << std::setw(22) << "�����" << std::setw(20) << "�����������" << std::setw(17) << "���. �����"  << std::setw(25) << "�����" << std::setw(30) << std::endl; // �������� �����
	fout << "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" << std::endl; // ��������� �����
	std::vector<std::string> name = { "������", "������", "������", "����", "�����", "��������", "����", "������", "�������", "�������", "�������", "������", "���������", "������", "����", "�����������", "����", "������", "���������", "Ը���" };
	std::vector<std::string> name2 = { "�����", "���������", "�������", "���������", "���������", "���������", "����������", "�������", "����", "�������", "�������", "��������", "�������", "�����", "�����", "�����", "�����", "�����", "������", "�����" };
	std::vector<std::string> surname = { "�������", "������" , "��������" , "�����" , "��������" , "�������" , "�������" , "���������" , "�������" , "�������" , "������" , "������" , "�������" , "������" , "�������" , "�������" , "������" , "��������" , "�������" , "��������" };
	std::vector<std::string> surname2 = { "�������������", "������������", "������������", "����������", "�����������", "��������", "���������", "�������", "������", "�������", "�������", "������", "��������", "�������", "��������", "�������", "�������", "����������", "�������", "�������", "������", "��������", "��������", "���������" };
	std::vector<std::string> secondname = { "�������������", "����������", "���������", "����������", "����������", "����������", "����������", "������������" , "�������������", "�������������", "��������", "�����������", "���������", "��������", "����������", "���������", "�����������", "�����������", "�������������", "����������", "��������������", "�����������", "���������", "���������" };
	std::vector<std::string> secondname2 = { "����������", "���������", "���������" , "����������" , "�������������" , "�����������" , "��������������" , "���������" , "��������" , "�������������" , "�������������" , "����������" , "����������" , "��������" , "����������" , "�����������" , "����������" , "�����������" , "���������" , "���������" , "��������" };
	std::vector<std::string> city = { "������", "�����-���������", "������" , "������-��-����" , "������ ��������" , "�����������" , "����������" , "���������" , "������" , "���" , "�������" , "����������" , "�������", "�����������", "����", "���������", "������", "����" };
	std::vector<std::string> street = { "�������", "�������" , "����������" , "���������" , "���������" , "����������" , "���������" , "���������" , "��������" , "���������" , "�����������" , "���������" , "������������" , "�������������" , "�����������" , "���������" , "�������" };
	std::vector<std::string> newday1{ "01","02","03" ,"04" ,"05","06" ,"07" ,"08","09" };
	std::vector<std::string> newday2{ "10","11","12" ,"13" ,"14","15" ,"16" ,"17","18","19","20","21","22","23","24","25","26","27","28" };
	std::vector<std::string> seriya{ "45", "40", "46", "78", "75", "69", "03", "04" };
	std::vector<std::string> payday{ "5000���", "10.000���", "15.000���", "20.000���", "25.000���", "30.000���", "35.000���", "40.000���", "45.000���", "50.000���", "55.000���", "60.000���", "65.000���", "70.000���", "75.000���", "80.000���", "85.000���", "90.000���", "95.000���", "100.000���" };
	std::vector<std::string> education{ "�������","������","�����������" ,"������������"};
	std::vector<std::string> social{ "������","�������","������"};
	std::vector<std::string> estno{ "����", "���" };
	std::vector<std::string> job{ "�������","���������","��������","����","�������������","�����������","����������","���������","�������","�����������","��������","�������","�������" };
	std::random_device rd;
	std::mt19937 gen(rd());
	std::uniform_int_distribution <> dist(1000000, 9999999);
	std::uniform_int_distribution <> dist0(10, 99);
	std::uniform_int_distribution <> dist1(1970, 1997);
	std::uniform_int_distribution <> dist2(1000, 9999);
	std::uniform_int_distribution <> dist3(1000000, 9999999);
	std::uniform_int_distribution <> dist4(70, 97);
	std::uniform_int_distribution <> dist5(100000, 999999);
	std::uniform_int_distribution <> dist6(1, 100);
	std::uniform_int_distribution <> dist7(1, 20);
	std::uniform_int_distribution <> dist8(100000, 999999);
	std::uniform_int_distribution <> dist9(100000, 999999);
	std::uniform_int_distribution <> dist10(100, 999);
	std::uniform_int_distribution <> dist11(45872, 99999);
	int x = 0;
	int month = 0;
	int rnd = 0;
	std::string nole;
	std::string day;
	srand(time(NULL));
	for (int iter = 0; iter < 500; iter++) {
		x = rand() % 2;
		month = 1 + rand() % 13;
		if (month < 10)
			nole = "0";
		else
			nole = "";
		rnd = rand() % 2;
		if (rnd < 1)
			day = newday1[rand() % newday1.size()];
		else
			day = newday2[rand() % newday2.size()];

		if (x < 1)
		{	
			
			fout <<  std::setw(3) << dist11(gen) << std::setw(15) <<
				surname[rand() % surname.size()] << std::setw(15) <<
				name[rand() % name.size()] << std::setw(15) <<
				secondname[rand() % secondname.size()] << std::setw(15) <<
				"+79" << dist0(gen) << dist(gen) << std::setw(15) <<
				day << "." << nole << month << "." << dist1(gen) << std::setw(15) <<
				"�������" << std::setw(30) <<
				city[rand() % city.size()] << std::setw(15) <<
				seriya[rand() % seriya.size()] << dist4(gen) << "_" << dist5(gen) << std::setw(15) <<
				dist2(gen) << dist3(gen) << std::setw(15) <<
				dist8(gen) << dist9(gen) << std::setw(15) <<
				payday[rand() % payday.size()] << std::setw(20) <<
				job[rand() % job.size()] << std::setw(15) <<
				estno[rand() % estno.size()] << std::setw(15) <<
				"�" << dist10(gen) << "-" << dist10(gen) << "-" << dist10(gen) << "-" << dist0(gen) << std::setw(20) <<
				education[rand() % education.size()] << std::setw(15) <<
				social[rand() % social.size()] << std::setw(15) <<
				"��." << street[rand() % street.size()] << "_" << "�." << dist7(gen) << "_" << "�." << dist6(gen) <<
				std::endl;
		}
		else
		{
			fout << std::setw(3) << dist11(gen) << std::setw(15) <<
				surname2[rand() % surname2.size()] << std::setw(15) <<
				name2[rand() % name2.size()] << std::setw(15) <<
				secondname2[rand() % secondname2.size()] << std::setw(15) <<
				"+79" << dist0(gen) << dist(gen) << std::setw(15) <<
				day << "." << nole << month << "." << dist1(gen) << std::setw(15) <<
				"�������" << std::setw(30) <<
				city[rand() % city.size()] << std::setw(15) <<
				seriya[rand() % seriya.size()] << dist4(gen) << "_" << dist5(gen) << std::setw(15) <<
				dist2(gen) << dist3(gen) << std::setw(15) <<
				dist8(gen) << dist9(gen) << std::setw(15) <<
				payday[rand() % payday.size()] << std::setw(20) <<
				job[rand() % job.size()] << std::setw(15) <<
				estno[rand() % estno.size()] << std::setw(15) <<
				"�" << dist10(gen) << "-" << dist10(gen) << "-" << dist10(gen) << "-" << dist0(gen) << std::setw(20) <<
				education[rand() % education.size()] << std::setw(15) <<
				social[rand() % social.size()] << std::setw(15) <<
				"��." << street[rand() % street.size()] << "_" << "�." << dist7(gen) << "_" << "�." << dist6(gen) <<
				std::endl;
		}
	}
	fout.close();
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " C������ ����� ���� ������." << endl;
	logdat.close();
}

// �������� ��
void Delete()
{
	remove("clients.txt");
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " ���� ������ �������. " << endl;
	logdat.close();
}

// �������� ��
void bd()
{
	system("notepad.exe clients.txt");
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " ���� ������ ���� �����������. " << endl;
	logdat.close();
}

// ����� ������� � ��
void find()
{
	bool ok = false;
	system("cls");
	ifstream in("clients.txt");
	string find;
	cout << "����� �� ������ ��������: " << endl;
	cin >> find;
	cout << "\n������ �������:" << endl;
	while (!in.eof())
	{
		in >> number >> surname >> name >> secondname >> mobile >> data >> gender >>  city >> passport >> polis >> inn >> payday >> job >> credit >> snils >> education >> social >> adress;
		if (number == find)
		{
			cout << "\n� ��������: " << number << endl;
			cout << "\n�������: " << surname << endl;
			cout << "\n���: " << name << endl;
			cout << "\n��������: " << secondname << endl;
			cout << "\n���.�������: " << mobile << endl;
			cout << "\n���� ��������: " << data << endl;
			cout << "\n ���: " << gender << endl;
			cout << "\n������ �����: " << city << endl;
			cout << "\n����� � ����� ��������: " << passport << endl;
			cout << "\n����� � ����� ������ ���: " << polis << endl;
			cout << "\n����� ���: " << inn << endl;
			cout << "\n�����: " << inn << endl;
			cout << "\n���������: " << inn << endl;
			cout << "\n������� ��������: " << inn << endl;
			cout << "\n�����: " << inn << endl;
			cout << "\n�����������: " << inn << endl;
			cout << "\n���. �����: " << inn << endl;
			cout << "\n�����: " << adress << "\n" << "\n" << endl;
			ok = true;
			break;
		}
	}
	if (ok == false)
	{
		cout << "���������� �� �������!\n";
	}
	in.close();
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " ��� ��������� ����� �������." << endl;
	logdat.close();
	system("pause");
}

// ���������� ������� � ��
void client()
{
	system("cls");
	string number2, surname2, name2, secondname2, mobile2, data2, gender2, city2, passport2, polis2, inn2, payday2, job2, credit2, snils2, education2, social2, adress2;
	ofstream out("clients.txt", ios_base::app);
	cout << "\n� ��������: ";
	cin >> number2;
	cout << "\n�������: ";
	cin >> surname2;
	cout << "\n���: ";
	cin >> name2;
	cout << "\n��������: ";
	cin >> secondname2;
	cout << "\n���.�������(������:+79161456732): ";
	cin >> mobile2;
	cout << "\n���� ��������(������:25.02.1996): ";
	cin >> data2;
	cout << "\n���(������:�������): ";
	cin >> gender2;
	cout << "\n������ �����: ";
	cin >> city2;
	cout << "\n����� � ����� ��������(������:4687_419874): ";
	cin >> passport2;
	cout << "\n����� � ����� ������ ���(������:49343407491) : ";
	cin >> polis2;
	cout << "\n����� ���(������:220330969920): ";
	cin >> inn2;
	cout << "\n�����(������: 30.000���): ";
	cin >> payday2;
	cout << "\n���������(������: �������): ";
	cin >> job2;
	cout << "\n������� ��������(������: ����): ";
	cin >> credit2;
	cout << "\n�����(������ :  �428-996-265-12): ";
	cin >> snils2;
	cout << "\n�����������(������: ������): ";
	cin >> education2;
	cout << "\n���. �����(������: �������): ";
	cin >> social2;
	cout << "\n�����(������: ��.������������_�.40_�.6): ";
	cin >> adress2;

	out << setw(3) << number2 << setw(15) << surname2 << setw(15) << name2 << setw(15) << secondname2 << setw(15) << mobile2 << setw(15) << data2 << setw(15) << gender2 << setw(30) << city2 << setw(15) << passport2 << setw(15) << polis2 << setw(15) << inn2 << setw(15) << payday2 << setw(20) << job2 << setw(15) << credit2 << setw(15) << snils2 << setw(20) << education2 << setw(15) << social2 << setw(15) << adress2 << endl;
	out.close();
}

// ����������� ����������
void reg_user()
{
	string login3, login4, password4;
	bool boom = true;
	system("cls");

	cout << "���������� ����� � ������\n";
	cout << "�����:";
	cin >> login4;
	cout << "������:";
	cin >> password4;
	login3 = login;
	string login2, password2;
	ifstream in2("user.txt");
	while (!in2.eof())
	{
		in2 >> login2 >> password2;
		if (login4 == login2)
		{
			cout << "����� ����� ��� ���������������!" << endl;
			system("pause");
			boom = false;
			break;
		}
	}
	in2.close();
	if (boom == true)
	{
		ofstream out{ "user.txt",ios_base::app };
		out << login4 << "\t" << password4 << endl;
		out.close();
	}
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " ������������ " << login3 << "  ��� ���������������!" << endl;
	logdat.close();
}

// ����������� ������
void reg_admin()
{
	string login3, login4, password4;
	bool boom = true;
	system("cls");

	cout << "���������� ����� � ������\n";
	cout << "�����:";
	cin >> login4;
	cout << "������:";
	cin >> password4;
	login3 = login4;
	string login2, password2;
	ifstream in2("admin.txt");
	while (!in2.eof())
	{
		in2 >> login2 >> password2;
		if (login4 == login2)
		{
			cout << "����� ����� ��� ���������������!" << endl;
			system("pause");
			boom = false;
			break;
		}
	}
	in2.close();
	if (boom == true)
	{
		ofstream out{ "admin.txt",ios_base::app };
		out << login4 << "\t" << password4 << endl;
		out.close();
	}
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " �����" << login3 << "  ��� ���������������!" << endl;
	logdat.close();
}

// ������� ������
void admin()
{
	security = true;
	while (true)
	{
		system("cls");
		cout << "�������� �������\n";
		cout << "\n1.������ � ����� ������\n";
		cout << "2.�����������\n";
		cout << "3.������� ������������\n";
		cout << "4.����� �� �������\n";

		cout << "�������: ";
		cin >> choose;
		if (choose == "1")
		{
			system("cls");
			cout << "�������� �������\n";
			cout << "\n1.������� ����\n";
			cout << "2.������� ����\n";
			cout << "3.�������� ����\n";
			cout << "4.����� �������\n";
			cout << "5.����� ������\n";
			cout << "6.��������� � ����\n";

			cout << "�������: ";
			cin >> choose;

			if (choose == "1")
			{
				Create();
				system("cls");
				cout << "�������� �������\n";
				cout << "\n1.������� ����\n";
				cout << "2.�������� ����\n";
				cout << "3.����� �������\n";
				cout << "4.����� ������\n";
				cout << "5.� ����\n";

				cout << "�������: ";
				cin >> choose;

				if (choose == "1")
				{
					Delete();
				}
				else if (choose == "2")
				{
					bd();
				}
				else if (choose == "3")
				{
					find();
				}
				else if (choose == "4")
				{
					client();
				}
				else if (choose == "5")
				{
					auth = false;
				}
			}
			else if (choose == "2")
			{
				Delete();
				system("cls");
				cout << "�������� �������\n";
				cout << "\n1.������� ����\n";
				cout << "2.�������� ����\n";
				cout << "3.����� �������\n";
				cout << "4.����� ������\n";
				cout << "5.��������� � ����\n";

				cout << "�������: ";
				cin >> choose;

				if (choose == "1")
				{
					Create();
					system("cls");
					cout << "�������� �������\n";
					cout << "\n1.������� ����\n";
					cout << "2.�������� ����\n";
					cout << "3.����� �������\n";
					cout << "4.����� ������\n";
					cout << "5.��������� � �����\n";

					cout << "�������: ";
					cin >> choose;

					if (choose == "1")
					{
						Delete();
					}
					else if (choose == "2")
					{
						bd();
						system("cls");
						cout << "�������� �������\n";
						cout << "\n1.��������� � �����\n";

						cout << "�������: ";
						cin >> choose;
						if (choose == "1")
						{
							auth = false;
							auth2 = false;
							break;
						}
					}
					else if (choose == "3")
					{
						find();
					}
					else if (choose == "4")
					{
						client();
					}
					else if (choose == "5")
					{
						auth = false;
						auth2 = false;
						break;
					}
				}
				else if (choose == "2")
				{
					bd();
					system("cls");
					cout << "�������� �������\n";
					cout << "\n1.��������� � �����\n";

					cout << "�������: ";
					cin >> choose;
					if (choose == "1")
					{
						auth = false;
						auth2 = false;
						break;
					}
				}
				else if (choose == "3")
				{
					find();
				}
				else if (choose == "4")
				{
					client();
				}
				else if (choose == "5")
				{
					auth = false;
				}
			}
			else if (choose == "3")
			{
				bd();
				system("cls");
				cout << "�������� �������\n";
				cout << "\n1.��������� � �����\n";

				cout << "�������: ";
				cin >> choose;
				if (choose == "1")
				{
					auth = false;
					auth2 = false;
					break;
				}
			}
			else if (choose == "4")
			{
				find();
			}
			else if (choose == "5")
			{
				client();
			}
			else if (choose == "6")
			{
				auth = false;
			}
		}
		else if (choose == "2")
		{
			system("cls");
			cout << "�������� �������\n";
			cout << "1.����������� ����������\n";
			cout << "2.����������� ������\n";
			cout << "3.��������� � ����\n";

			cout << "�������: ";
			cin >> choose;
			if (choose == "1")
			{
				reg_user();
			}
			else if (choose == "2")
			{
				reg_admin();
			}
			else if (choose == "3")
			{
				auth = false;
			}
		}
		else if (choose == "3")
		{
			auth = false;
			auth2 = false;
			break;
		}
		else if (choose == "4")
		{
			exit(0);
		}
	}
}

// ������� ������������
void user()
{
	security = true;
	while (true)
	{
		system("cls");
		cout << "�������� �������\n";
		cout << "\n1.������ � ����� ������\n";
		cout << "2.������� ������������\n";
		cout << "3.����� �� �������\n";

		cout << "�������: ";
		cin >> choose;
		if (choose == "1")
		{
			system("cls");
			cout << "�������� �������\n";
			cout << "1.�������� ����\n";
			cout << "2.����� �������\n";
			cout << "3.����� ������\n";
			cout << "4.��������� � �����\n";

			cout << "�������: ";
			cin >> choose;

			if (choose == "1")
			{
				bd();
				system("cls");
				cout << "�������� �������\n";
				cout << "\n1.��������� � �����\n";

				cout << "�������: ";
				cin >> choose;
				if (choose == "1")
				{
					auth = false;
					auth2 = false;
					break;
				}
			}
			else if (choose == "2")
			{
				find();
			}
			else if (choose == "3")
			{
				client();
			}
			else if (choose == "4")
			{
				auth = false;
				auth2 = false;
				break;
			}
		}
		
		else if (choose == "2")
		{
			auth = false;
			auth2 = false;
			break;
		}
		else if (choose == "3")
		{
			exit(0);
		}
	}
}

// �����
int main()
{
	security = false;
	string login2;
	int i = 0;
	auth = false;
	auth2 = false;
	setlocale(LC_ALL, "rus");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	cout << "\t" << "\t" << "    ����� ����������!\n";
	cout << "�����: ";
	cin >> login;
	cout << "������: ";
	cin >> password;
	login2 = login;

	ifstream fadmin("admin.txt");
	while (!fadmin.eof())
	{
		fadmin >> alogin >> apassword;
		if (login == alogin && password == apassword)
		{
			auth = true;
			break;

		}
	}
	fadmin.close();
	if (auth == true)
	{
		ofstream logdat("data.txt", ios_base::app);
		char buffer[80];
		time_t seconds = time(NULL);
		tm* timeinfo = localtime(&seconds);
		char* format = "%A, %B %d, %Y %H:%M:%S";
		strftime(buffer, 80, format, timeinfo);
		logdat << buffer << "     ����� ����� � �������!" << endl;
		logdat.close();
		system("cls");
		admin();
	}
	ifstream fuser("user.txt");
	while (!fuser.eof())
	{
		fuser >> ulogin >> upassword;
		if (ulogin == login && upassword == password) {
			auth2 = true;
			break;
			fuser.close();
		}
	}
	if (auth2 == true)
	{
		ofstream logdat("data.txt", ios_base::app);
		char buffer[80];
		time_t seconds = time(NULL);
		tm* timeinfo = localtime(&seconds);
		char* format = "%A, %B %d, %Y %H:%M:%S";
		strftime(buffer, 80, format, timeinfo);
		logdat << buffer << "  " << login2 << " ����� � �������!" << endl;
		logdat.close();
		system("cls");
		user();
	}
	while (login != ulogin && password != upassword || login != alogin && password != apassword)
	{
		auth = false;
		auth2 = false;
		system("cls");
		cout << "\t" << "\t" << "    ����� ����������!\n";
		cout << "�����: ";
		cin >> login;
		cout << "������: ";
		cin >> password;
		login2 = login;
		ifstream fadmin("admin.txt");
		while (!fadmin.eof())
		{
			fadmin >> alogin >> apassword;
			if (login == alogin & password == apassword)
			{
				auth = true;
				break;
			}
		}
		fadmin.close();
		if (auth == true)
		{
			ofstream logdat("data.txt", ios_base::app);
			char buffer[80];
			time_t seconds = time(NULL);
			tm* timeinfo = localtime(&seconds);
			char* format = "%A, %B %d, %Y %H:%M:%S";
			strftime(buffer, 80, format, timeinfo);
			logdat << buffer << "     ����� ����� � �������!" << endl;
			logdat.close();
			system("cls");
			admin();
		}

		ifstream fuser("user.txt");
		while (!fuser.eof())
		{
			fuser >> ulogin >> upassword;
			if (ulogin == login && upassword == password) {
				auth2 = true;
				break;
			}
		}
		fuser.close();
		if (auth2 == true)
		{
			ofstream logdat("data.txt", ios_base::app);
			char buffer[80];
			time_t seconds = time(NULL);
			tm* timeinfo = localtime(&seconds);
			char* format = "%A, %B %d, %Y %H:%M:%S";
			strftime(buffer, 80, format, timeinfo);
			logdat << buffer << "  " << login2 << " ����� � �������!" << endl;
			logdat.close();
			system("cls");
			user();
		}
	}
	return 0;
}