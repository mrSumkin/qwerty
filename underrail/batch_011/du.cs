using System;
using TimelapseVertigo.Common;

// Token: 0x02000620 RID: 1568
public sealed class du : em8, e86
{
	// Token: 0x0600286F RID: 10351 RVA: 0x000E8AC8 File Offset: 0x000E6CC8
	public override lu eg()
	{
		return this.a;
	}

	// Token: 0x06002870 RID: 10352 RVA: 0x000E8AD0 File Offset: 0x000E6CD0
	public du(eu7 A_0) : base(A_0)
	{
		this.a = a5v.a(A_0.d(), A_0);
	}

	// Token: 0x06002871 RID: 10353 RVA: 0x000E8AEC File Offset: 0x000E6CEC
	public override TimelapseCursor? eh(object A_0)
	{
		ehl ehl = base.ati().p() as ehl;
		if (ehl != null)
		{
			TimelapseCursor? timelapseCursor = ehl.wz(A_0, cho.a(A_0));
			if (timelapseCursor != null)
			{
				return new TimelapseCursor?(timelapseCursor.Value);
			}
		}
		if (ehl != null && ehl.Nature == ci8.c)
		{
			return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpell);
		}
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x06002872 RID: 10354 RVA: 0x000E8B58 File Offset: 0x000E6D58
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
					bsc.e = "INVOKE_CAP_" + base.ati().p().TechnicalName;
					ale b = c5x.h.b.a8().k.b;
					eu7 eu = base.ati() as eu7;
					if (eu != null)
					{
						dqw dqw = dpo.b(eu);
						bsc.a = d7x.a(c5x, base.a(), eu.c(base.a()), null, (dqw != null) ? dqw.sb() : null, eu.m());
					}
					if (base.ati().p() is eua)
					{
						bsc.b = base.ati().b8().Offense.av();
					}
					else
					{
						bsc.b = base.ati().d(base.a());
					}
					return bsc;
				}
			}
		}
		return null;
	}

	// Token: 0x04001658 RID: 5720
	private new lu a;
}
