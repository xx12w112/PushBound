using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScaneUIManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    private bool isPaused = true;
    [SerializeField] private Toggle k;
    [SerializeField] private Toggle g;
    [SerializeField] private Toggle e;
    private MainLang la;

    private void Start()
    {
        la = GetComponent<MainLang>();
        g.SetIsOnWithoutNotify(TextManahger.g);
        e.SetIsOnWithoutNotify(TextManahger.eng);
        k.SetIsOnWithoutNotify(TextManahger.k);
    }

    public void OpenMenu()
    {
        menu.SetActive(true);
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void Korea()
    {
        TextManahger.rst = "재시작";
        TextManahger.ot = "설정";
        TextManahger.Et = "나가기";
        TextManahger.kt = " 한국어";
        TextManahger.engt = " 영어";
        TextManahger.gt = " 독일어";
        TextManahger.lt = "언어설정";
        TextManahger.met = "돌아가기";
        TextManahger.st = "시작";
        TextManahger.mt = "메뉴";
        TextManahger.g = false;
        TextManahger.k = true;
        TextManahger.eng = false;
        TextManahger.keg = 0;
        g.SetIsOnWithoutNotify(false);
        e.SetIsOnWithoutNotify(false);
        k.SetIsOnWithoutNotify(true);
        la.ChangeLanguage();
    }
    public void English()
    {
        TextManahger.rst = "Restart";
        TextManahger.ot = "Options";
        TextManahger.Et = "Exit";
        TextManahger.kt = " Korea";
        TextManahger.engt = " English";
        TextManahger.gt = " German";
        TextManahger.lt = "Language Settings";
        TextManahger.met = "back";
        TextManahger.st = "Start";
        TextManahger.mt = "Menu";
        TextManahger.g = false;
        TextManahger.k = false;
        TextManahger.eng = true;
        TextManahger.keg = 1;
        g.SetIsOnWithoutNotify(false);
        e.SetIsOnWithoutNotify(true);
        k.SetIsOnWithoutNotify(false);
        la.ChangeLanguage();
    }
    public void German()
    {
        TextManahger.rst = "Neu starten";
        TextManahger.ot = "Einstellungen";
        TextManahger.Et = "Verlassen";
        TextManahger.kt = " Koreanisch";
        TextManahger.engt = " Englisch";
        TextManahger.gt = " die deutsche Sprache";
        TextManahger.lt = "Spracheinstellungen";
        TextManahger.met = "Zurück zu";
        TextManahger.st = "Start";
        TextManahger.mt = "Das Menü";
        TextManahger.g = true;
        TextManahger.k = false;
        TextManahger.eng = false;
        TextManahger.keg = 2;
        g.SetIsOnWithoutNotify(true);
        e.SetIsOnWithoutNotify(false);
        k.SetIsOnWithoutNotify(false);
        la.ChangeLanguage();
    }
    public void Exit()
    {
        Application.Quit();
    }
}
