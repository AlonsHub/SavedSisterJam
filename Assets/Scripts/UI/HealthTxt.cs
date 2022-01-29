using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class HealthTxt : MonoBehaviour
{
    private TMP_Text _txtComponent;
    public TMP_Text TxtComponent => _txtComponent;

    [SerializeField]
    private HealthData _playerHealthData;
    public HealthData PlayerHealthData => _playerHealthData;

    private void Awake()
    {
        _txtComponent = GetComponent<TMP_Text>();

        _playerHealthData.EntityDamageEvent += setTxt;

        setTxt();
    }

    private void setTxt()
    {
        _txtComponent.text = _playerHealthData.currentHealth.ToString();
    }
}
