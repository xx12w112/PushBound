using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private bool upDown;
    [SerializeField] private bool rightleft;
    [SerializeField] private int ads;
    private bool isPush;
    private SpriteRenderer sprite;
    [SerializeField] private SpriteRenderer boy;
    [SerializeField] private Back rollback;
    private MoveCube movecube;

    private void Start()
    {
        isPush = true;
        sprite = GetComponent<SpriteRenderer>();
        movecube = GetComponent<MoveCube>();
    }

    public void RollBack()
    {
        isPush = true;
        sprite.color = Color.white;
        boy.color = Color.white;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Push"))
        {
            if (isPush)
            {
                if (upDown)
                {
                    collision.transform.position += new Vector3(0, ads, 0);
                    isPush = false;
                    sprite.color = Color.gray;
                    boy.color = Color.gray;
                    rollback.PlayerOrCube.Push(3);
                    rollback.CubeMoveObject.Push(movecube);
                }
                if(rightleft){
                    collision.transform.position += new Vector3(ads, 0, 0);
                    isPush = false;
                    sprite.color = Color.gray;
                    boy.color = Color.gray;
                    rollback.PlayerOrCube.Push(3);
                    rollback.CubeMoveObject.Push(movecube);
                }
            }
        }
    }
}
