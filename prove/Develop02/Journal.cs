using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

public class Journal
{
    // Declare a list of Entries, the needed attribute
    public List<Entry> _journal = new List <Entry> ();

    // Add a new Entry to the _journal list of entries
    public void AddingEntry(Entry entry)
    {
        // Add entry1 to myJournal
        _journal.Add(entry);
    }

    // Display all the enrties one by one 
    public void DisplayAllEntries()
    {
        foreach (Entry element in _journal)
        {
            element.Display();
        }
    }

    // Save all entries into a file
    public void SaveFile(string fileName)
    {
        Console.WriteLine("Wait while the entries are being save to a file...");
        Console.WriteLine();

        // using function will close the file automaticly right after I end using it
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _journal)
            {
                // ~~ This is the choosen carachter to separate values in CSV format
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entry}");  
            }
        
        }
    }

    // Upload all entries from a file
    public void Load(string fileName)
    {
        // Read the entire file into an array of strings (one per line)
        string [] lines = System.IO.File.ReadAllLines("journalPersonal.txt");

        // Loop to split every line in their 3 parts
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Entry entry = new Entry();  // Create a new entry object per line
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            // Adding entry objects to _journal (List of entry objects)
            AddingEntry(entry);
        }
    }

}