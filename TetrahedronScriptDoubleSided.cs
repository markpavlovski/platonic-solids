using System;
using UnityEngine;

public class TetrahedronScriptDoubleSided : MonoBehaviour {

	 
	 //	Tetrahedron defined by (+-1,0,-w) and (0,+-1,w) where w = 1/sqrt(2)

	public Material tetrahedronMaterial;
	public Vector3[] p;
	float w = 1 / Mathf.Sqrt (2);
	Mesh tetrahedronMesh;
	static float normalizedScale = 1f/1f;

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


		int[] triangles = new int[24];

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

		triangles [12] = 0;
		triangles [13] = 1;
		triangles [14] = 3;

		triangles [15] = 0;
		triangles [16] = 2;
		triangles [17] = 1;

		triangles [18] = 0;
		triangles [19] = 3;
		triangles [20] = 2;

		triangles [21] = 1;
		triangles [22] = 2;
		triangles [23] = 3;

		tetrahedronMesh.triangles = triangles;
		tetrahedronMesh.RecalculateNormals ();

		transform.localScale *= normalizedScale;

	}








	void Awake (){
		Generate ();
	}

	void Update(){
		transform.localRotation = Quaternion.Euler (-135f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 15f* 4,0f);
		//transform.localRotation = Quaternion.Euler (-45f, 0f, 0f);
		//transform.localRotation = Quaternion.Euler (0, -45f, 0f);
		}
		

}
