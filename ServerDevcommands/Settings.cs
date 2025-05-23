using System;
using System.Collections.Generic;
using System.Linq;
using BepInEx.Configuration;
using UnityEngine;
namespace ServerDevcommands;
#nullable disable
public static class Settings
{
  public static bool Cheats => (ZNet.instance && ZNet.instance.IsServer()) || Console.instance.IsCheatsEnabled();

  public static ConfigEntry<bool> configMapCoordinates;
  public static bool MapCoordinates => Cheats && configMapCoordinates.Value;
  public static ConfigEntry<bool> configMiniMapCoordinates;
  public static bool MiniMapCoordinates => Cheats && configMiniMapCoordinates.Value;
  public static ConfigEntry<bool> configShowPrivatePlayers;
  public static bool ShowPrivatePlayers => Cheats && configShowPrivatePlayers.Value;
  public static ConfigEntry<bool> configAutoDevcommands;
  public static bool AutoDevcommands => configAutoDevcommands.Value;
  public static ConfigEntry<bool> configDebugModeFastTeleport;
  public static bool DebugModeFastTeleport => configDebugModeFastTeleport.Value;
  public static ConfigEntry<bool> configAutoDebugMode;
  public static bool AutoDebugMode => configAutoDebugMode.Value;
  public static ConfigEntry<bool> configKillDestroySpawners;
  public static bool KillDestroySpawners => configKillDestroySpawners.Value;
  public static ConfigEntry<bool> configAutoGodMode;
  public static bool AutoGodMode => configAutoGodMode.Value;
  public static ConfigEntry<bool> configDisableNoMap;
  public static bool DisableNoMap => Cheats && configDisableNoMap.Value;
  public static ConfigEntry<bool> configAutoGhostMode;
  public static bool AutoGhostMode => configAutoGhostMode.Value;
  public static ConfigEntry<bool> configAutomaticItemPickUp;
  public static bool AutomaticItemPickUp => configAutomaticItemPickUp.Value;
  public static ConfigEntry<bool> configAutoNoCost;
  public static bool AutoNoCost => configAutoNoCost.Value;
  public static ConfigEntry<bool> configDisableEvents;
  public static bool DisableEvents => Cheats && configDisableEvents.Value;
  public static ConfigEntry<bool> configDisableUnlockMessages;
  public static bool DisableUnlockMessages => configDisableUnlockMessages.Value;
  public static ConfigEntry<bool> configDisableDebugModeKeys;
  public static bool DisableDebugModeKeys => configDisableDebugModeKeys.Value;
  public static ConfigEntry<bool> configAutoFly;
  public static bool AutoFly => configAutoFly.Value;
  public static ConfigEntry<string> configAutoTod;
  public static string AutoTod => configAutoTod.Value;
  public static ConfigEntry<string> configAutoEnv;
  public static string AutoEnv => configAutoEnv.Value;
  public static ConfigEntry<bool> configDisableMessages;
  public static bool DisableMessages => configDisableMessages.Value;
  public static ConfigEntry<bool> configGodModeNoWeightLimit;
  public static bool GodModeNoWeightLimit => Cheats && configGodModeNoWeightLimit.Value;
  public static ConfigEntry<bool> configGodModeNoStamina;
  public static bool GodModeNoStamina => Cheats && configGodModeNoStamina.Value;
  public static ConfigEntry<bool> configGodModeNoEitr;
  public static bool GodModeNoEitr => Cheats && configGodModeNoEitr.Value;
  public static ConfigEntry<bool> configGodModeNoUsage;
  public static bool GodModeNoUsage => Cheats && configGodModeNoUsage.Value;
  public static ConfigEntry<bool> configGodModeAlwaysDodge;
  public static bool GodModeAlwaysDodge => Cheats && configGodModeAlwaysDodge.Value;
  public static ConfigEntry<bool> configGodModeAlwaysParry;
  public static bool GodModeAlwaysParry => Cheats && configGodModeAlwaysParry.Value;
  public static ConfigEntry<bool> configGodModeNoStagger;
  public static bool GodModeNoStagger => Cheats && configGodModeNoStagger.Value;
  public static ConfigEntry<bool> configHideShoutPings;
  public static bool HideShoutPings => Cheats && configHideShoutPings.Value;
  public static ConfigEntry<bool> configGodModeNoEdgeOfWorld;
  public static bool GodModeNoEdgeOfWorld => Cheats && configGodModeNoEdgeOfWorld.Value;
  public static ConfigEntry<bool> configDisableStartShout;
  public static bool DisableStartShout => configDisableStartShout.Value;
  public static ConfigEntry<bool> configAccessPrivateChests;
  public static bool AccessPrivateChests => Cheats && configAccessPrivateChests.Value;
  public static ConfigEntry<bool> configAccessWardedAreas;
  public static bool AccessWardedAreas => Cheats && configAccessWardedAreas.Value;
  public static ConfigEntry<bool> configFlyNoClip;
  public static bool FlyNoClip => Cheats && configFlyNoClip.Value;
  public static ConfigEntry<bool> configNoClipClearEnvironment;
  public static bool NoClipClearEnvironment => configNoClipClearEnvironment.Value;
  public static ConfigEntry<bool> configGodModeNoKnockback;
  public static bool GodModeNoKnockback => Cheats && configGodModeNoKnockback.Value;
  public static ConfigEntry<bool> configGodModeNoMist;
  public static bool GodModeNoMist => Cheats && configGodModeNoMist.Value;
  public static ConfigEntry<bool> configAliasing;
  public static bool Aliasing => configAliasing.Value;
  public static ConfigEntry<string> configSubstitution;
  public static string Substitution => configSubstitution.Value;
  public static ConfigEntry<string> configWrapping;
  public static string Wrapping => configWrapping.Value;
  public static ConfigEntry<bool> configImprovedAutoComplete;
  public static bool ImprovedAutoComplete => configImprovedAutoComplete.Value;
  public static ConfigEntry<bool> configMultiCommand;
  public static bool MultiCommand => configMultiCommand.Value;
  public static ConfigEntry<bool> configGhostInvisibility;
  public static bool GhostInvisibility => Cheats && configGhostInvisibility.Value;
  public static ConfigEntry<bool> configGhostNoSpawns;
  public static bool GhostNoSpawns => Cheats && configGhostNoSpawns.Value;
  public static ConfigEntry<bool> configServerChat;
  public static bool IsServerChat => configServerChat.Value;
  public static ConfigEntry<string> configServerChatName;
  public static string ServerChatName => configServerChatName.Value;
  public static ConfigEntry<bool> configGhostIgnoreSleep;
  public static bool GhostIgnoreSleep => Cheats && configGhostIgnoreSleep.Value;
  public static ConfigEntry<string> configFlyUpKeys;
  public static List<KeyCode> FlyUpRequiredKeys = [];
  public static List<KeyCode> FlyUpBannedKeys = [];
  public static ConfigEntry<string> configFlyDownKeys;
  public static List<KeyCode> FlyDownRequiredKeys = [];
  public static List<KeyCode> FlyDownBannedKeys = [];
  public static ConfigEntry<bool> configFreeFlyInvertCamera;
  public static bool FreeFlyCameraInvert => configFreeFlyInvertCamera.Value;
  public static ConfigEntry<bool> configNoDrops;
  public static bool NoDrops => Cheats && configNoDrops.Value;
  public static ConfigEntry<bool> configNoClipView;
  public static bool NoClipView => Cheats && configNoClipView.Value;
  public static ConfigEntry<string> configCommandAliases;
  public static ConfigEntry<bool> configImprovedChat;
  public static bool ImprovedChat => configImprovedChat.Value;

