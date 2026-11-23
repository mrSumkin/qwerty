using System;
using System.Runtime.Serialization;

// Token: 0x02001A5B RID: 6747
[eiz("MBAPE")]
[Serializable]
public sealed class ahq : dh6, bdr, ISerializable
{
	// Token: 0x0600927A RID: 37498 RVA: 0x0039F94C File Offset: 0x0039DB4C
	private ahq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("MBAPE:BAN");
			return;
		}
		if (base.GetType() == typeof(ahq))
		{
			this.a = A_0.GetString("_BaseAbilityName");
			return;
		}
		this.a = A_0.GetString("ModifyBaseAbilityPercentageEffect+_BaseAbilityName");
	}

	// Token: 0x0600927B RID: 37499 RVA: 0x0039F9BC File Offset: 0x0039DBBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MBAPE:BAN", this.a);
	}

	// Token: 0x0600927C RID: 37500 RVA: 0x0039F9D8 File Offset: 0x0039DBD8
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600927D RID: 37501 RVA: 0x0039F9E0 File Offset: 0x0039DBE0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600927E RID: 37502 RVA: 0x0039F9EC File Offset: 0x0039DBEC
	public ahq()
	{
	}

	// Token: 0x0600927F RID: 37503 RVA: 0x0039F9F4 File Offset: 0x0039DBF4
	public ahq(string A_0, float A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06009280 RID: 37504 RVA: 0x0039FA08 File Offset: 0x0039DC08
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (!string.IsNullOrWhiteSpace(this.a) && A_0.a() != null)
		{
			to to = A_0.a().BaseAbilities.a(this.a);
			if (to != null)
			{
				to to2 = to;
				to2.b(to2.g() + (int)((float)to.f() * base.c()));
			}
		}
	}

	// Token: 0x06009281 RID: 37505 RVA: 0x0039FA74 File Offset: 0x0039DC74
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ahq)A_0).a = this.a;
	}

	// Token: 0x06009282 RID: 37506 RVA: 0x0039FA90 File Offset: 0x0039DC90
	public override string b2()
	{
		return qv.a("StaticEffects/ModifyBaseAbilityPercentage", new object[]
		{
			this.a,
			base.c() * 100f
		});
	}

	// Token: 0x06009283 RID: 37507 RVA: 0x0039FAC4 File Offset: 0x0039DCC4
	public override d3e b3()
	{
		ahq ahq = new ahq();
		this.xx(ahq);
		return ahq;
	}

	// Token: 0x04003855 RID: 14421
	private new string a;
}
