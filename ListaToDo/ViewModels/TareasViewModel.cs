using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ListaToDo.Helpers;
using ListaToDo.Models;

namespace TodoList.ViewModels
{
    public class TareasViewModel
    {
        public TareasViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new Tareas();
                this.TodoItems = db.Query<Tareas>("SELECT * FROM ToDoListItem ORDER BY Fecha ASC").ToList();
            }
        }

        public List<Tareas> TodoItems { get; set; }

        public Tareas EditableItem { get; set; }
    }
}