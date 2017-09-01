using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MasterScript : MonoBehaviour {

	
	//for side length 1, the volumes are:

	static float generalScale = .5f;
	static float tetrahedronScale = 1 / Mathf.Pow(Mathf.Sqrt(2)/12, 1/3) * generalScale;
	static float cubeScale =  1 * generalScale;
	static float octahedronScale = 1 / Mathf.Pow(Mathf.Sqrt(2f)/3f, 1f/3f) * generalScale;
	static float icosahedronScale = 1/ Mathf.Pow((15+5*Mathf.Sqrt(5))/12,1/3) * generalScale;
	static float dodecahedronScale = 1/ Mathf.Pow((15+7*Mathf.Sqrt(5))/4,1/3) * generalScale;	

	public Material generalMaterial;
	float r = 5;
	float theta = 2* Mathf.PI / 5;

	GameObject tetrahedronObject;
	GameObject cubeObject;
	GameObject octahedronObject;
	GameObject icosahedronObject;
	GameObject dodecahedronObject;


	void Start () {

		tetrahedronObject = new GameObject ();
		tetrahedronObject.transform.SetParent(gameObject.transform);
		tetrahedronObject.AddComponent<TetrahedronScript> ();
		tetrahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;
			


		cubeObject = new GameObject ();
		cubeObject.transform.SetParent(gameObject.transform);
		cubeObject.AddComponent<CubeScript> ();
		cubeObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		octahedronObject = new GameObject ();
		octahedronObject.transform.SetParent(gameObject.transform);
		octahedronObject.AddComponent<OctahedronScript> ();
		octahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		icosahedronObject = new GameObject ();
		icosahedronObject.transform.SetParent(gameObject.transform);
		icosahedronObject.AddComponent<IcosahedronScript> ();
		icosahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		dodecahedronObject = new GameObject ();
		dodecahedronObject.transform.SetParent(gameObject.transform);
		dodecahedronObject.AddComponent<DodecahedronScript> ();
		dodecahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;



		
	}
	
	void Update () { 

		tetrahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(0 * theta),0,r * Mathf.Sin(0 * theta));
		tetrahedronObject.transform.localScale = Vector3.one * tetrahedronScale;


		cubeObject.transform.localPosition = new Vector3 (r * Mathf.Cos(1 * theta),0,r * Mathf.Sin(1 * theta));
		cubeObject.transform.localScale = Vector3.one * cubeScale;

		octahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(2 * theta),0,r * Mathf.Sin(2 * theta));
		octahedronObject.transform.localScale = Vector3.one * octahedronScale;


		icosahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(3 * theta),0,r * Mathf.Sin(3 * theta));
		icosahedronObject.transform.localScale = Vector3.one * icosahedronScale;


		dodecahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(4 * theta),0,r * Mathf.Sin(4 * theta));
		dodecahedronObject.transform.localScale = Vector3.one * dodecahedronScale;

		float timeOfRotation = (float)DateTime.Now.TimeOfDay.TotalSeconds; 
			
		transform.localRotation = Quaternion.Euler (0f,timeOfRotation * 20, 0f);


	}
}
