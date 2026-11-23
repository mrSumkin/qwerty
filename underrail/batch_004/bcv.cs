using System;
using Microsoft.Xna.Framework;

// Token: 0x02001676 RID: 5750
public sealed class bcv : uu
{
	// Token: 0x06007D7B RID: 32123 RVA: 0x0034DCD0 File Offset: 0x0034BED0
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			a7j a_ = new a7j(c5x, "BluePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.7f), new int?(30), dz6.b(), false, null);
			c5x.Zone.ActionManager.g9(a_, atp.a);
			a7j a_2 = new a7j(c5x, "BluePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.5f), new int?(45), dz6.b(), false, null);
			c5x.Zone.ActionManager.g9(a_2, atp.a);
			a7j a_3 = new a7j(c5x, "BluePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.3f), new int?(60), dz6.b(), false, null);
			c5x.Zone.ActionManager.g9(a_3, atp.a);
			egc a_4 = new egc(cpz.a * d0u.b);
			c5x.h.b.aa().StatusEffects.a(a_4, false, false, false);
			return true;
		}
		vr a_5 = new vr(new ap9(c5x.h.b.aa()), null, "Trance shot had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_5, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_5);
		return false;
	}
}
