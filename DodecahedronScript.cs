using System;
using UnityEngine;
using System.Collections;
public class DodecahedronScript : MonoBehaviour {


	//	Dodecahedron defined by (+-1,+-1,+-1), (0, +-phi, +-1/phi), (+-1/phi,0,+-phi), (+-phi,+-1/phi,0)

	public Material dodecahedronMaterial;
	public Vector3[] p;

	Mesh dodecahedronMesh;
	float phi = (1 + Mathf.Sqrt (5))/2;

	float s = 3f;
	Vector3 normalizedScale = new Vector3(1f/s, 1f/s, 1f/s);

	/*
	private void OnDrawGizmos () {
		if (p == null) {
			return;
		}
		Gizmos.color = Color.red;
		for (int i = 0; i < p.Length; i++) {
			Gizmos.DrawSphere(p[i], 0.1f);
		}
	}
	*/



	void Generate(){

		gameObject.AddComponent<MeshRenderer> ().material = dodecahedronMaterial;

		dodecahedronMesh = new Mesh ();
		gameObject.AddComponent<MeshFilter> ().mesh = dodecahedronMesh;
		dodecahedronMesh.name = "Dodecahedron Mesh";


		p = new Vector3[20];

		p [0] = new Vector3 (-1f, -1f, -1f);
		p [1] = new Vector3 (-1f, -1f, 1f);
		p [2] = new Vector3 (-1f, 1f, -1f);
		p [3] = new Vector3 (-1f, 1f, 1f);
		p [4] = new Vector3 (1f, -1f, -1f);
		p [5] = new Vector3 (1f, -1f, 1f);
		p [6] = new Vector3 (1f, 1f, -1f);
		p [7] = new Vector3 (1f, 1f, 1f);

		p [8] = new Vector3 (0f, -phi, -1/phi);
		p [9] = new Vector3 (0f, -phi, 1/phi);
		p [10] = new Vector3 (0f, phi, -1/phi);
		p [11] = new Vector3 (0f, phi, 1/phi);

		p [12] = new Vector3 (-1/phi, 0f, -phi);
		p [13] = new Vector3 (-1/phi, 0f, phi);
		p [14] = new Vector3 (1/phi, 0f, -phi);
		p [15] = new Vector3 (1/phi, 0f, phi);

		p [16] = new Vector3 (-phi, -1/phi, 0f);
		p [17] = new Vector3 (-phi, 1/phi, 0f);
		p [18] = new Vector3 (phi, -1/phi, 0f);
		p [19] = new Vector3 (phi, 1/phi, 0f);

		dodecahedronMesh.vertices = p;
		
		int[][] faces = new int[12][];

		faces[0] =  new int [5] {8,9,5,18,4};
		faces[1] =  new int [5] {9,1,13,15,5};
		faces[2] =  new int [5] {5,15,7,19,18};
		faces[3] =  new int [5] {18,19,6,14,4};
		faces[4] =  new int [5] {4,14,12,0,8};
		faces[5] =  new int [5] {8,0,16,1,9};
		faces[6] =  new int [5] {3,17,2,10,11};
		faces[7] =  new int [5] {11,7,15,13,3};	
		faces[8] =  new int [5] {10,6,19,7,11};
		faces[9] =  new int [5] {2,12,14,6,10};
		faces[10] =  new int [5] {17,16,0,12,2};
		faces[11] =  new int [5] {3,13,1,16,17};


		int[] triangles = new int[12 * 3 * 3];

		for (int i = 0, f = 0; f < 12 && i < 108; f++, i+=9) {

			triangles[i] = faces[f][2];
			triangles[i+1] = faces[f][1];
			triangles[i+2] = faces[f][0];

			triangles[i+3] = faces[f][4];
			triangles[i+4] = faces[f][2];
			triangles[i+5] = faces[f][0];

			triangles[i+6] = faces[f][4];
			triangles[i+7] = faces[f][3];
			triangles[i+8] = faces[f][2];

		}

		dodecahedronMesh.triangles = triangles;
		dodecahedronMesh.RecalculateNormals ();

		transform.localScale = normalizedScale;
		
	}








	void Awake (){
		Generate ();
	}

	void Update(){
		transform.localRotation = Quaternion.Euler ((float)DateTime.Now.TimeOfDay.TotalSeconds * 15f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 20f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 25f);
	}

}
