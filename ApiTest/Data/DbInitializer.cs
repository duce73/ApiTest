using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Models;

namespace ApiTest.Data
{
    //初始化数据库
    public static class DbInitializer
    {
        public static void Initializer(TodoContext context)
        {
            //自动创建数据库
            context.Database.EnsureCreated();

            if (context.TodoItems.Any())
            {
                return;
            }
            var todoItems = new TodoItem[]
            {
                new TodoItem{Name = "duce", IsComplete = true },
                new TodoItem{Name  = "test", IsComplete = false},
                new TodoItem{Name = "helu", IsComplete = true},
            };
            foreach(TodoItem todoItem in todoItems)
            {
                context.TodoItems.Add(todoItem);
            }
            context.SaveChanges();
        }
    }
}
