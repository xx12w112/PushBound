using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
{
    public static int Count = 0;
    [SerializeField] private int clearCount;
    private bool isClear = true;
    [SerializeField] private int c;
    
    private void Update()
    {
        if (Keyboard.current.nKey.isPressed && Keyboard.current.eKey.isPressed && Keyboard.current.xKey.isPressed &&
            Keyboard.current.tKey.isPressed)
        {
            isClear = false;
            SceneManager.LoadScene(c);
        }
        if (Count == clearCount && isClear)
        {
            isClear = false;
            SceneManager.LoadScene(c);
        }
    }
}
