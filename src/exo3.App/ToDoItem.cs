using System;

namespace ToDo
{
    public class ToDoItem{
        string description {get;}
        DateTime date {get;}

        bool isDione {get;set;}

        public ToDoItem(string description, DateTime date, bool isDione){
            this.description = description;
            this.date = date;
            this.isDione = isDione;
        }

        public ToDoItem(string description) {
            this.description = description;
        }

        public ToDoItem MarkDone(){
            this.isDione = true;
            return this;
        }
    }
}