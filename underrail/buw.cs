using System;
using TimelapseVertigo.Common;

// Token: 0x0200061D RID: 1565
public sealed class buw : bad, e86
{
	// Token: 0x0600285F RID: 10335 RVA: 0x000E85BC File Offset: 0x000E67BC
	public override lu eg()
	{
		return new cn0();
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x000E85C4 File Offset: 0x000E67C4
	public override bool io()
	{
		efk efk = ces.c();
		return base.io() && efk != null && !efk.SpecialStates.f;
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x000E85F8 File Offset: 0x000E67F8
	public buw(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002862 RID: 10338 RVA: 0x000E8608 File Offset: 0x000E6808
	public override TimelapseCursor? eh(object A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.s.b != null)
		{
			TimelapseCursor? result = c5x.s.b.ar3();
			if (result != null)
			{
				return result;
			}
		}
		avd[] array = c5x.s.b.jz();
		if (this.a)
		{
			if (array != null && array.Length != 0)
			{
				return new TimelapseCursor?(TimelapseCursor.ForbiddenMultiUse);
			}
			return new TimelapseCursor?(TimelapseCursor.ForbiddenUse);
		}
		else
		{
			if (array != null && array.Length != 0)
			{
				return new TimelapseCursor?(TimelapseCursor.MultiUse);
			}
			return new TimelapseCursor?(TimelapseCursor.Use);
		}
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x000E86A4 File Offset: 0x000E68A4
	public sealed override void f1(c1a A_0)
	{
		b0b b0b = base.a() as b0b;
		if (b0b != null)
		{
			bim aspect = b0b.GetAspect<bim>();
			if (aspect != null)
			{
				bpo.GetServiceOrThrow<cnk>().aqu().v().b().GetAspect<ale>().b(base.a() as b0b, aspect.t(), 1, aspect.y(), null);
			}
		}
	}

	// Token: 0x06002864 RID: 10340 RVA: 0x000E8708 File Offset: 0x000E6908
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
				if (c5x != null && c5x.h.b != null && c5x2 != null && c5x2.s.b != null)
				{
					return new bsc
					{
						d = base.a(),
						e = "USE_" + c5x2.qe().ToString(),
						a = d7x.a(c5x, base.a(), c5x2.s.b.ac(), c5x2.s.b.t(), null, 0),
						b = d0u.a()[c5x2.s.b.pr()]
					};
				}
			}
		}
		return null;
	}

	// Token: 0x04001656 RID: 5718
	private new bool a;
}
