using UnityEngine;
using TMPro;

public class IngameTxtUi : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI hpTxt;
    public TextMeshProUGUI stageTxt;
    public TextMeshProUGUI atkTxt;
    public TextMeshProUGUI speedTxt;
    public TextMeshProUGUI rpmTxt;
    public GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (player != null)
        {
            stageTxt.text = "Stage" + GameManager.I.stage.ToString();
            scoreTxt.text = "Score: " + GameManager.I.sccore.ToString();
            hpTxt.text = "Hp: " + player.GetComponent<PlayerInfo>().Hp.ToString();
            hpTxt.text = "Atk: " + player.GetComponent<PlayerInfo>().Atk.ToString();
            hpTxt.text = "Speed: " + player.GetComponent<PlayerInfo>().MoveSpeed.ToString();
            hpTxt.text = "RPM: " + player.GetComponent<PlayerInfo>().BulletRpm.ToString();
        }
    }
}
