//Козлов Н.Ю Захаров Н.А 171-362
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

// Сокращение
using std::cin;
using std::cout;
using std::ofstream;
using std::endl;
using std::ifstream;
using std::string;
using std::vector;
using std::ios_base;
using std::setw;


// Переменные
bool security, auth, auth2;
string login, password, alogin, apassword, ulogin, upassword, surname, name, secondname, mobile, data, gender, city, passport, polis, inn, number, payday, job , credit , snils, education , social, adress, choose;



// Генерация БД
void Create()
{
	setlocale(LC_ALL, "RUS");
	std::ofstream fout("clients.txt");
	fout << "Номер" << std::setw(15) << "Фамилия" << std::setw(15) << "Имя" << std::setw(15) << "Отчество" << std::setw(24) << "Номер тел." << std::setw(23) << "Дата рож." << std::setw(15) << "Пол" << std::setw(30) << "Город" << std::setw(24) << "Паспорт" << std::setw(22) << "ОМС" << std::setw(21) << "ИНН" << std::setw(15) << "Доход" << std::setw(20) << "Профессия" << std::setw(22) << "Наличие кредитов" << std::setw(22) << "СНИЛС" << std::setw(20) << "Образование" << std::setw(17) << "Соц. класс"  << std::setw(25) << "Адрес" << std::setw(30) << std::endl; // Создание шапки
	fout << "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" << std::endl; // Отделение шапки
	std::vector<std::string> name = { "Андрей", "Максим", "Никита", "Олег", "Антон", "Владимир", "Илья", "Виктор", "Василий", "Николай", "Алексей", "Михаил", "Владислав", "Сергей", "Артём", "Пантелеймон", "Егор", "Степан", "Станислав", "Фёдор" };
	std::vector<std::string> name2 = { "Ольга", "Екатерина", "Наталья", "Анастасия", "Елизавета", "Маргорита", "Александра", "Надежда", "Вера", "Татьяна", "Евгения", "Виктория", "Валерия", "София", "Софья", "Мария", "Лидия", "Дарья", "Анжела", "Ирина" };
	std::vector<std::string> surname = { "Лебедев", "Зайцев" , "Медведев" , "Орлов" , "Петушков" , "Голубев" , "Телегин" , "Мельников" , "Бочкарёв" , "Сидоров" , "Иванов" , "Павлов" , "Романов" , "Волков" , "Соболев" , "Морозов" , "Громов" , "Воронцов" , "Алмазов" , "Богатырёв" };
	std::vector<std::string> surname2 = { "Воскресенская", "Александрова", "Серебрянская", "Королькова", "Виноградова", "Цветаева", "Золотарёва", "Козлова", "Белова", "Крылова", "Чернова", "Быкова", "Воронина", "Леонова", "Архипова", "Галкина", "Князева", "Плотникова", "Ушакова", "Боброва", "Ларина", "Сахарова", "Суворова", "Чеснокова" };
	std::vector<std::string> secondname = { "Александрович", "Алексеевич", "Андреевич", "Аркадьевич", "Богданович", "Васильевич", "Викторович", "Владимирович" , "Владиславович", "Вячеславоваич", "Глебович", "Григорьевич", "Денисович", "Добрынич", "Евгеньевич", "Донатович", "Евдакимович", "Евстафьевич", "Иннокентиевич", "Кириллович", "Константинович", "Ярославович", "Филатович", "Федотович" };
	std::vector<std::string> secondname2 = { "Трофимовна", "Тимуровна", "Тарасовна" , "Степановна" , "Станиславовна" , "Спиридонова" , "Сильвесторовна" , "Сергеевна" , "Семёновна" , "Севастьяновна" , "Святославовна" , "Савельевна" , "Руслановна" , "Романова" , "Радионовна" , "Разумникова" , "Прохоровна" , "Прокопьевна" , "Патаповна" , "Платонова" , "Павловна" };
	std::vector<std::string> city = { "Москва", "Санкт-Петербург", "Казань" , "Ростов-на-Дону" , "Нижний Новгород" , "Екатерибург" , "Новосибирс" , "Волгоград" , "Самара" , "Уфа" , "Воронеж" , "Красноярск" , "Саратов", "Владивосток", "Омск", "Краснодар", "Тюмень", "Сочи" };
	std::vector<std::string> street = { "Пушкина", "Есенина" , "Кремлёвская" , "Можайская" , "Каширская" , "Молостовых" , "Заводская" , "Земельная" , "Заречная" , "Зубовская" , "Октябрьская" , "Арбатская" , "Авангардская" , "Автозаводская" , "Авиационная" , "Соколиная" , "Садовая" };
	std::vector<std::string> newday1{ "01","02","03" ,"04" ,"05","06" ,"07" ,"08","09" };
	std::vector<std::string> newday2{ "10","11","12" ,"13" ,"14","15" ,"16" ,"17","18","19","20","21","22","23","24","25","26","27","28" };
	std::vector<std::string> seriya{ "45", "40", "46", "78", "75", "69", "03", "04" };
	std::vector<std::string> payday{ "5000руб", "10.000руб", "15.000руб", "20.000руб", "25.000руб", "30.000руб", "35.000руб", "40.000руб", "45.000руб", "50.000руб", "55.000руб", "60.000руб", "65.000руб", "70.000руб", "75.000руб", "80.000руб", "85.000руб", "90.000руб", "95.000руб", "100.000руб" };
	std::vector<std::string> education{ "Среднее","Высшее","Аспирантура" ,"Докторантура"};
	std::vector<std::string> social{ "Низший","Средний","Высший"};
	std::vector<std::string> estno{ "Есть", "Нет" };
	std::vector<std::string> job{ "Дантист","Фармацевт","Аналитик","Врач","Администратор","Разработчик","Стоматолог","Ветеринар","Средний","Программист","Психолог","Инженер","Средний" };
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
				"Мужчина" << std::setw(30) <<
				city[rand() % city.size()] << std::setw(15) <<
				seriya[rand() % seriya.size()] << dist4(gen) << "_" << dist5(gen) << std::setw(15) <<
				dist2(gen) << dist3(gen) << std::setw(15) <<
				dist8(gen) << dist9(gen) << std::setw(15) <<
				payday[rand() % payday.size()] << std::setw(20) <<
				job[rand() % job.size()] << std::setw(15) <<
				estno[rand() % estno.size()] << std::setw(15) <<
				"№" << dist10(gen) << "-" << dist10(gen) << "-" << dist10(gen) << "-" << dist0(gen) << std::setw(20) <<
				education[rand() % education.size()] << std::setw(15) <<
				social[rand() % social.size()] << std::setw(15) <<
				"ул." << street[rand() % street.size()] << "_" << "д." << dist7(gen) << "_" << "к." << dist6(gen) <<
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
				"Женщина" << std::setw(30) <<
				city[rand() % city.size()] << std::setw(15) <<
				seriya[rand() % seriya.size()] << dist4(gen) << "_" << dist5(gen) << std::setw(15) <<
				dist2(gen) << dist3(gen) << std::setw(15) <<
				dist8(gen) << dist9(gen) << std::setw(15) <<
				payday[rand() % payday.size()] << std::setw(20) <<
				job[rand() % job.size()] << std::setw(15) <<
				estno[rand() % estno.size()] << std::setw(15) <<
				"№" << dist10(gen) << "-" << dist10(gen) << "-" << dist10(gen) << "-" << dist0(gen) << std::setw(20) <<
				education[rand() % education.size()] << std::setw(15) <<
				social[rand() % social.size()] << std::setw(15) <<
				"ул." << street[rand() % street.size()] << "_" << "д." << dist7(gen) << "_" << "к." << dist6(gen) <<
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
	logdat << buffer << " " << " Cоздана новая база данных." << endl;
	logdat.close();
}

