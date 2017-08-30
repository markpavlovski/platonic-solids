using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour {

	
	//for side length 1, the volumes are:

	float generalScale = 1;
	float tetrahedronScale = Mathf.Sqrt(2)/12 / generalScale;
	float cubeScale =  1 / generalScale;
	float octahedronScale = Mathf.Sqrt(2)/3 / generalScale;
	float icosahedronScale = (15+5*Mathf.Sqrt(5))/12 / generalScale;
	float dodecahedronScale = (15+7*Mathf.Sqrt(5))/4 / generalScale;	

	public Material generalMaterial;
	float r = 7;
	float theta = 2* Mathf.PI / 5;

	GameObject tetrahedronObject;
	GameObject cubeObject;
	GameObject octahedronObject;
	GameObject icosahedronObject;
	GameObject dodecahedronObject;


	void Start () {

		tetrahedronObject = new GameObject ();
		tetrahedronObject.transform.SetParent(gameObject.transform);
		tetrahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(0 * theta),0,r * Mathf.Sin(0 * theta));
		tetrahedronObject.transform.localScale = new Vector3(1f/tetrahedronScale,1f/tetrahedronScale,1f/tetrahedronScale);
		tetrahedronObject.AddComponent<TetrahedronScript> ();
		tetrahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;


		cubeObject = new GameObject ();
		cubeObject.transform.SetParent(gameObject.transform);
		cubeObject.transform.localPosition = new Vector3 (r * Mathf.Cos(1 * theta),0,r * Mathf.Sin(1 * theta));
		cubeObject.transform.localScale = new Vector3(1f/cubeScale,1f/cubeScale,1f/cubeScale);
		cubeObject.AddComponent<CubeScript> ();
		cubeObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		octahedronObject = new GameObject ();
		octahedronObject.transform.SetParent(gameObject.transform);
		octahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(2 * theta),0,r * Mathf.Sin(2 * theta));
		octahedronObject.transform.localScale = new Vector3(1f/octahedronScale,1f/octahedronScale,1f/octahedronScale);
		octahedronObject.AddComponent<OctahedronScript> ();
		octahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		icosahedronObject = new GameObject ();
		icosahedronObject.transform.SetParent(gameObject.transform);
		icosahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(3 * theta),0,r * Mathf.Sin(3 * theta));
		icosahedronObject.transform.localScale = new Vector3(1f/icosahedronScale,1f/icosahedronScale,1f/icosahedronScale);
		icosahedronObject.AddComponent<IcosahedronScript> ();
		icosahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		dodecahedronObject = new GameObject ();
		dodecahedronObject.transform.SetParent(gameObject.transform);
		dodecahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(4 * theta),0,r * Mathf.Sin(4 * theta));
		dodecahedronObject.transform.localScale = new Vector3(1f/dodecahedronScale,1f/dodecahedronScale,1f/dodecahedronScale);
		dodecahedronObject.AddComponent<DodecahedronScript> ();
		dodecahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;



		
	}
	
	void Update () {
		
	}
}
