x = +prompt();
y = +prompt();
a = +prompt();
b = +prompt();

if (x < y) {
  minEl = a - Math.cos(x);
  if (a / (b + y) < minEl) {
    minEl = a / (b + y);
  }
  if (Math.pow(Math.sin(y), 2) < minEl) {
    minEl = Math.pow(Math.sin(y), 2);
  }
  z = minEl;
} else if (y <= x && x < y + 5) {
  maxEl = Math.pow(a, 3);

  if (maxEl < Math.log(Math.pow(x, 2) + Math.pow(y, 2))) {
    maxEl = Math.log(Math.pow(x, 2) + Math.pow(y, 2));
  }
  z = maxEl;
} else if (x >= y + 5) {
  z = a + Math.pow(Math.cos(x - y), 3);
}

console.log(z);
alert(z);
