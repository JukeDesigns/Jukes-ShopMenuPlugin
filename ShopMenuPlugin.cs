// References to CS Sharp API
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Menu;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API;

namespace ShopMenuPlugin;
public partial class ShopChatMenu : BasePlugin, IPlugin
{
    public override string ModuleName => "ShopMenuPlugin";
    public override string ModuleVersion => "0.0.2";
    public override string ModuleAuthor => "Juke";
    public override string ModuleDescription => "Menu Test";

    public override void Load(bool hotReload)
    {
        Console.WriteLine("SHOP MENU PLUGIN HAS LOADED");;
    }

    [ConsoleCommand("shop")]
    public void Shop(CCSPlayerController? player, CommandInfo command)
    {
        if (player == null) 
        {
            return;
        }

        Console.WriteLine("Shop Menu Has been called...");
        var shopMenu = new ChatMenu($" {ChatColors.Gold}Shop");
        MenuHelper.ShopMenu(shopMenu);
        MenuManager.OpenChatMenu(player!, shopMenu);
    }
}

public static class MenuHelper
{
    internal static void ShopMenu(ChatMenu shopMenu)
    {
        shopMenu.AddMenuOption("Option 1", (p, o) => 
        Server.PrintToChatAll($" {ChatColors.Gold}Shop Menu Option Has Been Chosen"), false);
    }
}


