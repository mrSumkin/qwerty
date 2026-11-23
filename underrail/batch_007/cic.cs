using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020004AB RID: 1195
[eiz("A52")]
[Serializable]
public sealed class cic : ISerializable
{
	// Token: 0x06001E51 RID: 7761 RVA: 0x000A9280 File Offset: 0x000A7480
	private cic(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetSingle("A52:M");
		di7.ReadDictionary<c9z, float>("A52:V", ref this.b, A_0);
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x000A92C0 File Offset: 0x000A74C0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("A52:M", this.a);
		di7.WriteDictionary<c9z, float>("A52:V", this.b, info);
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x000A92E4 File Offset: 0x000A74E4
	public float c()
	{
		return this.a;
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x000A92EC File Offset: 0x000A74EC
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x000A92F8 File Offset: 0x000A74F8
	public Dictionary<c9z, float> b()
	{
		return this.b;
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x000A9300 File Offset: 0x000A7500
	public void a(Dictionary<c9z, float> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001E57 RID: 7767 RVA: 0x000A930C File Offset: 0x000A750C
	public cic()
	{
		this.b[c9z.a] = 1f;
		this.b[c9z.b] = 0.5f;
		this.b[c9z.c] = 0.4f;
		this.b[c9z.d] = 1f;
		this.b[c9z.e] = 0.3f;
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000A938C File Offset: 0x000A758C
	public cic a()
	{
		return new cic
		{
			b = new Dictionary<c9z, float>(this.b),
			a = this.a
		};
	}

	// Token: 0x0400135D RID: 4957
	private float a = 1f;

	// Token: 0x0400135E RID: 4958
	private Dictionary<c9z, float> b = new Dictionary<c9z, float>();
}
