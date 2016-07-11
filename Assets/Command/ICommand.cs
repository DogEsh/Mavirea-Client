using Mavirea.Command;
using System;

namespace Mavirea.Command
{
    using ParameterID = Byte;
    /**
    <summary>
    Команда исполняющая сценарную операцию.
    </summary>
    */
    public interface ICommand
    {
        bool Do(IInterlocutorsContainer interlocators);
    }
}
