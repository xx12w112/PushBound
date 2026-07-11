using UnityEngine;

public class CrystalCube : MonoBehaviour
{
    public bool change;
    public bool Activation;
    private SpriteRenderer color;
    

    private void Start()
    {
        color = GetComponent<SpriteRenderer>();
        if (Activation)
        {
            color.color = Color.magenta;
        }
        else
        {
            color.color = Color.gray;
        }
    }
    private void Update()
    {
        if (change)
        {
            change = false;
            if (Activation)
            {
                color.color = Color.gray;
                Activation = false;
            }
            else
            {
                color.color = Color.magenta;
                Activation = true;
            }
        }
    }
}
