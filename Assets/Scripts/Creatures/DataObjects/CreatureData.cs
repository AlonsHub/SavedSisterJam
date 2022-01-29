using UnityEngine;

[CreateAssetMenu(menuName = "Data/Creature Data")]
public class CreatureData : ScriptableObject
{
    #region => ===== Creature Data =====

    [Header("Creature Data Settings")]
    [SerializeField]
    private float _speed;
    public float Speed => _speed;

    [SerializeField]
    private HealthData _healthData;
    public HealthData HealthData => _healthData;

    #endregion

    #region => ===== Trigger Data =====

    [Header("Players Trigger Settings")]
    [SerializeField]
    private float _yellowTriggerDistance;
    public float YellowTriggerDistance => _yellowTriggerDistance;

    [SerializeField]
    private float _purpleTriggerDistance;
    public float PurpleTriggerDistance => _purpleTriggerDistance;

    #endregion

    #region => ===== Purple Effect Data =====

    [Header("Purple Effect Settings")]
    [SerializeField, Range(0, 0.15f)]
    private float _purpleRepelper;
    public float PurpleRepelper => _purpleRepelper;

    [SerializeField, Range(0, 500)]
    private float _purpleAtkForce;
    public float PurpleAtkForce => _purpleAtkForce;

    [SerializeField]
    private float _atkExplosionRadius;
    public float AtkExplosionRadius => _atkExplosionRadius;

    [SerializeField]
    private int _purpleAtkDuration;
    public int PurpleAtkDuration => _purpleAtkDuration;

    #endregion

    #region => ===== Yellow Atk Data =====

    [Header("Yellow Effect Settings")]
    [SerializeField, Range(1,3)]
    private float _yellowEffectSpeedMultiplier;
    public float YellowEffectSpeedMultiplier => _yellowEffectSpeedMultiplier;

    [SerializeField, Range(0, 10)]
    private float _yellowEffectDuration;
    public float YellowEffectDuration => _yellowEffectDuration;

    #endregion

}
