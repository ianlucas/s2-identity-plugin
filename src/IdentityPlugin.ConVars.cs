/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared.Convars;

namespace IdentityPlugin;

public partial class IdentityPlugin
{
    public readonly IConVar<string> Url = core.ConVar.Create(
        "identity_url",
        "URL endpoint for fetching player identity data.",
        ""
    );
    public readonly IConVar<bool> IsStrict = core.ConVar.Create(
        "identity_strict",
        "Kick players when their identity data cannot be retrieved.",
        true
    );
    public readonly IConVar<bool> IsForceNickname = core.ConVar.Create(
        "identity_force_nickname",
        "Override player nicknames with their identity nickname.",
        true
    );
    public readonly IConVar<bool> IsForceRating = core.ConVar.Create(
        "identity_force_rating",
        "Override player ratings with their identity rating.",
        true
    );
}
