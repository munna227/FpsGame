using UnityEngine.Audio;
using UnityEngine;

public class Option : MonoBehaviour
{
  
    public AudioMixer mainMixer;
   public void SetVolume(float volume)
   {
       mainMixer.SetFloat("Volum",volume);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

  
}

