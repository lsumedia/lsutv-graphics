package  {
	
	import flash.display.MovieClip;
	import flash.utils.*;
	import flash.events.Event;
	import flash.events.TimerEvent;
	import se.svt.caspar.template.CasparTemplate;
	import flash.text.TextField;
	
	public class CountDown_L3 extends CasparTemplate {
		
		public var CountDownMovie:MovieClip;
		private var targetTime:Number = 0;
		var clockTimer:Timer = new Timer(1000);
		
		public function CountDown_L3(){
			clockTimer.addEventListener(TimerEvent.TIMER, RefreshClock);
			clockTimer.start();
			RefreshClock(null);
		}

		public override function SetData(xmlData:XML):void 
			{
				for each(var element:XML in xmlData.elements()){
					if(element.@id == "ProgramTitle"){
						CountDownMovie.ProgramTitle.text = String(element.data.@value);
					}
					if(element.@id == "ProgramStartTime"){
						targetTime = Number(element.data.@value) * 1000;
					}
					
				}
				
				RefreshClock(null);
				
				//super.SetData(xmlData);
			}
			
		private function RefreshClock(event:TimerEvent):void{
			var cDate = new Date();
			var cTime = cDate.getTime();
			
			var tLeft = targetTime - cTime;
			var secsLeft = Math.floor(tLeft/1000);
			
			CountDownMovie.CountDownTime.text = toTimeString(tLeft);
		}
		
		public function toTimeString(remainder:Number):String
		{						
			if (remainder < 1) return "00:00";
			
            var numHours:Number = Math.floor(remainder / 3600000);
            remainder = remainder - (numHours * 3600000);

            var numMinutes:Number = Math.floor(remainder / 60000);
            remainder = remainder - (numMinutes * 60000);

            var numSeconds:Number = Math.floor(remainder / 1000);
            remainder = remainder - (numSeconds * 1000);
			
			return (numHours > 0 ? toPadString(Math.min(9999, numHours)) + ":" : "") + toPadString(numMinutes) + ":" + toPadString(numSeconds);
		}
		
		public function toPadString(value:Number):String
		{
			var str:String = value.toString();
			while (str.length < 2)
				str = "0" + str;
			return str;
		}

	}
		
}
