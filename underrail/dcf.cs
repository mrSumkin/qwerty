using System;
using Ouroboros.Playfield.References;

// Token: 0x02000463 RID: 1123
public sealed class dcf : b64
{
	// Token: 0x06001D37 RID: 7479 RVA: 0x000A1F94 File Offset: 0x000A0194
	public dcf(string A_0, Type A_1, cqc A_2, Func<TimeSpan, double, bool> A_3 = null, Func<bool, float> A_4 = null) : base(A_0, A_3, null, A_4, null)
	{
		this.a = A_1;
		this.c = A_2;
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x000A1FB4 File Offset: 0x000A01B4
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.b = null;
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x000A1FC0 File Offset: 0x000A01C0
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		bm6 bm = this.Subject;
		amc amc = bm.a8().h.b;
		if (amc != null)
		{
			if (this.b == null)
			{
				eu7 eu = ecf.a(dgk.c(this.a), new eru(new EntityAspectReference<amc, amc>(amc)), null) as eu7;
				if (eu != null && eu.yw())
				{
					this.b = cp.b(eu, bm.a8(), this.c.adh().a8());
					if (this.b == null)
					{
						return ej1.c;
					}
				}
			}
			else
			{
				if (this.b.x() == dc4.c)
				{
					return ej1.b;
				}
				if (this.b.x() == dc4.e)
				{
					return ej1.c;
				}
			}
			return ej1.a;
		}
		return ej1.c;
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x000A2084 File Offset: 0x000A0284
	public override bool acj(TimeSpan A_0, double A_1)
	{
		if (this.a == null || !base.acj(A_0, A_1))
		{
			return false;
		}
		if (this.c != null && this.c.adh() != null)
		{
			bm6 bm = this.Subject;
			if (bm != null)
			{
				amc amc = bm.a8().h.b;
				if (amc != null)
				{
					c3n a_ = dgk.c(this.a);
					if (amc.aa().SpecialAbilities.c(a_))
					{
						eu7 eu = ecf.a(a_, new eru(new EntityAspectReference<amc, amc>(amc)), null) as eu7;
						return eu != null && eu.yw();
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0400102E RID: 4142
	private Type a;

	// Token: 0x0400102F RID: 4143
	private new ad5 b;

	// Token: 0x04001030 RID: 4144
	private new cqc c;
}
