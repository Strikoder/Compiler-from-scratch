﻿// See https://aka.ms/new-console-template for more information

namespace sharpiler
{
   class Program
   {
	   static void Main(string [] args)
	   {
		   while(true)
		   {
			   Console.Write("> ");
			   var line = Console.ReadLine();
			   if (string.IsNullOrWhiteSpace(line))
				   return;
			   if (line == "1+2+3")
				   Console.WriteLine("7");
			   else
			       Console.WriteLine("Error: Invalid Expression");
		   }
	   }

	   enum SynatxKind
	   {

	   }

	   class SyntaxToken
	   {
		   public SyntaxToken(SyntaxKind kind, int position, string text)
		   {
			   Kind=kind;
			   Position=position;
			   Text=text;
		   }

		   public SyntaxKind Kind {get;}
		   public int Position {get;}
		   public string Text {get;}
	   }

	   class Lexer
	   {
		   private readonly string _text;
		   private int _position;

		   public Lexer(string text)
		   {
			   _text=text;
		   }

		   public SyntaxToken NextToken()
		   {
			   //numbers

		   }

		   
	   }
       
   } 
}
