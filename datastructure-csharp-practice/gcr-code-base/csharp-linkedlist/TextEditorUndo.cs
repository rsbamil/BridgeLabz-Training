using System;

// Each node stores one state of text
class TextNode
{
    public string Content;
    public TextNode Prev;
    public TextNode Next;

    public TextNode(string text)
    {
        Content = text;
        Prev = Next = null;
    }
}

// Text editor using doubly linked list
class TextEditor
{
    private TextNode current = null;

    // Add new text state
    public void AddText(string text)
    {
        TextNode node = new TextNode(text);

        // If editor already has text
        if (current != null)
        {
            current.Next = node;
            node.Prev = current;
        }

        current = node;
    }

    // Undo operation (go to previous state)
    public void Undo()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
    }

    // Redo operation (go to next state)
    public void Redo()
    {
        if (current != null && current.Next != null)
            current = current.Next;
    }

    // Display current text
    public void ShowText()
    {
        Console.WriteLine("Current Text: " + current.Content);
    }
}

// Main class
class TextEditorUndo
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddText("Hello");
        editor.AddText("Hello World");
        editor.AddText("Hello World!");

        editor.ShowText();

        editor.Undo();
        editor.ShowText();

        editor.Redo();
        editor.ShowText();
    }
}