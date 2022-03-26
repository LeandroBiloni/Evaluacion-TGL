using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Project.Exersice3;

public class UIController : MonoBehaviour
{
    [SerializeField] private PlayerLocalRepository _playerLocalRepository;
    [SerializeField] private LifeLocalRepository _lifeLocalRepository;
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private TextMeshProUGUI _hpText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            ShowHP();

        if (Input.GetKeyDown(KeyCode.A))
            ShowName();
    }
    public void ShowName()
    {
        _nameText.text = "Player: " + _playerLocalRepository.GetData().Result;
    }

    public void ShowHP()
    {
        _hpText.text = "HP: " + _lifeLocalRepository.GetData().Result;
    }
}
