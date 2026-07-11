using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class whyzoo1 : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void Update()
    {
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            animator.SetBool("breaking",true);
        }
    }
}
