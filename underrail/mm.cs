using System;
using TimelapseVertigo.Common;

// Token: 0x020005F3 RID: 1523
public sealed class mm : bad, e86
{
	// Token: 0x060027FA RID: 10234 RVA: 0x000E73BC File Offset: 0x000E55BC
	public override lu eg()
	{
		return new hm(null);
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x000E73C8 File Offset: 0x000E55C8
	public override bool io()
	{
		efk efk = ces.c();
		return base.io() && efk != null && !efk.SpecialStates.f;
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x000E73FC File Offset: 0x000E55FC
	public override TimelapseCursor? eh(object A_0)
	{
		return new TimelapseCursor?(TimelapseCursor.Attack);
	}

	// Token: 0x060027FD RID: 10237 RVA: 0x000E7404 File Offset: 0x000E5604
	public override void f1(c1a A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			amc aspect = serviceOrThrow.aqu().v().b().GetAspect<amc>();
			if (aspect != null)
			{
				aspect.b((base.a() as b0b).GetAspect<amc>());
			}
		}
	}

	// Token: 0x060027FE RID: 10238 RVA: 0x000E747C File Offset: 0x000E567C
	public bsc ei()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInControl)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				c5x c5x2 = base.a() as c5x;
				if (c5x != null && c5x.h.b != null && c5x2 != null)
				{
					cd1 cd = c5x.h.b.aa().Offense.u();
					bsc bsc = new bsc();
					bsc.d = base.a();
					bsc.e = "AUTO_ATTACK_" + cd.Id.ToString();
					bsc.a = d7x.a(c5x, base.a(), cd.TypedDefinition.ad(), null, null, cd.TypedDefinition.ah());
					bsc.b = c5x.h.b.aa().Offense.av();
					if (!string.IsNullOrEmpty(c5x.h.b.aa().Offense.u().TypedDefinition.b()))
					{
						dkf dkf = ckf.a(c5x.h.b.aa().Offense.u().TypedDefinition.b()) as dkf;
						if (dkf != null)
						{
							int? num = dkf.pb(c5x.h.b);
							if (num != null)
							{
								bsc.b = num.Value;
							}
						}
					}
					return bsc;
				}
			}
		}
		return null;
	}
}
