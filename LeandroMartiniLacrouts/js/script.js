$(document).ready(function() {
    var percent = 0;
    
    timerId = setInterval(function() {
        //increment progress bar
        percent += 5;
        $('.progress-bar').css('width', percent+'%');
        $('.progress-bar').attr('aria-valuenow', percent);
 
        //complete
        if (percent == 75) {
            clearInterval(timerId);
        }
 
    }, 100);
});