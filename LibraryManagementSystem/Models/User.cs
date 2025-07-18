using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Абстрактный пользователь системы.
    /// Имеет уникальный идентификатор, имя и роль.
    /// Наследуется в Reader и Librarian.
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Уникальный идентификатор пользователя.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Роль пользователя (например, Reader или Librarian).
        /// </summary>
        public string Role { get; protected set; }

        /// <summary>
        /// Создаёт нового пользователя с уникальным идентификатором.
        /// </summary>
        protected User(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        /// <summary>
        /// Абстрактный метод, выводящий информацию о правах пользователя.
        /// Должен быть реализован в наследниках.
        /// </summary>
        public abstract void ShowPermissions();
    }
}
