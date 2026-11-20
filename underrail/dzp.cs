using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000DBC RID: 3516
[e79("Dc_RahmUmbraExitsElevator")]
public sealed class dzp : dgy
{
	// Token: 0x06004BA8 RID: 19368 RVA: 0x0020CFD4 File Offset: 0x0020B1D4
	public dzp()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null && c5x.i.b != null)
			{
				dzp.a a = new dzp.a();
				c5x.i.b.a(true, false);
				a.a = (new ar7(new Guid("b2b1039f-a68e-4bc3-9d02-ada1698fa0d9"), c5x.Area).ao() as c5x);
				if (a.a != null && a.a.h.b != null && a.a.i.b != null)
				{
					new e80(false).ym(null, null, null);
					a.a.i.b.a(true, false);
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
					c6w.a(new ar7(a.a));
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

	// Token: 0x02000DBD RID: 3517
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BAA RID: 19370 RVA: 0x0020D20C File Offset: 0x0020B40C
		internal auv a()
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportEnter"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.a, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			if (this.a.h.b.aa().Offense.au() == WeaponKey.Secondary)
			{
				awx.ad().Add(new e4t(this.a.h.b, CharacterState.Custom4, cux.j, 0, null, 1));
			}
			else
			{
				awx.ad().Add(new e4t(this.a.h.b, CharacterState.Custom3, cux.j, 0, null, 1));
			}
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.a);
			ad.b(1.0);
			ad.c(0.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(250));
			awx.ad().Add(new ays(this.a, false, false, true));
			return awx;
		}

		// Token: 0x04001E72 RID: 7794
		public c5x a;
	}
}
