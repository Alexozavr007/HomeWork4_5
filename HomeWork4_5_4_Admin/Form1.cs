using HomeWork4_5_4_Common;
using Newtonsoft.Json;

namespace HomeWork4_5_4_Admin;

public partial class Form1 : Form {

    private string _configFilePath = "..\\..\\..\\..\\config.xml";
    private Config _config;

    public Form1() {
        InitializeComponent();
        _config = Config.ReadFromFile(_configFilePath);
        cbAllowDiskFormat.Checked = _config.AllowDiskFormat;
        cbAllowSpamSend.Checked = _config.AllowSpamSend;
        switch (_config.WindowPosition) {
            case EWindowPosition.Center:
                rbCenter.Checked = true;
                break;
            case EWindowPosition.LeftTop:
                rbLeftTop.Checked = true;
                break;
            case EWindowPosition.RightTop:
                rbRightTop.Checked = true;
                break;
            case EWindowPosition.LeftBottom:
                rbLeftBottom.Checked = true;
                break;
            case EWindowPosition.RightBottom:
                rbRightBottom.Checked = true;
                break;
        }
    }

    private void cbAllowDiskFormat_CheckedChanged(object sender, EventArgs e) {
        _config.AllowDiskFormat = cbAllowDiskFormat.Checked;
        _config.SaveToFile(_configFilePath);
    }

    private void WindowPositionChanged(object sender, EventArgs e) {
        _config.WindowPosition =
            rbLeftTop.Checked ? EWindowPosition.LeftTop :
            rbRightTop.Checked ? EWindowPosition.RightTop :
            rbLeftBottom.Checked ? EWindowPosition.LeftBottom :
            rbRightBottom.Checked ? EWindowPosition.RightBottom :
            EWindowPosition.Center;
        _config.SaveToFile(_configFilePath);
    }

    private void cbAllowSpamSend_CheckedChanged(object sender, EventArgs e) {
        _config.AllowSpamSend = cbAllowSpamSend.Checked;
        _config.SaveToFile(_configFilePath);
    }

    private void cbAllowtxtbox_CheckedChanged(object sender, EventArgs e) {
        _config.Allowtxtbox = cbAllowtxtbox.Checked;
        _config.SaveToFile(_configFilePath);
    }
}
