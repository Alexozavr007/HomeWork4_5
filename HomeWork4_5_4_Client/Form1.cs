using HomeWork4_5_4_Common;

namespace HomeWork4_5_4_Client;

public partial class Form1 : Form {

    private Config _config;
    private string _configDirectory = "..\\..\\..\\..\\";
    private string _configFilePath = "config.xml";

    public Form1() {
        InitializeComponent();
        InitializeUiByConfig();

        var watcher = new FileSystemWatcher(_configDirectory, "*.xml");
        watcher.EnableRaisingEvents = true;
        watcher.Changed += Watcher_Changed;
        watcher.Created += Watcher_Changed;
        watcher.Deleted += Watcher_Changed;
    }

    private void Watcher_Changed(object sender, FileSystemEventArgs e) {
        if (e.Name == _configFilePath) {
            //InitializeUiByConfig();
            this.Invoke(new Action(() => InitializeUiByConfig()));
        }
    }

    private void InitializeUiByConfig() {
        _config = Config.ReadFromFile(_configDirectory + _configFilePath);
        txtbox.Visible = _config.Allowtxtbox;
        btnFormatDisk.Enabled = _config.AllowDiskFormat;
        btnSpamSend.Enabled = _config.AllowSpamSend;

        var W = Screen.FromControl(this).Bounds.Width;
        var H = Screen.FromControl(this).Bounds.Height;
        var h = this.Height;
        var w = this.Width;
        switch (_config.WindowPosition) {
            case EWindowPosition.Center:
                this.Top = (H / 2) - (h / 2);
                this.Left = (W / 2) - (w / 2);
                break;
            case EWindowPosition.LeftTop:
                this.Top = 0;
                this.Left = 0;
                break;
            case EWindowPosition.RightTop:
                this.Top = 0;
                this.Left = W - w;
                break;
            case EWindowPosition.LeftBottom:
                this.Top = H - h;
                this.Left = 0;
                break;
            case EWindowPosition.RightBottom:
                this.Top = H - h;
                this.Left = W - w;
                break;
        }
    }
}
