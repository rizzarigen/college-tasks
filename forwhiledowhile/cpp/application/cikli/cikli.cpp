
#include <iostream>
#define _USE_MATH_DEFINES
#include <math.h>


using namespace std;



int main()
{
    setlocale(LC_ALL, "");

    double x;
    double y;
    double h = M_PI / 8;
    
    double sum{};

    for (x = -M_PI; x <= M_PI; x += h) {
        
        y = (1 / (x + 2 * M_PI)) - sin(x);
        sum += y;
        cout << "x =" << x << "; y=" << y << endl;
    }

    cout <<"Сумма: "<< sum << endl;

    cout << "-------------------------------------" << endl;

    x = -M_PI;
    sum = 0;

    while (x <= M_PI) {
        y = (1 / (x + 2 * M_PI)) - sin(x);
        sum += y;
        cout << "x =" << x << "; y=" << y << endl;
        x += h;
    }

    cout << "Сумма: " << sum << endl;

    cout << "-------------------------------------" << endl; 
    x = -M_PI;
    sum = 0;

    do {
        y = (1 / (x + 2 * M_PI)) - sin(x);
        sum += y;
        cout << "x =" << x << "; y=" << y << endl;
        x += h;
    } while (x <= M_PI);

    cout << "Сумма: " << sum << endl;
}
