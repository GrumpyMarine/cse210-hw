using System;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach (Entry newEntry in entries)
        {
            Console.WriteLine(newEntry);
        }

    }
    public void SaveFile(string fileName)
    {
        using (StreamWriter write = new StreamWriter(fileName))
        {
            foreach (Entry newEntry in entries)
            {
                write.WriteLine(newEntry.ToString());
                write.WriteLine();
            }
        }
    }
    public void LoadFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                string currentEntry = "";
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        currentEntry += line + "\n";
                    else if (!string.IsNullOrWhiteSpace(currentEntry))
                    {
                        string[] entryLines = currentEntry.Trim().Split("\n");
                        if (entryLines.Length == 3)
                        {
                            DateTime date = DateTime.Parse(entryLines[0].Split(": ")[1]);
                            string prompt = entryLines[1].Split(": ")[1];
                            string response = entryLines[2].Split(": ")[1];
                            entries.Add(new Entry(prompt, response) { Date = date });
                        }
                        currentEntry = "";
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"Sorry, file {fileName} does not exist. ");
        }


    }

}
