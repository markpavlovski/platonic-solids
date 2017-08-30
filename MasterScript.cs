using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour {

	
	//for side length 1, the volumes are:

	static float generalScale = 1f;
	float tetrahedronScale = Mathf.Sqrt(2)/12 / generalScale;
	float cubeScale =  1 / generalScale;
	float octahedronScale = Mathf.Sqrt(2)/3 / generalScale;
	float icosahedronScale = (15+5*Mathf.Sqrt(5))/12 / generalScale;
	float dodecahedronScale = (15+7*Mathf.Sqrt(5))/4 / generalScale;	

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
		//tetrahedronObject.transform.localScale = tetrahedronObject.GetComponent<TetrahedronScript> ().normalizedScale * tetrahedronScale;

		cubeObject.transform.localPosition = new Vector3 (r * Mathf.Cos(1 * theta),0,r * Mathf.Sin(1 * theta));
		//cubeObject.transform.localScale = cubeObject.GetComponent<CubeScript>().normalizedScale * cubeScale;

		octahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(2 * theta),0,r * Mathf.Sin(2 * theta));
		//octahedronObject.transform.localScale = octahedronObject.GetComponent<OctahedronScript>().normalizedScale * octahedronScale;

		icosahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(3 * theta),0,r * Mathf.Sin(3 * theta));
		//icosahedronObject.transform.localScale = icosahedronObject.GetComponent<IcosahedronScript>().normalizedScale * icosahedronScale;

		dodecahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(4 * theta),0,r * Mathf.Sin(4 * theta));
		//dodecahedronObject.transform.localScale = dodecahedronObject.GetComponent<DodecahedronScript>().normalizedScale * dodecahedronScale;

	}
}
