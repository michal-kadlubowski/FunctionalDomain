public class TaskDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    
    public TaskDto(FunctionalDomain.DomainLogic.KanbanBoard.Task task)
    {
        Title = task.Title;
        Description = Microsoft.FSharp.Core.OptionModule.ToObj(task.Description);
    }
}