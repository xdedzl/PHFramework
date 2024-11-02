using System;

namespace PHFramework.Tasks
{
    public interface ITask
    {
        bool IsDone { get;}
        ITask Next { get; set; }

        void Update();
    }
}