using System;
using Ouroboros.Playfield.References;

// Token: 0x02000474 RID: 1140
public sealed class uy : adt
{
	// Token: 0x06001D7E RID: 7550 RVA: 0x000A346C File Offset: 0x000A166C
	public uy(string A_0, int A_1, int A_2) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x000A3484 File Offset: 0x000A1684
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.c = null;
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x000A3490 File Offset: 0x000A1690
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		bm6 bm = this.Subject;
		amc amc = bm.a8().h.b;
		if (amc != null)
		{
			if (this.c == null)
			{
				eu7 eu = ecf.a(dgk.Get<bbc>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as eu7;
				if (eu != null && eu.yw())
				{
					this.c = cp.b(eu, bm.a8(), bm.a8());
					if (this.c == null)
					{
						return ej1.c;
					}
				}
			}
			else
			{
				if (this.c.x() == dc4.c)
				{
					return ej1.b;
				}
				if (this.c.x() == dc4.e)
				{
					return ej1.c;
				}
			}
			return ej1.a;
		}
		return ej1.c;
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x000A3544 File Offset: 0x000A1744
	public override float km(bool A_0)
	{
		double? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<double>(cy1.c, null);
		if (primitivePropertyValue != null && primitivePropertyValue.Value > (double)this.b)
		{
			return 1f;
		}
		cmb classPropertyValue = this.Subject.y6().GetClassPropertyValue<cmb>(cy1.h);
		if (classPropertyValue != null)
		{
			bm6 bm = this.Subject;
			if (bm == null || bm.a8().h.b == null)
			{
				return 0f;
			}
			int num = (int)bm.a8().h.b.aa().Offense.u().TypedDefinition.ad();
			if (num == 0)
			{
				num = 1;
			}
			float num2 = classPropertyValue.b(num);
			if (num2 != -1f && num2 > (float)this.a)
			{
				return 1f;
			}
		}
		return 0f;
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x000A3640 File Offset: 0x000A1840
	public override bool acj(TimeSpan A_0, double A_1)
	{
		cqc cqc = base.Parent as cqc;
		if (cqc != null && cqc.adh() != null)
		{
			bm6 bm = this.Subject;
			if (bm != null)
			{
				amc amc = bm.a8().h.b;
				if (amc != null && amc.aa().SpecialAbilities.c(dgk.Get<bbc>()))
				{
					eu7 eu = ecf.a(dgk.Get<bbc>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as eu7;
					return eu != null && eu.yw();
				}
			}
		}
		return false;
	}

	// Token: 0x04001042 RID: 4162
	private int a;

	// Token: 0x04001043 RID: 4163
	private new int b;

	// Token: 0x04001044 RID: 4164
	private new ad5 c;
}
