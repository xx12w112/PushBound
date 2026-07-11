using UnityEngine;

public class Crystal : MonoBehaviour
{
    public bool Touch;
    private bool isTouching = true;
    [SerializeField] private SpriteRenderer[] color;
    [SerializeField] private CrystalCube[] crystalCube;
    [SerializeField] private Back back;
    
    private void Update()
    {
        if (Touch)
        {
            if (isTouching)
            {
                isTouching = false;
                for (int i = 0; i < color.Length; i++)
                {
                    color[i].color = Color.gray;
                }
                
            }
            else
            {
                isTouching = true;
                for (int i = 0; i < color.Length; i++)
                {
                    color[i].color = Color.white;
                }
            }
            for (int i = 0; i < crystalCube.Length; i++)
            {
                crystalCube[i].change = true;
            }
            Touch = false;
        }
    }
}
