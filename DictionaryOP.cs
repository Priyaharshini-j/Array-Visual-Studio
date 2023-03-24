 // Dictionary

        namespace List
        {
            internal class DictionaryOP
            {
                static void list(string[] args)
                {
                    var Dict = new Dictionary<String, int>();
                    Dict.Add("Red", 2);
                    Dict.Add("Blue", 98);
                    Dict.Add("Green", 34);
                    Dict.Add("Pink", 6);

                    foreach(KeyValuePair<string,int> i in Dict)
                    {
                        Console.WriteLine($"The Key is {i.Key} and the value is {i.Value}\n");
                    }

                    //Remove Function
                    Dict.Remove("Red");
                    foreach (KeyValuePair<string, int> i in Dict)
                    {
                        Console.WriteLine($"The Key is {i.Key} and the value is {i.Value}");
                    }


                    // We are changing the value of dictionary
                    foreach(KeyValuePair<string ,int> i in Dict)
                    {
                        if (i.Key.Equals("Pink"))
                        {
                            Dict[i.Key]= i.Value + 4;

                        }
                    }

                    foreach (KeyValuePair<string, int> i in Dict)
                    {
                        Console.WriteLine($"The Key is {i.Key} and the value is {i.Value}");
                    }

            }
        }
}




