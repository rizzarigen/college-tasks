
#include <iostream>
#include "lap.h"

using namespace std;

int year;

int main()
{
    setlocale(LC_ALL, "Russian");
    
    char key;

    while (true) {
        cout << "Введите год" << endl;
        cin >> year;
        if (year != 0) {
            if (checkLapYear(year)) {
                cout << "Год будет високосным" << endl;
            }
            else {
                cout << "Год не будет високосным" << endl;
            }
        }
        else
        {
            break;
        }
        
    }


}
