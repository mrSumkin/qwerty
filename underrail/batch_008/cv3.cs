using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004E1 RID: 1249
[eiz("MPBAC")]
[Serializable]
public sealed class cv3 : dnh, ISerializable
{
	// Token: 0x0600202D RID: 8237 RVA: 0x000AF21C File Offset: 0x000AD41C
	private cv3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MPBAC:MV");
		if (ell.a() >= 411)
		{
			this.b = (BaseAbilityEnum)A_0.GetValue("MPBAC:BAN", typeof(BaseAbilityEnum));
			return;
		}
		Enum.TryParse<BaseAbilityEnum>(A_0.GetString("MPBAC:BAN"), true, out this.b);
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000AF28C File Offset: 0x000AD48C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPBAC:MV", this.a);
		info.AddValue("MPBAC:BAN", this.b);
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000AF2C0 File Offset: 0x000AD4C0
	public int b()
	{
		return this.a;
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000AF2C8 File Offset: 0x000AD4C8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x000AF2D4 File Offset: 0x000AD4D4
	public BaseAbilityEnum a()
	{
		return this.b;
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000AF2DC File Offset: 0x000AD4DC
	public void a(BaseAbilityEnum A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x000AF2E8 File Offset: 0x000AD4E8
	public cv3()
	{
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000AF2F4 File Offset: 0x000AD4F4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c2h.a(serviceOrThrow.aqu().v(), this.b) >= this.a;
	}

	// Token: 0x04001402 RID: 5122
	private int a;

	// Token: 0x04001403 RID: 5123
	private BaseAbilityEnum b;
}
