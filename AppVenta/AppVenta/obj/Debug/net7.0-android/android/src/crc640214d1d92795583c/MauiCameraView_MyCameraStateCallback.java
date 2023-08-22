package crc640214d1d92795583c;


public class MauiCameraView_MyCameraStateCallback
	extends android.hardware.camera2.CameraDevice.StateCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onOpened:(Landroid/hardware/camera2/CameraDevice;)V:GetOnOpened_Landroid_hardware_camera2_CameraDevice_Handler\n" +
			"n_onDisconnected:(Landroid/hardware/camera2/CameraDevice;)V:GetOnDisconnected_Landroid_hardware_camera2_CameraDevice_Handler\n" +
			"n_onError:(Landroid/hardware/camera2/CameraDevice;I)V:GetOnError_Landroid_hardware_camera2_CameraDevice_IHandler\n" +
			"";
		mono.android.Runtime.register ("Camera.MAUI.Platforms.Android.MauiCameraView+MyCameraStateCallback, Camera.MAUI", MauiCameraView_MyCameraStateCallback.class, __md_methods);
	}


	public MauiCameraView_MyCameraStateCallback ()
	{
		super ();
		if (getClass () == MauiCameraView_MyCameraStateCallback.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView+MyCameraStateCallback, Camera.MAUI", "", this, new java.lang.Object[] {  });
		}
	}

	public MauiCameraView_MyCameraStateCallback (crc640214d1d92795583c.MauiCameraView p0)
	{
		super ();
		if (getClass () == MauiCameraView_MyCameraStateCallback.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView+MyCameraStateCallback, Camera.MAUI", "Camera.MAUI.Platforms.Android.MauiCameraView, Camera.MAUI", this, new java.lang.Object[] { p0 });
		}
	}


	public void onOpened (android.hardware.camera2.CameraDevice p0)
	{
		n_onOpened (p0);
	}

	private native void n_onOpened (android.hardware.camera2.CameraDevice p0);


	public void onDisconnected (android.hardware.camera2.CameraDevice p0)
	{
		n_onDisconnected (p0);
	}

	private native void n_onDisconnected (android.hardware.camera2.CameraDevice p0);


	public void onError (android.hardware.camera2.CameraDevice p0, int p1)
	{
		n_onError (p0, p1);
	}

	private native void n_onError (android.hardware.camera2.CameraDevice p0, int p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
