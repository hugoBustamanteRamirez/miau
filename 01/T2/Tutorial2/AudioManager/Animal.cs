using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
namespace AudioManager
{
    public class Animal
    {
        public virtual void animalSound()
        {
            AudioFileReader audioFileReader = new AudioFileReader("Resources/dog.wav");
            WaveOutEvent waveOutEvent=new WaveOutEvent(); 
            waveOutEvent.Init(audioFileReader);
            waveOutEvent.Play();
            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep  (500);
            }
            waveOutEvent.Dispose();
            audioFileReader.Dispose();
        }
        
    }
}
