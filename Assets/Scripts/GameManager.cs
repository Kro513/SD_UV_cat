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

	[SerializeField] private GameObject StatusUI;
	[SerializeField] private GameObject InventoryUI;

	[SerializeField] private GameObject StatusBtn;
	[SerializeField] private GameObject InventoryBtn;
	[SerializeField] private GameObject QuestionEquipUI;

	[SerializeField] private TextMeshProUGUI QuestionText;
	[SerializeField] private TextMeshProUGUI QuestionEquipText;

	private int currentGoldText = 20000;
	private int currentAtkText = 10;
	private int currentDefText = 10;
	private int currentExpText = 2;
	private int currentLevelText = 1;
	private int currentHpText = 100;
	private int currentCritText = 10;
	private string currentNameText = "Gray";
	private string currentInfoText = "The cute gray cat!";
	

	public bool isEquip;
	

	private void Awake()
	{
		Instance = this;

		StatusUI.SetActive(false);
		InventoryUI.SetActive(false);
		StatusBtn.gameObject.SetActive(true);
		InventoryBtn.gameObject.SetActive(true);
		//QuestionEquipUI.gameObject.SetActive(false);

		DefaltPlayerStatusSetting();

	}

	

	
	private void DefaltPlayerStatusSetting()
	{
		nameText.text = (currentNameText).ToString();
		atkText.text = (currentAtkText).ToString();
		defText.text = (currentDefText).ToString();
		expText.text = ((currentExpText % 10).ToString() + " / 10");
		levelText.text = (currentLevelText).ToString();
		infoText.text = (currentInfoText).ToString();
		goldText.text = (currentGoldText).ToString();
		hpText.text = (currentHpText).ToString();
		critText.text = (currentCritText).ToString();
		
	}


	public void CancelEquip()
	{
		QuestionEquipUI.gameObject.SetActive(false);
	}

	public void EquipItem()
	{
		if (isEquip == false)
		{
			//string input = gameObject.name;
			//switch (input)
			//{
			//	case "threadBall":
			//		currentAtkText += ItemManager.ThreadBall(Atk);
			//		currentDefText += ItemManager.ThreadBall(Def);
			//		break;

			//	case "fishingToy":
			//		currentAtkText += ItemManager.FishingToy(Atk);
			//		currentDefText += ItemManager.FishingToy(Def);
			//		break;

			//	case "laserPoint":
			//		currentAtkText += ItemManager.LaserPoint(Atk);
			//		currentDefText += ItemManager.LaserPoint(Def);
			//		break;

			//	case "mouseToy":
			//		currentAtkText += ItemManager.MouseToy(Atk);
			//		currentDefText += ItemManager.MouseToy(Def);
			//		break;
			//}
			isEquip = true;
		}
		QuestionEquipUI.gameObject.SetActive(false);
	}

	public void OpenEquipUI()
	{
		QuestionEquipUI.gameObject.SetActive(true);

		if (isEquip == false)
		{
			QuestionEquipText.text = "Do you want to equip it?";
		}
		else
		{
			QuestionEquipText.text = "Do you want to unequip it?";
		}
	}
}
