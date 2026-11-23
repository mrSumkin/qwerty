using System;

// Token: 0x020011BA RID: 4538
public static class dz6
{
	// Token: 0x060060BE RID: 24766 RVA: 0x002A395C File Offset: 0x002A1B5C
	public static bool e()
	{
		d02 service = bpo.GetService<d02>();
		return service != null && service.ahg();
	}

	// Token: 0x060060BF RID: 24767 RVA: 0x002A3980 File Offset: 0x002A1B80
	public static float d()
	{
		return 50f;
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x002A3988 File Offset: 0x002A1B88
	public static bool a(auv A_0)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			service.ahp(A_0);
			return true;
		}
		return false;
	}

	// Token: 0x060060C1 RID: 24769 RVA: 0x002A39AC File Offset: 0x002A1BAC
	public static d4n b(efk A_0)
	{
		if (A_0 != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				d4n d4n = service.ahu(A_0);
				if (d4n == service.ahe())
				{
					return d4n;
				}
			}
		}
		return null;
	}

	// Token: 0x060060C2 RID: 24770 RVA: 0x002A39F0 File Offset: 0x002A1BF0
	public static void b(chb A_0)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			service.ahz(A_0);
		}
	}

	// Token: 0x060060C3 RID: 24771 RVA: 0x002A3A10 File Offset: 0x002A1C10
	public static void a(chb A_0)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			service.ah0(A_0);
		}
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x002A3A30 File Offset: 0x002A1C30
	public static void c(int A_0)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null && !service.ahg())
		{
			service.ahk((double)Math.Max(A_0, 3000));
		}
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x002A3A68 File Offset: 0x002A1C68
	public static void a(amc A_0, int A_1, bool A_2 = false, int A_3 = 2000, bool A_4 = false, bool A_5 = false)
	{
		if (A_0 != null)
		{
			dz6.a(A_0.aa(), A_1, A_2, A_3, A_4, A_5);
		}
	}

	// Token: 0x060060C6 RID: 24774 RVA: 0x002A3A84 File Offset: 0x002A1C84
	public static void a(efk A_0, int A_1, bool A_2 = false, int A_3 = 2000, bool A_4 = false, bool A_5 = false)
	{
		if (A_0 is e3q)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && (A_4 || !service.ahg()))
			{
				service.ah2(A_1, A_2, A_3, A_5);
			}
		}
	}

	// Token: 0x060060C7 RID: 24775 RVA: 0x002A3AC8 File Offset: 0x002A1CC8
	public static int a(efk A_0)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null && service.ahg())
		{
			d4n d4n = service.ahu(A_0);
			if (d4n != null)
			{
				return (int)d4n.c;
			}
		}
		return 0;
	}

	// Token: 0x060060C8 RID: 24776 RVA: 0x002A3B04 File Offset: 0x002A1D04
	public static bool a(c5x A_0, bim A_1)
	{
		if (A_1 != null)
		{
			int num = d0u.a()[A_1.pr()];
			if (A_0 != null && A_0.h.b != null)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null && service.ahg())
				{
					d4n d4n = service.ahu(A_0.h.b.aa());
					if (d4n != null)
					{
						bool flag = false;
						if (d4n.c < (double)num)
						{
							flag = true;
						}
						d4n.a(num, true);
						if (flag)
						{
							return false;
						}
					}
				}
				else if (d0u.f[A_1.pr()])
				{
					dz6.a(A_0.h.b, num, false, 2000, false, false);
				}
			}
		}
		return true;
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x002A3BC4 File Offset: 0x002A1DC4
	public static void a(c5x A_0, int A_1, bool A_2 = true)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				d4n d4n = service.ahu(A_0.h.b.aa());
				if (d4n != null)
				{
					d4n.b(A_1, A_2);
				}
			}
		}
	}

	// Token: 0x060060CA RID: 24778 RVA: 0x002A3C24 File Offset: 0x002A1E24
	public static float c()
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return serviceOrThrow2.aq1().c().f();
		}
		return 1f;
	}

	// Token: 0x060060CB RID: 24779 RVA: 0x002A3C68 File Offset: 0x002A1E68
	public static int b(int A_0)
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return (int)((float)A_0 * (1f / serviceOrThrow2.aq1().c().f()));
		}
		return A_0;
	}

	// Token: 0x060060CC RID: 24780 RVA: 0x002A3CB4 File Offset: 0x002A1EB4
	public static float b(float A_0)
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return A_0 * serviceOrThrow2.aq1().c().f();
		}
		return A_0;
	}

	// Token: 0x060060CD RID: 24781 RVA: 0x002A3CF8 File Offset: 0x002A1EF8
	public static float a(float A_0)
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return Math.Max(A_0, aju.d) * serviceOrThrow2.aq1().c().e();
		}
		return A_0;
	}

	// Token: 0x060060CE RID: 24782 RVA: 0x002A3D44 File Offset: 0x002A1F44
	public static double a(double A_0)
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return A_0 * (double)serviceOrThrow2.aq1().c().f();
		}
		return A_0;
	}

	// Token: 0x060060CF RID: 24783 RVA: 0x002A3D88 File Offset: 0x002A1F88
	public static int a(int A_0)
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return (int)Math.Ceiling((double)((float)A_0 * (1f / serviceOrThrow2.aq1().c().f())));
		}
		return A_0;
	}

	// Token: 0x060060D0 RID: 24784 RVA: 0x002A3DD8 File Offset: 0x002A1FD8
	public static float? b()
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return new float?(1f / serviceOrThrow2.aq1().c().f());
		}
		return null;
	}

	// Token: 0x060060D1 RID: 24785 RVA: 0x002A3E2C File Offset: 0x002A202C
	public static float? a()
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (dz6.e() && !serviceOrThrow.alk())
		{
			return new float?(1f / serviceOrThrow2.aq1().c().e());
		}
		return null;
	}
}
