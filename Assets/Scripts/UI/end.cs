using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    [SerializeField] private Store s;
    [SerializeField] private int c;

    private void Update()
    {
        if (s.count == c)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}
