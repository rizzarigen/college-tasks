"use strict";

let sum = 0;

let x;
let y;
let h = Math.PI/8;

console.log("-------------------------------------");

for (x=-Math.PI; x<=Math.PI; x += h) {
    y = (1/(x + 2*Math.PI)) - Math.sin(x);
    sum += y;
    console.log("x=" + x + "; y=" + y);
}

alert("Сумма: " + sum);

console.log("-------------------------------------");

x = -Math.PI;
sum = 0;

while (x <= Math.PI) {
    y = (1/(x + 2*Math.PI)) - Math.sin(x);
    sum += y;
    console.log("x=" + x + "; y=" + y);
    x += h;
}

alert("Сумма: " + sum);

console.log("-------------------------------------");

x = -Math.PI;
sum = 0;

do {
    y = (1/(x + 2*Math.PI)) - Math.sin(x);
    sum += y;
    console.log("x=" + x + "; y=" + y);
    x += h;
} while (x <= Math.PI);

alert("Сумма: " + sum);