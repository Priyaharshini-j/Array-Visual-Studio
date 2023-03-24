
        namespace List
        {
            internal class SortedDictionaryOP
            {
                static void Main(string[] args)
                {
                  SortedDictionary<int, string> sor = new SortedDictionary<int, string>();
                  sor.Add(3, "Three");
                  sor.Add(4, "four"); 
                  sor.Add(1, "One");
                  sor.Add(2, "Two");

                  // Printing the SOrted Dictionar
                  foreach(KeyValuePair<int , string> kvp in sor) {
                      Console.WriteLine($" This is the Key {kvp.Key} and this is value {kvp.Value}");
                  }


                  //OrderBY
                  foreach( var i in sor.OrderBy(x => x.Key) )
                  {
                      Console.WriteLine($" This is the Key {i.Key} and this is value {i.Value}");
                  }

                  //ContainsKey
                  if (sor.ContainsKey(4))
                  {
                      sor.Remove(4);
                      sor.Add(5, "Replaced");
                  }
                  foreach (var i in sor.OrderBy(x => x.Key))
                  {
                      Console.WriteLine($" This is the Key {i.Key} and this is value {i.Value}");
                  }
                  // Defaultvalue set up
                  Console.WriteLine(sor.GetValueOrDefault(7, "Error"));
                  }
                  }
                  }
        
