namespace Zbra.Domain.Models
{
    public class Address
    {
        public string Path { get; private set; }

        public Address(string path)
        {
            Path = !string.IsNullOrEmpty(path) ? path : throw new ArgumentException("Path não pode ser nulo ou vazio");
        }

        public int GetValueAddress(string path)
        {
            var commands = new List<string>();

            using (var sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    commands.Add(line);
                }
            }

            return ReadCommand(commands);
        }

        private int ReadCommand(List<string> commands)
        {
            var address = 0;
            var currentIndex = 0;

            while (currentIndex < commands.Count)
            {
                string currentCommand = commands[currentIndex];

                if (currentCommand.Substring(0, 2) == "20")
                {
                    var value = int.Parse(currentCommand.Substring(2, currentCommand.Length - 2));
                    address += value;
                    currentIndex++;
                }
                else if (currentCommand.Substring(0, 1) == "5")
                {
                    var jumpTo = int.Parse(currentCommand.Substring(1, currentCommand.Length - 1));
                    currentIndex += jumpTo;
                }
                else
                {
                    currentIndex++;
                }
            }

            return address;
        }
    }
}
