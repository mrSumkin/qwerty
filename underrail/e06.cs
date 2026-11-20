using System;
using TimelapseVertigo.Common;

// Token: 0x0200062B RID: 1579
public sealed class e06 : em8, e86
{
	// Token: 0x0600288D RID: 10381 RVA: 0x000E90EC File Offset: 0x000E72EC
	public override lu eg()
	{
		return this.a;
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x000E90F4 File Offset: 0x000E72F4
	public e06(bl6 A_0) : base(A_0)
	{
		czh.a(A_0, "proxy");
		this.a = new d73(A_0);
	}

	// Token: 0x0600288F RID: 10383 RVA: 0x000E9114 File Offset: 0x000E7314
	public override TimelapseCursor? eh(object A_0)
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x06002890 RID: 10384 RVA: 0x000E9120 File Offset: 0x000E7320
	public bsc ei()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (base.ati() != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInControl)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && base.a() != null)
				{
					bsc bsc = new bsc();
					bsc.d = base.a();
					bsc.e = "TOGGLE_AURA_" + (base.ati().q() ? "OFF" : "ON") + "_" + base.ati().p().TechnicalName;
					bl6 bl = base.ati() as bl6;
					if (bl != null && !bl.q())
					{
						bsc.b = base.ati().d(base.a());
					}
					return bsc;
				}
			}
		}
		return null;
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x000E924C File Offset: 0x000E744C
	public override void f1(c1a A_0)
	{
		if (!base.ati().yw() || base.ati().p() == null)
		{
			return;
		}
		c5x c5x = bpo.GetServiceOrThrow<cnk>().aqu().v().b() as c5x;
		bl6 bl = base.ati() as bl6;
		if (bl != null && !bl.q() && !base.ati().p().hm(new eoj(base.ati().b8(), base.ati().b9(), base.a())))
		{
			return;
		}
		c5x.h.b.a(base.ati(), base.a());
	}

	// Token: 0x0400165A RID: 5722
	private new lu a;
}
