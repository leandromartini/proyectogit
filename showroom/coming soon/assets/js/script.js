$(function(){
	
	var note = $('#note'),
		ts = new Date(2019, 11 - 1 , 15),
		newYear = true;
	
		var diffDays = parseInt((ts - new Date()) / (1000 * 60 * 60 * 24), 10); 
		

	if(diffDays < 10){
		// The new year is here! Count towards something else.
		// Notice the *1000 at the end - time must be in milliseconds
		//ts = (new Date()).getTime() + 10*24*60*60*1000;
		newYear = false;
	}
		
	$('#countdown').countdown({
		timestamp	: ts,
		callback	: function(days, hours, minutes, seconds){
			
			var message = "";
			
			message += days + " day" + ( days==1 ? '':'s' ) + ", ";
			message += hours + " hour" + ( hours==1 ? '':'s' ) + ", ";
			message += minutes + " minute" + ( minutes==1 ? '':'s' ) + " and ";
			message += seconds + " second" + ( seconds==1 ? '':'s' ) + " <br />";
			
			if(newYear){
				message += "PROXIMAMENTE";
			}
			else {
				message += "quedan 10 días!";
			}
			
			note.html(message);
		}
	});
	
});
