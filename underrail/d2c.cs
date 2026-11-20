using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000F1C RID: 3868
[e79("Xpbl_ExitSubmarine")]
public sealed class d2c : dgy
{
	// Token: 0x06004ED5 RID: 20181 RVA: 0x00236718 File Offset: 0x00234918
	public d2c()
	{
		d2c.a a = new d2c.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			bool value = a.a.aqu().r().GetPrimitivePropertyValue<bool>("vehicle_xpbl_submarine_atAbyssal", new bool?(false)).Value;
			string classPropertyValue = a.a.aqu().r().GetClassPropertyValue<string>("vehicle_xpbl_submarine_exitZoneName");
			a.b = a.a.aqu().r().GetPrimitivePropertyValue<Guid>("vehicle_xpbl_submarine_exitAreaId", null).GetValueOrDefault();
			a.c = a.a.aqu().r().GetPrimitivePropertyValue<Guid>("vehicle_xpbl_submarine_exitZoneId", null).GetValueOrDefault();
			c5x c5x = a.a.aqu().v().b() as c5x;
			new ar7(new Guid("fae0be13-9d4e-44e3-9ba1-dfb7a8597ae4"), c5x.Area).ao();
			if (c5x != null)
			{
				btm[] array = new btm[1];
				int num = 0;
				bfq bfq = new bfq();
				bfq.a(bvl.c);
				bfq.c("SubmarineHatchOpen");
				bfq.a(true);
				array[num] = new ace(bfq);
				base.a(array);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array2[num2] = dky;
				base.a(array2);
				if (value)
				{
					base.a(new btm[]
					{
						new di4(new c2w("xpbl_ds1", "FromSubmarine"), false, new bool?(true), 0, null, false, false, false)
					});
				}
				else
				{
					base.a(new btm[]
					{
						new di4(new c2w(classPropertyValue, "ExitSubmarine"), false, new bool?(true), 0, null, false, false, false)
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c6w c6w = new c6w(new Func<auv>(a.a));
					c6w.a(new ar7(aju.a, a.b, a.c, bl1.a));
					array3[num3] = c6w;
					base.a(array3);
				}
				btm[] array4 = new btm[1];
				int num4 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array4[num4] = c8s;
				base.a(array4);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F1D RID: 3869
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004ED7 RID: 20183 RVA: 0x002369C0 File Offset: 0x00234BC0
		internal auv a()
		{
			csd csd = this.a.aqw().g("ExitSubmarine");
			if (csd != null)
			{
				ak1 ak = csd.Area.b((int)csd.Location.X, (int)csd.Location.Y);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						wv wv = ((c5x)b0b).GetAspect<bim>() as wv;
						if (wv != null)
						{
							this.a.aqw().h("ExitSubmarine");
							c5x c5x = new ar7(aju.a, this.b, this.c, bl1.a).ao() as c5x;
							return new kp(wv, c5x.h.b);
						}
					}
				}
			}
			this.a.aqw().h("ExitSubmarine");
			return null;
		}

		// Token: 0x04002049 RID: 8265
		public cnk a;

		// Token: 0x0400204A RID: 8266
		public Guid b;

		// Token: 0x0400204B RID: 8267
		public Guid c;
	}
}
