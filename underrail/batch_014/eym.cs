using System;

// Token: 0x0200134D RID: 4941
public static class eym
{
	// Token: 0x06006FD5 RID: 28629 RVA: 0x002EE5A0 File Offset: 0x002EC7A0
	public static void a(amc A_0, ak1 A_1, double A_2, bool A_3 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && A_0.a8() != null && A_0.a8().t.b != null && A_0.aa().IsInControl && !A_0.aa().IsInCombat)
		{
			exw exw = eym.a(A_0);
			if (exw != null && A_2 >= exw.b())
			{
				A_0.a8().t.b.y6()[ddq.an] = new bt4(A_1.Area.y8(), A_1.Location.a());
				if (A_3)
				{
					foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
					{
						if (d4n.b != null && d4n.b != A_0 && !d4n.b.aa().Passive && !(d4n.b.aa() is e3q) && A_0.a8().t.b.b(d4n.b, false))
						{
							h h = A_0.aa().a(serviceOrThrow.aqu().ac(), d4n.b.aa().FactionId);
							cky cky = serviceOrThrow.aqu().ac().abu(d4n.b.aa().FactionId, A_0.aa().FactionId);
							if (!(d4n.b.aa().FactionId == A_0.aa().FactionId))
							{
								if (h != h.e || cky == null)
								{
									continue;
								}
								h? b = cky.b;
								h h2 = h.a;
								if (!(b.GetValueOrDefault() == h2 & b != null))
								{
									continue;
								}
							}
							exw exw2 = eym.a(d4n.b);
							if (exw2 != null && exw2.c() != d6n.a)
							{
								eym.a(d4n.b, A_1, A_2, false);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006FD6 RID: 28630 RVA: 0x002EE7F4 File Offset: 0x002EC9F4
	public static exw a(amc A_0)
	{
		if (A_0 != null && A_0.a8() != null)
		{
			if (A_0.a8().k == null || A_0.a8().k.b == null)
			{
				return null;
			}
			if (A_0.a8().t == null || A_0.a8().t.b != null)
			{
				exw classPropertyValue = A_0.a8().t.b.y6().GetClassPropertyValue<exw>(ddq.bs);
				if (classPropertyValue != null)
				{
					return classPropertyValue;
				}
			}
			exw classPropertyValue2 = A_0.a8().Zone.CustomProperties.GetClassPropertyValue<exw>("VigilanceSettings_" + A_0.aa().FactionId);
			if (classPropertyValue2 != null)
			{
				return classPropertyValue2;
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bqi bqi = serviceOrThrow.aqu().ac().abt(A_0.aa().FactionId);
				if (bqi != null)
				{
					return bqi.b();
				}
			}
		}
		return null;
	}

	// Token: 0x06006FD7 RID: 28631 RVA: 0x002EE8F4 File Offset: 0x002ECAF4
	public static void a(c5x A_0, double A_1)
	{
		if (A_0 != null && A_0.Area != null && A_0.j == cgy.b && A_1 > 0.0)
		{
			ak1 ak = A_0.Area.a(A_0.aj().a());
			if (ak != null)
			{
				cn9 a_ = new cn9(new edx(ak), A_1);
				A_0.Zone.ActionManager.g9(a_, atp.a);
				dz6.a(a_);
			}
		}
	}

	// Token: 0x06006FD8 RID: 28632 RVA: 0x002EE970 File Offset: 0x002ECB70
	public static void a(qy A_0, c5x A_1, double A_2)
	{
		if (A_1 != null && A_1.Area != null && A_1.j == cgy.b && A_2 > 0.0)
		{
			ak1 ak = A_1.Area.a(A_1.aj().a());
			if (ak != null)
			{
				cn9 item = new cn9(new edx(ak), A_2);
				A_0.ad().Add(item);
			}
		}
	}
}
