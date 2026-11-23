using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020018C4 RID: 6340
[eiz("FS1")]
[Serializable]
public sealed class c7g : oj, ISerializable
{
	// Token: 0x06008687 RID: 34439 RVA: 0x0037C214 File Offset: 0x0037A414
	private c7g(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 639)
		{
			byte[] a_ = A_0.GetValue("FS1:D", typeof(byte[])) as byte[];
			this.a(a_);
			return;
		}
		if (ell.a() != 0)
		{
			di7.ReadDictionary<string, bqi>("FS1:F", ref this.a, A_0);
			using (Dictionary<string, bqi>.Enumerator enumerator = this.a.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, bqi> keyValuePair = enumerator.Current;
					keyValuePair.Value.f();
				}
				return;
			}
		}
		if (base.GetType() == typeof(c7g))
		{
			this.a = (Dictionary<string, bqi>)A_0.GetValue("_Factions", typeof(Dictionary<string, bqi>));
			return;
		}
		this.a = (Dictionary<string, bqi>)A_0.GetValue("FactionSet+_Factions", typeof(Dictionary<string, bqi>));
	}

	// Token: 0x06008688 RID: 34440 RVA: 0x0037C32C File Offset: 0x0037A52C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		byte[] value = this.a();
		info.AddValue("FS1:D", value);
	}

	// Token: 0x06008689 RID: 34441 RVA: 0x0037C34C File Offset: 0x0037A54C
	private byte[] a()
	{
		MemoryStream memoryStream = new MemoryStream(1048576);
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(this.a.Count);
		foreach (KeyValuePair<string, bqi> keyValuePair in this.a)
		{
			binaryWriter.Write(keyValuePair.Key);
			keyValuePair.Value.a(binaryWriter);
		}
		binaryWriter.Flush();
		binaryWriter.Close();
		return memoryStream.ToArray();
	}

	// Token: 0x0600868A RID: 34442 RVA: 0x0037C3F0 File Offset: 0x0037A5F0
	private void a(byte[] A_0)
	{
		MemoryStream memoryStream = new MemoryStream(A_0);
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		int num = binaryReader.ReadInt32();
		this.a = new Dictionary<string, bqi>(num);
		for (int i = 0; i < num; i++)
		{
			this.a[binaryReader.ReadString()] = bqi.a(binaryReader);
		}
		binaryReader.Close();
		memoryStream.Close();
	}

	// Token: 0x0600868B RID: 34443 RVA: 0x0037C450 File Offset: 0x0037A650
	public Dictionary<string, bqi> abr()
	{
		return this.a;
	}

	// Token: 0x0600868C RID: 34444 RVA: 0x0037C458 File Offset: 0x0037A658
	public c7g()
	{
	}

	// Token: 0x0600868D RID: 34445 RVA: 0x0037C46C File Offset: 0x0037A66C
	public bqi abs(string A_0, string A_1, h A_2, bool A_3 = false, exw A_4 = null, bool A_5 = true)
	{
		czh.a(A_0, "id");
		czh.a(A_1, "name");
		if (this.a.ContainsKey(A_0))
		{
			return this.a[A_0];
		}
		bqi bqi = new bqi(A_0, A_1);
		bqi.a(A_2);
		bqi.a(A_3);
		bqi.a(A_4 ?? new exw());
		bqi.b(A_5);
		this.a.Add(A_0, bqi);
		return bqi;
	}

	// Token: 0x0600868E RID: 34446 RVA: 0x0037C4F0 File Offset: 0x0037A6F0
	public bqi abt(string A_0)
	{
		bqi result;
		this.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x0600868F RID: 34447 RVA: 0x0037C510 File Offset: 0x0037A710
	public cky abu(string A_0, string A_1)
	{
		czh.a(A_0, "sourceFactionId");
		czh.a(A_1, "targetFactionId");
		bqi bqi;
		this.a.TryGetValue(A_0, out bqi);
		if (bqi == null)
		{
			return null;
		}
		bqi bqi2;
		this.a.TryGetValue(A_1, out bqi2);
		if (bqi2 == null)
		{
			return null;
		}
		return this.abv(bqi, bqi2);
	}

	// Token: 0x06008690 RID: 34448 RVA: 0x0037C56C File Offset: 0x0037A76C
	public cky abv(bqi A_0, bqi A_1)
	{
		czh.a(A_0, "sourceFaction");
		czh.a(A_1, "targetFaction");
		cky result;
		A_0.d().TryGetValue(A_1.e(), out result);
		return result;
	}

	// Token: 0x06008691 RID: 34449 RVA: 0x0037C5A4 File Offset: 0x0037A7A4
	public cky abx(bqi A_0, bqi A_1, h A_2, h? A_3, bool A_4, bool A_5)
	{
		cky cky;
		A_0.d().TryGetValue(A_1.e(), out cky);
		bool flag = false;
		if (cky == null)
		{
			cky = new cky();
			A_0.d().Add(A_1.e(), cky);
			flag = true;
		}
		if (!flag && A_5)
		{
			if (A_2 < cky.a)
			{
				cky.a = A_2;
			}
		}
		else
		{
			cky.a = A_2;
		}
		if (A_3 != null)
		{
			cky.b = A_3;
		}
		if (A_4)
		{
			this.abx(A_1, A_0, A_2, A_3, false, A_5);
		}
		return cky;
	}

	// Token: 0x06008692 RID: 34450 RVA: 0x0037C640 File Offset: 0x0037A840
	public cky abw(string A_0, string A_1, h A_2, h? A_3, bool A_4, bool A_5)
	{
		czh.a(A_0, "sourceFactionId");
		czh.a(A_1, "targetFactionId");
		bqi bqi;
		this.a.TryGetValue(A_0, out bqi);
		if (bqi == null)
		{
			return null;
		}
		bqi bqi2;
		this.a.TryGetValue(A_1, out bqi2);
		if (bqi2 == null)
		{
			return null;
		}
		return this.abx(bqi, bqi2, A_2, A_3, A_4, A_5);
	}

	// Token: 0x06008693 RID: 34451 RVA: 0x0037C6A0 File Offset: 0x0037A8A0
	public void aby(string A_0, string A_1, c2n A_2, object A_3)
	{
	}

	// Token: 0x06008694 RID: 34452 RVA: 0x0037C6A4 File Offset: 0x0037A8A4
	public h? abz(string A_0, string A_1)
	{
		if (A_1 == null || A_0 == null)
		{
			return null;
		}
		if (A_1 == A_0)
		{
			bqi bqi = this.abt(A_1);
			if (bqi != null)
			{
				return new h?(bqi.g());
			}
			return null;
		}
		else
		{
			cky cky = this.abu(A_0, A_1);
			if (cky != null)
			{
				return cky.b;
			}
			return null;
		}
	}

	// Token: 0x040033D1 RID: 13265
	private Dictionary<string, bqi> a = new Dictionary<string, bqi>();
}
