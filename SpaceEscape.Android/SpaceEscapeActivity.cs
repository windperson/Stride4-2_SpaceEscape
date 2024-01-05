using Android.App;
using Android.OS;
using Android.Content.PM;
using Android;

using Stride.Engine;
using Stride.Starter;

namespace SpaceEscape
{
    [Activity(MainLauncher = true,
              Icon = "@mipmap/gameicon",
              ScreenOrientation = ScreenOrientation.Portrait,
              Theme = "@android:style/Theme.NoTitleBar",
              ConfigurationChanges = ConfigChanges.UiMode | ConfigChanges.Orientation | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class SpaceEscapeActivity : StrideActivity
    {
        protected Game Game;

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnCreate(Bundle bundle)
        {
            // Check if the BLUETOOTH_CONNECT permission is granted
            if (CheckSelfPermission(Manifest.Permission.BluetoothConnect) != Permission.Granted)
            {
                RequestPermissions(new string[] { Manifest.Permission.BluetoothConnect }, 0);
            }

            // ENSURE YOU DO PERMISSION BEFORE THIS LINE

            base.OnCreate(bundle);
        }

        protected override void OnRun()
        {
            base.OnRun();

            Game = new Game();
            Game.Run(GameContext);
        }

        protected override void OnDestroy()
        {
            Game.Dispose();

            base.OnDestroy();
        }
    }
}
