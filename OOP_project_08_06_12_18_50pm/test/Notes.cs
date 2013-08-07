/*
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Notes
    {

        private double pitchMultiplier;//a value used to change octaves by multiply either up or down the pitch

        public double PitchMult//property that gets and sets pitchMultiplier
        {
            get
            {
                return pitchMultiplier; 
            }
            set
            {
                pitchMultiplier = value;
            }
        }

        private double durationMultiplier;//a value used to change duration or timming by default set to 1.
        public double DurMult// had to make this a double for it to work (I don't know why?)
        {
            get
            {
                return durationMultiplier;
            }
            set
            {
                durationMultiplier = value;
            }
        }

        private double duration;// note time length as default set to 250.
        public double Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        //array to hold pitch values
        public int[] pitchArray = { 277, 294, 330, 370, 392, 440, 494, 554, 587, 659, 740, 784, 880, 988, 22000 };
       
        //array to hold note charcaters (z the symbol for rest corresponds to a frequency of 22000 in pitchArray so that its 
        //played as a rest note as computers speakers can't play that frequency and human beings can't hear above 20000mhz anyway)
        public char[] notesArray = { 'C', 'D', 'E', 'F', 'G', 'A', 'B', 'c', 'd', 'e', 'f', 'g', 'a', 'b', 'z' };
        
        // default constructor
        public Notes()
        {
            pitchMultiplier = 1;
            durationMultiplier = 1;
            duration = 250;
        }
        // constructor with parameters
        public Notes(double pitchMultiplier, double durationMultiplier, double duration)
        {
            this.pitchMultiplier = pitchMultiplier;
            this.durationMultiplier = durationMultiplier;
            this.duration = duration;
        }
        //returns corresponding pitch for note
        public int Note2Pitch(char note)// takes in a note from the string of music 
        {
            for (int j = 0; j < notesArray.Length-1; j++)//loops through notesArray
            {
                if (notesArray[j] == note)// compares the music string note to all notes in the notesArray and if its equal
                    return pitchArray[j]; //return the corresponding pitch value from the pitchArray. If character doesn't match it just moves on.
            }
            return 0;// if there is no match retun 0
        }

        public int Note2PitchUp(char note)// takes in a note from the string of music and move its pitch up one note
        {
            for (int j = 0; j < notesArray.Length - 1; j++)//loops through notesArray
            {
                if (notesArray[j] == note)// compares the music string note to all notes in the notesArray and if its equal
                    return pitchArray[j + 1]; //return the corresponding pitch value from the pitchArray. If character doesn't match it just moves on.
            }
            return 0;// if there is no match retun 0
        }

        public int Note2PitchDown(char note)// takes in a note from the string of music and drops its pitch down onw note
        {
            for (int j = 0; j < notesArray.Length - 1; j++)//loops through notesArray
            {
                if (notesArray[j] == note)// compares the music string note to all notes in the notesArray and if its equal
                    return pitchArray[j - 1]; //return the corresponding pitch value from the pitchArray. If character doesn't match it just moves on.
            }
            return 0;// if there is no match retun 0
        }

        public void ResetNote()// reset all notes values back to their defaults
        {
            pitchMultiplier = 1;
            durationMultiplier = 1;
            duration = 250;
        }
    }
}
  