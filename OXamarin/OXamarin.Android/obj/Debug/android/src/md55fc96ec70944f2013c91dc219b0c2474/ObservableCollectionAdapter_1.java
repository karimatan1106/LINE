package md55fc96ec70944f2013c91dc219b0c2474;


public class ObservableCollectionAdapter_1
	extends md55fc96ec70944f2013c91dc219b0c2474.ListAdapter_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Reactive.Bindings.ObservableCollectionAdapter`1, ReactiveProperty.Android, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null", ObservableCollectionAdapter_1.class, __md_methods);
	}


	public ObservableCollectionAdapter_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ObservableCollectionAdapter_1.class)
			mono.android.TypeManager.Activate ("Reactive.Bindings.ObservableCollectionAdapter`1, ReactiveProperty.Android, Version=3.6.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
