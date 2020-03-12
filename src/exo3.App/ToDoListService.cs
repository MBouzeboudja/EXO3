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

    public class ToDoService : IToDoService
    {

        public ToDoList toDoList {get;}

        public ToDoService(ToDoList toDoList){
            this.toDoList = toDoList;
        }

        public ToDoList addTodoItem(ToDo item)
        {
            this.toDoList.addItem(item);
            return this.toDoList;
        }

        public ToDoList markToDoItemDone(ToDo item)
        {
           ToDo item = this.toDoList.item
        }

        public ToDoList removeToDoItem(ToDo item)
        {
            throw new System.NotImplementedException();
        }
    }
}