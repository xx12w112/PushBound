using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Back : MonoBehaviour
{
    public Stack<Vector3> RollBackPlayer = new Stack<Vector3>();
    public Stack<Vector3> RollBackCube = new Stack<Vector3>();
    public Stack<int> PlayerOrCube = new Stack<int>();
    public Stack<int> PlayerCount = new Stack<int>();
    public Stack<GameObject> CubeObject = new Stack<GameObject>();
    public Stack<MoveCube> CubeMoveObject = new Stack<MoveCube>();
    [SerializeField] private GameObject[] player;
    [SerializeField] private Crystal crystal;
    private int a;
    private int[] b = new int[4];
    private int PC = 0;
    private int c = 0;
    private bool pfe = false;
    public Stack<int> CubeCount = new Stack<int>();
    public int CCt = 0;
    private int h = 0;
    private void Update()
    {
        if (CCt != 0)
        {
            CubeCount.Push(CCt);
            CCt = 0;
        }
        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            if (PlayerOrCube.Count > 0)
            {
                a=PlayerOrCube.Pop();
                if (a == 0)
                {
                    for (int i = 0; i < player.Length; i++)
                    {
                        if (PlayerCount.Count <= 0)
                        {
                            break;
                        }
                        PC = PlayerCount.Pop();

                        b[c] = PC;
                        for (int j = 0; j < c; j++)
                        {
                            if (b[j] == PC)
                            {
                                PlayerCount.Push(PC);
                                pfe = true;
                                break;
                            }
                        }
                        if (pfe)
                        {
                            break;
                        }
                        c++;
                        for (int j = 0; j < player.Length; j++)
                        {
                            if (j == PC)
                            {
                                player[PC].transform.position = RollBackPlayer.Pop();
                                if (h != 0)
                                {
                                    a = PlayerOrCube.Pop();
                                }
                                h++;
                            }
                        }
                    }
                    for (int i = 0; i < b.Length; i++)
                    {
                        b[i] = 100;
                    }
                    h = 0;
                    c = 0;
                    pfe = false;
                }
                else if(a == 1)
                {
                    if (CubeCount.Count > 0)
                    {
                        int g = CubeCount.Pop();
                        for (int i = 0; i < g; i++) 
                        {
                            CubeObject.Pop().transform.position = RollBackCube.Pop();
                            if (i < g - 1)
                            {
                                a = PlayerOrCube.Pop();
                            }
                        }
                    }
                }
                else if (a == 2)
                {
                    crystal.Touch = true;
                }
                else if (a == 3)
                {
                    CubeMoveObject.Pop().RollBack();
                    while (a == 3)
                    {
                        a = PlayerOrCube.Pop();
                        if (a != 3)
                        {
                            break;
                        }
                        CubeMoveObject.Pop().RollBack();
                    }
                    CubeObject.Pop().transform.position = RollBackCube.Pop();
                }
            }
        }
    }
}