  public static ConfigEntry<KeyboardShortcut> configMapTeleport;
  public static KeyboardShortcut MapTeleport => configMapTeleport.Value;
  public static ConfigEntry<string> configAutoExecBoot;
  public static string AutoExecBoot => configAutoExecBoot.Value;
  public static ConfigEntry<string> configAutoExec;
  public static string AutoExec => configAutoExec.Value;
  public static ConfigEntry<string> configAutoExecDevOn;
  public static string AutoExecDevOn => configAutoExecDevOn.Value;
  public static ConfigEntry<string> configAutoExecDevOff;
  public static string AutoExecDevOff => configAutoExecDevOff.Value;
  public static ConfigEntry<bool> configCommandDescriptions;
  public static bool CommandDescriptions => configCommandDescriptions.Value;
  private static Dictionary<string, string> Aliases = [];
  public static string[] AliasKeys = [];

  private static void ParseAliases(string value)
  {
    Aliases = value.Split('¤').Select(str => str.Split(' ')).ToDictionary(split => split[0], static split => string.Join(" ", split.Skip(1)));
    Aliases = Aliases.Where(kvp => kvp.Key != "").ToDictionary(kvp => kvp.Key, static kvp => kvp.Value);
    AliasKeys = Aliases.Keys.OrderBy(key => key).ToArray();
  }
  public static string GetAliasValue(string key) => Aliases.ContainsKey(key) ? Aliases[key] : "_";
  public static void RegisterCommands()
  {
    foreach (var alias in Aliases)
    {
      AliasCommand.AddCommand(alias.Key, alias.Value);
    }
    DisableCommands.UpdateCommands(configRootUsers.Value, configDisabledCommands.Value);
  }

