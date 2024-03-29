﻿using MyTodo.Domain.InputModels;
using MyTodo.Domain.Models;

namespace MyTodo.Domain.Storages
{
    public interface ITodoListItemStorage
    {
        Task<TodoListItemModel?> GetByIdAsync(int id);
        Task<IEnumerable<TodoListItemModel>> SearchByTodoListIdAsync(int toDoListId);
        Task InsertAsync(CreateListItemInputModel inputModel);
        Task<bool> UpdateAsync(UpdateListItemInputModel inputModel);
        Task<bool> DeleteByIdAsync(int id);
    }
}
