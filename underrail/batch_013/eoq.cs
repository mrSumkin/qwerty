using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

// Token: 0x020000DD RID: 221
public static class eoq
{
	// Token: 0x060004CA RID: 1226 RVA: 0x00015B04 File Offset: 0x00013D04
	public static string SerializeToXml<T>(T obj, Type[] extraTypes = null)
	{
		czh.a(obj, "obj");
		MemoryStream memoryStream = null;
		string result;
		try
		{
			memoryStream = new MemoryStream();
			new XmlSerializer(typeof(T), extraTypes).Serialize(memoryStream, obj);
			memoryStream.Position = 0L;
			result = new StreamReader(memoryStream).ReadToEnd();
		}
		finally
		{
			if (memoryStream != null)
			{
				memoryStream.Dispose();
			}
		}
		return result;
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00015B7C File Offset: 0x00013D7C
	public static T DeserializeFromXml<T>(string xml, Type[] extraTypes = null)
	{
		czh.a(xml, "xml");
		MemoryStream memoryStream = null;
		StreamWriter streamWriter = null;
		T result;
		try
		{
			memoryStream = new MemoryStream();
			streamWriter = new StreamWriter(memoryStream);
			streamWriter.Write(xml);
			streamWriter.Flush();
			memoryStream.Position = 0L;
			result = (T)((object)new XmlSerializer(typeof(T), extraTypes).Deserialize(memoryStream));
		}
		finally
		{
			if (streamWriter != null)
			{
				streamWriter.Dispose();
			}
			else if (memoryStream != null)
			{
				memoryStream.Dispose();
			}
		}
		return result;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00015C0C File Offset: 0x00013E0C
	public static void SerializeToXmlFile<T>(string filePath, T obj, Type[] extraTypes = null)
	{
		czh.a(filePath, "filePath");
		czh.a(obj, "obj");
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			new XmlSerializer(typeof(T), extraTypes).Serialize(memoryStream, obj);
			File.WriteAllBytes(filePath, memoryStream.ToArray());
		}
		finally
		{
			if (memoryStream != null)
			{
				memoryStream.Close();
			}
		}
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00015C84 File Offset: 0x00013E84
	public static T DeserializeFromXmlFile<T>(string filePath, Type[] extraTypes = null)
	{
		czh.a(filePath, "filePath");
		FileStream fileStream = null;
		T result;
		try
		{
			fileStream = File.OpenRead(filePath);
			result = (T)((object)new XmlSerializer(typeof(T), extraTypes).Deserialize(fileStream));
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return result;
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00015CE4 File Offset: 0x00013EE4
	public static Stream SerializeToBinary<T>(T obj, SerializationBinder binder = null, Stream targetStream = null, long currentDataModelVersion = 0L, bool embedDataModelVersion = false, bool resetStreamPositionAtTheEnd = true)
	{
		czh.a(obj, "obj");
		Stream stream;
		if (targetStream == null)
		{
			stream = new MemoryStream();
		}
		else
		{
			stream = targetStream;
		}
		if (embedDataModelVersion)
		{
			eoq.a(stream, currentDataModelVersion);
		}
		eoq.a(stream, obj, binder, currentDataModelVersion);
		if (resetStreamPositionAtTheEnd)
		{
			stream.Position = 0L;
		}
		return stream;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00015D40 File Offset: 0x00013F40
	public static Stream a(object A_0, SerializationBinder A_1 = null, Stream A_2 = null)
	{
		return eoq.SerializeToBinary<object>(A_0, A_1, A_2, 0L, false, true);
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00015D50 File Offset: 0x00013F50
	public static T DeserializeFromBinary<T>(Stream stream, SerializationBinder binder = null, bool tryToRetrieveDataModelVersion = false, bool resetStreamPositionFirst = true)
	{
		czh.a(stream, "stream");
		if (resetStreamPositionFirst)
		{
			stream.Position = 0L;
		}
		long dataModelVersion = 0L;
		if (tryToRetrieveDataModelVersion)
		{
			dataModelVersion = eoq.a(stream);
		}
		return eoq.DeserializeFromBinaryInternal<T>(stream, binder, dataModelVersion);
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00015D90 File Offset: 0x00013F90
	public static void SerializeToBinaryFile<T>(string filePath, T obj, SerializationBinder binder = null, long currentDataModelVersion = 0L, bool embedDataModelVersion = false)
	{
		czh.a(filePath, "filePath");
		czh.a(obj, "obj");
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			eoq.SerializeToBinary<T>(obj, binder, memoryStream, currentDataModelVersion, embedDataModelVersion, true);
			File.WriteAllBytes(filePath, memoryStream.ToArray());
		}
		finally
		{
			if (memoryStream != null)
			{
				memoryStream.Close();
			}
		}
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00015DFC File Offset: 0x00013FFC
	public static T DeserializeFromBinaryFile<T>(string filePath, SerializationBinder binder = null, bool tryToRetrieveDataModelVersion = false)
	{
		czh.a(filePath, "filePath");
		FileStream fileStream = null;
		T result;
		try
		{
			fileStream = File.OpenRead(filePath);
			result = eoq.DeserializeFromBinary<T>(fileStream, binder, tryToRetrieveDataModelVersion, true);
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return result;
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00015E4C File Offset: 0x0001404C
	public static Stream SerializeToBinaryCompressed<T>(T obj, SerializationBinder binder = null, Stream targetStream = null, long currentDataModelVersion = 0L, bool embedDataModelVersion = false)
	{
		czh.a(obj, "obj");
		Stream stream;
		if (targetStream == null)
		{
			stream = new MemoryStream();
		}
		else
		{
			stream = targetStream;
		}
		if (embedDataModelVersion)
		{
			eoq.a(stream, currentDataModelVersion);
		}
		GZipStream gzipStream = new GZipStream(stream, 1);
		eoq.a(gzipStream, obj, binder, currentDataModelVersion);
		gzipStream.Flush();
		gzipStream.Close();
		return stream;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00015EAC File Offset: 0x000140AC
	public static T DeserializeFromBinaryCompressed<T>(Stream stream, SerializationBinder binder = null, bool tryToRetrieveDataModelVersion = false)
	{
		czh.a(stream, "stream");
		long dataModelVersion = 0L;
		if (tryToRetrieveDataModelVersion)
		{
			dataModelVersion = eoq.a(stream);
		}
		GZipStream gzipStream = new GZipStream(stream, 0);
		byte[] array = null;
		byte[] array2 = null;
		MemoryStream memoryStream = null;
		T result;
		try
		{
			array = dh4.a();
			memoryStream = new MemoryStream(array);
			array2 = dh4.c(4096L);
			int num = 0;
			int num2;
			while ((num2 = gzipStream.Read(array2, 0, array2.Length)) != 0)
			{
				num += num2;
				memoryStream.Write(array2, 0, num2);
			}
			memoryStream.Position = 0L;
			result = eoq.DeserializeFromBinaryInternal<T>(memoryStream, binder, dataModelVersion);
		}
		finally
		{
			if (gzipStream != null)
			{
				gzipStream.Close();
			}
			if (memoryStream != null)
			{
				memoryStream.Close();
			}
			if (array != null)
			{
				dh4.a(array);
			}
			if (array2 != null)
			{
				dh4.a(array2);
			}
		}
		return result;
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00015F88 File Offset: 0x00014188
	public static void SerializeToBinaryFileCompressed<T>(string filePath, T obj, SerializationBinder binder = null, long currentDataModelVersion = 0L, bool embedDataModelVersion = false)
	{
		czh.a(filePath, "filePath");
		czh.a(obj, "obj");
		FileStream fileStream = null;
		try
		{
			fileStream = File.Create(filePath, 16384);
			if (embedDataModelVersion)
			{
				eoq.a(fileStream, currentDataModelVersion);
			}
			GZipStream gzipStream = new GZipStream(fileStream, 1);
			eoq.a(gzipStream, obj, binder, currentDataModelVersion);
			gzipStream.Flush();
			gzipStream.Close();
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
		}
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00016010 File Offset: 0x00014210
	public static T DeserializeFromBinaryFileCompressed<T>(string filePath, SerializationBinder binder = null, bool tryToRetrieveDataModelVersion = false)
	{
		czh.a(filePath, "filePath");
		FileStream fileStream = null;
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		byte[] array = null;
		byte[] array2 = null;
		T result;
		try
		{
			fileStream = File.OpenRead(filePath);
			long dataModelVersion = 0L;
			if (tryToRetrieveDataModelVersion)
			{
				dataModelVersion = eoq.a(fileStream);
			}
			array = dh4.c(fileStream.Length);
			memoryStream = new MemoryStream(array);
			fileStream.CopyTo(memoryStream);
			memoryStream.Position = 0L;
			GZipStream gzipStream = new GZipStream(memoryStream, 0);
			array2 = dh4.c(fileStream.Length);
			memoryStream2 = new MemoryStream();
			byte[] array3 = new byte[4096];
			int count;
			while ((count = gzipStream.Read(array3, 0, array3.Length)) != 0)
			{
				memoryStream2.Write(array3, 0, count);
			}
			memoryStream2.Position = 0L;
			result = eoq.DeserializeFromBinaryInternal<T>(memoryStream2, binder, dataModelVersion);
		}
		finally
		{
			if (array != null)
			{
				dh4.a(array);
			}
			if (array2 != null)
			{
				dh4.a(array2);
			}
			if (memoryStream != null)
			{
				memoryStream.Dispose();
			}
			if (memoryStream2 != null)
			{
				memoryStream2.Dispose();
			}
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
		}
		return result;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x00016128 File Offset: 0x00014328
	private static void a(Stream A_0, long A_1)
	{
		A_0.Write(eoq.b, 0, eoq.b.Length);
		A_0.Write(BitConverter.GetBytes(A_1), 0, 8);
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0001614C File Offset: 0x0001434C
	private static long a(Stream A_0)
	{
		if (A_0.Length >= (long)eoq.b.Length)
		{
			byte[] buffer = new byte[eoq.b.Length];
			A_0.Read(buffer, 0, eoq.b.Length);
			Guid g = new Guid(buffer);
			if (eoq.a.Equals(g))
			{
				byte[] array = new byte[8];
				A_0.Read(array, 0, 8);
				return BitConverter.ToInt64(array, 0);
			}
			A_0.Position = 0L;
		}
		return 0L;
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x000161C8 File Offset: 0x000143C8
	private static void a(Stream A_0, object A_1, SerializationBinder A_2, long A_3)
	{
		try
		{
			ca0.a = new ca0(A_3);
			new BinaryFormatter
			{
				Binder = A_2
			}.Serialize(A_0, A_1);
		}
		finally
		{
			ca0.a = null;
		}
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00016210 File Offset: 0x00014410
	private static T DeserializeFromBinaryInternal<T>(Stream stream, SerializationBinder binder, long dataModelVersion)
	{
		T result;
		try
		{
			ca0.a = new ca0(dataModelVersion);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			((BinaryFormatter)binaryFormatter).AssemblyFormat = 0;
			binaryFormatter.Binder = binder;
			result = (T)((object)binaryFormatter.Deserialize(stream));
		}
		finally
		{
			ca0.a = null;
		}
		return result;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x0001626C File Offset: 0x0001446C
	public static T Clone<T>(T obj)
	{
		Stream stream = eoq.SerializeToBinary<T>(obj, dds.a(), null, eh9.c, true, true);
		stream.Position = 0L;
		T result = eoq.DeserializeFromBinary<T>(stream, dds.a(), true, true);
		stream.Dispose();
		return result;
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x000162A8 File Offset: 0x000144A8
	public static string SerializeNetDataContract<T>(T obj, SerializationBinder binder = null)
	{
		czh.a(obj, "obj");
		MemoryStream memoryStream = null;
		string result;
		try
		{
			memoryStream = new MemoryStream();
			new NetDataContractSerializer
			{
				Binder = binder
			}.Serialize(memoryStream, obj);
			memoryStream.Position = 0L;
			result = new StreamReader(memoryStream).ReadToEnd();
		}
		finally
		{
			if (memoryStream != null)
			{
				memoryStream.Dispose();
			}
		}
		return result;
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0001631C File Offset: 0x0001451C
	public static T DeserializeNetDataContract<T>(Stream stream, SerializationBinder binder = null)
	{
		czh.a(stream, "stream");
		stream.Position = 0L;
		return (T)((object)new NetDataContractSerializer
		{
			AssemblyFormat = 0,
			Binder = binder
		}.Deserialize(stream));
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0001635C File Offset: 0x0001455C
	public static T DeserializeNetDataContract<T>(string xml, SerializationBinder binder = null)
	{
		czh.a(xml, "xml");
		MemoryStream memoryStream = null;
		StreamWriter streamWriter = null;
		T result;
		try
		{
			memoryStream = new MemoryStream();
			streamWriter = new StreamWriter(memoryStream);
			streamWriter.Write(xml);
			streamWriter.Flush();
			memoryStream.Position = 0L;
			result = (T)((object)new NetDataContractSerializer
			{
				AssemblyFormat = 0,
				Binder = binder
			}.Deserialize(memoryStream));
		}
		finally
		{
			if (streamWriter != null)
			{
				streamWriter.Dispose();
			}
			else if (memoryStream != null)
			{
				memoryStream.Dispose();
			}
		}
		return result;
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x000163F0 File Offset: 0x000145F0
	public static void SerializeNetDataContractToFile<T>(string filePath, T obj, SerializationBinder binder = null)
	{
		czh.a(filePath, "filePath");
		czh.a(obj, "obj");
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			new NetDataContractSerializer
			{
				Binder = binder
			}.Serialize(memoryStream, obj);
			File.WriteAllBytes(filePath, memoryStream.ToArray());
		}
		finally
		{
			if (memoryStream != null)
			{
				memoryStream.Close();
			}
		}
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00016464 File Offset: 0x00014664
	public static T DeserializeNetDataContractFromFile<T>(string filePath, SerializationBinder binder = null)
	{
		czh.a(filePath, "filePath");
		FileStream fileStream = null;
		T result;
		try
		{
			fileStream = File.OpenRead(filePath);
			result = (T)((object)new NetDataContractSerializer
			{
				AssemblyFormat = 0,
				Binder = binder
			}.Deserialize(fileStream));
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return result;
	}

	// Token: 0x0400046D RID: 1133
	public static readonly Guid a = new Guid("{838B53F9-361F-4332-BAAE-0D17865D0854}");

	// Token: 0x0400046E RID: 1134
	public static readonly byte[] b = eoq.a.ToByteArray();
}