// Удаление БД
void Delete()
{
	remove("clients.txt");
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " База данных удалена. " << endl;
	logdat.close();
}

// Просмотр БД
void bd()
{
	system("notepad.exe clients.txt");
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " База данных была просмотрена. " << endl;
	logdat.close();
}

// Поиск клиента в БД
void find()
{
	bool ok = false;
	system("cls");
	ifstream in("clients.txt");
	string find;
	cout << "Поиск по номеру договора: " << endl;
	cin >> find;
	cout << "\nДанные клиента:" << endl;
	while (!in.eof())
	{
		in >> number >> surname >> name >> secondname >> mobile >> data >> gender >>  city >> passport >> polis >> inn >> payday >> job >> credit >> snils >> education >> social >> adress;
		if (number == find)
		{
			cout << "\n№ договора: " << number << endl;
			cout << "\nФамилия: " << surname << endl;
			cout << "\nИмя: " << name << endl;
			cout << "\nОтчество: " << secondname << endl;
			cout << "\nМоб.Телефон: " << mobile << endl;
			cout << "\nДата рождения: " << data << endl;
			cout << "\n Пол: " << gender << endl;
			cout << "\nРодной город: " << city << endl;
			cout << "\nСерия и номер паспорта: " << passport << endl;
			cout << "\nСерия и номер полиса ОМС: " << polis << endl;
			cout << "\nНомер ИНН: " << inn << endl;
			cout << "\nДоход: " << inn << endl;
			cout << "\nПрофессия: " << inn << endl;
			cout << "\nНаличие кредитов: " << inn << endl;
			cout << "\nСНИЛС: " << inn << endl;
			cout << "\nОбразование: " << inn << endl;
			cout << "\nСоц. класс: " << inn << endl;
			cout << "\nАдрес: " << adress << "\n" << "\n" << endl;
			ok = true;
			break;
		}
	}
	if (ok == false)
	{
		cout << "Информация не найдена!\n";
	}
	in.close();
	ofstream logdat("data.txt", ios_base::app);
	char buffer[80];
	time_t seconds = time(NULL);
	tm* timeinfo = localtime(&seconds);
	char* format = "%A, %B %d, %Y %H:%M:%S";
	strftime(buffer, 80, format, timeinfo);
	logdat << buffer << " " << " Был произведён поиск клиента." << endl;
	logdat.close();
	system("pause");
}

