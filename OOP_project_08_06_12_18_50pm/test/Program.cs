/*
 
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
       
          
         static void Main(string[] args)
            {
                string music1 = "DEFGABcd";
                string music2 = "D2E2F3GABcd";
                string music3 = "defgabc'd'";
                string music4 = "dcB|A2FAD2FA|dAdefdBd|A~F3DFAF|GBEFGdcB|A~F3D2FA|dAdefdBd|AdcBAFGE|FD~D3|";
                string music5 = "dD~D2 FDFA|dfaf gfec|dD~D2 FDFA|GFEF GABc|dD~D2 FDFA|dfaf gfeg|fdec dBAF|GFEF GABc|d2fd Adfd|d2fd BABc|d2fd Adfd|BGEF GABc|d2fd Adfd|d2fd cdeg|fdec dAFA|GFEF GABc|d2fd Adfd|d2fd BABc|dcde fdAF|GEFD ~E3z|~a3b afdf|gfef gbag|fdec dBAF|GFEF GABc";
                string tildeTest = "~B~c~d~eF4~";
                string sharpTest = "C^C D^D E^E F^F G^Ga^ab^b";
                string music7 = "dff cee|def gfe|dff cee|dfe dBA|dff cee|def gfe|faf gfe|1 dfe dBA:|2 dfe dcB|~A3 B3|gfe fdB|AFA B2c|dfe dcB|~A3 ~B3|efe efg|faf gfe|1 dfe dcB:|2 dfe dBA|fAA eAA|def gfe|fAA eAA|dfe dBA|fAA eAA|def gfe|faf gfe|dfe dBA:|";


                /* creates a new Notes object. When the program gets to here it jumps accross to Notes 
                 * Class where it
                 1. initializes pitch array
                 2. intializes the notesArray
                 3. Calls defalut constructor and sets all fields to their values
                 4. then returns back to program */
                Notes mynotes = new Notes();
                
                /* creates a new Player object called myPlayer. . It then
                    runs through all the methods of the PLayer class*/

                Player myPLayer = new Player();// create new player object

                myPLayer.play(music5, mynotes);//the play method takes the string of music to play and the new note
                                               // object(which contains all information about notes) as parameters
            }
          
     }

          
        
    
}
