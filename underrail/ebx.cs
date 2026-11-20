using System;
using Ouroboros.Playfield.References;

// Token: 0x02000473 RID: 1139
public sealed class ebx : adt
{
	// Token: 0x06001D77 RID: 7543 RVA: 0x000A3274 File Offset: 0x000A1474
	public ebx(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x000A3280 File Offset: 0x000A1480
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		ad5 ad = cgh.a(this.Subject) as ad5;
		if (ad != null && ad.e() != null && ad.e().p() == dgk.Get<byc>())
		{
			return ej1.a;
		}
		return ej1.b;
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x000A32C8 File Offset: 0x000A14C8
	public override float km(bool A_0)
	{
		return 1f;
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x000A32D4 File Offset: 0x000A14D4
	public override bool acj(TimeSpan A_0, double A_1)
	{
		cqc cqc = base.Parent as cqc;
		if (cqc != null && cgh.a(cqc.adh(), this.Subject))
		{
			eu7 eu = this.a();
			return eu != null && eu.yw();
		}
		return false;
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x000A3320 File Offset: 0x000A1520
	public override void mc(TimeSpan A_0, double A_1)
	{
		bm6 bm = this.Subject;
		amc b = bm.a8().h.b;
		amc amc = new bzv(this.Subject.y6()).g();
		if (b != null && amc != null && !amc.aa().Dead)
		{
			eu7 eu = ecf.a(dgk.Get<byc>(), new eru(new EntityAspectReference<amc, amc>(b)), null) as eu7;
			if (eu != null && eu.yw())
			{
				cp.b(eu, bm.a8(), amc.a8());
			}
		}
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x000A33B8 File Offset: 0x000A15B8
	public override void ack()
	{
		ad5 ad = cgh.a(this.Subject) as ad5;
		if (ad != null && ad.e() != null && ad.e().p() == dgk.Get<byc>())
		{
			ad.j();
		}
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x000A3404 File Offset: 0x000A1604
	private eu7 a()
	{
		bm6 bm = this.Subject;
		if (bm != null)
		{
			amc b = bm.a8().h.b;
			if (b != null && b.aa().SpecialAttacks.c(dgk.Get<byc>()))
			{
				return ecf.a(dgk.Get<byc>(), new eru(new EntityAspectReference<amc, amc>(b)), null) as eu7;
			}
		}
		return null;
	}
}
