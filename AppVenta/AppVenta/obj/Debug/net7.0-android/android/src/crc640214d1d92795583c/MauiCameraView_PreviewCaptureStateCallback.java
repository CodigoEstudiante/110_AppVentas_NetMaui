package crc640214d1d92795583c;


public class MauiCameraView_PreviewCaptureStateCallback
	extends android.hardware.camera2.CameraCaptureSession.StateCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConfigured:(Landroid/hardware/camera2/CameraCaptureSession;)V:GetOnConfigured_Landroid_hardware_camera2_CameraCaptureSession_Handler\n" +
			"n_onConfigureFailed:(Landroid/hardware/camera2/CameraCaptureSession;)V:GetOnConfigureFailed_Landroid_hardware_camera2_CameraCaptureSession_Handler\n" +
			"";
		mono.android.Runtime.register ("Camera.MAUI.Platforms.Android.MauiCameraView+PreviewCaptureStateCallback, Camera.MAUI", MauiCameraView_PreviewCaptureStateCallback.class, __md_methods);
	}


	public MauiCameraView_PreviewCaptureStateCallback ()
	{
		super ();
		if (getClass () == MauiCameraView_PreviewCaptureStateCallback.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView+PreviewCaptureStateCallback, Camera.MAUI", "", this, new java.lang.Object[] {  });
		}
	}

	public MauiCameraView_PreviewCaptureStateCallback (crc640214d1d92795583c.MauiCameraView p0)
	{
		super ();
		if (getClass () == MauiCameraView_PreviewCaptureStateCallback.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView+PreviewCaptureStateCallback, Camera.MAUI", "Camera.MAUI.Platforms.Android.MauiCameraView, Camera.MAUI", this, new java.lang.Object[] { p0 });
		}
	}


	public void onConfigured (android.hardware.camera2.CameraCaptureSession p0)
	{
		n_onConfigured (p0);
	}

	private native void n_onConfigured (android.hardware.camera2.CameraCaptureSession p0);


	public void onConfigureFailed (android.hardware.camera2.CameraCaptureSession p0)
	{
		n_onConfigureFailed (p0);
	}

	private native void n_onConfigureFailed (android.hardware.camera2.CameraCaptureSession p0);

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
