using DragAndDropMacroCreator.Models.Enum;

namespace DragAndDropMacroCreator.Models;

public class TimelineItem
{
    public TimelineItemAction Action { get; set; } = TimelineItemAction.ERROR;

    public string ActionInformation { get; set; } = string.Empty;

    public string ActionAdditionalInformation { get; set; } = string.Empty;

}
