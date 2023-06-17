using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioManager
{
    public class Cow : Animal
    {
        public override void animalSound()
        {
            AudioFileReader audioFileReader = new AudioFileReader("Resources/cow.wav");
            WaveOutEvent waveOutEvent = new WaveOutEvent();
            waveOutEvent.Init(audioFileReader);
            waveOutEvent.Play();
            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }
            waveOutEvent.Dispose();
            audioFileReader.Dispose();
        }
    }
}
