using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Spawn Manager Data")]
public class SpawnManagerData : ScriptableObject
{

    #region => ===== Data =====

    [SerializeField]
    private CreatureController[] _animalsToLoad;
    public CreatureController[] AnimalsToLoad => _animalsToLoad;

    [SerializeField]
    private CreatureController[] _monstersToLoad;
    public CreatureController[] MonstersToLoad => _monstersToLoad;

    [SerializeField]
    private float _spawnIntervalTime;
    public float SpawnIntervalTime => _spawnIntervalTime;

    #endregion

    #region => ===== Methods =====

    public void SetSpawnIntervalTime(float newIntervalTime)
    {
        _spawnIntervalTime = newIntervalTime;
    }

    #endregion

}
