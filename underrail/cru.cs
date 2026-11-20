using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001BF1 RID: 7153
[eiz("ARS")]
[Serializable]
public sealed class cru : ISerializable
{
	// Token: 0x06009BD6 RID: 39894 RVA: 0x003D1BD4 File Offset: 0x003CFDD4
	private cru(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<csk>("ARS:D", ref this.a, A_0);
		di7.ReadList<csk>("ARS:U", ref this.b, A_0);
		if (ell.a() >= 268)
		{
			this.c = A_0.GetBoolean("ARS:K");
		}
		if (ell.a() >= 283)
		{
			this.d = A_0.GetBoolean("ARS:C");
		}
		if (ell.a() >= 659)
		{
			this.e = A_0.GetInt32("ARS:B");
		}
	}

	// Token: 0x06009BD7 RID: 39895 RVA: 0x003D1C80 File Offset: 0x003CFE80
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<csk>("ARS:D", this.a, info);
		di7.WriteList<csk>("ARS:U", this.b, info);
		info.AddValue("ARS:K", this.c);
		info.AddValue("ARS:C", this.d);
		info.AddValue("ARS:B", this.e);
	}

	// Token: 0x06009BD8 RID: 39896 RVA: 0x003D1CE4 File Offset: 0x003CFEE4
	public cru()
	{
	}

	// Token: 0x04003BAC RID: 15276
	public List<csk> a = new List<csk>();

	// Token: 0x04003BAD RID: 15277
	public List<csk> b = new List<csk>();

	// Token: 0x04003BAE RID: 15278
	public bool c;

	// Token: 0x04003BAF RID: 15279
	public bool d;

	// Token: 0x04003BB0 RID: 15280
	public int e;
}
