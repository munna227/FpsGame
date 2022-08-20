using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Camera camerapos;
    private static SoundManager _instance;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SoundManager>();
            }

            return _instance;
        }
    }

    public AudioClip Walk;
    public AudioClip Shoot;
    public AudioClip enemyShoot;
    public AudioClip enemyDown;
    public AudioClip Realode;
    public AudioClip jump;

    public void PlaySound(AudioClip clipName)
    {
        AudioSource.PlayClipAtPoint(clipName,camerapos.transform.position,0.5f);
    }
}
