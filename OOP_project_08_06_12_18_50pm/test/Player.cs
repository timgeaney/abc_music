/*
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Player
    {      
        //takes in string of ABC music characters and the Notes object as parameters
        public void play(string music, Notes noteInfo)
        {
            for (int i = 0; i <= music.Length -1 ; i++)

            {
                if (i != music.Length - 1)// if its not the last character in the array do the following conditional statements. 
                    //Without this you get an exception out of bounds error as program tries to go past last array position
                {
                    if (music[i + 1] == ',')//if next character is a ',' signifiying a note down an octave
                    {
                        noteInfo.PitchMult = noteInfo.PitchMult / 2; // divide pitch by 2
                    }
                    if (music[i + 1] == '\'')//if next character is a ' signifiying a note up an octave
                    {
                        noteInfo.PitchMult = noteInfo.PitchMult * 2;// multiply pitch by 2
                    }

                    if (char.IsNumber(music[i + 1]))// char.IsNumber returns the ASCII value for the number (as in 2 in decimal = 50 in ascii)
                    {
                        noteInfo.DurMult = noteInfo.DurMult * (music[i + 1] - 48);// ddt 48 from the ASCI value to get back to decimal value
                    }

                    if (music[i] == '^')// play sharp note
                    {
                        playSharp(noteInfo, music[i + 1]);
                        printMusic(noteInfo, music[i + 1]);// call the print music method
                        noteInfo.ResetNote();// call the ResetNote method
                        i++;// move past already payed note(withou this it plays note following^ twice)
                        continue;// break will exit loop completely while continue will stop the current iteration
                    }

                    else if (music[i] == ('~'))// if tilde character is next character
                    {
                        playTilde(noteInfo, music[i + 1]);//call playTilde method pass it in the noteInfo from the Notes class
                        noteInfo.ResetNote();// call the ResetNote function to reset all notes values back to orgional ready fro next note in music string
                        //i++; we want it to play this note again with its time signature so we don't skip it like with the sharp
                        continue; // continue out of loop if you matched this character stops program from continuing to iterate through te loop
                    }
                }
                        //After checking all these conditions Now play note
                        PlayNote(noteInfo, music[i]);// call play note method
                        printMusic(noteInfo, music[i]);// call the print music method
                        noteInfo.ResetNote();// call the ResetNote method
                        continue;
            }

        }
        // configuration and the note you want to play.
        private void PlayNote(Notes noteInfo, char note)
        {
            int pitch = noteInfo.Note2Pitch(note);// Note2Pitch matches note info (or character) with pitch. Here program jumps accross to the Note2Pitch method in the Notes class
            if (pitch != 0)
                Console.Beep((int)(pitch * noteInfo.PitchMult),(int)(noteInfo.Duration * noteInfo.DurMult));//this is where the magic happens! (Had to cast values to ints because they are doubles and console.Beep only accepts ints)
        }

        private void playTilde(Notes noteInfo, char notesArray)
        {
            int pitch1 = noteInfo.Note2PitchUp(notesArray);// move pitch up a note
            int pitch2 = noteInfo.Note2Pitch(notesArray);//same pitch
            int pitch3 = noteInfo.Note2PitchDown(notesArray);// move pitch down a note
           
            Console.WriteLine("pitch1 =" + pitch1 + "pitch2 =" + pitch2 + "pitch3 =" + pitch3 + "Tilde Note =" + notesArray);

            if (pitch1 != 0 && pitch2 != 0 && pitch3 != 0)// first check whether pitch is not zero
            {
                Console.Beep((int)(pitch1 * noteInfo.PitchMult), (int)(noteInfo.Duration * (noteInfo.DurMult * 0.25)));//cahnge duration to quater note
                Console.Beep((int)(pitch2 * noteInfo.PitchMult), (int)(noteInfo.Duration * (noteInfo.DurMult * 0.50)));// change duration to half note
                Console.Beep((int)(pitch3 * noteInfo.PitchMult), (int)(noteInfo.Duration * (noteInfo.DurMult * 0.25)));// change duration to quater note
            }
        
        }

        private void playSharp(Notes noteInfo, char notesArray)
        {

            int pitchSharp = noteInfo.Note2Pitch(notesArray);

            if (pitchSharp != 0)// first check whether pitch is not zero
            {
                noteInfo.PitchMult += noteInfo.PitchMult * .06; // increase pitch by 6% to get sharp note
                Console.Beep((int)(pitchSharp * noteInfo.PitchMult), (int)(noteInfo.Duration * (noteInfo.DurMult)));//change duration to quater note
            }

        }

        public void printMusic(Notes noteInfo, char note)//method to print out music characters 
        {
            //int pitch = noteInfo.Note2Pitch(note);
            //if (note != ':' || '')
            {
            Console.Write(note);
            }
        }

    }
}
