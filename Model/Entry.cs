using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace MoviesList.Model
{
	public class Entry
	{
		public required string Title;
		public string? TitleExt;
		public string? TitleAlt;

		public string? Comment;

		public string? Date;

		public string? Fsk;

		public string? Imdb;
		[YamlMember(Alias ="anidb")]
		public string? AniDB;

		public bool? Homebrewn;
		public bool? Series;
		public int? Number;

		public int? NumDvds;
		public string? DateDvd;

		public int? NumBlurays;
		public int? NumUHDBlurays;
		public string? DateBluray;

		public Entry[]? Box;


	}
}
