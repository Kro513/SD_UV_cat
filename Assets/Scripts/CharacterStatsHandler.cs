using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
	[SerializeField] private CharacterStats baseStats;
	public CharacterStats CurrentStats { get; private set; }
	public List<CharacterStats> statsModifiers = new List<CharacterStats>();

	private void Awake()
	{
		UpdateCharacterStats();
	}

	private void UpdateCharacterStats()
	{
		AttackSO attackSO = null;
		if (baseStats.attackSO != null)
		{
			attackSO = Instantiate(baseStats.attackSO);
		}

		CurrentStats = new CharacterStats { attackSO = attackSO };
		// TODO
		CurrentStats.statsChangeType = baseStats.statsChangeType;
		CurrentStats.level = baseStats.level;
		CurrentStats.name = baseStats.name;
		CurrentStats.maxExp = baseStats.maxExp;
		CurrentStats.gold = baseStats.gold;
		CurrentStats.info = baseStats.info;
		CurrentStats.atk = baseStats.atk;
		CurrentStats.def = baseStats.def;
		CurrentStats.hp = baseStats.hp;
		CurrentStats.crit = baseStats.crit;

	}
}
