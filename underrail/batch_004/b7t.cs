using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// Token: 0x020020D0 RID: 8400
[bmq("1.1.5.0_Cc_SergiosDenChanges", "1.1.5.0", "cc1", false)]
public sealed class b7t : fg
{
	// Token: 0x0600C805 RID: 51205 RVA: 0x00467FF8 File Offset: 0x004661F8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("62c31dd8-e1bc-42ff-8f99-a4bd23742cbf"), A_1.n("cc1_HS")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				if (!Enumerable.Any<cze>(c5x.h.b.ay()))
				{
					List<cze> list = c5x.h.b.ay();
					e2d e2d = new e2d();
					e2d.a(true);
					e2d.a(new Guid?(new Guid("3e3e8e7a-1b8b-47b3-a5a0-66bcdd4568e0")));
					e2d.a(c5x.Area.y8());
					list.Add(e2d);
					c4f c4f = new c4f();
					c4f.Properties["npc_cc_sergio_died"] = true;
					c5x.h.b.ay().Add(c4f);
				}
				c5x.h.b.aa().Gear.l().Item = null;
				c5x.h.b.aa().Gear.g().a(new k7(ez2.CreateDefinitonProvider<bqu>("armor\\wizardHat")), true);
				c5x.h.b.aa().Level = 20;
				c5x.h.b.aa().Skills.Get<e74>().a(75);
				c5x.h.b.aa().Skills.Get<erc>().a(85);
				c5x.h.b.aa().Skills.Get<dql>().a(125);
				c5x.h.b.aa().PsiAbilities.b(dgk.Get<d97>());
				c5x.h.b.aa().PsiAbilities.b(dgk.Get<dx2>());
				if (c5x.t.b != null)
				{
					c5x.t.b.ad()["FrightenPsiAbilityUser"] = true;
				}
				c5x.h.b.a("srg");
				c5x.h.b.aa().bl();
			}
			c5x c5x2 = new ar7(new Guid("a9f2f2bb-e727-4228-925a-4788cd9d72a5"), A_1.n("cc1_HS")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("15a70554-bff5-466c-a17a-b11f87b4ec06"), A_1.n("cc1_HS")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("0d0debd7-2bea-42f7-a6ba-e97a9e178659"), A_1.n("cc1_HS")).ao() as c5x;
			if (c5x2 != null && c5x2.h.b != null)
			{
				c5x2.h.b.aa().Level = 16;
				c5x2.h.b.aa().Skills.Get<jk>().a(90);
				c5x2.h.b.aa().Skills.Get<bec>().a(60);
				c5x2.h.b.aa().bl();
			}
			if (c5x3 != null && c5x3.h.b != null)
			{
				c5x3.h.b.aa().Level = 18;
				c5x3.h.b.aa().Skills.Get<jk>().a(65);
				c5x3.h.b.aa().Skills.Get<ct7>().a(100);
				c5x3.h.b.aa().Skills.Get<dei>().a(75);
				c5x3.h.b.aa().Feats.d(typeof(be1));
				c5x3.h.b.aa().bl();
			}
			if (c5x4 != null && c5x4.h.b != null)
			{
				c5x4.h.b.aa().Level = 17;
				c5x4.h.b.aa().Skills.Get<e5n>().a(80);
				c5x4.h.b.aa().Skills.Get<rs>().a(105);
				c5x4.h.b.aa().bl();
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
