using Unity.VisualScripting;
using UnityEngine;

public class SingletonAudioManager : MonoBehaviour
{
    public static SingletonAudioManager Instance;
    [SerializeField] AudioSource audioAmbiente;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayMusic(AudioClip clip, float volume)
    {
        audioAmbiente.clip = clip;
        audioAmbiente.volume = volume;
        audioAmbiente.loop = true;
        audioAmbiente.Play();
    }

}
