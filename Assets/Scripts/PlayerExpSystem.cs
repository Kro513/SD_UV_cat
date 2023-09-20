using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerExpSystem : MonoBehaviour
{
    private CharacterStatsHandler _statsHandler;

    public event Action TakeExp;
    public event Action LevelUp;

    public int CurrentExp { get; private set; }
    public int CurrentLevel { get; private set; }

    public int MaxExp => _statsHandler.CurrentStats.maxExp;

	private void Start()
	{
		CurrentExp = _statsHandler.CurrentStats.maxExp;
        CurrentLevel = _statsHandler.CurrentStats.level;
	}
}
