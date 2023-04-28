using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationSelection1 : MonoBehaviour
{
	public GameObject[] location;
	public GameObject[] locationNext;
	public GameObject[] locarionPrivious;
	public GameObject[] locarionDescription;
	
	public int selectedLocation = 0;
	public int selectedLocationNext = 0;
	public int selectedLocationPrivious = 0;
	public int selectedLocationDescription = 0;

	public void NextCharacter()
	{
		location[selectedLocation].SetActive(false);
		selectedLocation = (selectedLocation + 1) % location.Length;
		location[selectedLocation].SetActive(true);	

		locationNext[selectedLocationNext].SetActive(false);
		selectedLocationNext = (selectedLocationNext + 1) % locationNext.Length;
		locationNext[selectedLocationNext].SetActive(true);

		locarionPrivious[selectedLocationPrivious].SetActive(false);
		selectedLocationPrivious = (selectedLocationPrivious + 1) % locarionPrivious.Length;
		locarionPrivious[selectedLocationPrivious].SetActive(true);

		locarionDescription[selectedLocationDescription].SetActive(false);
		selectedLocationDescription = (selectedLocationDescription + 1) % locarionDescription.Length;
		locarionDescription[selectedLocationDescription].SetActive(true);
	}

	
	public void PreviousCharacter()
	{
		location[selectedLocation].SetActive(false);
		selectedLocation--;
		if (selectedLocation < 0)
		{
			selectedLocation += location.Length;
		}
		location[selectedLocation].SetActive(true);

		locationNext[selectedLocationNext].SetActive(false);
		selectedLocationNext--;
		if (selectedLocationNext < 0)
		{
			selectedLocationNext += locationNext.Length;
		}
		locationNext[selectedLocationNext].SetActive(true);

		locarionPrivious[selectedLocationPrivious].SetActive(false);
		selectedLocationPrivious--;
		if (selectedLocationPrivious < 0)
		{
			selectedLocationPrivious += locarionPrivious.Length;
		}
		locarionPrivious[selectedLocationPrivious].SetActive(true);

		locarionDescription[selectedLocationDescription].SetActive(false);
		selectedLocationDescription--;
		if (selectedLocationDescription < 0)
		{
			selectedLocationDescription += locarionDescription.Length;
		}
		locarionDescription[selectedLocationDescription].SetActive(true);
	}
}
