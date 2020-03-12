using System.Collections.Generic;
namespace ToDo
{
    public class ToDoList{
        public List<ToDoItem> items {get;}

        public ToDoList(){
            this.items = new List<ToDoItem>();
        }
        
        public ToDoList addItem(ToDoItem item){
            this.items.Add(item);
            return this;
        }

        public ToDoList markDoneItem(ToDoItem item){
           ToDoItem searchedItem = this.items.Find(i => i.Equals(item));
           searchedItem.MarkDone();
           return this;
        }
    }
}