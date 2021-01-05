$(document).ready(function() {
percent = 0;percent1 = 0;percent2 = 0;percent3 = 0; percent4 = 0; percent5 = 0; percent6 = 0; percent7 = 0; inc = 1;
    timerId = setInterval(function() { percent += inc;
        $('.prg').css('width', percent + '%'); if (percent == 75) { clearInterval(timerId); } }, 20);
    timerId1 = setInterval(function() { percent1 += inc;
        $('.prg1').css('width', percent1 + '%'); if (percent1 == 85) { clearInterval(timerId1); } }, 20);
    timerId2 = setInterval(function() { percent2 += inc;
        $('.prg2').css('width', percent2 + '%'); if (percent2 == 75) { clearInterval(timerId2); } }, 20);
    timerId3 = setInterval(function() { percent3 += inc;
        $('.prg3').css('width', percent3 + '%'); if (percent3 == 90) { clearInterval(timerId3); } }, 20);
    timerId4 = setInterval(function() { percent4 += inc;
        $('.prg4').css('width', percent4 + '%'); if (percent4 == 80) { clearInterval(timerId4); } }, 20);
    timerId5 = setInterval(function() { percent5 += inc;
        $('.prg5').css('width', percent5 + '%'); if (percent5 == 79) { clearInterval(timerId5); } }, 20);
    timerId6 = setInterval(function() { percent6 += inc;
        $('.prg6').css('width', percent6 + '%'); if (percent6 == 90) { clearInterval(timerId6); } }, 20);
    timerId7 = setInterval(function() { percent7 += inc;
        $('.prg7').css('width', percent7 + '%'); if (percent7 == 80) { clearInterval(timerId7); } }, 20);
});