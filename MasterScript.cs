using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour {

	public Material generalMaterial;
	float r = 15f;
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
		tetrahedronObject.AddComponent<TetrahedronScript> ();
		tetrahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;


		cubeObject = new GameObject ();
		cubeObject.transform.SetParent(gameObject.transform);
		cubeObject.transform.localPosition = new Vector3 (r * Mathf.Cos(1 * theta),0,r * Mathf.Sin(1 * theta));
		cubeObject.AddComponent<CubeScript> ();
		cubeObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		octahedronObject = new GameObject ();
		octahedronObject.transform.SetParent(gameObject.transform);
		octahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(2 * theta),0,r * Mathf.Sin(2 * theta));
		octahedronObject.AddComponent<OctahedronScript> ();
		octahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		icosahedronObject = new GameObject ();
		icosahedronObject.transform.SetParent(gameObject.transform);
		icosahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(3 * theta),0,r * Mathf.Sin(3 * theta));
		icosahedronObject.AddComponent<IcosahedronScript> ();
		icosahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;

		dodecahedronObject = new GameObject ();
		dodecahedronObject.transform.SetParent(gameObject.transform);
		dodecahedronObject.transform.localPosition = new Vector3 (r * Mathf.Cos(4 * theta),0,r * Mathf.Sin(4 * theta));
		dodecahedronObject.AddComponent<DodecahedronScript> ();
		dodecahedronObject.GetComponent<MeshRenderer> ().material = generalMaterial;



		
	}
	
	void Update () {
		
	}
}