  private static void SaveAliases()
  {
    var value = string.Join("¤", Aliases.Select(kvp => kvp.Key + " " + kvp.Value));
    configCommandAliases.Value = value;
  }

  public static void AddAlias(string alias, string value)
  {
    if (value == "")
    {
      RemoveAlias(alias);
    }
    else
    {
      Aliases[alias] = value;
      SaveAliases();
    }
  }

  public static void AddAlias(Dictionary<string, string> dict)
  {
    Aliases = dict;
    SaveAliases();
  }
  public static void RemoveAlias(string alias)
  {
    if (!Aliases.ContainsKey(alias)) return;
    Aliases.Remove(alias);
    SaveAliases();
  }

  private static HashSet<string> ParseList(string value) => Parse.Split(value).Select(s => s.ToLower()).ToHashSet();
  public static ConfigEntry<string> configDisabledCommands;
  public static ConfigEntry<string> configRootUsers;
  public static ConfigEntry<string> configDisabledGlobalKeys;
  public static ConfigEntry<string> configUndoLimit;
  public static int UndoLimit => Parse.Int(configUndoLimit.Value, 50);
  public static HashSet<string> DisabledGlobalKeys => ParseList(configDisabledGlobalKeys.Value);
  public static bool IsGlobalKeyDisabled(string key) => DisabledGlobalKeys.Contains(key.ToLower());



  public static ConfigEntry<string> configPlayerListFormat;
  public static string PlayerListFormat => configPlayerListFormat.Value;
  public static ConfigEntry<string> configCommandLogFormat;
  public static string CommandLogFormat => configCommandLogFormat.Value;

