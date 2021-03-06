﻿namespace TDDDay2HomeWork
{
    public class Book
    {
		#region Properties 
        public string Author { get; private set; }

        public int Dollar { get; private set; }

        public string Name { get; private set; }

        public string Series { get; private set; }

        public int Volume { get; private set; }
		#endregion Properties 

		#region Constructors 
        public Book(string name, string series, int volume, string author, int dollar)
        {
            this.Name = name;
            this.Series = series;
            this.Volume = volume;
            this.Author = author;
            this.Dollar = dollar;
        }
		#endregion Constructors 
    }
}