using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public bool isMove = true;
    private Vector3 MoveDir3 = new Vector3(1, 0, 0);
    [SerializeField] private Back rollbacktransform;
    [SerializeField] private GameObject RotationObject;
    [SerializeField] private Animator anim;
    private SpriteRenderer sprite;
    [SerializeField] private int playerCount;
    [SerializeField] private PlayerPush Push;
    private bool delay = true;
    [SerializeField] private AudioSource MoveSound;

    private void Awake()
    {
        MoveSound.clip.LoadAudioData();
    }
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (MoveSound.time > 0.3f)
        {
            MoveSound.enabled = false;
        }
        if (isMove)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                MoveSound.enabled = false;
                MoveSound.enabled = true;
                rollbacktransform.RollBackPlayer.Push(transform.position);
                rollbacktransform.PlayerOrCube.Push(0);
                rollbacktransform.PlayerCount.Push(playerCount);
                transform.position += MoveDir3;
            }
        }

        if (delay)
        {
            if (Keyboard.current.dKey.wasPressedThisFrame || Keyboard.current.rightArrowKey.wasPressedThisFrame)
            {
                anim.SetInteger("Direction",0);
                sprite.flipX = false;
                RotationObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                MoveDir3 = new Vector3(1, 0, 0);
                Push.isPush = false;
                delay = false;
                StartCoroutine(Delay());
            }
            if (Keyboard.current.aKey.wasPressedThisFrame || Keyboard.current.leftArrowKey.wasPressedThisFrame)
            {
                anim.SetInteger("Direction",0);
                sprite.flipX = true;
                RotationObject.transform.rotation = Quaternion.Euler(0, 0, -180);
                MoveDir3 = new Vector3(-1, 0, 0);
                Push.isPush = false;
                delay = false;
                StartCoroutine(Delay());
            }
            if (Keyboard.current.wKey.wasPressedThisFrame || Keyboard.current.upArrowKey.wasPressedThisFrame)
            {
                anim.SetInteger("Direction",3);
                RotationObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                MoveDir3 = new Vector3(0, 1, 0);
                Push.isPush = false;
                delay = false;
                StartCoroutine(Delay());
            }
            if (Keyboard.current.sKey.wasPressedThisFrame || Keyboard.current.downArrowKey.wasPressedThisFrame)
            {
                anim.SetInteger("Direction",1);
                RotationObject.transform.rotation = Quaternion.Euler(0, 0, -90);
                MoveDir3 = new Vector3(0, -1, 0);
                Push.isPush = false;
                delay = false;
                StartCoroutine(Delay());
            }
        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.1f);
        delay = true;
    }
}
