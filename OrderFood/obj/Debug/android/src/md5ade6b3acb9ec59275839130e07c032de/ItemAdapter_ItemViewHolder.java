package md5ade6b3acb9ec59275839130e07c032de;


public class ItemAdapter_ItemViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("OrderFood.Adapters.ItemAdapter+ItemViewHolder, OrderFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ItemAdapter_ItemViewHolder.class, __md_methods);
	}


	public ItemAdapter_ItemViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ItemAdapter_ItemViewHolder.class)
			mono.android.TypeManager.Activate ("OrderFood.Adapters.ItemAdapter+ItemViewHolder, OrderFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
