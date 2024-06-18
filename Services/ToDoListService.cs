using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataModel;

namespace ToDoList.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem { Description = "Zrób prezentacje na studia" },
            new ToDoItem { Description = "Kup mleko, mąke" },
            new ToDoItem { Description = "Naucz się na egzamin" },
        };
    }
}
