using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace MoviesList.Model
{
	internal class DirectCamelCase : INamingConvention
	{
		internal static readonly DirectCamelCase Instance = new DirectCamelCase();

		public string Apply(string value)
		{
			return char.ToLower(value[0]) + value[1..];
		}

		public string Reverse(string value)
		{
			throw new NotImplementedException();
		}
	}
}
