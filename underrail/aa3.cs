using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004D4 RID: 1236
[eiz("MXPBAC")]
[Serializable]
public sealed class aa3 : dnh, ISerializable
{
	// Token: 0x06001FB8 RID: 8120 RVA: 0x000AE0D0 File Offset: 0x000AC2D0
	private aa3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MXPBAC:MV");
		if (ell.a() >= 411)
		{
			this.b = (BaseAbilityEnum)A_0.GetValue("MXPBAC:BAN", typeof(BaseAbilityEnum));
			return;
		}
		Enum.TryParse<BaseAbilityEnum>(A_0.GetString("MXPBAC:BAN"), true, out this.b);
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x000AE140 File Offset: 0x000AC340
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MXPBAC:MV", this.a);
		info.AddValue("MXPBAC:BAN", this.b);
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x000AE174 File Offset: 0x000AC374
	public int a()
	{
		return this.a;
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000AE17C File Offset: 0x000AC37C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x000AE188 File Offset: 0x000AC388
	public BaseAbilityEnum b()
	{
		return this.b;
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x000AE190 File Offset: 0x000AC390
	public void a(BaseAbilityEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x000AE19C File Offset: 0x000AC39C
	public aa3()
	{
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000AE1A8 File Offset: 0x000AC3A8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c2h.a(serviceOrThrow.aqu().v(), this.b) <= this.a;
	}

	// Token: 0x040013E1 RID: 5089
	private int a;

	// Token: 0x040013E2 RID: 5090
	private BaseAbilityEnum b;
}
