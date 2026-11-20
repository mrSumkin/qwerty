using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004CE RID: 1230
[eiz("MAXPUBAC")]
[Serializable]
public sealed class c4q : dnh, ISerializable
{
	// Token: 0x06001F88 RID: 8072 RVA: 0x000AD970 File Offset: 0x000ABB70
	private c4q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MAXPUBAC:MV");
		this.b = (BaseAbilityEnum)A_0.GetValue("MAXPUBAC:BAN", typeof(BaseAbilityEnum));
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x000AD9B8 File Offset: 0x000ABBB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MAXPUBAC:MV", this.a);
		info.AddValue("MAXPUBAC:BAN", this.b);
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000AD9EC File Offset: 0x000ABBEC
	public int a()
	{
		return this.a;
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x000AD9F4 File Offset: 0x000ABBF4
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x000ADA00 File Offset: 0x000ABC00
	public BaseAbilityEnum b()
	{
		return this.b;
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000ADA08 File Offset: 0x000ABC08
	public void a(BaseAbilityEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x000ADA14 File Offset: 0x000ABC14
	public c4q()
	{
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x000ADA20 File Offset: 0x000ABC20
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().BaseAbilities.a(this.b.ToString()).f() <= this.a;
	}

	// Token: 0x040013D5 RID: 5077
	private int a;

	// Token: 0x040013D6 RID: 5078
	private BaseAbilityEnum b;
}
