using System;
using Ouroboros.Playfield.References;

// Token: 0x02000471 RID: 1137
public class eqe : adt
{
	// Token: 0x06001D6F RID: 7535 RVA: 0x000A3094 File Offset: 0x000A1294
	public eqe(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x000A30A0 File Offset: 0x000A12A0
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		cp.a(this.a(), this.Subject.a8(), false);
		return ej1.b;
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x000A30C8 File Offset: 0x000A12C8
	public override float km(bool A_0)
	{
		return 0.75f;
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x000A30D4 File Offset: 0x000A12D4
	public override bool acj(TimeSpan A_0, double A_1)
	{
		e5b a_ = dgk.Get<e5b>();
		if (this.Subject.a8().h.b == null || !this.Subject.a8().h.b.aa().SpecialAbilities.c(a_))
		{
			return false;
		}
		av av = this.a();
		return !av.q() && av.yw();
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x000A3148 File Offset: 0x000A1348
	private bl6 a()
	{
		return ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(this.Subject.a8().h.b)), null) as bl6;
	}
}
