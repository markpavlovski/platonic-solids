using System;
using UnityEngine;

public class IcosahedronScript : MonoBehaviour {


	//	Icosahedron defined by (+-2,+-1,0), (0, +-2, +-1), (+-1,0,+-2)

	public Material icosahedronMaterial;
	public Vector3[] p;
	Mesh icosahedronMesh;

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
		
		int[] triangles = new int[60];

		// Front 

		triangles [0] = 10;
		triangles [1] = 6;
		triangles [2] = 3;

		triangles [3] = 6;
		triangles [4] = 10;
		triangles [5] = 8;

		triangles [6] = 3;
		triangles [7] = 6;
		triangles [8] = 7;

		triangles [9] = 10;
		triangles [10] = 3;
		triangles [11] = 2;

		triangles [12] = 10;
		triangles [13] = 4;
		triangles [14] = 8;

		triangles [15] = 10;
		triangles [16] = 2;
		triangles [17] = 4;

		triangles [18] = 6;
		triangles [19] = 8;
		triangles [20] = 1;

		triangles [21] = 6;
		triangles [22] = 1;
		triangles [23] = 7;

		triangles [24] = 3;
		triangles [25] = 7;
		triangles [26] = 11;

		triangles [27] = 3;
		triangles [28] = 11;
		triangles [29] = 2;

		// Back

		triangles [30] = 0;
		triangles [31] = 5;
		triangles [32] = 9;

		triangles [33] = 0;
		triangles [34] = 9;
		triangles [35] = 1;

		triangles [36] = 9;
		triangles [37] = 5;
		triangles [38] = 11;

		triangles [39] = 5;
		triangles [40] = 0;
		triangles [41] = 4;

		triangles [42] = 0;
		triangles [43] = 1;
		triangles [44] = 8;

		triangles [45] = 0;
		triangles [46] = 8;
		triangles [47] = 4;

		triangles [48] = 4;
		triangles [49] = 7;
		triangles [50] = 1;

		triangles [51] = 4;
		triangles [52] = 11;
		triangles [53] = 7;

		triangles [54] = 5;
		triangles [55] = 2;
		triangles [56] = 11;

		triangles [57] = 5;
		triangles [58] = 4;
		triangles [59] = 2;

		icosahedronMesh.triangles = triangles;
		icosahedronMesh.RecalculateNormals ();
		
	}








	void Awake (){
		Generate ();
	}

	void Update(){
		transform.localRotation = Quaternion.Euler ((float)DateTime.Now.TimeOfDay.TotalSeconds * 15f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 20f,(float)DateTime.Now.TimeOfDay.TotalSeconds * 25f);
	}

}