// Добавление клиента в БД
void client()
{
	system("cls");
	string number2, surname2, name2, secondname2, mobile2, data2, gender2, city2, passport2, polis2, inn2, payday2, job2, credit2, snils2, education2, social2, adress2;
	ofstream out("clients.txt", ios_base::app);
	cout << "\n№ договора: ";
	cin >> number2;
	cout << "\nФамилия: ";
	cin >> surname2;
	cout << "\nИмя: ";
	cin >> name2;
	cout << "\nОтчество: ";
	cin >> secondname2;
	cout << "\nМоб.Телефон(Пример:+79161456732): ";
	cin >> mobile2;
	cout << "\nДата рождения(Пример:25.02.1996): ";
	cin >> data2;
	cout << "\nПол(Пример:Мужской): ";
	cin >> gender2;
	cout << "\nРодной город: ";
	cin >> city2;
	cout << "\nСерия и номер паспорта(Пример:4687_419874): ";
	cin >> passport2;
	cout << "\nСерия и номер полиса ОМС(Пример:49343407491) : ";
	cin >> polis2;
	cout << "\nНомер ИНН(Пример:220330969920): ";
	cin >> inn2;
	cout << "\nДоход(Пример: 30.000руб): ";
	cin >> payday2;
	cout << "\nПрофессия(Пример: Дантист): ";
	cin >> job2;
	cout << "\nНаличие кредитов(Пример: Есть): ";
	cin >> credit2;
	cout << "\nСНИЛС(Пример :  №428-996-265-12): ";
	cin >> snils2;
	cout << "\nОбразование(Пример: Высшее): ";
	cin >> education2;
	cout << "\nСоц. класс(Пример: Средний): ";
	cin >> social2;
	cout << "\nАдрес(Пример: ул.Промышленная_д.40_к.6): ";
	cin >> adress2;

	out << setw(3) << number2 << setw(15) << surname2 << setw(15) << name2 << setw(15) << secondname2 << setw(15) << mobile2 << setw(15) << data2 << setw(15) << gender2 << setw(30) << city2 << setw(15) << passport2 << setw(15) << polis2 << setw(15) << inn2 << setw(15) << payday2 << setw(20) << job2 << setw(15) << credit2 << setw(15) << snils2 << setw(20) << education2 << setw(15) << social2 << setw(15) << adress2 << endl;
	out.close();
}

