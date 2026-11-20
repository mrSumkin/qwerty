using System;
using System.Collections.Generic;

// Token: 0x0200035B RID: 859
public sealed class cf4 : abg
{
	// Token: 0x0600182F RID: 6191 RVA: 0x0007AC6C File Offset: 0x00078E6C
	public override void lt()
	{
		this.e = this.d;
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x0007AC7C File Offset: 0x00078E7C
	public override abg f7()
	{
		if (this.a())
		{
			new bzv(base.b().c().y6()).a(null);
			return this.a;
		}
		return this.b;
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x0007ACBC File Offset: 0x00078EBC
	private bool a()
	{
		bool flag = base.b().g().aa().b(d8o.b | d8o.c | d8o.d);
		amc amc = new bzv(base.b().c().y6()).g();
		int num = this.c;
		bool flag2 = false;
		if (flag && amc != null && amc.aa().SpecialStates.k)
		{
			return true;
		}
		if (amc != null && !(amc.aa() is e3q))
		{
			num = 5;
		}
		cmb classPropertyValue = base.b().c().y6().GetClassPropertyValue<cmb>(cy1.h);
		if (classPropertyValue != null)
		{
			float num2 = classPropertyValue.b((int)base.b().c().a8().h.b.aa().Offense.u().TypedDefinition.ad());
			if (num2 == -1f || num2 > (float)num)
			{
				int num3 = this.e - 1;
				this.e = num3;
				if (num3 <= 0 || (amc != null && !(amc.aa() is e3q)))
				{
					return true;
				}
				flag2 = (amc != null && amc.aa() is e3q);
			}
		}
		if (!cgh.a(amc, base.b().c()))
		{
			return true;
		}
		if (!base.b().vz() && base.b().g().a8().k.b == null && !base.b().c().b(amc, false))
		{
			return true;
		}
		Guid? primitivePropertyValue = base.b().c().y6().GetPrimitivePropertyValue<Guid>(ddq.a3, null);
		Guid? primitivePropertyValue2 = base.b().c().y6().GetPrimitivePropertyValue<Guid>(ddq.a4, null);
		List<Guid> classPropertyValue2 = base.b().c().y6().GetClassPropertyValue<List<Guid>>(ddq.a5);
		bzv bzv = new bzv(base.b().c().y6());
		Dictionary<Guid, blk> dictionary = bzv.a();
		if (amc != null && amc.a8() != null && primitivePropertyValue == null && ((primitivePropertyValue2 != null && amc.a8().qe() != primitivePropertyValue2.Value) || (classPropertyValue2 != null && classPropertyValue2.Count > 0 && classPropertyValue2.Contains(amc.a8().qe()))))
		{
			int num4 = bzv.f();
			bool flag3 = false;
			if (num4 > 0)
			{
				foreach (blk blk in dictionary.Values)
				{
					if (blk != null && blk.e() != null && blk.e().a8() != null && blk.a().f() == cem.d && !blk.e().aa().Dead && !blk.e().aa().Passive && base.b().c().a8().h.b.a(blk.e()) == h.a)
					{
						if (classPropertyValue2 == null || !classPropertyValue2.Contains(blk.e().a8().qe()))
						{
							flag3 = true;
						}
						if (primitivePropertyValue2 == blk.e().a8().qe())
						{
							return true;
						}
					}
				}
				if (classPropertyValue2 != null && classPropertyValue2.Count > 0 && classPropertyValue2.Contains(amc.a8().qe()) && flag3)
				{
					return true;
				}
			}
		}
		if (amc != null && amc.aa().FactionId == asp.c)
		{
			return true;
		}
		if (flag2)
		{
			foreach (blk blk2 in dictionary.Values)
			{
				if (blk2.e().aa().FactionId == asp.c && blk2.b())
				{
					base.b().d()["forceFieldKillingMode"] = true;
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04000E2C RID: 3628
	public abg a;

	// Token: 0x04000E2D RID: 3629
	public abg b;

	// Token: 0x04000E2E RID: 3630
	public new int c = 180;

	// Token: 0x04000E2F RID: 3631
	public int d = 2;

	// Token: 0x04000E30 RID: 3632
	private int e;
}
