using System;
using Xunit;

public class Account
{
    //https://gist.github.com/nirlanka/ed10b8cc9806bc192625a33837ba4a3b

    [Flags]
    public enum Access
    {
        Delete = 1,
        Publish = 2,
        Submit = 4,
        Comment = 8,
        Modify = 16,
        Writer = Submit | Modify,
        Editor = Delete | Publish | Comment,
        Owner = Writer | Editor
    }

    public static void Main(string[] args)
    {
        Assert.Equal(Access.Writer.HasFlag(Access.Delete),false);

        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
        Console.WriteLine(Access.Editor.HasFlag(Access.Delete) && Access.Writer.HasFlag(Access.Publish)); //Should print: "False"
        Console.WriteLine(Access.Owner.HasFlag(Access.Writer) && Access.Owner.HasFlag(Access.Editor)); //Should print: "False"
    }
}