// Регистрация сотрудника
void reg_user()
{
	string login3, login4, password4;
	bool boom = true;
	system("cls");

	cout << "Придумайте Логин и пароль\n";
	cout << "Логин:";
	cin >> login4;
	cout << "Пароль:";
	cin >> password4;
	login3 = login;
	string login2, password2;
	ifstream in2("user.txt");
	while (!in2.eof())
	{
		in2 >> login2 >> password2;
		if (login4 == login2)
		{
			cout << "Такой Логин уже зарегистрирован!" << endl;
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
	logdat << buffer << " " << " Пользователь " << login3 << "  был зарегистрирован!" << endl;
	logdat.close();
}

// Регистрация админа
void reg_admin()
{
	string login3, login4, password4;
	bool boom = true;
	system("cls");

	cout << "Придумайте Логин и пароль\n";
	cout << "Логин:";
	cin >> login4;
	cout << "Пароль:";
	cin >> password4;
	login3 = login4;
	string login2, password2;
	ifstream in2("admin.txt");
	while (!in2.eof())
	{
		in2 >> login2 >> password2;
		if (login4 == login2)
		{
			cout << "Такой Логин уже зарегистрирован!" << endl;
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
	logdat << buffer << " " << " Админ" << login3 << "  был зарегистрирован!" << endl;
	logdat.close();
}

// Функции админа
void admin()
{
	security = true;
	while (true)
	{
		system("cls");
		cout << "Выберите функцию\n";
		cout << "\n1.Работа с базой данных\n";
		cout << "2.Регистрация\n";
		cout << "3.Сменить пользователя\n";
		cout << "4.Выйти из системы\n";

		cout << "Вариант: ";
		cin >> choose;
		if (choose == "1")
		{
			system("cls");
			cout << "Выберите функцию\n";
			cout << "\n1.Создать базу\n";
			cout << "2.Удалить базу\n";
			cout << "3.Просмотр базы\n";
			cout << "4.Найти клиента\n";
			cout << "5.Новый клиент\n";
			cout << "6.Вернуться в меню\n";

			cout << "Вариант: ";
			cin >> choose;

			if (choose == "1")
			{
				Create();
				system("cls");
				cout << "Выберите функцию\n";
				cout << "\n1.Удалить базу\n";
				cout << "2.Просмотр базы\n";
				cout << "3.Найти клиента\n";
				cout << "4.Новый клиент\n";
				cout << "5.В меню\n";

				cout << "Вариант: ";
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
				cout << "Выберите функцию\n";
				cout << "\n1.Создать базу\n";
				cout << "2.Просмотр базы\n";
				cout << "3.Найти клиента\n";
				cout << "4.Новый клиент\n";
				cout << "5.Вернуться в меню\n";

				cout << "Вариант: ";
				cin >> choose;

				if (choose == "1")
				{
					Create();
					system("cls");
					cout << "Выберите функцию\n";
					cout << "\n1.Удалить базу\n";
					cout << "2.Просмотр базы\n";
					cout << "3.Найти клиента\n";
					cout << "4.Новый клиент\n";
					cout << "5.Сохранить и выйти\n";

					cout << "Вариант: ";
					cin >> choose;

					if (choose == "1")
					{
						Delete();
					}
					else if (choose == "2")
					{
						bd();
						system("cls");
						cout << "Выберите функцию\n";
						cout << "\n1.Сохранить и выйти\n";

						cout << "Вариант: ";
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
					cout << "Выберите функцию\n";
					cout << "\n1.Сохранить и выйти\n";

					cout << "Вариант: ";
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
				cout << "Выберите функцию\n";
				cout << "\n1.Сохранить и выйти\n";

				cout << "Вариант: ";
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
			cout << "Выберите функцию\n";
			cout << "1.Регистрация сотрудника\n";
			cout << "2.Регистрация админа\n";
			cout << "3.Вернуться в меню\n";

			cout << "Вариант: ";
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

// Функции пользователя
void user()
{
	security = true;
	while (true)
	{
		system("cls");
		cout << "Выберите функцию\n";
		cout << "\n1.Работа с базой данных\n";
		cout << "2.Сменить пользователя\n";
		cout << "3.Выйти из системы\n";

		cout << "Вариант: ";
		cin >> choose;
		if (choose == "1")
		{
			system("cls");
			cout << "Выберите функцию\n";
			cout << "1.Просмотр базы\n";
			cout << "2.Найти клиента\n";
			cout << "3.Новый клиент\n";
			cout << "4.Сохранить и выйти\n";

			cout << "Вариант: ";
			cin >> choose;

			if (choose == "1")
			{
				bd();
				system("cls");
				cout << "Выберите функцию\n";
				cout << "\n1.Сохранить и выйти\n";

				cout << "Вариант: ";
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

// Логин
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
	cout << "\t" << "\t" << "    Добро пожаловать!\n";
	cout << "Логин: ";
	cin >> login;
	cout << "Пароль: ";
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
		logdat << buffer << "     Админ вошёл в систему!" << endl;
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
		logdat << buffer << "  " << login2 << " вошёл в систему!" << endl;
		logdat.close();
		system("cls");
		user();
	}
	while (login != ulogin && password != upassword || login != alogin && password != apassword)
	{
		auth = false;
		auth2 = false;
		system("cls");
		cout << "\t" << "\t" << "    Добро пожаловать!\n";
		cout << "Логин: ";
		cin >> login;
		cout << "Пароль: ";
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
			logdat << buffer << "     Админ вошёл в систему!" << endl;
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
			logdat << buffer << "  " << login2 << " вошёл в систему!" << endl;
			logdat.close();
			system("cls");
			user();
		}
	}
	return 0;
}