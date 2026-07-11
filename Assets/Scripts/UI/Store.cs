using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI PlayerNPcText;
    [SerializeField] private GameObject BackGround;
    [SerializeField] private Image NPc;
    [SerializeField] private GameObject NPc2;
    [SerializeField] private GameObject NPc1;
    [SerializeField] private int MaxCount;
    [SerializeField] private string[] ks;
    [SerializeField] private string[] es;
    [SerializeField] private string[] gs;
    public int count = 0;
    [SerializeField] private bool c;
    [SerializeField] private bool end;
    
    private void Start()
    {
        BackGround.SetActive(true);
        if (TextManahger.keg == 0)
        {
            PlayerNPcText.text = ks[0];
        }
        if (TextManahger.keg == 1)
        {
            PlayerNPcText.text = es[0];
        }
        if (TextManahger.keg == 2)
        {
            PlayerNPcText.text = gs[0];
        }
    }

    private void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            count++;
            if (end)
            {
                if (count == 2)
                {
                
                }
            }
            if (count == 10)
            {
                NPc.color = Color.white;
            }

            if (c)
            {
                if (count == 5)
                {
                    NPc1.SetActive(false);
                    NPc2.SetActive(true);
                }

                if (count == 6)
                {
                    NPc2.SetActive(false);
                    NPc1.SetActive(true);
                }
            }
            if (count >= MaxCount)
            {
                BackGround.SetActive(false);
            }
            else
            {
                if (TextManahger.keg == 0)
                {
                    PlayerNPcText.text = ks[count];
                }
                if (TextManahger.keg == 1)
                {
                    PlayerNPcText.text = es[count];
                }
                if (TextManahger.keg == 2)
                {
                    PlayerNPcText.text = gs[count];
                }
            }
        }
    }
    public void Next()
    {
        count++;
        if (end)
        {
            if (count == 2)
            {
                
            }
        }
        if (count == 10)
        {
            NPc.color = Color.white;
        }

        if (c)
        {
            if (count == 5)
            {
                NPc1.SetActive(false);
                NPc2.SetActive(true);
            }

            if (count == 6)
            {
                NPc2.SetActive(false);
                NPc1.SetActive(true);
            }
        }
        if (count >= MaxCount)
        {
            BackGround.SetActive(false);
        }
        else
        {
            if (TextManahger.keg == 0)
            {
                PlayerNPcText.text = ks[count];
            }
            if (TextManahger.keg == 1)
            {
                PlayerNPcText.text = es[count];
            }
            if (TextManahger.keg == 2)
            {
                PlayerNPcText.text = gs[count];
            }
        }
    }
}
