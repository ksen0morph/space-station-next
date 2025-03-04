using Content.Shared.CartridgeLoader.Cartridges;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CorvaxNext.CartridgeLoader.Cartridges;

[GenerateTypedNameReferences]
public sealed partial class SecWatchUiFragment : BoxContainer
{
    public SecWatchUiFragment()
    {
        RobustXamlLoader.Load(this);
    }

    public void UpdateState(SecWatchUiState state)
    {
        NoEntries.Visible = state.Entries.Count == 0;
        Entries.RemoveAllChildren();
        foreach (var entry in state.Entries)
        {
            Entries.AddChild(new SecWatchEntryControl(entry));
        }
    }
}