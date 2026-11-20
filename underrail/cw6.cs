using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000C44 RID: 3140
public sealed class cw6 : jn
{
	// Token: 0x060046BB RID: 18107 RVA: 0x001D2D90 File Offset: 0x001D0F90
	public cw6() : base("jy_cliff", "creature\\characters\\jy_cliff")
	{
	}

	// Token: 0x060046BC RID: 18108 RVA: 0x001D2DA4 File Offset: 0x001D0FA4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jysaveJenny_completed", new bool?(false)).Value)
		{
			return null;
		}
		return "jyt4";
	}

	// Token: 0x060046BD RID: 18109 RVA: 0x001D2DDC File Offset: 0x001D0FDC
	public override void hp(b0b A_0, cyt A_1, string A_2)
	{
		if (A_2 == "jyt4")
		{
			c5x c5x = A_0 as c5x;
			if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead)
			{
				a5e a5e = Enumerable.FirstOrDefault<a5e>(Enumerable.Where<a5e>(c5x.h.b.aa().StatusEffects.Get<a5e>(), new Func<a5e, bool>(cw6.a.a.a)));
				if (a5e != null)
				{
					if ((float)((int)(a5e.TimeLeft / (double)d0u.b)) > c5x.h.b.aa().Defense.q().zo())
					{
						c5x.h.b.a(null, false);
						return;
					}
					c5x.h.b.aa().StatusEffects.d(a5e);
				}
			}
		}
	}

	// Token: 0x060046BE RID: 18110 RVA: 0x001D2EE0 File Offset: 0x001D10E0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			bn5 bn = c5x.GetAspect<j7>() as bn5;
			if (bn != null)
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_jytjenny_cured", new bool?(false)).Value && A_2 == "jyt4")
				{
					bn.b("events\\jyt_CliffAndJenny");
					return;
				}
				bn.b("characters\\jyt_cliff");
			}
		}
	}

	// Token: 0x02000C45 RID: 3141
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060046C1 RID: 18113 RVA: 0x001D2F6C File Offset: 0x001D116C
		internal bool a(a5e A_0)
		{
			return A_0.Code == "mortalWound";
		}

		// Token: 0x04001C70 RID: 7280
		public static readonly cw6.a a = new cw6.a();

		// Token: 0x04001C71 RID: 7281
		public static Func<a5e, bool> b;
	}
}
