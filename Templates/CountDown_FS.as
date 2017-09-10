package  {
	
	import flash.display.MovieClip;
	import flash.events.Event;
	import flash.events.TimerEvent;
	import flash.text.TextField;
	import flash.text.TextFieldAutoSize;
	import flash.text.TextFormat;
	import flash.utils.*;
	import se.svt.caspar.template.CasparTemplate;
	
	
	public class Countdown_FS extends CasparTemplate {
		
		public function Countdown_FS() 
		{		
			trace("[CountDown]");
			
			xTime.text = "";
			myTimer.addEventListener("timer", onTimer);			
			onTimer(null);
			myTimer.start();
			
			this.xTime
			this.visible = true;//false;
			this.allowPlay = true; //false;
			targetTime = new Date(2000, 5, 7, 15, 0, 0).getTime();
		}
		
		override public function SetData(xmlData:XML):void
		{		
			var year:Number;
			var month:Number;
			var day:Number;
			var hour:Number;
			var min:Number;
			var sec:Number;
			
			for each (var element:XML in xmlData.elements())
			{				
				if (element.@id == "f0")	
					year = Number(element.data.@value);						
				else if (element.@id == "f1")
					month= Number(element.data.@value)-1;
				else if (element.@id == "f2")
					day = Number(element.data.@value);
				else if (element.@id == "f3")
					hour = Number(element.data.@value);
				else if (element.@id == "f4")
					min = Number(element.data.@value);
				else if (element.@id == "f5")
					sec = Number(element.data.@value);
			}
			
			targetTime = new Date(year, month, day, hour, min, sec).getTime();
			this.allowPlay = true;
			
			onTimer(null);
		}
	}
	
}
