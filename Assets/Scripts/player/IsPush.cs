using UnityEngine;

public class IsPush : MonoBehaviour
{
    [SerializeField]private PlayerPush Push;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 0.2f, LayerMask.GetMask("no"));
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position, Vector2.up, 0.2f, LayerMask.GetMask("dontpush"));
        if(hit.collider != null)
        {
            Push.IsMove = true;
        }
        if (hit2.collider != null)
        {
            Push.IsMove = false;
        }
        if (hit2.collider == null)
        {
            Push.IsMove = true;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, Vector2.left * 0.2f); 
    }
}
