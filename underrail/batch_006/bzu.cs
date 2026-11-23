using System;
using Microsoft.Xna.Framework;

// Token: 0x02001663 RID: 5731
public sealed class bzu : uu
{
	// Token: 0x06007D55 RID: 32085 RVA: 0x0034C5F8 File Offset: 0x0034A7F8
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
			int num = b6b.a(A_0);
			dcu dcu = c5x.h.b.aa().Offense;
			if (num > (int)dcu.ab().zo())
			{
				int num2 = num - (int)dcu.ab().zo();
				num = (int)dcu.ab().zo();
				num += Convert.ToInt32((double)num2 * b6b.b);
			}
			float num3 = dcu.d(num, true);
			dcu.b(-(int)num3, false);
			return true;
		}
		vr a_4 = new vr(new ap9(c5x.h.b.aa()), null, "{0}, не чувствует воздействия от пси-усилителя", new Color?(adi.m), null);
		bey.a(a_4, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_4);
		return false;
	}
}
