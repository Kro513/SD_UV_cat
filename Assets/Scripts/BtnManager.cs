using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour
{
    
	[SerializeField] private GameObject StatusBtn;
	[SerializeField] private GameObject InventoryBtn;
	[SerializeField] private GameObject StatusUI;
	[SerializeField] private GameObject InventoryUI;
	[SerializeField] private GameObject CancelEquipUIBtn;
	[SerializeField] private GameObject ConfirmEquipBtn;
	

	public void OpenStatusUI()
    {
		StatusBtn.gameObject.SetActive(false);
		InventoryBtn.gameObject.SetActive(false);
		StatusUI.gameObject.SetActive(true);
    }

	public void OpenInventoryUI()
	{
		StatusBtn.gameObject.SetActive(false);
		InventoryBtn.gameObject.SetActive(false);
		InventoryUI.gameObject.SetActive(true);
	}

	public void CloseStatusUI()
	{
		StatusBtn.gameObject.SetActive(true);
		InventoryBtn.gameObject.SetActive(true);
		StatusUI.gameObject.SetActive(false);
	}

	public void CloseInventoryUI()
	{
		StatusBtn.gameObject.SetActive(true);
		InventoryBtn.gameObject.SetActive(true);
		InventoryUI.gameObject.SetActive(false);
	}

	
}
