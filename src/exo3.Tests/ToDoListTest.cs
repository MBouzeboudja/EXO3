using System;
using Xunit;
using ToDo;

namespace exo3.Tests
{
    public class ToDoListTest{

        [Fact]
        public void should_mark_done_item(){
            var toDoList = new ToDoList();
            var toDoItem = new ToDoItem("name1", DateTime.Now, false);
            toDoList.addItem(toDoItem);
            toDoList.markDoneItem(toDoItem);
            ///Assert.True(toDoList.items[))
        }

    }
}
