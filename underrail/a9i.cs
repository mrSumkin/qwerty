using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F18 RID: 3864
[e79("Xpbl_Pir_ToddArrivesToCeto")]
public sealed class a9i : dgy
{
	// Token: 0x06004ECF RID: 20175 RVA: 0x00236300 File Offset: 0x00234500
	public a9i()
	{
		a9i.b b = new a9i.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			b.b = (b.a.aqu().v().b() as c5x);
			new ar7(b.b);
			if (b.b != null)
			{
				b.c = b.b.Area;
				if (b.c != null)
				{
					a9i.a a = new a9i.a();
					a.b = b;
					a.a = (new ar7(new Guid("eeeb3815-98da-4fc1-8d8c-29204bc22801"), a.b.b.Area).ao() as c5x);
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
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b.a), null, null, null)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.a(false);
					array2[num2] = c8s;
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000F19 RID: 3865
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004ED1 RID: 20177 RVA: 0x002364CC File Offset: 0x002346CC
		internal bool a(e6d A_0)
		{
			if (!this.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_metTodd", new bool?(false)).Value)
			{
				a0l.a(this.b, "player_meeting", true);
				vq.a("Creature\\Characters\\xpbl\\Todd", this.c.Zone.g("todd_meeting"), true);
			}
			else
			{
				c5x c5x = new ar7(new Guid("8b993b71-2472-446c-a9ba-30099404c50d"), this.b.Area).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
			}
			return true;
		}

		// Token: 0x04002044 RID: 8260
		public cnk a;

		// Token: 0x04002045 RID: 8261
		public c5x b;

		// Token: 0x04002046 RID: 8262
		public aud c;
	}

	// Token: 0x02000F1A RID: 3866
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004ED3 RID: 20179 RVA: 0x00236584 File Offset: 0x00234784
		internal bool a(e6d A_0)
		{
			this.b.b.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04002047 RID: 8263
		public c5x a;

		// Token: 0x04002048 RID: 8264
		public a9i.b b;
	}
}
