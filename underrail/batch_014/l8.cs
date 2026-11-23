using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200026A RID: 618
[eiz("ZDM")]
[Serializable]
public sealed class l8 : ISerializable
{
	// Token: 0x06001239 RID: 4665 RVA: 0x0004B4CC File Offset: 0x000496CC
	private l8(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadDictionary<Guid, yc>("ZDM:A", ref this.b, A_0);
			return;
		}
		di7.ReadDictionary<Guid, yc>("Areas", ref this.b, A_0);
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x0004B50C File Offset: 0x0004970C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteDictionary<Guid, yc>("ZDM:A", this.b, info);
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x0004B520 File Offset: 0x00049720
	public l8()
	{
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x0004B538 File Offset: 0x00049738
	public static l8 b(c1a A_0)
	{
		czh.a(A_0, "zone");
		l8 l = new l8();
		foreach (aud aud in A_0.Areas)
		{
			yc value = yc.b(aud);
			l.b.Add(aud.qe(), value);
		}
		return l;
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x0004B5B8 File Offset: 0x000497B8
	public static l8 a(c1a A_0)
	{
		czh.a(A_0, "zone");
		l8 l = new l8();
		foreach (aud aud in A_0.Areas)
		{
			yc value = yc.a(aud);
			l.b.Add(aud.qe(), value);
		}
		return l;
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x0004B638 File Offset: 0x00049838
	public void c(c1a A_0)
	{
		czh.a(A_0, "zone");
		foreach (KeyValuePair<Guid, yc> keyValuePair in this.b)
		{
			aud aud = A_0.d(keyValuePair.Key);
			if (aud != null)
			{
				keyValuePair.Value.c(aud);
			}
		}
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x0004B6B8 File Offset: 0x000498B8
	public void b(string A_0)
	{
		czh.a(A_0, "filePath");
		eoq.SerializeToBinaryFileCompressed<l8>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x0004B6D8 File Offset: 0x000498D8
	public static l8 a(string A_0)
	{
		czh.a(A_0, "filePath");
		return eoq.DeserializeFromBinaryFileCompressed<l8>(A_0, dds.a(), true);
	}

	// Token: 0x04000A1C RID: 2588
	public const string a = "uzdm";

	// Token: 0x04000A1D RID: 2589
	public Dictionary<Guid, yc> b = new Dictionary<Guid, yc>();
}
