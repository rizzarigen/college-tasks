let x = [5, -2, 0, 3, 4, 12, 7];

let count = 0;

let mid = 0;

for (let i = 0; i < x.length; i++) {
    if (x[i] > 0) {
        mid += x[i];
        count++;
    }
}

mid /= count;

console.log(mid)

for (let i = 0; i < x.length; i++) {
    if (x[i] > mid) {
        x[i] = mid
    }
}

console.log(x)
