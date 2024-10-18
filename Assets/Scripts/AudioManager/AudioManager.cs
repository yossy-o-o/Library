using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource bgmSource;
    public AudioSource sfxSource;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void ChangeBGM(AudioClip newBGM)
    {
        bgmSource.clip = newBGM;
        bgmSource.Play();
    }
}
