using Order.Application.TodoLists.Queries.ExportTodos;

namespace Order.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
