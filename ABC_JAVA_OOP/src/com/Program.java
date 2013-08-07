package com;

public class Program {
	public static void main(String[] args)
	{
		 String music1 = "DEFGABcd";
         String music2 = "D2E2F3GABcd";
         String music3 = "defgabc'd'";
         String music4 = "dcB|A2FAD2FA|dAdefdBd|A~F3DFAF|GBEFGdcB|A~F3D2FA|dAdefdBd|AdcBAFGE|FD~D3|";
         String music5 = "dD~D2 FDFA|dfaf gfec|dD~D2 FDFA|GFEF GABc|dD~D2 FDFA|dfaf gfeg|fdec dBAF|GFEF GABc|d2fd Adfd|d2fd BABc|d2fd Adfd|BGEF GABc|d2fd Adfd|d2fd cdeg|fdec dAFA|GFEF GABc|d2fd Adfd|d2fd BABc|dcde fdAF|GEFD ~E3z|~a3b afdf|gfef gbag|fdec dBAF|GFEF GABc";
         String tildeTest = "B2c4d4e6F6";
         String sharpTest = "C^C D^D E^E F^F G^Ga^ab^b";
         String music7 = "DdAGgAfA|DdAGgAfA|EdAGgAfA|EdAGgAfA|GdAGgAfA|GdAGgAfA|DdAGgAfA|DdAGgAfA|DdAGgAfA|DdAGgAfA|EdAGgAfA|EdAGgAfA|GdAGgAfA|GdAGgAfA|DdAGgAfA|DdAGgAfA|";
		
         Notes myNotes = new Notes();
         
         Song mySong = new Song();
         
         mySong.play(music7, myNotes);
         
		
	}
	
	

}
