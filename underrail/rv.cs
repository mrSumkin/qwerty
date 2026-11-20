using System;

// Token: 0x02000475 RID: 1141
public sealed class rv : adt
{
	// Token: 0x06001D83 RID: 7555 RVA: 0x000A36D4 File Offset: 0x000A18D4
	public rv(string A_0, int A_1, int A_2) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x000A36EC File Offset: 0x000A18EC
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		new bzv(this.Subject.y6()).h();
		return ej1.b;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000A3708 File Offset: 0x000A1908
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
			float num = classPropertyValue.b((int)bm.a8().h.b.aa().Offense.u().TypedDefinition.ad());
			if (num == -1f || num > (float)this.a)
			{
				return 1f;
			}
		}
		cqc cqc = base.Parent as cqc;
		if (cqc == null || !cgh.a(cqc.adh(), this.Subject))
		{
			return 1f;
		}
		return 0f;
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x000A3828 File Offset: 0x000A1A28
	public override bool acj(TimeSpan A_0, double A_1)
	{
		cqc cqc = base.Parent as cqc;
		return cqc != null && cqc.adh() != null;
	}

	// Token: 0x04001045 RID: 4165
	private int a;

	// Token: 0x04001046 RID: 4166
	private new int b;
}
