using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
	public GameObject[] cars;
	public GameObject[] carsNext;
	public GameObject[] carsPrivious;
	public GameObject[] carsName;
	
	public int selectedCar = 0;
	public int selectedCarNext = 0;
	public int selectedCarPrivious = 0;
	public int selectedCarName = 0;

	public void NextCharacter()
	{
		cars[selectedCar].SetActive(false);
		selectedCar = (selectedCar + 1) % cars.Length;
		cars[selectedCar].SetActive(true);	

		carsNext[selectedCarNext].SetActive(false);
		selectedCarNext = (selectedCarNext + 1) % carsNext.Length;
		carsNext[selectedCarNext].SetActive(true);

		carsPrivious[selectedCarPrivious].SetActive(false);
		selectedCarPrivious = (selectedCarPrivious + 1) % carsPrivious.Length;
		carsPrivious[selectedCarPrivious].SetActive(true);

		carsName[selectedCarName].SetActive(false);
		selectedCarName = (selectedCarName + 1) % carsName.Length;
		carsName[selectedCarName].SetActive(true);
	}

	
	public void PreviousCharacter()
	{
		cars[selectedCar].SetActive(false);
		selectedCar--;
		if (selectedCar < 0)
		{
			selectedCar += cars.Length;
		}
		cars[selectedCar].SetActive(true);

		carsNext[selectedCarNext].SetActive(false);
		selectedCarNext--;
		if (selectedCarNext < 0)
		{
			selectedCarNext += carsNext.Length;
		}
		carsNext[selectedCarNext].SetActive(true);

		carsPrivious[selectedCarPrivious].SetActive(false);
		selectedCarPrivious--;
		if (selectedCarPrivious < 0)
		{
			selectedCarPrivious += carsPrivious.Length;
		}
		carsPrivious[selectedCarPrivious].SetActive(true);

		carsName[selectedCarName].SetActive(false);
		selectedCarName--;
		if (selectedCarName < 0)
		{
			selectedCarName += carsName.Length;
		}
		carsName[selectedCarName].SetActive(true);
	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCar);
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}
}
