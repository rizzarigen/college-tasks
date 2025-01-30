//18

let x = +prompt('Введите x:')
let y = +prompt('Введите y:')

let f = (((Math.PI/3) + Math.log(x^3)) / (3*y - x)) + (x * Math.sin(y^2))

let i = f
let j = Math.floor(f)

console.log("i = " + i)
console.log("j = " + j)
