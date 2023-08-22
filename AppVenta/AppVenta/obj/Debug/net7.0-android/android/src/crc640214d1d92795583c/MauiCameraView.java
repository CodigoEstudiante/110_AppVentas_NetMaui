package crc640214d1d92795583c;


public class MauiCameraView
	extends android.widget.GridLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConfigurationChanged:(Landroid/content/res/Configuration;)V:GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler\n" +
			"";
		mono.android.Runtime.register ("Camera.MAUI.Platforms.Android.MauiCameraView, Camera.MAUI", MauiCameraView.class, __md_methods);
	}


	public MauiCameraView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MauiCameraView.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView, Camera.MAUI", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public MauiCameraView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MauiCameraView.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView, Camera.MAUI", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public MauiCameraView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MauiCameraView.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView, Camera.MAUI", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public MauiCameraView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == MauiCameraView.class) {
			mono.android.TypeManager.Activate ("Camera.MAUI.Platforms.Android.MauiCameraView, Camera.MAUI", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void onConfigurationChanged (android.content.res.Configuration p0)
	{
		n_onConfigurationChanged (p0);
	}

	private native void n_onConfigurationChanged (android.content.res.Configuration p0);

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
