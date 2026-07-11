using UnityEngine;

public class asdasd : MonoBehaviour
{
    [SerializeField] private Store s;
    [SerializeField] private GameObject g;
    [SerializeField] private int c;
    [SerializeField] private bool f;

    private void Update()
    {
        if (!f)
        {
            if (s.count == c)
            {
                g.SetActive(false);
            }
        }
        if (f)
        {
            if (s.count == c)
            {
                g.SetActive(true);
            }
        }
    }
}
