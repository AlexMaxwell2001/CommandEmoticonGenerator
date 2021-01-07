using System;
using System.Collections.Generic;
public class User
{
    private Stack<Command> undo;
    private Stack<Command> redo;
    public int UndoCount { get => undo.Count; }
    public int RedoCount { get => undo.Count; }
    public User()
    {
        Reset();
    }
    public void Reset()
    {
        undo = new Stack<Command>();
        redo = new Stack<Command>();
    }

    public void Action(Command command,string tell)
    {
        undo.Push(command);  // save the command to the undo command
        redo.Clear();        // once a new command is issued, the redo stack clears
        if(tell==null) {
            Console.WriteLine("Command Received: Add new Feature to the face!" + Environment.NewLine);
            command.Do();
        }
       
    } 
    public void Undo()
    {
        if (undo.Count > 0)
        {
            Command c = undo.Pop(); c.Undo(); redo.Push(c);
            Console.WriteLine("Undoing operation!"); Console.WriteLine();
        }else{
            Console.WriteLine("There isn't anything to undo!"); Console.WriteLine();
        }
    }
     public void Redo()
    {
       
        if (redo.Count > 0)
        {
            Console.WriteLine("Redoing operation!"); Console.WriteLine();
            Command c = redo.Pop(); c.Do(); undo.Push(c);
        }else{
            Console.WriteLine("There isn't any operation to redo!");
        }
    }
}