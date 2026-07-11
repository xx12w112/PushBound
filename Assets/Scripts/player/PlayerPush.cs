using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPush : MonoBehaviour
{
    public bool isPush;
    private GameObject Cube;
    [SerializeField] private playerMovement playerMovement;
    [SerializeField] private float _raysize;
    public bool IsMove = true;
    private bool isTouching;
    private CrystalCube crystalCube;
    [SerializeField] private Crystal crystal;
    [SerializeField] private Back rollbacktransform;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource TouchSound;
    [SerializeField] AudioSource As;

    private void Awake()
    {
        As.enabled = false;
    }
    private void Update()
    {
        if (As.time > 1f)
        {
            As.enabled = false;
        }
        if (isPush && Keyboard.current.lKey.wasPressedThisFrame)
        {
            if (IsMove)
            {
                As.enabled = false;
                As.enabled = true;
                rollbacktransform.CCt++;
                rollbacktransform.RollBackCube.Push(Cube.transform.position);
                rollbacktransform.PlayerOrCube.Push(1);
                rollbacktransform.CubeObject.Push(Cube);
                if (player.transform.rotation == Quaternion.Euler(0, 0, 0))
                {
                    Cube.transform.position += new Vector3(1, 0, 0);
                }
                if (player.transform.rotation == Quaternion.Euler(0, 0, 90))
                {
                    Cube.transform.position += new Vector3(0, 1, 0);
                }
                if (player.transform.rotation == Quaternion.Euler(0, 0, -180))
                {
                    Cube.transform.position += new Vector3(-1, 0, 0);
                }
                if (player.transform.rotation == Quaternion.Euler(0, 0, -90))
                {
                    Cube.transform.position += new Vector3(0, -1, 0);
                }
            }
        }

        if (isTouching && Keyboard.current.lKey.wasPressedThisFrame)
        {
            TouchSound.enabled = false;
            TouchSound.enabled = true;
            rollbacktransform.PlayerOrCube.Push(2);
            crystal.Touch = true;
        }
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, _raysize, LayerMask.GetMask("Push"));
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position, Vector2.up, _raysize, LayerMask.GetMask("Crystal"));
        RaycastHit2D hit3 = Physics2D.Raycast(transform.position, Vector2.up, _raysize, LayerMask.GetMask("Wall"));
        RaycastHit2D hit4 = Physics2D.Raycast(transform.position, Vector2.up, _raysize, LayerMask.GetMask("Crystalcube"));
        if(hit.collider != null)
        {
            isPush = true;
            Cube = hit.collider.gameObject;
            playerMovement.isMove = false;
            isTouching = false;
        }
        else if (hit2.collider != null)
        {
            isTouching = true;
            playerMovement.isMove = false;
            isPush = false;
        }
        else if (hit3.collider != null)
        {
            playerMovement.isMove = false;
            isPush = false;
            isTouching = false;
        }
        else if (hit4.collider != null)
        {
            crystalCube = hit4.collider.GetComponent<CrystalCube>();
            if (crystalCube.Activation)
            {
                playerMovement.isMove = false;
            }
            else
            {
                playerMovement.isMove = true;
            }
            isPush = false;
            isTouching = false;
        }
        else
        {
            Cube = null;
            isPush = false;
            isTouching = false;
            playerMovement.isMove = true;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, Vector2.left * _raysize); 
    }
}
