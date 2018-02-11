/*
##############################################################
		Adobe Edge Animate to CasparCG Template Library
 				version 0.7.1 - 11.September.2015
 			by Seppo Sormunen / Pukki Visuals Oy
##############################################################

 	BIG THANX TO EVERYONE INVOLVED IN CASPARCG DEVELOPMENT
 		AND CASPARCG COMMUNITY AND PEOPLE IN FORUMS!

##############################################################

 Contains full, unmodified copies of these libs:

 	jQuery 1.11.2			http://jQuery.com
 	jQuery UI 1.11.4		http://jqueryui.com
 	GSAP 1.16.1 + plugins	http://greensock.com
	moment.js 2.10.2		http://momentjs.com
	socket.io 1.3.5			http://socket.io
	Underscore.js 1.8.3		http://underscorejs.org
	X2JS.js 1.1.5			https://code.google.com/p/x2js/
	Velocity 1.2.2 + UI		http://VelocityJS.org

##############################################################

Whats new in version 0.7.1:

 -	PHP CORS Proxy support and script for external data

Whats new in version 0.7.0:

 -	templateData & external data can now pass images, masks or both in format:
 	"img=images/imagefile.jpg", "mask=images/mask.png" or both "img=images/imagefile.jpg;mask=images/mask.png"
 -	Velocity.js and Velocity UI added
 - 	Masking for images - updateImage(element, image, maskImage)
 -	Removed isEdge parameter from updateData/updateText
 -	updateImage(element,image url, optional mask url) function added for changing images 
 -	updateText(element,text) function added, easier to remember but is same as updateData()
 -	"uppercase", "lowercase" & "capitalize" classes for text fields
 -	"autoscale" class, font autoscaling down for long texts
 -	new findDataWithAttr(from,searchAttr,searchValue,returnWhich,returnAttr) function added
 -	Active mapping for XML structures added
 -  new updateExternal() function added for external data updates
 -	data_activeMapping inverted and renamed to data_elementMapping! New syntax is "element":"data",
 	now allows to use same data in multiple elements
 -	added "edgeElement(element id)" function. Returns JQuery object of element. Id is naming convention "Symbol_Element" and so on..
 	Same as: var x = mainStage.getSymbol("symbol").$(element); etc.
 -	Underscore.js library added
 -	External library loading refined (using YepNope now)
 -	dataCaspar variable renamed to templateData for consistency, templateData contains all accessible data now.
 -	Debug re-designed. Cleaner look, new floating option
 -	Some code clean up & error management
 -	New minified version of E2C_Libraries file (now easier to add own libs also)

 v.0.6.1 - First release

##############################################################
Settings
##############################################################

*/

var debug_buttons = true;													// show debug buttons, for local browser testing, disable for production
var debug_floating = true;													// use floating debug panel, draggable

var data_useExternal = true;	 											// set true to use Ajax to get data from external datasource
var data_externalType = 'XML'; 												// if we use external data, is it XML, JSON or JSONP
var data_typeCasparXML = false;												// is external XML data styled as Caspar Template Data
var data_clientDataAsExternalParameters = false;							// pass Caspar Client data to external url as GET parameters
var data_jsonpCallback = "data";											// if JSONP, callback function to use
var data_externalUrl = 'http://domain/externaldata.xml'; 					// URL where we can fecth the data

var data_useProxy = false;													// use PHP CORS Proxy for external data
var data_proxyUrl = "http://localhost/php/proxy.php";						// URL of proxy script


 
var io_useWebSocket = false;
var io_websocketUrl = "http://192.168.1.100";

var data_elementMapping = { 													// Edge/DOM <- DATA mapping? THIS IS NOW INVERTED! Syntax: {"element":"data", more..}

	// example mapping, can be removed!	
	//"topInfo_topText" : "f0",
	"bottomInfo_infoBar_text" : "datasource.entry[0].field[3].__text",
	//"bottomInfo_flagImage" : "datasource.entry[0].field[0].__text",
	//"bottomInfo_name" : {source: "datasource.entry", attr:"_name", search:"full_name", resultIndex:"0"},
	//"bottomInfo_bwBar_text" : {source: "datasource.entry", attr:"_name", search:"source_type", resultIndex:"0"},

};



// Basic CasparCG functions
// #######################################################

function playCCG(){	// CASPAR CG - PLAY
	// insert code here
	mainStage.play();
}

function stop () {			// CASPAR CG - STOP
	// insert code here
	mainStage.play('outro',true);
}

function next () {			// CASPAR CG - NEXT
	// insert code here
	mainStage.play('next',true);
}

function update(str) {		// CASPAR CG - UPDATE
	parseCaspar(str);		// <- don't remove
	// insert code here


}


function updateExternal() {			// Executed when external data is updated (after ajax call)
	// insert code here


	// example of findDataWithAttr usage, FOR DEMO PURPOSES - CAN BE REMOVED
	//var names = findDataWithAttr("datasource.entry", "_name", "full_name", "*", "__text");
	//var images = findDataWithAttr("datasource.entry", "_name", "profile_image", "*", "__text");



	// end of your code
	updateAutoScale(); // <- don't remove, especially if your own code changes content of 'autoscale' texts
}

function remove(){			// CASPAR CG - REMOVE
	// insert code here
}


// Your own custom functions, to be used in timeline etc..
// #######################################################
// insert code here


function updateClock(){	// FOR DEMO PURPOSES - CAN BE REMOVED
	// updateData('MiddleBar_Clock' , moment().format("hh:mm:ss") );	// update clock element
}


$(function (){ // run on load - FOR DEMO PURPOSES - CAN BE REMOVED

	//var clock_timer = setInterval(function(){ updateClock(); }, 1000);	// we start timer for clock updates

	/*	here we could initialize WebSocket handlers

	socket.on('clock', function(socket) {
		updateData("TopBar_Clock",socket.time);
	});

	socket.on('test', function(socket){
		test_function();
	});

	*/

});


function test_function(){	// FOR DEMO PURPOSES - CAN BE REMOVED

	// Content manipulation jQuery
	//mainStage.getSymbol("Line1").$("Text").html(data1);

	// Basic jQuery effects
	//mainStage.getSymbol("Line1").getSymbolElement().slideDown(1000);

	// GASP Plugin Animation
	//TweenLite.to( mainStage.getSymbol("TopBar").$("Period") , 5, {text:"Period over!", ease:Linear.easeNone});

	// GASP Timeline Animation
	//mainStage.getSymbol("Line1").$("Text").html(data1);
	//mainStage.getSymbol("Line1").getSymbolElement().show();

	//var element = mainStage.getSymbol("TopBar").getSymbolElement();
	//var tl = new TimelineMax({repeat:0, repeatDelay:0});
	//tl.add( TweenLite.from(element, 1, {opacity:0}, {opacity:1}) );
	//tl.from( element, 1, {top:-100}, "-=1" );
}


// ########## END OF FILE ########## END OF FILE ###################
