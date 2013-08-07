package com;

public class Song {
	
	public void play(String music, Notes noteInfo)
	{
		char[] charMusic = music.toCharArray();
		
		for (int i = 0; i <= music.length() -1; i++)
		{
			if (i != charMusic.length -1)
			{
				if(charMusic[i] == '|' || charMusic[i] == ' ' || charMusic[i] =='~' || Character.isDigit(charMusic[i]))
				{
					continue;
				}
				if(charMusic[i + 1] == ',')
				{
					double pm = noteInfo.getPitchMulti() / 2;// problem is here?????the left hand of the assignment must be a variable????
				}
				
				if(charMusic[i + 1] =='\'')
				{
					double pm = noteInfo.getPitchMulti() * 2;	
						
				}
				if(Character.isDigit(charMusic[i + 1]))
				{
					int digitNextChar = Character.getNumericValue(charMusic[i + 1]);
                    double dm = (double)digitNextChar;
                    
                    playNote(noteInfo, charMusic[i], dm);
                    noteInfo.ResetNote();
                    System.out.println("note length = " + dm);
					
				}
				if (charMusic[i + 1] =='~')
				{
					playTilde(noteInfo, charMusic[i]);
					noteInfo.ResetNote();
					continue;
				}
				
				playNote(noteInfo, charMusic[i], noteInfo.getDurationMulti());
				printMusic(noteInfo, charMusic[i]);
				noteInfo.ResetNote();
				continue;
			}
		}
	}
	
	private void playNote(Notes noteInfo, char note, double durLength)
	{
		int pitch = noteInfo.Note2Pitch(note);
		double[] playBeep= Beep.beep(((double)pitch * noteInfo.getPitchMulti()), (noteInfo.getDuration() * durLength ));
        StdAudio.play(playBeep);
		
		
	}
	
	private void playTilde(Notes noteInfo, char note)
	{
		int pitch1 = noteInfo.Note2PitchUp(note);
		int pitch2 = noteInfo.Note2Pitch(note);
		int pitch3 = noteInfo.Note2PitchDown(note);
		
		double[] playBeep1= Beep.beep(((double)pitch1 * noteInfo.getPitchMulti()), (noteInfo.getDuration() * noteInfo.getDurationMulti() * 0.25));
        StdAudio.play(playBeep1);
        
        double[] playBeep2= Beep.beep(((double)pitch2 * noteInfo.getPitchMulti()), (noteInfo.getDuration() * noteInfo.getDurationMulti() * 0.5));
        StdAudio.play(playBeep2);
        
        double[] playBeep3= Beep.beep(((double)pitch3 * noteInfo.getPitchMulti()), (noteInfo.getDuration() * noteInfo.getDurationMulti() * 0.25));
        StdAudio.play(playBeep3);
	}
	
	
	
	
	public void printMusic(Notes noteInfo, char note)
	{
		int pitch = noteInfo.Note2Pitch(note);
		System.out.println("Note or character = " + note + " " + "Pitch = " + pitch);
		
	}

}
