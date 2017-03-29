using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;

namespace Game
{
    [Activity(Label = "Game", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button startGame = FindViewById<Button>(Resource.Id.newGame);
            Button loadGame = FindViewById<Button>(Resource.Id.loadGame);
            string savedFile = "";

            startGame.Click += delegate 
            {
                if (savedFile == "" || savedFile == null)
                {
                    StartActivity(typeof(CreateChar));
                }
                else {
                    AlertDialog alertDialog = new AlertDialog.Builder(AlertDialogActivity.this).create();
                    alertDialog.setTitle("Confirmation");
                    alertDialog.setMessage("Do you wat to delete save file?");
                }
                //if savefile doesn't exist, go directly to creation
            };
            loadGame.Click += delegate {
                //load game
            };
        }
    }
}

