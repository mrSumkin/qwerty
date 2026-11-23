using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200026B RID: 619
[eiz("EDI")]
[Serializable]
public sealed class bf0 : ISerializable
{
	// Token: 0x06001241 RID: 4673 RVA: 0x0004B6F4 File Offset: 0x000498F4
	private bf0(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (bjp)A_0.GetValue("EDI:D", typeof(bjp));
		this.b = (bjp)A_0.GetValue("EDI:GL", typeof(bjp));
		if (ell.b() >= 21)
		{
			di7.ReadDictionary<byte, Color?>("EDI:H", ref this.c, A_0);
		}
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x0004B764 File Offset: 0x00049964
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("EDI:D", this.a);
		info.AddValue("EDI:GL", this.b);
		di7.WriteDictionary<byte, Color?>("EDI:H", this.c, info);
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x0004B79C File Offset: 0x0004999C
	public bf0()
	{
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x0004B7A8 File Offset: 0x000499A8
	public static bf0 b(b0b A_0)
	{
		bf0 bf = new bf0();
		if (A_0 != null)
		{
			bf.a = A_0.t;
			bf.b = A_0.u;
			bf.c = A_0.r;
			A_0.t = new bjp();
			A_0.u = null;
		}
		else
		{
			bf.a = new bjp();
		}
		return bf;
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x0004B808 File Offset: 0x00049A08
	public static bf0 a(b0b A_0)
	{
		bf0 bf = new bf0();
		if (A_0 != null)
		{
			bf.a = A_0.t;
			bf.b = A_0.u;
			bf.c = A_0.r;
		}
		else
		{
			bf.a = new bjp();
		}
		return bf;
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x0004B858 File Offset: 0x00049A58
	public void c(b0b A_0)
	{
		A_0.t = this.a;
		A_0.u = this.b;
		if (this.c != null)
		{
			A_0.r = this.c;
		}
	}

	// Token: 0x04000A1E RID: 2590
	private bjp a;

	// Token: 0x04000A1F RID: 2591
	private bjp b;

	// Token: 0x04000A20 RID: 2592
	private Dictionary<byte, Color?> c;
}
