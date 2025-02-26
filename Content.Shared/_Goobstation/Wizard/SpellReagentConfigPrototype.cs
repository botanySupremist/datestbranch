using Content.Shared.FixedPoint;
using Robust.Shared.Prototypes;

namespace Content.Shared._Goobstation.Wizard;

[DataDefinition]
[Prototype("spellReagentConfiguration")]

public sealed partial class SpellReagentConfigPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } // I don't know what this does, but it doesn't work without it.

    [DataField(required: true)]
    public Dictionary<string, FixedPoint2> Reagents = new();
}
