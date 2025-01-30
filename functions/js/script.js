function peri(n, R) {
    let degrad = (180/n) * (Math.PI/180);
    return 2*R*Math.sin(degrad);
}

let r = +prompt('Введите радиус')

alert("Периметр 10-тиугольника: " + peri(10, r));
alert("Периметр 50-тиугольника: " + peri(50, r));
alert("Периметр 100-угольника: " + peri(100, r));