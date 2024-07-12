using Newtonsoft.Json;

namespace HomeWork4_5_4_Common;

public enum EWindowPosition {
    Center = 0,
    LeftTop = 1,
    RightTop = 2,
    LeftBottom = 3,
    RightBottom = 4,
}

public class Config {
    public bool AllowDiskFormat { get; set; }
    public bool AllowSpamSend { get; set; }
    public bool Allowtxtbox { get; set; }
    public EWindowPosition WindowPosition { get; set; }

    private static Config CreateEmpty() {
        var config = new Config();
        config.AllowDiskFormat = false;
        config.AllowSpamSend = false;
        config.Allowtxtbox = false;
        config.WindowPosition = EWindowPosition.Center;

        return config;
    }

    public static Config ReadFromFile(string filePath) {
        if (!System.IO.File.Exists(filePath)) {
            return CreateEmpty();
        }

        using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = new StreamReader(fs);
        var content = reader.ReadToEnd();

        reader.Close();
        fs.Close();

        if (String.IsNullOrEmpty(content)) {
            return CreateEmpty();
        } else {
            var res = JsonConvert.DeserializeObject<Config>(
                content
                //System.IO.File.ReadAllText(filePath)
                );
            return res;
        }
    }

    public void SaveToFile(string filePath) {
        using var fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
        using var writer = new StreamWriter(fs);
        fs.Position = 0;
        fs.SetLength(0);

        var data = JsonConvert.SerializeObject(this);
        writer.Write(data);

        writer.Close();
        fs.Close();

        //System.IO.File.WriteAllText(filePath, JsonConvert.SerializeObject(this));
    }

}