  public static ConfigEntry<string> configFindFormat;
  public static string FindFormat => configFindFormat.Value;
  public static ConfigEntry<string> configMinimapFormat;
  public static string MinimapFormat => configMinimapFormat.Value;
  public static ConfigEntry<bool> configChatOutput;
  public static bool ChatOutput => configChatOutput.Value;
  public static string Format(string format)
  {
    return format
      .Replace("{player_id", "{0")
      .Replace("{character_name", "{1")
      .Replace("{character_id", "{2")
      .Replace("{pos_x", "{3")
      .Replace("{pos_y", "{4")
      .Replace("{pos_z", "{5");
  }
  public static void Init(ConfigFile config)
  {
    var section = "1. General";
    configGhostInvisibility = config.Bind(section, "Invisible to other players with ghost mode", false, "");
    configGhostNoSpawns = config.Bind(section, "Disables spawns with ghost mode", false, "");
    configGhostIgnoreSleep = config.Bind(section, "Ignores sleep check with ghost mode", false, "");
    configServerChat = config.Bind(section, "Server chat", false, "Adds the server as a fake player to allow server to send chat messages.");
    configServerChatName = config.Bind(section, "Server chat name", "Server", "Name of the server chat player.");
    configServerChatName.SettingChanged += (s, e) => ServerChat.RefreshPlayerInfo();
    configNoDrops = config.Bind(section, "No creature drops", false, "Disables drops from creatures (if you control the zone), intended to fix high star enemies crashing the game.");
    configNoClipView = config.Bind(section, "No clip view", false, "Removes collision check for the camera.");
    configAutoDebugMode = config.Bind(section, "Automatic debug mode", false, "Automatically enables debug mode when enabling devcommands.");
    configKillDestroySpawners = config.Bind(section, "Kill destroys spawners", true, "Destroys spawners when using kill commands");
    configAutoFly = config.Bind(section, "Automatic fly mode", false, "Automatically enables fly mode when enabling devcommands.");
    configAutoEnv = config.Bind(section, "Automatic environment", "", "Automatically enables environment when enabling devcommands (for example clear).");
    configAutoTod = config.Bind(section, "Automatic time of day", "", "Automatically enables time of day when enabling devcommands (for example 0.33).");
    configAutoNoCost = config.Bind(section, "Automatic no cost mode", false, "Automatically enables no cost mode when enabling devcommands.");
    configAutoGodMode = config.Bind(section, "Automatic god mode", false, "Automatically enables god mode when enabling devcommands.");
    configAutoGhostMode = config.Bind(section, "Automatic ghost mode", false, "Automatically enables ghost mode when enabling devcommands.");
    configAutomaticItemPickUp = config.Bind(section, "Automatic item pick up", true, "Sets the default value for the automatic item pick up feature.");
    configAutomaticItemPickUp.SettingChanged += (s, e) =>
    {
      if (Player.m_localPlayer) Player.m_enableAutoPickup = AutomaticItemPickUp;
    };
    configAutoDevcommands = config.Bind(section, "Automatic devcommands", true, "Automatically enables devcommands when joining servers.");
    configDebugModeFastTeleport = config.Bind(section, "Debug mode fast teleport", true, "All teleporting is much faster with the debug mode.");
    configDisableNoMap = config.Bind(section, "Disable no map", false, "Disables no map having effect.");
    configDisableNoMap.SettingChanged += (s, e) => Game.UpdateNoMap();
    configGodModeNoStamina = config.Bind(section, "No stamina usage with god mode", true, "");
    configGodModeNoEitr = config.Bind(section, "No eitr usage with god mode", true, "");
    configGodModeNoUsage = config.Bind(section, "No item usage with god mode", false, "");
    configGodModeNoWeightLimit = config.Bind(section, "No weight limit with god mode", false, "");
    configGodModeAlwaysDodge = config.Bind(section, "Always dodge with god mode", false, "");
    configGodModeAlwaysParry = config.Bind(section, "Always parry with god mode (when not blocking)", false, "");
    configGodModeNoStagger = config.Bind(section, "No staggering with god mode", true, "");
    configHideShoutPings = config.Bind(section, "Hide shout pings", false, "Forces shout pings at the world center.");
    configGodModeNoEdgeOfWorld = config.Bind(section, "No edge of world pull with god mode", true, "");
    configDisableStartShout = config.Bind(section, "Disable start shout", false, "Removes the initial shout message when joining the server.");
    configAccessPrivateChests = config.Bind(section, "Access private chests", true, "Allows opening private chests.");
    configAccessWardedAreas = config.Bind(section, "Access warded areas", true, "Allows accessing warded areas.");
    configFlyNoClip = config.Bind(section, "No clip with fly mode", false, "");
    configFreeFlyInvertCamera = config.Bind(section, "Free fly uses camera invert", true, "Makes free fly to use camera invert settings.");
    configNoClipClearEnvironment = config.Bind(section, "No clip clears forced environments", true, "Removes any forced environments when the noclip is enabled. This disables any dark dungeon environments and prevents them from staying on when exiting the dungeon.");
    configGodModeNoKnockback = config.Bind(section, "No knockback with god mode", true, "");
    configGodModeNoMist = config.Bind(section, "No Mistlands mist with god mode", false, "");
    configMapCoordinates = config.Bind(section, "Show map coordinates", true, "The map shows coordinates on hover.");
    configMiniMapCoordinates = config.Bind(section, "Show minimap coordinates", false, "The minimap shows player coordinates.");
    configShowPrivatePlayers = config.Bind(section, "Show private players", false, "The map shows private players.");
    configDisableEvents = config.Bind(section, "Disable random events", false, "Disables random events (server side setting).");
    configDisableUnlockMessages = config.Bind(section, "Disable unlock messages", false, "Disables messages about new pieces and items.");
    configDisableDebugModeKeys = config.Bind(section, "Disable debug mode keys", false, "Removes debug mode key bindings for killall, removedrops, fly and no cost.");
    configDisabledGlobalKeys = config.Bind(section, "Disabled global keys", "", "Global keys separated by , that won't be set (server side setting).");
    configDisabledGlobalKeys.SettingChanged += (s, e) => DisableGlobalKeys.RemoveDisabled();
    configUndoLimit = config.Bind(section, "Max undo steps", "50", "How many undo actions are stored.");
    configUndoLimit.SettingChanged += (s, e) => UndoManager.MaxSteps = UndoLimit;
    UndoManager.MaxSteps = UndoLimit;
    section = "2. Console";
    configDisableMessages = config.Bind(section, "Disable messages", false, "Prevents messages from commands.");
    configMapTeleport = config.Bind(section, "Map teleport bind key", new KeyboardShortcut(KeyCode.Mouse2, KeyCode.LeftControl), "Key bind for map teleport.");
    configAutoExecBoot = config.Bind(section, "Auto exec boot", "", "Executes the given command when starting the game.");
    configAutoExecDevOn = config.Bind(section, "Auto exec dev on", "", "Executes the given command when enabling devcommands.");
    configAutoExecDevOff = config.Bind(section, "Auto exec dev off", "", "Executes the given command when disabling devcommands.");
    configAutoExec = config.Bind(section, "Auto exec", "", "Executes the given command when joining a server (before admin is checked).");
    configCommandDescriptions = config.Bind(section, "Command descriptions", true, "Shows command descriptions as autocomplete.");
    configAliasing = config.Bind(section, "Alias system", true, "Enables the command aliasing system (allows creating new commands).");
    configImprovedAutoComplete = config.Bind(section, "Improved autocomplete", true, "Enables parameter info or options for every parameter.");
    configCommandAliases = config.Bind(section, "Command aliases", "", "Internal data for aliases.");
    configMultiCommand = config.Bind(section, "Multiple commands per line", true, "Enables multiple commands when separated with ;.");
    configImprovedChat = config.Bind(section, "Improved chat", true, "Enables alias and multicommands system for chat.");
    configSubstitution = config.Bind(section, "Substitution", "$$", "Enables the command parameter substitution system (substitution gets replaced with the next free parameter).");
    configWrapping = config.Bind(section, "Wrapping", "\"", "Allows using space bars in command parameters.");
    configCommandAliases.SettingChanged += (s, e) => ParseAliases(configCommandAliases.Value);
    configRootUsers = config.Bind(section, "Root users", "", "Steam IDs separated by , that can execute blacklisted commands. Server side setting.");
    configRootUsers.SettingChanged += (s, e) =>
    {
      DisableCommands.UpdateCommands(configRootUsers.Value, configDisabledCommands.Value);
      RootUsers.Update();
    };
    configDisabledCommands = config.Bind(section, "Disabled commands", "dev_config disable_command", "Command names separated by , that can't be executed.");
    configDisabledCommands.SettingChanged += (s, e) => DisableCommands.UpdateCommands(configRootUsers.Value, configDisabledCommands.Value);
    configFlyUpKeys = config.Bind(section, "Key for fly up", "Space", "Key codes separated by ,");
    configFlyUpKeys.SettingChanged += (s, e) => ParseFlyUp();
    ParseFlyUp();
    configFlyDownKeys = config.Bind(section, "Key for fly down", "LeftControl", "Key codes separated by ,");
    configFlyDownKeys.SettingChanged += (s, e) => ParseFlyDown();
    ParseFlyDown();
    configChatOutput = config.Bind(section, "Chat output", false, "Sends messages to the chat window from bound keys.");
    section = "3. Formatting";
    ParseAliases(configCommandAliases.Value);
    configPlayerListFormat = config.Bind(section, "Player list format", "{player_id}/{character_name}/{character_id} ({pos_x:F0}, {pos_z:F0}, {pos_y:F0})", "Format of playerlist command.");
    configCommandLogFormat = config.Bind(section, "Command log format", "{player_id}/{character_name} ({pos_x:F0}, {pos_z:F0}, {pos_y:F0}): {command}", "Format for the command log.");
    configFindFormat = config.Bind(section, "Find format", "{pos_x:F0}, {pos_z:F0}, {pos_y:F0}, distance {distance:F0} ({name})", "Format for the find command. Server side setting.");
    configMinimapFormat = config.Bind(section, "Minimap format", "x: {pos_x:F0}, z: {pos_z:F0}, y: {pos_y:F0}", "Format for minimap coordinates.");
  }
  private static void ParseFlyUp()
  {
    FlyUpRequiredKeys.Clear();
    FlyUpBannedKeys.Clear();
    var split = Parse.Split(configFlyUpKeys.Value);
    foreach (var key in split)
    {
      if (key.StartsWith("-"))
      {
        if (Enum.TryParse<KeyCode>(key.Substring(1), true, out var keyCode))
          FlyUpBannedKeys.Add(keyCode);
      }
      else if (Enum.TryParse<KeyCode>(key, true, out var keyCode))
        FlyUpRequiredKeys.Add(keyCode);
    }
  }
  private static void ParseFlyDown()
  {
    FlyDownRequiredKeys.Clear();
    FlyDownBannedKeys.Clear();
    var split = Parse.Split(configFlyDownKeys.Value);
    foreach (var key in split)
    {
      if (key.StartsWith("-"))
      {
        if (Enum.TryParse<KeyCode>(key.Substring(1), true, out var keyCode))
          FlyDownBannedKeys.Add(keyCode);
      }
      else if (Enum.TryParse<KeyCode>(key, true, out var keyCode))
        FlyDownRequiredKeys.Add(keyCode);
    }
  }

