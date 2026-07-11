using TMPro;
using UnityEngine;

public class LanguageSetting : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI rst;
    [SerializeField] private TextMeshProUGUI ot;
    [SerializeField] private TextMeshProUGUI et;
    [SerializeField] private TextMeshProUGUI ott;
    [SerializeField] private TextMeshProUGUI lst;
    [SerializeField] private TextMeshProUGUI kt;
    [SerializeField] private TextMeshProUGUI engt;
    [SerializeField] private TextMeshProUGUI gt;
    [SerializeField] private TextMeshProUGUI Met;
    
    private void Start()
    {
        rst.text = TextManahger.rst;
        ot.text = TextManahger.ot;
        ott.text = TextManahger.ot;
        et.text = TextManahger.Et;
        lst.text = TextManahger.lt;
        gt.text = TextManahger.gt;
        kt.text = TextManahger.kt;
        engt.text = TextManahger.engt;
        Met.text = TextManahger.met;
    }

    public void ChangeLanguage()
    {
        rst.text = TextManahger.rst;
        ot.text = TextManahger.ot;
        ott.text = TextManahger.ot;
        et.text = TextManahger.Et;
        lst.text = TextManahger.lt;
        gt.text = TextManahger.gt;
        kt.text = TextManahger.kt;
        engt.text = TextManahger.engt;
        Met.text = TextManahger.met;
    }
}
