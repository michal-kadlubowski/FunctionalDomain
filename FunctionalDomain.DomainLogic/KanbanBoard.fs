namespace FunctionalDomain.DomainLogic

module public KanbanBoard =

  type Status = Todo | InProgress | Tests | Done

  type TaskType = Feature | Bug | Improvement

  type Epic = {
    Name : string
  }

  type UserStory = {
    Title: string
    Story: string
    Epic: Option<Epic>
  }
  
  type  Task = {
    Title: string
    Description: Option<string>
    Status: Status
    Type: TaskType
  }

  type Board = Task list

  