  public static List<string> Options = [
    "access_private_chests",
    "access_warded_areas",
    "map_coordinates",
    "private_players",
    "auto_devcommands",
    "auto_debugmode",
    "auto_fly",
    "god_no_stagger",
    "auto_nocost",
    "auto_ghost",
    "auto_god",
    "debug_console",
    "no_drops",
    "aliasing",
    "god_no_stamina",
    "substitution",
    "wrapping",
    "improved_autocomplete",
    "disable_events",
    "disable_warnings",
    "multiple_commands",
    "god_no_knockback",
    "ghost_invibisility",
    "auto_exec_dev_on",
    "auto_exec_dev_off",
    "auto_exec_boot",
    "auto_exec",
    "command_descriptions",
    "server_commands",
    "fly_no_clip",
    "disable_command",
    "minimap_coordinates",
    "disable_global_key",
    "disable_debug_mode_keys",
    "god_always_parry",
    "god_always_dodge",
    "fly_up_key",
    "fly_down_key",
    "disable_start_shout",
    "mouse_wheel_bind_key",
    "god_no_weight_limit",
    "automatic_item_pick_up",
    "disable_messages",
    "god_no_edge",
    "no_clip_clear_environment",
    "max_undo_steps",
    "best_command_match",
    "debug_fast_teleport",
    "disable_no_map",
    "hide_shout_pings",
    "disable_unlock_messages",
    "no_clip_view",
    "god_no_eitr",
    "god_no_item",
    "players_format",
    "command_log_format",
    "minimap_format",
    "chat_output",
    "free_fly_camera_invert",
    "server_chat",
    "server_chat_name",
  ];
  private static string State(bool value) => value ? "enabled" : "disabled";
  private static string Flag(bool value) => value ? "Removed" : "Added";

