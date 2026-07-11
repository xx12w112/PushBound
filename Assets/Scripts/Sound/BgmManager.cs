using UnityEngine;

public class BgmManager : MonoBehaviour
{
    public static BgmManager Instance;

    [SerializeField] private AudioSource bgmSource;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (!bgmSource.isPlaying)
        {
            bgmSource.Play();
        }
    }
}
