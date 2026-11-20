using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020000D5 RID: 213
public sealed class ccc : IDisposable
{
	// Token: 0x060004A8 RID: 1192 RVA: 0x00014E00 File Offset: 0x00013000
	public dhr d(string A_0)
	{
		ei5 ei;
		if (this.c.a.TryGetValue(A_0, out ei) && this.b.Count > ei.b)
		{
			return new dhr
			{
				a = this.b[ei.b].b,
				b = ei.c,
				c = ei.d,
				d = ei.e
			};
		}
		return null;
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00014E84 File Offset: 0x00013084
	public bool a(string A_0, byte[] A_1, long A_2, long A_3, bool? A_4 = null)
	{
		bool result = false;
		ei5 ei;
		if (this.c.a.TryGetValue(A_0, out ei))
		{
			result = true;
			if (ei.d != A_3)
			{
				this.a(ei);
				ei = null;
			}
		}
		if (ei == null)
		{
			int num = -1;
			long num2 = -1L;
			for (int i = 0; i < this.b.Count; i++)
			{
				num2 = this.b[i].a(A_3);
				if (num2 != -1L)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				by1 by = new by1();
				this.b.Add(by);
				num = this.b.Count - 1;
				num2 = by.a(A_3);
			}
			if (num2 == -1L)
			{
				throw new Exception(string.Format("Failed to allocate space for item '{0}' with length of {1}.", A_0, A_3));
			}
			ei = new ei5();
			ei.a = A_0;
			ei.b = num;
			ei.c = num2;
			ei.d = A_3;
			this.c.a[A_0] = ei;
		}
		ei.e = A_4;
		this.a(ei, A_1, A_2);
		return result;
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00014FAC File Offset: 0x000131AC
	public bool PutItemCompressed<T>(string name, T obj, bool validate = true)
	{
		byte[] array = dh4.a();
		bool result;
		try
		{
			ccc.a a = new ccc.a(array);
			eoq.SerializeToBinaryCompressed<T>(obj, dds.a(), a, eh9.c, true);
			bool flag = this.a(name, array, 0L, a.a, new bool?(true));
			if (validate)
			{
				this.a(name);
			}
			result = flag;
		}
		finally
		{
			dh4.a(array);
		}
		return result;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0001501C File Offset: 0x0001321C
	public bool PutItemUncompressed<T>(string name, T obj, bool validate = true)
	{
		byte[] array = dh4.a();
		bool result;
		try
		{
			MemoryStream memoryStream = new MemoryStream(array);
			eoq.SerializeToBinary<T>(obj, dds.a(), memoryStream, eh9.c, true, false);
			bool flag = this.a(name, array, 0L, memoryStream.Position, new bool?(false));
			if (validate)
			{
				this.a(name);
			}
			result = flag;
		}
		finally
		{
			dh4.a(array);
		}
		return result;
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x0001508C File Offset: 0x0001328C
	public T GetItem<T>(string name, bool throwOnMissing = false)
	{
		dhr dhr = this.d(name);
		if (dhr != null)
		{
			MemoryStream memoryStream = new MemoryStream(dhr.a);
			memoryStream.Position = dhr.b;
			T result;
			if (dhr.d.GetValueOrDefault())
			{
				result = eoq.DeserializeFromBinaryCompressed<T>(memoryStream, dds.a(), true);
			}
			else
			{
				result = eoq.DeserializeFromBinary<T>(memoryStream, dds.a(), true, false);
			}
			return result;
		}
		if (throwOnMissing)
		{
			throw new Exception(string.Format("BulkStorage does not contain item '{0}'.", name));
		}
		return default(T);
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00015114 File Offset: 0x00013314
	public T GetItemCompressed<T>(string name, bool throwOnMissing = false)
	{
		dhr dhr = this.d(name);
		if (dhr != null)
		{
			return eoq.DeserializeFromBinaryCompressed<T>(new MemoryStream(dhr.a)
			{
				Position = dhr.b
			}, dds.a(), true);
		}
		if (throwOnMissing)
		{
			throw new Exception(string.Format("BulkStorage does not contain item '{0}'.", name));
		}
		return default(T);
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00015174 File Offset: 0x00013374
	public T GetItemUncompressed<T>(string name, bool throwOnMissing = false)
	{
		dhr dhr = this.d(name);
		if (dhr != null)
		{
			return eoq.DeserializeFromBinary<T>(new MemoryStream(dhr.a)
			{
				Position = dhr.b
			}, dds.a(), true, false);
		}
		if (throwOnMissing)
		{
			throw new Exception(string.Format("BulkStorage does not contain item '{0}'.", name));
		}
		return default(T);
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x000151D4 File Offset: 0x000133D4
	public bool e(string A_0)
	{
		ei5 a_;
		if (this.c.a.TryGetValue(A_0, out a_))
		{
			this.a(a_);
			return true;
		}
		return false;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00015204 File Offset: 0x00013404
	public void g(string A_0)
	{
		try
		{
			eoq.SerializeToBinaryFile<en1>(Path.Combine(A_0, "bulk.map"), this.c, dds.a(), eh9.c, true);
			for (int i = 0; i < this.b.Count; i++)
			{
				string filePath = Path.Combine(A_0, string.Format("chunk{0}.map", i));
				string text = Path.Combine(A_0, string.Format("chunk{0}.dat", i));
				eoq.SerializeToBinaryFile<by1>(filePath, this.b[i], dds.a(), eh9.c, true);
				FileStream fileStream = File.OpenWrite(text);
				try
				{
					fileStream.Write(this.b[i].b, 0, (int)this.b[i].e);
				}
				finally
				{
					if (fileStream != null)
					{
						fileStream.Close();
					}
				}
			}
		}
		catch (Exception innerException)
		{
			throw new Exception(string.Format("Failed to save bulk storage to '{0}'", A_0), innerException);
		}
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00015310 File Offset: 0x00013510
	public void f(string A_0)
	{
		try
		{
			List<string> list = new List<string>();
			if (!Directory.Exists(A_0))
			{
				Directory.CreateDirectory(A_0);
			}
			foreach (ei5 ei in this.c.a.Values)
			{
				string text = Path.Combine(A_0, ei.a);
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				using (FileStream fileStream = File.OpenWrite(text))
				{
					byte[] array = this.b[ei.b].b;
					if (ei.d < 24L || array[(int)(checked((IntPtr)(unchecked(ei.c + 24L))))] != 31)
					{
						list.Add(ei.a);
					}
					fileStream.Write(array, (int)ei.c, (int)ei.d);
				}
			}
		}
		catch (Exception innerException)
		{
			throw new Exception(string.Format("Failed to unpack bulk storage to '{0}'", A_0), innerException);
		}
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00015458 File Offset: 0x00013658
	public static ccc c(string A_0)
	{
		ccc result;
		try
		{
			en1 en = eoq.DeserializeFromBinaryFile<en1>(Path.Combine(A_0, "bulk.map"), dds.a(), true);
			ccc ccc = new ccc();
			ccc.c = en;
			int num = 0;
			foreach (KeyValuePair<string, ei5> keyValuePair in en.a)
			{
				num = Math.Max(num, keyValuePair.Value.b + 1);
			}
			for (int i = 0; i < num; i++)
			{
				string filePath = Path.Combine(A_0, string.Format("chunk{0}.map", i));
				string text = Path.Combine(A_0, string.Format("chunk{0}.dat", i));
				by1 by = eoq.DeserializeFromBinaryFile<by1>(filePath, dds.a(), true);
				ccc.b.Add(by);
				byte[] buffer = dh4.c(by1.a);
				FileStream fileStream = File.OpenRead(text);
				try
				{
					fileStream.Read(buffer, 0, (int)fileStream.Length);
				}
				finally
				{
					if (fileStream != null)
					{
						fileStream.Close();
					}
				}
				by.b = buffer;
			}
			result = ccc;
		}
		catch (Exception innerException)
		{
			throw new Exception(string.Format("Failed to load bulk storage from '{0}'", A_0), innerException);
		}
		return result;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x000155E8 File Offset: 0x000137E8
	public static bool b(string A_0)
	{
		return File.Exists(Path.Combine(A_0, "bulk.map"));
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x000155FC File Offset: 0x000137FC
	private void a(ei5 A_0)
	{
		this.b[A_0.b].a(A_0.c, A_0.d);
		this.c.a.Remove(A_0.a);
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x0001563C File Offset: 0x0001383C
	private void a(ei5 A_0, byte[] A_1, long A_2)
	{
		by1 by = this.b[A_0.b];
		Array.Copy(A_1, A_2, by.b, A_0.c, A_0.d);
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00015674 File Offset: 0x00013874
	private void a(string A_0)
	{
		czh.a(A_0, "itemName");
		try
		{
			dhr dhr = this.d(A_0);
			if (dhr == null)
			{
				throw new c9w("Item not found", A_0);
			}
			if (dhr.a == null)
			{
				throw new c9w("Data was null", A_0);
			}
			if ((long)dhr.a.Length <= dhr.b + dhr.c)
			{
				throw new c9w("Item storage exceed the data byte array limits", A_0);
			}
			if (dhr.d != null)
			{
				if (dhr.c < (long)eoq.b.Length)
				{
					throw new c9w("Serialization header missing", A_0);
				}
				for (int i = 0; i < eoq.b.Length; i++)
				{
					if (dhr.a[(int)(checked((IntPtr)(unchecked(dhr.b + (long)i))))] != eoq.b[i])
					{
						throw new c9w("Invalid serialization header", A_0);
					}
				}
				if (dhr.d.GetValueOrDefault() && (dhr.b + 24L >= (long)dhr.a.Length || dhr.a[(int)(checked((IntPtr)(unchecked(dhr.b + 24L))))] != 31))
				{
					throw new c9w("Missing GZip header", A_0);
				}
			}
		}
		catch (Exception a_)
		{
			throw new c9w("Unexpected error", A_0, a_);
		}
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x000157D0 File Offset: 0x000139D0
	public void Dispose()
	{
		this.a(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x000157E0 File Offset: 0x000139E0
	private void a(bool A_0)
	{
		if (!this.a)
		{
			if (A_0)
			{
				foreach (by1 by in this.b)
				{
					by.Dispose();
				}
				this.b.Clear();
			}
			this.a = true;
		}
	}

	// Token: 0x04000457 RID: 1111
	private bool a;

	// Token: 0x04000458 RID: 1112
	public List<by1> b = new List<by1>();

	// Token: 0x04000459 RID: 1113
	public en1 c = new en1();

	// Token: 0x020000D6 RID: 214
	[Serializable]
	private sealed class a : MemoryStream
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x0001587C File Offset: 0x00013A7C
		public a(byte[] A_0) : base(A_0)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00015888 File Offset: 0x00013A88
		public override void Close()
		{
			this.a = this.Position;
			base.Close();
		}

		// Token: 0x0400045A RID: 1114
		[NonSerialized]
		public long a;
	}
}
