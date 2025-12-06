/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Convars;
using SwiftlyS2.Shared.GameEventDefinitions;
using SwiftlyS2.Shared.Plugins;

namespace IdentityPlugin;

[PluginMetadata(
    Id = "IdentityPlugin",
    Version = "1.0.0",
    Name = "IdentityPlugin",
    Author = "Ian Lucas",
    Description = "Authenticates external users."
)]
public partial class IdentityPlugin(ISwiftlyCore core) : BasePlugin(core)
{
    public override void Load(bool hotReload)
    {
        Core.Event.OnTick += OnTick;
        Core.Event.OnClientSteamAuthorize += OnClientSteamAuthorize;
        Core.GameEvent.HookPre<EventPlayerDisconnect>(OnPlayerDisconnect);
    }

    public override void Unload() { }
}
