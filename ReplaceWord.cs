using System;
class ReplaceWord{
    //method to replace word from a string
    public static string ReplaceWordInString(string str,string word,string wordToReplace){
        if (str.Trim().Length == 0) return ""; //to handle empty string

        int i = 0;
        int strLength = str.Length;
        string currentWord = "";
        string[] words = new string[50]; //assuming a maximum of 50 words
        int wordCount = 0;

        while(i < strLength){
            //if the character is not a space, add it to the current word
            if(str[i] != ' ') currentWord += str[i];
            else{
                //if we encounter a space and the current word is not empty, save it
                if(currentWord.Length > 0){
                    words[wordCount++] = currentWord;
                    currentWord = ""; //reset the current word
                }
            }
            i++;
        }

        //if the last word is not followed by a space, add it
        if (currentWord.Length > 0) words[wordCount++] = currentWord;

        //find the word and replace it with another word
        string result="";
        for(int j = 0; j < wordCount; j++){
            if(words[j]==word) result+=wordToReplace +" ";
            else result+=words[j]+" ";
        }
        return result;
    }

	//Main method
    static void Main(string[] args){
        //taking string as input from user
        Console.Write("Enter a string: ");
        string st = Console.ReadLine();

        Console.Write("Enter a word to remove it from text: ");
        string word = Console.ReadLine();

        Console.Write("Enter a word to add in place of removed word in the text: ");
        string replacingWord = Console.ReadLine();

		//printing the output using 'ReplaceWordInString' method
        Console.WriteLine("String after replacing \"{0}\" with \"{1}\" is : {2}",word,replacingWord,ReplaceWordInString(st,word,replacingWord));
    }
}