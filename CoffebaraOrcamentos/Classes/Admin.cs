using Newtonsoft.Json;
using System.IO;

public static class Admin
{
    public static string name = "Admin";
    public static string senha = "12345";
    public static string telefone = "telefone estatico";
    public static string Email = "Admin@e-mail.com";

    public static void SalvarConfiguracoes()
    {

        var settings = new
        {
            Name = name,
            Senha = senha,
            Telefone = telefone,
            Email = Email
        };

        string json = JsonConvert.SerializeObject(settings);
        File.WriteAllText("config.json", json);
    }

    public static void CarregarConfiguracoes()
    {
        if (File.Exists("config.json"))
        {
            string json = File.ReadAllText("config.json");
            dynamic settings = JsonConvert.DeserializeObject(json);

            name = settings.Name;
            senha = settings.Senha;
            telefone = settings.Telefone;
            Email = settings.Email;
        }
    }
}
