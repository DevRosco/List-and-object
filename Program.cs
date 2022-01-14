

string fewWords = "Number One, One, 1, First, Number Two, Two, 2, Second";

string[] brokenWords = fewWords.Split(',');

//add commnet to this on githhub
List<TestList> listOfWords = new List<TestList>();

for (int i = 0; i < brokenWords.Length; i = i + 4)
{
 
    TestList word = new TestList();

    word.One = brokenWords[i];
    word.Two = brokenWords[i +1];
    word.Three = Convert.ToInt32(brokenWords[i + 2]);
    word.Four = brokenWords[i + 3];
    listOfWords.Add(word);
}

foreach (var v in listOfWords)
{
    Console.WriteLine(v.Display());
}

public class TestList
{

   public string One { get; set; }
   public string Two { get; set; }
   public int Three { get; set; }
   public string Four { get; set; }

    public string Display()
    {
        return String.Format("return this {0}, - {1} - {2} - {3}", this.One, this.Two, this.Three, this.Four);
    }

}
