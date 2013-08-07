 #!/usr/bin/python2.7
import winsound

#global variables
duration = 250
pitchMulti = 1
durMulti = 1

listPitch = [277, 294, 330, 370, 392, 440, 494, 554, 587, 659, 740, 784, 880, 988, 22000]
listNotes = ['C', 'D', 'E', 'F', 'G', 'A', 'B', 'c', 'd', 'e', 'f', 'g', 'a', 'b', 'z']
song1 = "dD~D2 FDFA|dfaf gfec|dD~D2 FDFA|GFEF GABc|dD~D2 FDFA|dfaf gfeg|fdec dBAF|GFEF GABc|d2fd Adfd|d2fd BABc|d2fd Adfd|BGEF GABc|d2fd Adfd|d2fd cdeg|fdec dAFA|GFEF GABc|d2fd Adfd|d2fd BABc|dcde fdAF|GEFD ~E3z|~a3b afdf|gfef gbag|fdec dBAF|GFEF GABc|"
song2 = "defgabc'd'"
song3 = 'DdAGgAfA|DdAGgAfA|EdAGgAfA|EdAGgAfA|GdAGgAfA|GdAGgAfA|DdAGgAfA|DdAGgAfA|DdAGgAfA|DdAGgAfA|EdAGgAfA|EdAGgAfA|GdAGgAfA|GdAGgAfA|DdAGgAfA|DdAGgAfA|'
songList = list(song3)
        

def playSong(songList):
     for i in range (len(songList)):
        for j in range (len(listNotes)):
           if songList[i] == listNotes[j]:
                if songList[i + 1].isdigit():
                    globals()['duration'] = duration * int(songList[i + 1]) 
                if songList[i + 1] == '\'':
                    globals()['pitchMulti'] = pitchMulti * 2
                if songList[i + 1] == ',':
                    globals()['pitchMulti'] = pitchMulti * 0.5   
                    
                winsound.Beep(int(listPitch[j] * pitchMulti) , int(duration))
                resetVariables()
                print songList[i]


def resetVariables():
    globals()['duration'] = 250
    globals()['pitchMulti'] = 1


def main():
    playSong(song3)

if __name__ == '__main__':main()