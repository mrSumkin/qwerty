using System;

// Token: 0x02000352 RID: 850
public sealed class b4a : abg
{
	// Token: 0x06001816 RID: 6166 RVA: 0x00079C58 File Offset: 0x00077E58
	public override void lt()
	{
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x00079C5C File Offset: 0x00077E5C
	public override abg f7()
	{
		base.b().d()["forcefieldCheck"] = true;
		bool? flag = null;
		if (this.c != null)
		{
			flag = !this.c.b();
		}
		else
		{
			flag = this.a();
		}
		if (flag == null)
		{
			return null;
		}
		if (flag.Value)
		{
			base.b().d()["forceFieldKillingMode"] = true;
			new bzv(base.b().c().y6()).a(null);
			return this.a;
		}
		return this.b;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x00079D38 File Offset: 0x00077F38
	private bool? a()
	{
		bool flag = false;
		cmb classPropertyValue = base.b().c().y6().GetClassPropertyValue<cmb>(cy1.h);
		if (classPropertyValue != null)
		{
			float num = classPropertyValue.b((int)base.b().c().a8().h.b.aa().Offense.u().TypedDefinition.ad());
			int num2 = cuo.a.Next(8, 10);
			if (num == -1f || num > (float)num2)
			{
				flag = true;
			}
			if (flag)
			{
				foreach (blk blk in new bzv(base.b().c().y6()).a().Values)
				{
					if (blk.e().aa().FactionId == asp.c && blk.b())
					{
						base.b().d()["forceFieldKillingMode"] = true;
						return new bool?(true);
					}
				}
			}
			return new bool?(false);
		}
		amc amc = new bzv(base.b().c().y6()).g();
		if (amc == null || amc.a8() == null || !amc.a8().IsPlayer)
		{
			return new bool?(false);
		}
		this.c = new d41(base.b().g().a8(), amc.a8(), base.b().c().a8().h.b.aa().Offense.u().TypedDefinition.ad(), null);
		this.c.a();
		return null;
	}

	// Token: 0x04000E1E RID: 3614
	public abg a;

	// Token: 0x04000E1F RID: 3615
	public abg b;

	// Token: 0x04000E20 RID: 3616
	private new d41 c;
}
