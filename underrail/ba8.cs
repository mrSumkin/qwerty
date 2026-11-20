using System;
using System.Collections.Generic;
using Ouroboros.Playfield.Space;

// Token: 0x02000BAC RID: 2988
[euj]
public sealed class ba8
{
	// Token: 0x060043FB RID: 17403 RVA: 0x001AD09C File Offset: 0x001AB29C
	[ayh("XPHWDTRO")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null && service.aqw() != null)
		{
			d60 addon = service.aqw().GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"tunnelObservable"
				}))
				{
					b0b.w();
					b0b.an();
				}
			}
			foreach (string text in new List<string>
			{
				"xphw_up",
				"xphw_darkTer2",
				"xphw_exobase_tun"
			})
			{
				if (text != service.aqw().y8())
				{
					service.aqu().a(new bw0(text, new dki(), 1));
				}
			}
		}
	}

	// Token: 0x060043FC RID: 17404 RVA: 0x001AD1C8 File Offset: 0x001AB3C8
	[ayh("XPHWDTORBC")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = new ar7(new Guid("d1a599ca-ee74-4196-b19e-ca7572e99b5f"), A_1.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.an();
			}
			bfq bfq = new bfq("BatteryCompartmentOpen");
			bfq.a(bvl.c);
			bfq.ym(A_0, A_1, A_2);
			A_1.o.b.b.X = 0;
			A_1.RemoveAspect<bim>();
			d85 d = new d85(A_1);
			A_1.SetAspect<bim>(d);
			d.a().Add("Сами аккумуляторы, судя по всему, практически не повреждены. Но они нуждаются в подзарядке.");
			d.a(new List<HorizontalDirection>
			{
				HorizontalDirection.Southeast
			});
			d.c(2f);
			cj4 cj = new cj4(A_1);
			A_1.SetAspect<bbw>(cj);
			cj.s9(50.0);
			cj.s7(6000);
			cj.e().Add(new cxz("XPHWDTCRBS"));
		}
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x001AD2B8 File Offset: 0x001AB4B8
	[ayh("XPHWDTCRBS")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			cj4 cj = A_1.GetAspect<bbw>() as cj4;
			if (cj != null && cj.s8() >= (double)cj.s6())
			{
				new bfq("BatteryCompartmentClose").ym(A_0, A_1, A_2);
				cnk service = bpo.GetService<cnk>();
				if (service.aqu() != null)
				{
					service.aqu().r()["interface_xphw_railcar_hasPower"] = true;
				}
				A_1.o.b.b.X = 1;
				A_1.s.b.j = false;
			}
		}
	}
}
