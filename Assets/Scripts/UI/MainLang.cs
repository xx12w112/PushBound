using TMPro;
using UnityEngine;

public class MainLang : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI st;
    [SerializeField] private TextMeshProUGUI mt;
    [SerializeField] private TextMeshProUGUI et;
    [SerializeField] private TextMeshProUGUI mtt;
    [SerializeField] private TextMeshProUGUI lst;
    [SerializeField] private TextMeshProUGUI kt;
    [SerializeField] private TextMeshProUGUI engt;
    [SerializeField] private TextMeshProUGUI gt;
    [SerializeField] private TextMeshProUGUI Met;
    
    private void Start()
    {
        st.text = TextManahger.st;
        mt.text = TextManahger.mt;
        mtt.text = TextManahger.mt;
        et.text = TextManahger.Et;
        lst.text = TextManahger.lt;
        gt.text = TextManahger.gt;
        kt.text = TextManahger.kt;
        engt.text = TextManahger.engt;
        Met.text = TextManahger.met;
    }

    public void ChangeLanguage()
    {
        st.text = TextManahger.st;
        mt.text = TextManahger.mt;
        mtt.text = TextManahger.mt;
        et.text = TextManahger.Et;
        lst.text = TextManahger.lt;
        gt.text = TextManahger.gt;
        kt.text = TextManahger.kt;
        engt.text = TextManahger.engt;
        Met.text = TextManahger.met;
    }
}
