using Robust.Shared.Prototypes;

namespace Content.Shared._Goobstation.Wizard;

public sealed partial class SpellReagentComponent : Component
{
    [DataField(required: true)]
    public ProtoId<SpellReagentConfigPrototype> Configuration;
}
