using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F15 RID: 3861
[e79("Xpbl_Le_ToddArrivesToCamp")]
public sealed class cnw : dgy
{
	// Token: 0x06004ECA RID: 20170 RVA: 0x00235EC4 File Offset: 0x002340C4
	public cnw()
	{
		cnw.a a = new cnw.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			new ar7(a.b);
			if (a.b != null)
			{
				a.c = a.b.Area;
				if (a.c != null)
				{
					a.e = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), a.b.Area).ao() as c5x);
					a.d = (new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), a.b.Area).ao() as c5x);
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
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
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

	// Token: 0x02000F16 RID: 3862
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004ECC RID: 20172 RVA: 0x0023609C File Offset: 0x0023429C
		internal bool b(e6d A_0)
		{
			if (!this.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_oldfield_metTodd", new bool?(false)).Value)
			{
				a0l.a(this.b, "yahota_oldTent", true);
				vq.a("Creature\\Characters\\xpbl\\Todd", this.c.Zone.g("player_oldTent"), true);
				if (this.d != null)
				{
					a0l.a(this.d, "global:xpbl_briggs:oldTent", true);
				}
			}
			else
			{
				c5x c5x = new ar7(new Guid("8b993b71-2472-446c-a9ba-30099404c50d"), this.b.Area).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				if (this.d != null)
				{
					a0l.a(this.d, "global:xpbl_briggs:brigTent", true);
				}
			}
			return true;
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x00236180 File Offset: 0x00234380
		internal bool a(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.e.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x0400203F RID: 8255
		public cnk a;

		// Token: 0x04002040 RID: 8256
		public c5x b;

		// Token: 0x04002041 RID: 8257
		public aud c;

		// Token: 0x04002042 RID: 8258
		public c5x d;

		// Token: 0x04002043 RID: 8259
		public c5x e;
	}
}
