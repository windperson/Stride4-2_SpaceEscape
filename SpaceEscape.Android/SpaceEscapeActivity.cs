using Android.App;
using Android.OS;
using Android.Content.PM;

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
