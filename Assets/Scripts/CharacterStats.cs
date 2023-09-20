using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
	Add,
	Multiple,
	Override,
}

[Serializable]
public class CharacterStats
{
	public StatsChangeType statsChangeType;
	[Range(1, 100)] public int level;
	public string name;
	[Range(1, 20)] public int maxExp;
	[Range(1, 200000)] public long gold;
	public string info;
	public int atk;
	public int def;
	public int hp;
	public int crit;
	public AttackSO attackSO;
}
