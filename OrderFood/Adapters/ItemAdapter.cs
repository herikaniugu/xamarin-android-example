using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using OrderFood.Models;
using Android.Content;

namespace OrderFood.Adapters
{
    public class ItemAdapter : RecyclerView.Adapter
    {
	private Context context;
	public List<Item> item;
	public ItemAdapter(List<Item> item)
	{
	    this.item = item;
	}
	public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int type)
	{
	    View view = LayoutInflater.From(parent.Context).
		Inflate(Resource.Layout.Item, parent, false); context = parent.Context;
	    ItemViewHolder holder = new ItemViewHolder(view); return holder;
	}
	public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
	{
	    ItemViewHolder view = holder as ItemViewHolder;
	    view.card.Click += (sender, e) => {
		var intent = new Intent(context, typeof(OrderActivity));
		intent.PutExtra("image", this.item[position].image);
		intent.PutExtra("name", this.item[position].name);
		intent.PutExtra("price", this.item[position].price);
		context.StartActivity(intent);
	    };
	    view.image.SetImageResource(this.item[position].image);
	    view.name.Text = this.item[position].name;
	    view.price.Text = this.item[position].price;
	}
	public class ItemViewHolder : RecyclerView.ViewHolder
	{
	    public CardView card { get; set; }
	    public ImageView image { get; set; }
	    public TextView name { get; set; }
	    public TextView price { get; set; }
	    public ItemViewHolder(View view) : base(view)
	    {
		this.card = view.FindViewById<CardView>(Resource.Id.card);
		this.image = view.FindViewById<ImageView>(Resource.Id.image);
		this.name = view.FindViewById<TextView>(Resource.Id.name);
		this.price = view.FindViewById<TextView>(Resource.Id.price);
	    }
	}
	public void AddItem(Item value)
	{
	    this.item.Add(value);
	    NotifyItemChanged(this.item.Count);
	}
	public override int ItemCount
	{
	    get { return this.item.Count; }
	}
    }
}