using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Health Data")]
public class HealthData : ScriptableObject
{

    #region => ===== Data =====

    [SerializeField]
    private int _maxHealth;
    public int MaxHealth => _maxHealth;

    [SerializeField]
    private int _currentHealth;
    public int currentHealth => _currentHealth;

    public System.Action EntityDiedEvent;
    public System.Action EntityDamageEvent;

    #endregion

    #region => ===== Methods =====

    public void resetHealth()
    {
        _currentHealth = _maxHealth;
    }

    public void takeDamage(int amount)
    {
        _currentHealth -= amount;

        if (EntityDamageEvent != null) EntityDamageEvent();

        if(_currentHealth <= 0)
            if (EntityDiedEvent != null) EntityDiedEvent();
    }

    #endregion


}