  private static readonly HashSet<string> Truthies = [
    "1",
    "t",
    "true",
    "yes",
    "on"
  ];
  private static bool IsTruthy(string value) => Truthies.Contains(value);
  private static readonly HashSet<string> Falsies = [
    "0",
    "f",
    "false",
    "no",
    "off"
  ];
  private static bool IsFalsy(string value) => Falsies.Contains(value);
  private static void Toggle(Terminal context, ConfigEntry<bool> setting, string name, string value, bool reverse = false)
  {
    if (value == "") setting.Value = !setting.Value;
    else if (IsTruthy(value)) setting.Value = true;
    else if (IsFalsy(value)) setting.Value = false;
    Helper.AddMessage(context, $"{name} {State(reverse ? !setting.Value : setting.Value)}.");
  }
  private static void ToggleFlag(Terminal context, ConfigEntry<string> setting, string name, string value)
  {
    if (value == "")
    {
      Helper.AddMessage(context, $"{name}: {setting.Value}.");
      return;
    }
    var list = ParseList(setting.Value);
    var newList = ParseList(value);
    foreach (var flag in newList)
    {
      var remove = list.Contains(flag);
      if (remove) list.Remove(flag);
      else list.Add(flag);
      setting.Value = string.Join(",", list);
      Helper.AddMessage(context, $"{name}: {Flag(remove)} {flag}.");
    }
  }
  private static void SetValue(Terminal context, ConfigEntry<string> setting, string name, string value)
  {
    if (value == "")
    {
      Helper.AddMessage(context, $"{name}: {setting.Value}.");
      return;
    }
    if (value.Contains("/"))
    {
      var values = value.Split('/');
      value = values[0];
      for (var i = 0; i < values.Length - 1; i++)
      {
        if (string.Equals(setting.Value?.ToString(), values[i], StringComparison.OrdinalIgnoreCase))
        {
          value = values[i + 1];
          break;
        }
      }
    }
    setting.Value = value;
    Helper.AddMessage(context, $"{name} set to {value}.");
  }
  private static void SetKey(Terminal context, ConfigEntry<KeyboardShortcut> setting, string name, string value)
  {
    if (value == "")
    {
      Helper.AddMessage(context, $"{name}: {setting.Value}.");
      return;
    }
    if (!Enum.TryParse<KeyCode>(value, true, out var keyCode))
      throw new InvalidOperationException("'" + value + "' is not a valid UnityEngine.KeyCode.");
    setting.Value = new(keyCode);
    Helper.AddMessage(context, $"{name} set to {value}.");
  }
  public static void UpdateValue(Terminal context, string key, string value)
  {
    if (key == "no_clip_view") Toggle(context, configNoClipView, key, value);
    if (key == "fly_up_key") SetValue(context, configFlyUpKeys, key, value);
    if (key == "fly_down_key") SetValue(context, configFlyDownKeys, key, value);
    if (key == "max_undo_steps") SetValue(context, configUndoLimit, key, value);
    if (key == "auto_exec_dev_on") SetValue(context, configAutoExecDevOn, key, value);
    if (key == "auto_exec_dev_off") SetValue(context, configAutoExecDevOff, key, value);
    if (key == "auto_exec_boot") SetValue(context, configAutoExecBoot, key, value);
    if (key == "auto_exec") SetValue(context, configAutoExec, key, value);
    if (key == "substitution") SetValue(context, configSubstitution, key, value);
    if (key == "wrapping") SetValue(context, configWrapping, key, value);
    if (key == "auto_tod") SetValue(context, configAutoTod, key, value);
    if (key == "auto_env") SetValue(context, configAutoEnv, key, value);
    if (key == "debug_fast_teleport") Toggle(context, configDebugModeFastTeleport, key, value);
    if (key == "improved_chat") Toggle(context, configImprovedChat, key, value);
    if (key == "access_private_chests") Toggle(context, configAccessPrivateChests, key, value);
    if (key == "access_warded_areas") Toggle(context, configAccessWardedAreas, key, value);
    if (key == "no_clip_clear_environment") Toggle(context, configNoClipClearEnvironment, key, value);
    if (key == "disable_messages") Toggle(context, configDisableMessages, "Command messages", value, true);
    if (key == "automatic_item_pick_up") Toggle(context, configAutomaticItemPickUp, "Automatic item pick up", value);
    if (key == "command_descriptions") Toggle(context, configCommandDescriptions, "Command descriptions", value);
    if (key == "map_coordinates") Toggle(context, configMapCoordinates, "Map coordinates", value);
    if (key == "minimap_coordinates") Toggle(context, configMiniMapCoordinates, "Minimap coordinates", value);
    if (key == "private_players") Toggle(context, configShowPrivatePlayers, "Private players", value);
    if (key == "auto_devcommands") Toggle(context, configAutoDevcommands, "Automatic devcommands", value);
    if (key == "auto_debugmode") Toggle(context, configAutoDebugMode, "Automatic debug mode", value);
    if (key == "auto_fly") Toggle(context, configAutoFly, "Automatic fly", value);
    if (key == "auto_nocost") Toggle(context, configAutoNoCost, "Automatic no cost", value);
    if (key == "auto_god") Toggle(context, configAutoGodMode, "Automatic god mode", value);
    if (key == "auto_ghost") Toggle(context, configAutoGhostMode, "Automatic ghost mode", value);
    if (key == "no_drops") Toggle(context, configNoDrops, "Creature drops", value, true);
    if (key == "aliasing") Toggle(context, configAliasing, "Command aliasing", value);
    if (key == "improved_autocomplete") Toggle(context, configImprovedAutoComplete, "Improved autocomplete", value);
    if (key == "disable_unlock_messages") Toggle(context, configDisableUnlockMessages, "Unlock messages", value, true);
    if (key == "disable_events") Toggle(context, configDisableEvents, "Random events", value, true);
    if (key == "multiple_commands") Toggle(context, configMultiCommand, "Multiple commands per line", value);
    if (key == "god_no_stamina") Toggle(context, configGodModeNoStamina, "Stamina usage with god mode", value, true);
    if (key == "god_no_eitr") Toggle(context, configGodModeNoEitr, "Eitr usage with god mode", value, true);
    if (key == "god_no_item") Toggle(context, configGodModeNoUsage, "Item usage with god mode", value, true);
    if (key == "god_no_weight_limit") Toggle(context, configGodModeNoWeightLimit, "Weight limit with god mode", value, true);
    if (key == "god_no_stagger") Toggle(context, configGodModeNoStagger, "Staggering with god mode", value, true);
    if (key == "hide_shout_pings") Toggle(context, configHideShoutPings, "Shout pings", value, true);
    if (key == "god_no_edge") Toggle(context, configGodModeNoEdgeOfWorld, "Edge of world pull with god mode", value, true);
    if (key == "god_no_knockback") Toggle(context, configGodModeNoKnockback, "Knockback with god mode", value, true);
    if (key == "god_no_mist") Toggle(context, configGodModeNoMist, "Mist with god mode", value, true);
    if (key == "fly_no_clip") Toggle(context, configFlyNoClip, "No clip with fly mode", value);
    if (key == "ghost_invibisility") Toggle(context, configGhostInvisibility, "Invisibility with ghost mode", value);
    if (key == "ghost_no_spawns") Toggle(context, configGhostNoSpawns, "Spawns with ghost", value, true);
    if (key == "ghost_ignore_sleep") Toggle(context, configGhostIgnoreSleep, "Sleeping checked with ghost", value, true);
    if (key == "disable_command") ToggleFlag(context, configDisabledCommands, "Disabled commands", value);
    if (key == "disable_global_key") ToggleFlag(context, configDisabledGlobalKeys, "Disabled global keys", value);
    if (key == "disable_debug_mode_keys") Toggle(context, configDisableDebugModeKeys, "Debug mode key bindings", value, true);
    if (key == "god_always_parry") Toggle(context, configGodModeAlwaysParry, "Always parry with god mode", value);
    if (key == "god_always_dodge") Toggle(context, configGodModeAlwaysDodge, "Always dodge with god mode", value);
    if (key == "disable_start_shout") Toggle(context, configDisableStartShout, "Start shout", value, true);
    if (key == "disable_no_map") Toggle(context, configDisableNoMap, "Disable no map", value);
    if (key == "chat_output") Toggle(context, configChatOutput, "Chat output", value);
    if (key == "playerlist_format") SetValue(context, configPlayerListFormat, key, value);
    if (key == "command_log_format") SetValue(context, configCommandLogFormat, key, value);
    if (key == "find_format") SetValue(context, configFindFormat, key, value);
    if (key == "minimap_format") SetValue(context, configMinimapFormat, key, value);
    if (key == "kill_destroys_spawners") Toggle(context, configKillDestroySpawners, "Kill commands destroy spawners", value);
    if (key == "free_fly_camera_invert") Toggle(context, configFreeFlyInvertCamera, "Free fly camera invert", value);
    if (key == "server_chat") Toggle(context, configServerChat, "Server chat", value);
    if (key == "server_chat_name") SetValue(context, configServerChatName, "Server chat name", value);
  }
}
