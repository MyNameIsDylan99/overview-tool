using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mission", menuName = "Overview+/Missions", order = 10)]
public class MissionSO : ScriptableObject
{
    public string Description;
    public float RewardAmount;
}