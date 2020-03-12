namespace ToDo
{
    public interface IToDoService{

        ToDoList toDoList{get;}
        ToDoList addTodoItem(ToDoItem item);

        ToDoList removeToDoItem(ToDoItem item);

        ToDoList markToDoItemDone(ToDoItem item);
    }

    public interface IToDoListPersistanceService{
        ToDoList GetToDoList();
    }

    public class ToDoListService : IToDoService
    {

        public ToDoList toDoList {get;}

        public ToDoListService(ToDoList toDoList){
            this.toDoList = toDoList;
        }

        public ToDoList addTodoItem(ToDoItem item)
        {
            this.toDoList.addItem(item);
            return this.toDoList;
        }

        public ToDoList markToDoItemDone(ToDoItem item)
        {
          return this.toDoList.markDoneItem(item);    
        }

        public ToDoList removeToDoItem(ToDoItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}