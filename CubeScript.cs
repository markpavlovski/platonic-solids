using System;
using UnityEngine;

public class CubeScript : MonoBehaviour {


	//	Cube defined by (+-1,+-1,+-1)

	public Material cubeMaterial;
	public Vector3[] p;
	Mesh cubeMesh;
	static float s = 2f;
	public Vector3 normalizedScale = new Vector3(1f/s, 1f/s, 1f/s);


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

		gameObject.AddComponent<MeshRenderer> ().material = cubeMaterial;

		cubeMesh = new Mesh ();
		gameObject.AddComponent<MeshFilter> ().mesh = cubeMesh;
		cubeMesh.name = "Cube Mesh";


		p = new Vector3[8];
		p [0] = new Vector3 (-1f, -1f, -1f);
		p [1] = new Vector3 (-1f, -1f, 1f);
		p [2] = new Vector3 (-1f, 1f, -1f);
		p [3] = new Vector3 (-1f, 1f, 1f);
		p [4] = new Vector3 (1f, -1f, -1f);
		p [5] = new Vector3 (1f, -1f, 1f);
		p [6] = new Vector3 (1f, 1f, -1f);
		p [7] = new Vector3 (1f, 1f, 1f);
		cubeMesh.vertices = p;

		int[] triangles = new int[36];

		triangles [0] = 0;
		triangles [1] = 2;
		triangles [2] = 6;

		triangles [3] = 0;
		triangles [4] = 6;
		triangles [5] = 4;

		triangles [6] = 4;
		triangles [7] = 6;
		triangles [8] = 7;

		triangles [9] = 4;
		triangles [10] = 7;
		triangles [11] = 5;

		triangles [12] = 2;
		triangles [13] = 3;
		triangles [14] = 7;

		triangles [15] = 2;
		triangles [16] = 7;
		triangles [17] = 6;


		triangles [18] = 0;
		triangles [19] = 1;
		triangles [20] = 3;

		triangles [21] = 0;
		triangles [22] = 3;
		triangles [23] = 2;

		triangles [24] = 0;
		triangles [25] = 4;
		triangles [26] = 1;

		triangles [27] = 1;
		triangles [28] = 4;
		triangles [29] = 5;

		triangles [30] = 1;
		triangles [31] = 5;
		triangles [32] = 7;

		triangles [33] = 1;
		triangles [34] = 7;
		triangles [35] = 3;

		cubeMesh.triangles = triangles;
		cubeMesh.RecalculateNormals ();

		transform.localScale = normalizedScale;

	}








	void Awake (){
		Generate ();
	}

	void Update(){
		transform.localRotation = Quaternion.Euler ((float)DateTime.Now.TimeOfDay.TotalSeconds * 15f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 20f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 25f);
	}

}
