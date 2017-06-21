using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraExtensions {

//	public static Bounds OrthographicBounds()
//	{
//
//		float horzExtent = Camera.main.orthographicSize * Screen.width / Screen.height;
//		float swidth = Screen.width;
//		float sheight = Screen.height;
//		float osize = Camera.main.orthographicSize;
//
//		float depth = 19f;
//		float screenAspect = (float)Screen.width / (float)Screen.height;
//		float cameraHeight = Camera.main.orthographicSize * 2;
//		Bounds bounds = new Bounds(
//			Camera.main.transform.position,
//			new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
//		bounds.center = new Vector3 (bounds.center.x, bounds.center.y, bounds.center.z - depth/2f);
//		bounds.extents = new Vector3 (bounds.extents.x, bounds.extents.y, bounds.extents.z - depth/2f);
//		return bounds;
//	}
	public static Bounds OrthographicBounds()
	{
		float screenAspect = (float)Screen.width / (float)Screen.height;
		float cameraHeight = Camera.main.orthographicSize * 2;
		Bounds bounds = new Bounds(
			Camera.main.transform.position,
			new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
		return bounds;
	}

	public static Bounds OrthographicBoundsWorld()
	{
		Bounds o = OrthographicBounds();

		return new Bounds (Camera.main.ViewportToWorldPoint (o.center), Camera.main.ViewportToWorldPoint (o.size));
	}

	public static bool ContainBounds(Bounds target)
	{
		Bounds bounds = OrthographicBounds ();
		return bounds.Contains(target.min) && bounds.Contains(target.max);
	}
}
