using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Project.Exersice3;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private TextMeshProUGUI _hpText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            ShowHP();

        if (Input.GetKeyDown(KeyCode.S))
            ShowName();
    }
    public void ShowName()
    {
        var repo = FindObjectOfType<PlayerLocalRepository>();

        _nameText.text = "Player: " + repo.GetData().Result;
    }

    public void ShowHP()
    {
        var repo = FindObjectOfType<LifeLocalRepository>();

        _hpText.text = "HP: " + repo.GetData().Result;
    }
}
