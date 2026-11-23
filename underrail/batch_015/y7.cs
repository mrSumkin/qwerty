using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000CB4 RID: 3252
[e79("Tch_RejectsStealthEscape")]
public sealed class y7 : dgy
{
	// Token: 0x0600494C RID: 18764 RVA: 0x001E5AA0 File Offset: 0x001E3CA0
	public y7()
	{
		y7.a a = new y7.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.b.i.b.a(true, false);
				if (a.b.Area != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.a));
					array2[num2] = dva;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array3[num3] = c8s;
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000CB5 RID: 3253
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600494E RID: 18766 RVA: 0x001E5C04 File Offset: 0x001E3E04
		internal bool a(e6d A_0)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				int num = this.a.aqu().r().GetPrimitivePropertyValue<int>("loc_tch_rejectsEscaped", new int?(0)).Value;
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.ev)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
						num++;
					}
				}
				this.a.aqu().r()["loc_tch_rejectsEscaped"] = num;
			}
			a0l.a(this.b, "player_stealthRejects", true);
			if (this.b.h.b.aa().SpecialAbilities.a(typeof(e5b)))
			{
				bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(this.b.h.b)), null) as bl6;
				if (bl != null)
				{
					cp.a(bl, this.b, false);
				}
			}
			return true;
		}

		// Token: 0x04001D02 RID: 7426
		public cnk a;

		// Token: 0x04001D03 RID: 7427
		public c5x b;
	}
}
