using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000268 RID: 616
[eiz("AP")]
[Serializable]
public sealed class az0 : ISerializable
{
	// Token: 0x0600122D RID: 4653 RVA: 0x0004AFA0 File Offset: 0x000491A0
	private az0(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadList<e36>("AP:A", ref this.b, A_0);
		}
		else
		{
			di7.ReadList<e36>("Actions", ref this.b, A_0);
		}
		if (ell.b() >= 19)
		{
			this.c = (TimeSpan)A_0.GetValue("AP:T", typeof(TimeSpan));
		}
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x0004B01C File Offset: 0x0004921C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<e36>("AP:A", this.b, info);
		info.AddValue("AP:T", this.c);
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x0004B048 File Offset: 0x00049248
	public az0()
	{
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x0004B05C File Offset: 0x0004925C
	public void b(string A_0)
	{
		czh.a(A_0, "filePath");
		eoq.SerializeToBinaryFileCompressed<az0>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x0004B07C File Offset: 0x0004927C
	public static az0 a(string A_0)
	{
		czh.a(A_0, "filePath");
		return eoq.DeserializeFromBinaryFileCompressed<az0>(A_0, dds.a(), true);
	}

	// Token: 0x04000A17 RID: 2583
	public const string a = "ap";

	// Token: 0x04000A18 RID: 2584
	public List<e36> b = new List<e36>();

	// Token: 0x04000A19 RID: 2585
	public TimeSpan c;
}
