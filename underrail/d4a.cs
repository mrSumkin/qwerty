using System;
using Microsoft.Xna.Framework;

// Token: 0x02001678 RID: 5752
public sealed class d4a : uu
{
	// Token: 0x06007D7F RID: 32127 RVA: 0x0034DFA0 File Offset: 0x0034C1A0
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			a7j a_ = new a7j(c5x, "BlackPsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.7f), new int?(30), dz6.b(), false, null);
			c5x.Zone.ActionManager.g9(a_, atp.a);
			a7j a_2 = new a7j(c5x, "BluePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.5f), new int?(45), dz6.b(), false, null);
			c5x.Zone.ActionManager.g9(a_2, atp.a);
			a7j a_3 = new a7j(c5x, "BlackPsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.3f), new int?(60), dz6.b(), false, null);
			c5x.Zone.ActionManager.g9(a_3, atp.a);
			c6h c6h = new c6h(ja.a * d0u.b);
			amd a_4 = new amd(c5x.h.b, new els[]
			{
				c6h
			});
			c5x.Zone.ActionManager.g9(a_4, atp.a);
			return true;
		}
		vr a_5 = new vr(new ap9(c5x.h.b.aa()), null, "Morphine shot had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_5, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_5);
		return false;
	}
}
