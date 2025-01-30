
#define _USE_MATH_DEFINES

#include <iostream>
#include <cmath>
using namespace std;

double peri(int, int);

int main()
{
    
    
    int rad;

    cin >> rad;

    cout << "Периметр 10-тиугольника: " << peri(10, rad) << endl;
    cout << "Периметр 50-тиугольника: " << peri(50, rad) << endl;
    cout << "Периметр 100угольника: " << peri(100, rad) << endl;

}

double peri(int n, int R) {
        double degrad = (180 / n) * (3.14 / 180);
        double a = 2 * R * sin(degrad);
        return a;
    }