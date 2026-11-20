using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000DBA RID: 3514
[e79("Dc_RahmUmbraSnatchesCubeAndExitsElevator")]
public sealed class d0v : dgy
{
	// Token: 0x06004BA5 RID: 19365 RVA: 0x0020C9E4 File Offset: 0x0020ABE4
	public d0v()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			d0v.a a = new d0v.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null && a.a.i.b != null)
			{
				a.a.i.b.a(true, false);
				a.b = (new ar7(new Guid("b2b1039f-a68e-4bc3-9d02-ada1698fa0d9"), a.a.Area).ao() as c5x);
				if (a.b != null && a.b.h.b != null && a.b.i.b != null)
				{
					new e80(false).ym(null, null, null);
					a.b.i.b.a(true, false);
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array = new btm[1];
					int num = 0;
					c6w c6w = new c6w();
					c6w.a(new ar7(a.b));
					c6w.a = new Func<auv>(a.a);
					array[num] = c6w;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array2[num2] = dky;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					base.a(new btm[]
					{
						new di4(new c2w("cv-dc", "FromElevator"), false, null, 0, null, true, false, false)
					});
				}
			}
		}
	}

	// Token: 0x02000DBB RID: 3515
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BA7 RID: 19367 RVA: 0x0020CC38 File Offset: 0x0020AE38
		internal auv a()
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq(Guid.NewGuid().ToString(), "UnarmedWoosh"), null, null, null);
			a4s.b(new ar7(this.b));
			list.Add(a4s);
			awx.ad().Add(new e4t(this.b.h.b, CharacterState.Attack1, cux.m, 0, null, 1));
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, null, null);
			a4s2.b(new ar7(this.a));
			list2.Add(a4s2);
			awx.ad().Add(new a7j(this.a, "Electricity", 1, double.MaxValue, true, true, null, null, null, null, false, null));
			awx.ad().Add(new amd(this.a.h.b, new els[]
			{
				new ab3(27000)
			}));
			awx.ad().Add(new e4t(this.b.h.b, CharacterState.Idle, cux.a, 0, null, 2));
			awx.ad().Add(new e4t(this.b.h.b, CharacterState.OperateShort, cux.a, 0, null, 1));
			List<auv> list3 = awx.ad();
			d1i d1i = new d1i();
			d1i.a("cube");
			list3.Add(new a4s(d1i, null, null, null));
			awx.ad().Add(new e4t(this.b.h.b, CharacterState.Idle, cux.a, 0, null, 2));
			List<auv> list4 = awx.ad();
			a4s a4s3 = new a4s(new bfq("TeleportEnter"), null, null, null);
			a4s3.b(new ar7(this.b));
			list4.Add(a4s3);
			awx.ad().Add(new a7j(this.b, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			if (this.b.h.b.aa().Offense.au() == WeaponKey.Secondary)
			{
				awx.ad().Add(new e4t(this.b.h.b, CharacterState.Custom4, cux.j, 0, null, 1));
			}
			else
			{
				awx.ad().Add(new e4t(this.b.h.b, CharacterState.Custom3, cux.j, 0, null, 1));
			}
			List<auv> list5 = awx.ad();
			ad6 ad = new ad6(this.b);
			ad.b(1.0);
			ad.c(0.0);
			ad.a(0.005);
			list5.Add(ad);
			awx.ad().Add(new bm3(250));
			awx.ad().Add(new ays(this.b, false, false, true));
			return awx;
		}

		// Token: 0x04001E70 RID: 7792
		public c5x a;

		// Token: 0x04001E71 RID: 7793
		public c5x b;
	}
}
