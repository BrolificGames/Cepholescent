using UnityEngine;
using System.Collections;

public class SetParticleSortingLayer : MonoBehaviour 
{
	public string Layer;
	public int layerNumber;

	void Start()
	{
		// Set the sorting layer of the particle system.
		particleSystem.renderer.sortingLayerName = Layer;
		particleSystem.renderer.sortingOrder = layerNumber;
	}
}
