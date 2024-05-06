using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace MoviesList.Model
{
	public class ListFile
	{
		public required string Title;
		public required string Owner;
		public required string Type;
		public required string Version;
		public required Entry[] Collection;

		static public ListFile Load(string path)
		{
			const string yamlFileType = @"SGR.Collection.Yaml";

			using (StreamReader input = new(path))
			{
				var yamlDeserializer = new DeserializerBuilder()
					.WithNamingConvention(DirectCamelCase.Instance)
					.Build();

				var list = yamlDeserializer.Deserialize<ListFile>(input);

				if (!list.Type.Equals(yamlFileType)) throw new Exception($"Yaml file must be of type '{yamlFileType}'");
				if (new Version(list.Version) != new Version(1, 2)) throw new Exception("Yaml file must be of version '1.2'");

				return list;
			}
		}

		internal void Save(string path)
		{
			using (StreamWriter output = new(path, append: false, encoding: new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)))
			{
				var yamlSerializer = new SerializerBuilder()
					.WithNamingConvention(DirectCamelCase.Instance)
					.ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
					.Build();
				yamlSerializer.Serialize(output, this);
			}
		}
	}
}
