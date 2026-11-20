using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E8D RID: 3725
[e79("Rc_FacelessLeave")]
public sealed class d5i : dgy
{
	// Token: 0x06004D58 RID: 19800 RVA: 0x002221A4 File Offset: 0x002203A4
	public d5i()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			d5i.a a = new d5i.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
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
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				foreach (aud aud in a.a.Zone.Areas)
				{
					foreach (b0b b0b in aud.Entities)
					{
						c5x c5x = (c5x)b0b;
						if ((c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.cc || c5x.h.b.aa().FactionId == asp.cf)) || (c5x.s.b is c7j && !string.IsNullOrEmpty(c5x.y8()) && c5x.y8().StartsWith("Faceless") && c5x.Layer == aju.x))
						{
							btm[] array2 = new btm[1];
							int num2 = 0;
							a5 a2 = new a5();
							a2.a(new ar7(c5x));
							array2[num2] = a2;
							base.a(array2);
						}
					}
				}
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_sparedBuzzer", new bool?(false)).Value)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.b));
					array3[num3] = dva;
					base.a(array3);
				}
				btm[] array4 = new btm[1];
				int num4 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.a));
				array4[num4] = dva2;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array5[num5] = c8s;
				base.a(array5);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E8E RID: 3726
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D5A RID: 19802 RVA: 0x002224BC File Offset: 0x002206BC
		internal bool b(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("500d552b-b2b0-4197-b08c-16b7b810d604"), this.a.Zone.n("rc_shop2")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.a(null, false);
			}
			return true;
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00222524 File Offset: 0x00220724
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("76003d73-4b5b-43f4-b1dc-2827d953297f"), this.a.Zone.n("rc_shop2")).ao() as c5x;
			if (c5x != null)
			{
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null)
				{
					aspect.a(true, false);
				}
			}
			return true;
		}

		// Token: 0x04001F99 RID: 8089
		public c5x a;
	}
}
