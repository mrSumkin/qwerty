using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001747 RID: 5959
[eiz("ROEA")]
[Serializable]
public sealed class ew8 : a6k
{
	// Token: 0x0600806B RID: 32875 RVA: 0x00364308 File Offset: 0x00362508
	private ew8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600806C RID: 32876 RVA: 0x00364314 File Offset: 0x00362514
	public ew8()
	{
	}

	// Token: 0x0600806D RID: 32877 RVA: 0x00364320 File Offset: 0x00362520
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = this.fm() as c5x;
		if (c5x != null)
		{
			bbw aspect = c5x.GetAspect<bbw>();
			if (aspect != null && aspect.tb())
			{
				int num = a25.a(base.vg().e());
				if (num > 0)
				{
					if (base.vg().q() != null && base.vg().q().h.b != null)
					{
						c3g aspect2 = c5x.GetAspect<c3g>();
						if (aspect2 != null)
						{
							aspect2.a(base.vg().q().h.b);
						}
					}
					aspect.tc(base.vg().q(), (double)num);
					bmj.a(c5x, new e5x("Заряжено", Color.White, "Energy.RechargeObject", false));
					c5x.c().a("ObjectRecharge", "ObjectRecharge", 1f, c9z.a, false, false);
					return dc4.c;
				}
			}
			amc aspect3 = c5x.GetAspect<amc>();
			if (aspect3 != null && aspect3.aa().Vehicle != null && aspect3.aa().Vehicle.g() < (double)aspect3.aa().Vehicle.am())
			{
				int num2 = a25.a(base.vg().e());
				if (num2 > 0)
				{
					aspect3.aa().Vehicle.a((double)num2);
					bmj.a(c5x, new e5x("Заряжено", Color.White, "Energy.RechargeObject", false));
					c5x.c().a("ObjectRecharge", "ObjectRecharge", 1f, c9z.a, false, false);
					return dc4.c;
				}
			}
		}
		return dc4.e;
	}
}
