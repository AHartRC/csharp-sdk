using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Client
{
	///// <summary>
	/////     SingleOrArrayConverter enables typed JSON deserialization of List generics
	/////     when the API response may be an array of single object.
	///// </summary>
	//public class SingleOrArrayConverter<T> : JsonConverter<T>
	//{
	//	//public override bool CanWrite => false;

	//	public override bool CanConvert(Type objectType)
	//	{
	//		return objectType == typeof(List<T>);
	//	}

	//	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	//	{
	//		if(reader.TokenType == JsonTokenType.StartArray)
	//			return reader.Read()
	//		throw new NotImplementedException();
	//	}

	//	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	//	{
	//		throw new NotImplementedException();
	//	}

	//	//public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
	//	//	JsonSerializer serializer)
	//	//{
	//	//	JToken token = JToken.Load(reader);
	//	//	if (token.Type == JTokenType.Array) return token.ToObject<List<T>>();
	//	//	return new List<T> {token.ToObject<T>()};
	//	//}

	//	//public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	//	//{
	//	//	throw new NotImplementedException();
	//	//}
	//}
}