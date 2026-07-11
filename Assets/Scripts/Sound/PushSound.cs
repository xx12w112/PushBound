using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PushSound : MonoBehaviour
{
   private AudioSource As;
   [SerializeField] private PlayerPush pph;

   private void Awake()
   {
      As = GetComponent<AudioSource>();
   }

   private void Update()
   {
      if (As.time > 1f)
      {
         As.enabled = false;
      }
      if (pph.isPush && pph.IsMove && Keyboard.current.spaceKey.wasPressedThisFrame)
      {
         As.enabled = false;
         As.enabled = true;
      }
   }
   
   
   
}
