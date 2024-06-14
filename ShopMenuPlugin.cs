﻿// References to CS Sharp API
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Menu;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API;

// Reference to Figgle for ASCII Art Written in Console on load
using Figgle;

namespace ShopMenuPlugin;
public partial class ShopChatMenu : BasePlugin, IPlugin
{
    public override string ModuleName => "ShopMenuPlugin";
    public override string ModuleVersion => "0.0.2";
    public override string ModuleAuthor => "Juke";
    public override string ModuleDescription => "Menu Test";

    public override void Load(bool hotReload)
    {
        Console.WriteLine("SHOP MENU PLUGIN HAS LOADED");
        Console.WriteLine(FiggleFonts.SubZero.Render("Jukes Shop Plugin"));
    }

    [ConsoleCommand("shop")]
    public void Shop(CCSPlayerController? player, CommandInfo command)
    {
        if (player == null) 
        {
            return;
        }

        Console.WriteLine("Shop Menu Has been called...");
        var shopMenu = new ChatMenu(" {ChatColors.gold}Shop");
        MenuHelper.ShopMenu(shopMenu);
        MenuManager.OpenChatMenu(player!, shopMenu);
    }
}

public static class MenuHelper
{
    internal static void ShopMenu(ChatMenu shopMenu)
    {
        shopMenu.AddMenuOption("Option 1", (p, o) => 
        Server.PrintToChatAll(" {ChatColors.gold}Shop Menu Option Has Been Chosen"), false);
    }
}


