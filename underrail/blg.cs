using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004CF RID: 1231
[eiz("MPUBAC")]
[Serializable]
public sealed class blg : dnh, ISerializable
{
	// Token: 0x06001F90 RID: 8080 RVA: 0x000ADA88 File Offset: 0x000ABC88
	private blg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MPUBAC:MV");
		this.b = (BaseAbilityEnum)A_0.GetValue("MPUBAC:BAN", typeof(BaseAbilityEnum));
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x000ADAD0 File Offset: 0x000ABCD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPUBAC:MV", this.a);
		info.AddValue("MPUBAC:BAN", this.b);
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x000ADB04 File Offset: 0x000ABD04
	public int b()
	{
		return this.a;
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x000ADB0C File Offset: 0x000ABD0C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x000ADB18 File Offset: 0x000ABD18
	public BaseAbilityEnum a()
	{
		return this.b;
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x000ADB20 File Offset: 0x000ABD20
	public void a(BaseAbilityEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x000ADB2C File Offset: 0x000ABD2C
	public blg()
	{
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x000ADB38 File Offset: 0x000ABD38
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().BaseAbilities.a(this.b.ToString()).f() >= this.a;
	}

	// Token: 0x040013D7 RID: 5079
	private int a;

	// Token: 0x040013D8 RID: 5080
	private BaseAbilityEnum b;
}
