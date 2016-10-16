using Android.App;
using Android.Widget;
using Android.OS;
using Com.Oguzdev.Circularfloatingactionmenu.Library;

namespace Float_Menu
{
    [Activity(Label = "Float_Menu", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        FloatingActionMenu fam;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            //FAB BUTTON
            ImageView fabIcon=new ImageView(this);
            fabIcon.SetImageResource(Resource.Drawable.add_green);
            FloatingActionButton fab=new FloatingActionButton.Builder(this).SetContentView(fabIcon).Build();

            //BUILDER AND sub buttons
            SubActionButton.Builder builder=new SubActionButton.Builder(this);

            //BUTTON 1
            ImageView saveIcon = new ImageView(this);
            saveIcon.SetImageResource(Resource.Drawable.add_circle);
            SubActionButton saveBtn = builder.SetContentView(saveIcon).Build();

            //BUTTON 2
            ImageView editIcon = new ImageView(this);
            editIcon.SetImageResource(Resource.Drawable.add_note_blue);
            SubActionButton editBtn = builder.SetContentView(editIcon).Build();

            //BUTTON 1
            ImageView deleteIcon = new ImageView(this);
            deleteIcon.SetImageResource(Resource.Drawable.delete_red);
            SubActionButton deleteBtn = builder.SetContentView(deleteIcon).Build();

            //MENU
            fam = new FloatingActionMenu.Builder(this)
                .AddSubActionView(saveBtn)
                .AddSubActionView(editBtn)
                .AddSubActionView(deleteBtn)
                .AttachTo(fab)
                .Build();
            //CLICK EVENTS
            saveBtn.Click += SaveBtn_Click;
            editBtn.Click += EditBtn_Click;
            deleteBtn.Click += DeleteBtn_Click;

        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Deleted", ToastLength.Short).Show();
            //fam.
            fam.Close(true);
        }

        private void EditBtn_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Edited", ToastLength.Short).Show();
            fam.Close(true);


        }

        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this,"Saved",ToastLength.Short).Show();
            fam.Close(true);

        }
    }
}

