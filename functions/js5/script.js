"use strict"

function bis(a, b, c) {
    return Math.sqrt((b*c) * (Math.pow(b+c, 2) - Math.pow(a, 2)))
}

let a = +prompt('Введите сторону a: ');

let b = +prompt('Введите сторону a: ');

let c = +prompt('Введите сторону a: ');

console.log(bis(a, b, c));
console.log(bis(b, a, c));
console.log(bis(c, a, b));
