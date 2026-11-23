using System;
using System.Runtime.Serialization;

// Token: 0x020004E5 RID: 1253
[eiz("NLAC")]
[Serializable]
public sealed class at4 : dnh, ISerializable
{
	// Token: 0x0600204F RID: 8271 RVA: 0x000AF8D8 File Offset: 0x000ADAD8
	private at4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetSingle("NLAC:LL");
			this.b = A_0.GetSingle("NLAC:UL");
			this.c = A_0.GetString("NLAC:NN");
			return;
		}
		if (base.GetType() == typeof(at4))
		{
			this.a = A_0.GetSingle("_LowerLimit");
			this.b = A_0.GetSingle("_UpperLimit");
			this.c = A_0.GetString("_NpcName");
			return;
		}
		this.a = A_0.GetSingle("NpcLinearAdaptationCondition+_LowerLimit");
		this.b = A_0.GetSingle("NpcLinearAdaptationCondition+_UpperLimit");
		this.c = A_0.GetString("NpcLinearAdaptationCondition+_NpcName");
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x000AF9AC File Offset: 0x000ADBAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NLAC:LL", this.a);
		info.AddValue("NLAC:UL", this.b);
		info.AddValue("NLAC:NN", this.c);
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000AF9F4 File Offset: 0x000ADBF4
	public float b()
	{
		return this.a;
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x000AF9FC File Offset: 0x000ADBFC
	public void b(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x000AFA08 File Offset: 0x000ADC08
	public float a()
	{
		return this.b;
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x000AFA10 File Offset: 0x000ADC10
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x000AFA1C File Offset: 0x000ADC1C
	public string c()
	{
		return this.c;
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x000AFA24 File Offset: 0x000ADC24
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x000AFA30 File Offset: 0x000ADC30
	public at4()
	{
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x000AFA3C File Offset: 0x000ADC3C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		string name = bp5.j(this.c);
		float value = A_0.GetPrimitivePropertyValue<float>(name, new float?(0f)).Value;
		return value >= this.a && value <= this.b;
	}

	// Token: 0x0400140D RID: 5133
	private float a;

	// Token: 0x0400140E RID: 5134
	private float b;

	// Token: 0x0400140F RID: 5135
	private string c;
}
