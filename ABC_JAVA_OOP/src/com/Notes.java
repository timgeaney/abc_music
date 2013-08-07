package com;

public class Notes {
	
	private int [] pitchArray = {277, 294, 330, 370, 392, 440, 494, 554, 587, 659, 740, 784, 880, 988, 22000};
	private char [] notesArray = {'C', 'D', 'E', 'F', 'G', 'A', 'B', 'c', 'd', 'e', 'f', 'g', 'a', 'b', 'z'};
	
	private double pitchMulti;
	private double durMulti;
	private double dur;
	
	public double getPitchMulti()
	{
		return pitchMulti;
	}
	public void setPitchMulti()
	{
		this.pitchMulti = pitchMulti;
	}
	public double getDurationMulti()
	{
		return durMulti;
	}
	public void setDurationMulti()
	{
		this.durMulti = durMulti;
	}
	public double getDuration()
	{
		return dur;
	}
	public void setDuration()
	{
		this.dur = dur;
	}
	
	
	
	public Notes()//constructor
	{
		pitchMulti = 1;
		durMulti = 1;
		dur = 0.250d;
	}
	
	
	public int Note2Pitch(char note)
	{
		for (int j = 0; j < notesArray.length-1; j++)
		{
			if (notesArray[j] == note)
				return pitchArray[j];
		}
		return 0;
		
	}
	public int Note2PitchUp(char note)
	{
		for (int j = 0; j < notesArray.length-1; j++)
		{
			if (notesArray[j] == note)
				return pitchArray[j + 1];
		}
		return 0;
		
	}
	public int Note2PitchDown(char note)
	{
		for (int j = 0; j < notesArray.length-1; j++)
		{
			if (notesArray[j] == note)
				return pitchArray[j - 1];
		}
		return 0;
		
	}
	
	
	
	public void ResetNote()
	{
		pitchMulti = 1;
		durMulti = 1;
		dur = 0.250d;
		
	}

	
}
