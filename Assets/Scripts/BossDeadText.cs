using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BossDeadText : MonoBehaviour
{
    public TextMeshProUGUI txtBox;
    private List<BossText> bossTxt;
    public TextAsset bossCsv;

    public class BossText
    {
        public int Num;
        public string Txt;
    }

    private void Awake()
    {
        LoadDataAndRefreshUI();

    }

    private void Update()
    {
        UpdateUI();
    }

    public void LoadDataAndRefreshUI()
    {
        string[] data = bossCsv.text.Split(new char[] { '\n' });
        bossTxt = new List<BossText>();

        for (int i = 1; i < data.Length; i++) // Skip the first row (header)
        {
            string[] row = data[i].Split(new char[] { ',' });

            BossText t = new BossText();
            t.Num = int.Parse(row[0]);
            t.Txt = row[1];

            bossTxt.Add(t);
        }
    }

    private void UpdateUI()
    {
        foreach (BossText member in bossTxt)
        {
            if (GameManager.I.stage == member.Num)
            {
                txtBox.text = member.Txt; 
            }
        }
    }
}
