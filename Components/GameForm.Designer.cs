using GamePlay.Core;

namespace GamePlay.Components
{
    partial class GameForm
    {
        private void InitializeComponent()
        {
            Text = "Pixel Adventure";
            ClientSize = new System.Drawing.Size(800, 450);
            BackColor = Color.Black;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            GEngine engine = GEngine.GetGEngineInstance();
            Paint += engine.GetPaint;
        }
    }
}