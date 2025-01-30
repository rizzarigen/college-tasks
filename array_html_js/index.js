inbox = document.getElementById('inBox');
btn = document.getElementById('calculateBtn');
outbox = document.getElementById('outBox');


btn.onclick = function (){
    outbox.value = "";
    let x = inbox.value.split('\n').filter(element => element != "");
    let count = 0;

    let mid = 0;

    for (let i = 0; i < x.length; i++) {
        if (Number(x[i]) > 0) {
            mid += Number(x[i]);
            count++;
        }
    }

    mid /= count;

    for (let i = 0; i < x.length; i++) {
        if (Number(x[i]) > mid) {
            x[i] = mid
        }
    }
    
    for (let i = 0; i < x.length; i++) {
        outbox.value += x[i] + '\n';
    }

}