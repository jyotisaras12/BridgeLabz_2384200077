using System;
class LongestWordInString{
    //method to find the longest word in a string
    public static string FindLongestWord(string str){
        //checking if the string is empty or consists only of spaces
        if (str == null || str.Trim().Length == 0) return "";

        string longestWord = "";  //to store the longest word
        string currentWord = "";  //to store the current word being formed
        int strLength = str.Length;  //length of the input string

        //Iterating through the string character by character
        for (int i = 0; i < strLength; i++){
            char currentChar = str[i];
            if (currentChar != ' ')  //if the character is not a space, add it to the current word
				currentWord += currentChar;
            else{
                //if we encounter a space
                if (currentWord.Length > longestWord.Length){
                    longestWord = currentWord;  //updating the longest word
                }
                currentWord = "";  //reset current word
            }
        }

        //after the loop ends, we need to check the last word
        if(currentWord.Length > longestWord.Length) longestWord = currentWord;
        return longestWord;
    }

    //Main method
    static void Main(string[] args){
        //taking a sentence as input from the user
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        //finding and print the longest word in the sentence using 'FindLongestWord' method
        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("The longest word is: " + longestWord);
    }
}
