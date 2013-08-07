
public class abc {
	
	static double pitchMulti = 1;
	static int durMultipli = 1;
	static double dur = 0.25d; 
	
	public static void main (String[] args) throws Exception
	{
		int[] pitch = { 277, 294, 330, 370, 392, 440, 494, 554, 587, 659, 740, 784, 880, 988, 22000 };
		char[] notes = { 'C', 'D', 'E', 'F', 'G', 'A', 'B', 'c', 'd', 'e', 'f', 'g', 'a', 'b', 'z'};
		
		//String s = "dD~D2 FDFA|dfaf gfec|dD~D2 FDFA|GFEF GABc|dD~D2 FDFA|dfaf gfeg|fdec dBAF|GFEF GABc|d2fd Adfd|d2fd BABc|d2fd Adfd|BGEF GABc|d2fd Adfd|d2fd cdeg|fdec dAFA|GFEF GABc|d2fd Adfd|d2fd BABc|dcde fdAF|GEFD ~E3z|~a3b afdf|gfef gbag|fdec dBAF|GFEF GABc|";
		  String music = "DdAGgAfA|DdAGgAfA|EdAGgAfA|EdAGgAfA|GdAGgAfA|GdAGgAfA|DdAGgAfA|DdAGgAfA|DdAGgAfA|DdAGgAfA|EdAGgAfA|EdAGgAfA|GdAGgAfA|GdAGgAfA|DdAGgAfA|DdAGgAfA|";
		
		char[] abcArray = music.toCharArray();
		
		for (int currentChar = 0; currentChar < abcArray.length; currentChar++)// loop through all char in string piece of music
        {
            for (int j = 0; j < notes.length; j++)// then loop through all the notes and check following consitions
            {
                if (abcArray[currentChar] == notes[j])// if index abcArray currentChar does not equal index noteArray i move on to next index
                {

                int nextChar = currentChar + 1;
                
                if (currentChar < abcArray.length - 1 && abcArray[nextChar] == ('\''))
                {
                    pitchMulti =  2.0d;
                }
                if (currentChar < abcArray.length - 1 && abcArray[nextChar] == (','))
                {
                    pitchMulti = 0.5d;
                }
                
                if (currentChar < abcArray.length - 1 && Character.isDigit(abcArray[nextChar])==true)
                {  
                	int digitNextChar = Character.getNumericValue(abcArray[nextChar]);
                    durMultipli = digitNextChar;// subtract 48 to get back to decimal value of char
                    System.out.println("note length = " + digitNextChar);
                }
                
                

                if (currentChar < abcArray.length - 1 && abcArray[nextChar] == ('~'))
                {
                   
                    System.out.println("~ = Tilde");                 
                    
                }
  
              
                    double[] playBeep= Beep.beep(((double)pitch[j] * pitchMulti), (dur * durMultipli));
                    StdAudio.play(playBeep);
                    
                	
                    System.out.println("Note: " + notes[j]  + " Pitch: " + pitch[j]);

                    durMultipli = 1;// reset durationMultiplier back to one
                    pitchMulti = 1.0d;// reset pitchMultiplier back to one
                    break;// if match is found break out of inner loop and start iterating through abdArray again
                }

            }
		
        }
		
		
		
	}

}
