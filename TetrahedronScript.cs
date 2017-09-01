using System;
using UnityEngine;

public class TetrahedronScript : MonoBehaviour {

	 
	 //	Tetrahedron defined by (+-1,0,-w) and (0,+-1,w) where w = 1/sqrt(2)

	public Material tetrahedronMaterial;
	public Vector3[] p;
	float w = 1 / Mathf.Sqrt (2);
	Mesh tetrahedronMesh;
	static float normalizedScale = 1f/2f;

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

		gameObject.AddComponent<MeshRenderer> ().material = tetrahedronMaterial;

		tetrahedronMesh = new Mesh ();
		gameObject.AddComponent<MeshFilter> ().mesh = tetrahedronMesh;
		tetrahedronMesh.name = "Tetrahedron Mesh";


		p = new Vector3[4];
		Vector2[] uv = new Vector2[4];

		p [0] = new Vector3 (-1f, 0f, -w);
		p [1] = new Vector3 (1f, 0f, -w);
		p [2] = new Vector3 (0f, -1f, w);
		p [3] = new Vector3 (0f, 1f, w);
		tetrahedronMesh.vertices = p;

		uv [0] = new Vector2 (0f, 0f);
		uv [1] = new Vector2 (1f, 0f);
		uv [2] = new Vector2 (0f, 1f);
		uv [3] = new Vector2 (1f, 1f);

		tetrahedronMesh.uv = uv;


		int[] triangles = new int[12];

		triangles [0] = 0;
		triangles [1] = 3;
		triangles [2] = 1;

		triangles [3] = 0;
		triangles [4] = 1;
		triangles [5] = 2;

		triangles [6] = 0;
		triangles [7] = 2;
		triangles [8] = 3;

		triangles [9] = 1;
		triangles [10] = 3;
		triangles [11] = 2;

		tetrahedronMesh.triangles = triangles;
		tetrahedronMesh.RecalculateNormals ();

		transform.localScale *= normalizedScale;

	}








	void Awake (){
		Generate ();
	}

	void Update(){
		//transform.localRotation = Quaternion.Euler ((float)DateTime.Now.TimeOfDay.TotalSeconds * 15f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 20f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 25f);
		transform.localRotation = Quaternion.Euler (-45f, 0f, 0f);
		}
		

}
