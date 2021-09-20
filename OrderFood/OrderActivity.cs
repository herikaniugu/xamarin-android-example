
using Android.OS;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Widget;

namespace OrderFood
{
    [Activity(Label = "Order Food", WindowSoftInputMode = SoftInput.StateHidden, Theme = "@style/Theme.View")]
    public class OrderActivity : AppCompatActivity
    {
	protected override void OnCreate(Bundle bundle)
	{
	    // CREATE
	    base.OnCreate(bundle);
	    SetContentView(Resource.Layout.Order);

	    // UPDATE
	    var image = Intent.GetIntExtra("image", 0);
	    var name = Intent.GetStringExtra("name") ?? string.Empty;
	    var price = Intent.GetStringExtra("price") ?? string.Empty;
	    FindViewById<ImageView>(Resource.Id.photo).SetImageResource(image);
	    FindViewById<TextView>(Resource.Id.title).Text = name;
	    FindViewById<TextView>(Resource.Id.cost).Text = price;

	    // ADD
	    FindViewById<FloatingActionButton>(Resource.Id.add).Click += (sender, e) => {
		var quantity = FindViewById<EditText>(Resource.Id.quantity);
		int count = int.Parse(quantity.Text); count += 1;
		if (count < 100) quantity.Text = count.ToString();
	    };

	    // REDUCE
	    FindViewById<FloatingActionButton>(Resource.Id.reduce).Click += (sender, e) => {
		var quantity = FindViewById<EditText>(Resource.Id.quantity);
		int count = int.Parse(quantity.Text); count -= 1;
		if (count > 0) quantity.Text = count.ToString();
	    };

	    // ORDER
	    FindViewById<Button>(Resource.Id.order).Click += (sender, e) => {
		Toast.MakeText(Application.Context, "Demo for Exact Software", ToastLength.Short).Show();
	    };

	    // BACK
	    FindViewById<FloatingActionButton>(Resource.Id.fab).Click += (sender, e) => {
		base.OnBackPressed();
	    };
	}
    }
}