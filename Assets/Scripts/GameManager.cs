using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

	private PlayerExpSystem playerExpSystem;

	[SerializeField] private TextMeshProUGUI levelText;
	[SerializeField] private TextMeshProUGUI nameText;
	[SerializeField] private TextMeshProUGUI goldText;
	[SerializeField] private TextMeshProUGUI infoText;
	[SerializeField] private TextMeshProUGUI expText;
	[SerializeField] private TextMeshProUGUI atkText;
	[SerializeField] private TextMeshProUGUI defText;
	[SerializeField] private TextMeshProUGUI hpText;
	[SerializeField] private TextMeshProUGUI critText;
	[SerializeField] private Slider expGaugeSlider;


	private void Awake()
	{
		Instance = this;

		//playerExpSystem.TakeExp += UpdateExpUI;
		//playerExpSystem.LevelUp += UpdateLevel;

	}

	private void UpdateExpUI()
	{
		expGaugeSlider.value = playerExpSystem.CurrentExp / playerExpSystem.MaxExp;
	}

	private void UpdateLevel()
	{

	}
}
