using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using System.Collections.Generic;
using OrderFood.Models;
using OrderFood.Adapters;
using Android.App;

namespace OrderFood
{
    [Activity(Label = "Order Food", MainLauncher = true, Icon = "@drawable/Icon")]
    public class MainActivity : AppCompatActivity
    {
	protected override void OnCreate(Bundle bundle)
	{
	    // CREATE
	    base.OnCreate(bundle);
	    SetContentView(Resource.Layout.Main);

	    // TOOLBAR
	    var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
	    SetSupportActionBar(toolbar);
	    SupportActionBar.Title = Resources.GetString(Resource.String.Title);
	    var field = toolbar.Class.GetDeclaredField("mTitleTextView"); field.Accessible = true;
	    var title = (TextView)field.Get(toolbar);
	    title.TextAlignment = TextAlignment.Center;
	    title.Gravity = GravityFlags.Center;
	    title.LayoutParameters.Width = -1;

	    // LIST
	    var item = new List<Item>();
	    var manager = new LinearLayoutManager(this);
	    var adapter = new ItemAdapter(item);
	    var items = FindViewById<RecyclerView>(Resource.Id.items);
	    item.Add(new Item() { image = Resource.Drawable.Chicken, name = "Fried Beef and Chicken", price = "25,000 TZS" });
	    item.Add(new Item() { image = Resource.Drawable.Pizza, name = "Beef Pizza", price = "20,000 TZS" });
	    item.Add(new Item() { image = Resource.Drawable.Fish, name = "Fried Fish", price = "15,000 TZS" });
	    items.SetLayoutManager(manager);
	    items.SetAdapter(adapter);

	    // CART
	    FindViewById<Button>(Resource.Id.cart).Click += (sender, e) => {
		Toast.MakeText(Application.Context, "Demo for Exact Software", ToastLength.Short).Show();
	    };

	    // CONTINUE
	    FindViewById<Button>(Resource.Id.next).Click += (sender, e) => {
		Toast.MakeText(Application.Context, "Demo for Exact Software", ToastLength.Short).Show();
	    };

	    // BACK
	    FindViewById<FloatingActionButton>(Resource.Id.back).Click += (sender, e) => {
		base.OnBackPressed();
	    };
	}
    }
}