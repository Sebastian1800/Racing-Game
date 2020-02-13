using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{

	public GameObject TheCar;
	public float CarX;
	public float CarY;
	public float CarZ;

	void Update()
	{
		CarX = TheCar.transform.eulerAngles.x;
		CarY = TheCar.transform.eulerAngles.y;
		CarZ = TheCar.transform.eulerAngles.z;

		transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);// Carx si Carz se foloseste pt a intoarce camera,pt y nu s a folosit pt avem nev sa mearga in sus si in jos 

	}
}