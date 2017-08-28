using System;
using UnityEngine;

public class IcosahedronScript : MonoBehaviour {


	//	Icosahedron defined by (+-2,+-1,0), (0, +-2, +-1), (+-1,0,+-2)

	public Material icosahedronMaterial;
	public Vector3[] p;
	Mesh icosahedronMesh;


	private void OnDrawGizmos () {
		if (p == null) {
			return;
		}
		Gizmos.color = Color.red;
		for (int i = 0; i < p.Length; i++) {
			Gizmos.DrawSphere(p[i], 0.1f);
		}
	}



	void Generate(){

		gameObject.AddComponent<MeshRenderer> ().material = icosahedronMaterial;

		icosahedronMesh = new Mesh ();
		gameObject.AddComponent<MeshFilter> ().mesh = icosahedronMesh;
		icosahedronMesh.name = "Icosahedron Mesh";


		p = new Vector3[12];
		p [0] = new Vector3 (-2f, -1f, 0f);
		p [1] = new Vector3 (-2f, 1f, 0f);
		p [2] = new Vector3 (2f, -1f, 0f);
		p [3] = new Vector3 (2f, 1f, 0f);

		p [4] = new Vector3 (0f, -2f, -1f);
		p [5] = new Vector3 (0f, -2f, 1f);
		p [6] = new Vector3 (0f, 2f, -1f);
		p [7] = new Vector3 (0f, 2f, 1f);

		p [8] = new Vector3 (-1f, 0f, -2f);
		p [9] = new Vector3 (-1f, 0f, 2f);
		p [10] = new Vector3 (1f, 0f, -2f);
		p [11] = new Vector3 (1f, 0f, 2f);
		icosahedronMesh.vertices = p;
		/*
		int[] triangles = new int[24];

		triangles [0] = 3;
		triangles [1] = 0;
		triangles [2] = 5;

		triangles [3] = 3;
		triangles [4] = 5;
		triangles [5] = 1;

		triangles [6] = 3;
		triangles [7] = 1;
		triangles [8] = 4;

		triangles [9] = 3;
		triangles [10] = 4;
		triangles [11] = 0;

		triangles [12] = 2;
		triangles [13] = 1;
		triangles [14] = 5;

		triangles [15] = 2;
		triangles [16] = 5;
		triangles [17] = 0;


		triangles [18] = 2;
		triangles [19] = 0;
		triangles [20] = 4;

		triangles [21] = 2;
		triangles [22] = 4;
		triangles [23] = 1;

		icosahedronMesh.triangles = triangles;
		icosahedronMesh.RecalculateNormals ();
		*/
	}








	void Awake (){
		Generate ();
	}

	void Update(){
		transform.localRotation = Quaternion.Euler ((float)DateTime.Now.TimeOfDay.TotalSeconds * 15f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 20f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 25f);
	}

}
