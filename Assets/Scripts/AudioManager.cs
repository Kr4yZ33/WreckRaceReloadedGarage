using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource; // Reference to our Audio Source

    public AudioClip gameClip1; // reference to our game clip1
    public AudioClip gameClip2; // reference to our game clip2
    public AudioClip gameClip3; // reference to our game clip3
    public AudioClip gameClip4; // reference to our game clip4
    public AudioClip gameClip5; // reference to our game clip5
    public AudioClip gameClip6; // reference to our game clip6
    public AudioClip gameClip7; // reference to our game clip7
    public AudioClip gameClip8; // reference to our game clip8
    public AudioClip gameClip9; // reference to our game clip
    public AudioClip gameClip10; // reference to our game clip
    public AudioClip gameClip11; // reference to our game clip
    public AudioClip gameClip12; // reference to our game clip
    public AudioClip gameClip13; // reference to our game clip
    public AudioClip gameClip14; // reference to our game clip
    public AudioClip gameClip15; // reference to our game clip
    public AudioClip gameClip16; // reference to our game clip
    
    AudioClip currentTrack; // the current track being played
    AudioClip previousTrack; // the previous track that was played

    public bool clip1 = true;
    public bool clip2;
    public bool clip3;
    public bool clip4;
    public bool clip5;
    public bool clip6;
    public bool clip7;
    public bool clip8;
    public bool clip9;
    public bool clip10;
    public bool clip11;
    public bool clip12;
    public bool clip13;
    public bool clip14;
    public bool clip15;
    public bool clip16;
    bool rotationFinished;
    bool trackStopped;
    bool delay;

    void Start()
    {
        if(currentTrack == null)
        {
            currentTrack = gameClip1;
        }
        if(previousTrack == null)
        {
            previousTrack = gameClip1;
        }
        PlayBGM();
    }

    void FixedUpdate()
    {
        if(rotationFinished)
        {
            rotationFinished = false;
            clip16 = false;
            clip1 = true;
            PlayBGM();
        }

    }

    /// <summary>
    /// Play car skeleton exploding sound clip
    /// </summary>
    public void PlayGameClip2()
    {
        if (currentTrack != gameClip2)
        {
            previousTrack = gameClip1;
            audioSource.clip = gameClip2;
            audioSource.Play();
        }
    }


    /// <summary>
    /// play the previous track that was being played
    /// </summary>
    public void PlayTrack()
    {
        audioSource.Play();
        trackStopped = false;
    }

    public void StopTrack()
    {
        audioSource.Stop();
        trackStopped = true;
        
    }

    public void PreviousTrack()
    {
        if(!trackStopped)
        {
            if (clip1)
            {
                clip1 = false;
                clip16 = true;
                return;
            }
            if (clip2)
            {
                clip2 = false;
                clip1 = true;
            }
            if (clip3)
            {
                clip3 = false;
                clip2 = true;
            }
            if (clip4)
            {
                clip4 = false;
                clip3 = true;
            }
            if (clip5)
            {
                clip5 = false;
                clip4 = true;
            }
            if (clip6)
            {
                clip6 = false;
                clip5 = true;
            }
            if (clip7)
            {
                clip7 = false;
                clip6 = true;
            }
            if (clip8)
            {
                clip8 = false;
                clip7 = true;
            }
            if (clip9)
            {
                clip9 = false;
                clip8 = true;
            }
            if (clip10)
            {
                clip10 = false;
                clip9 = true;
            }
            if (clip11)
            {
                clip11 = false;
                clip10 = true;
            }
            if (clip12)
            {
                clip12 = false;
                clip11 = true;
            }
            if (clip13)
            {
                clip13 = false;
                clip12 = true;
            }
            if (clip14)
            {
                clip14 = false;
                clip13 = true;
            }
            if (clip15)
            {
                clip15 = false;
                clip14 = true;
            }
            if (clip16)
            {
                clip16 = false;
                clip15 = true;
            }
            PlayBGM();
        }
    }
    
    public void NextTrack()
    {
        if(!trackStopped)
        {
            if (clip16)
            {
                clip16 = false;
                clip1 = true;
                return;
            }
            if (clip15)
            {
                clip15 = false;
                clip16 = true;
            }
            if (clip14)
            {
                clip14 = false;
                clip15 = true;
            }
            if (clip13)
            {
                clip13 = false;
                clip14 = true;
            }
            if (clip12)
            {
                clip12 = false;
                clip13 = true;
            }
            if (clip11)
            {
                clip11 = false;
                clip12 = true;
            }
            if (clip10)
            {
                clip10 = false;
                clip11 = true;
            }
            if (clip9)
            {
                clip9 = false;
                clip10 = true;
            }
            if (clip8)
            {
                clip8 = false;
                clip9 = true;
            }
            if (clip7)
            {
                clip7 = false;
                clip8 = true;
            }
            if (clip6)
            {
                clip6 = false;
                clip7 = true;
            }
            if (clip5)
            {
                clip5 = false;
                clip6 = true;
            }
            if (clip4)
            {
                clip4 = false;
                clip5 = true;
            }
            if (clip3)
            {
                clip3 = false;
                clip4 = true;
            }
            if (clip2)
            {
                clip2 = false;
                clip3 = true;
            }
            if (clip1)
            {
                clip1 = false;
                clip2 = true;
            }
            PlayBGM();
        }
    }

    IEnumerator PlayBGMDelay()
    {
        if(delay || trackStopped)
        {
            yield break;
        }

        delay = true;
        
        Debug.Log("Before Wait for seconds");
        yield return new WaitForSeconds(audioSource.clip.length);
        Debug.Log("After Wait for seconds");

        delay = false;

        if (trackStopped)
        {
            yield break;
        }

        if (clip16)
        {
            rotationFinished = true;
        }
        else
        {
            Debug.Log("Next track");
            NextTrack();
        }
    }


    void PlayBGM()
    {
        if (clip16)
        {
            audioSource.clip = gameClip16;
        }
        if (clip15)
        {
            audioSource.clip = gameClip15;
        }
        if (clip14)
        {
            audioSource.clip = gameClip14;
        }
        if (clip13)
        {
            audioSource.clip = gameClip13;
        }
        if (clip12)
        {
            audioSource.clip = gameClip12;
        }
        if (clip11)
        {
            audioSource.clip = gameClip11;
        }
        if (clip10)
        {
            audioSource.clip = gameClip10;
        }
        if (clip9)
        {
            audioSource.clip = gameClip9;
        }
        if (clip8)
        {
            audioSource.clip = gameClip8;
        }
        if (clip7)
        {
            audioSource.clip = gameClip7;
        }
        if (clip6)
        {
            audioSource.clip = gameClip6;
        }
        if (clip5)
        {
            audioSource.clip = gameClip5;
        }
        if (clip4)
        {
            audioSource.clip = gameClip4;
        }
        if (clip3)
        {
            audioSource.clip = gameClip3;
        }
        if (clip2)
        {
            audioSource.clip = gameClip2;
        }
        if (clip1)
        {
            audioSource.clip = gameClip1;
        }
        audioSource.Play();
        StartCoroutine(PlayBGMDelay());
    }
}
