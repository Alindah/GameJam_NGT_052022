using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource correct;
    public AudioSource wrong;
    public AudioSource fail;
    public AudioSource levelUp;

    public void PlaySoundEffect(AudioSource audio)
    {
        audio.Play();
    }
}
