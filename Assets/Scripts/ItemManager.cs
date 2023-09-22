using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private GameObject threadBall;
	[SerializeField] private GameObject fishingToy;
	[SerializeField] private GameObject laserPoint;
	[SerializeField] private GameObject mouseToy;


	public class Item
	{
		public string Name { get; private set; }
		public int Atk { get; private set; }
		public int Def { get; private set; }

		public Item(string name, int atk, int def)
		{
			Name = name;
			Atk = atk;
			Def = def;
		}
	}

	public class ThreadBall : Item
	{
		public ThreadBall() : base("treadBall", 5, 0)
		{
		}
	}

	public class FishingToy : Item
	{
		public FishingToy() : base("fishingToy", 0, 5)
		{
		}
	}

	public class LaserPoint : Item
	{
		public LaserPoint() : base("laserPoint", 3, 2)
		{
		}
	}

	public class MouseToy : Item
	{
		public MouseToy() : base("mouseToy", 2, 3)
		{
		}
	}

	
}
