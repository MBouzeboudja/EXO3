using System.Collections.Generic;
using ToDo;
namespace ToDo
{
    public class ToDoList{
        List<ToDo> items {get;}

        public ToDoList(){
            this.items = new List<ToDo>();
        }
        public ToDoList addItem(ToDo item){
            this.items.Add(item);
            return this;
        }

        public ToDoList markDoneItem(ToDo item){
           ToDo searchedItem = this.items.Find(i => i.Equals(item));
           searchedItem.MarkDone();
           return this;
        }
    }
}