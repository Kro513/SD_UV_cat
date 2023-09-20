using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "StatsController/Attacks/Default", order = 0)]
public class AttackSO : ScriptableObject
{
	[Header("Attack Info")]
	public int level;
	public new string name;
	public int exp;
	public long gold;
	public string Info;
}
