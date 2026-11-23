using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200165F RID: 5727
public sealed class et3 : uu
{
	// Token: 0x06007D4D RID: 32077 RVA: 0x0034BE54 File Offset: 0x0034A054
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			c5x a_ = c5x;
			string a_2 = "GreenSparkExpiration";
			int a_3 = 3;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, c5x.Size.Z));
			float? a_7 = dz6.b();
			a7j a_8 = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
			c5x.Zone.ActionManager.g9(a_8, atp.a);
			int num = cdi.a;
			List<els> list = new List<els>();
			List<els> list2 = new List<els>(Enumerable.Cast<els>(Enumerable.OfType<dl2>(c5x.h.b.aa().StatusEffects.d())));
			while (list2.Count > 0 && num > 0)
			{
				els els = list2[cuo.a.Next(list2.Count)];
				if (els.Stacks > 1)
				{
					els els2 = els;
					int num2 = els2.Stacks;
					els2.Stacks = num2 - 1;
				}
				else
				{
					list.Add(els);
					list2.Remove(els);
				}
				num--;
			}
			foreach (els a_9 in list)
			{
				c5x.h.b.aa().StatusEffects.d(a_9);
			}
			if (list.Count > 0)
			{
				a20.a(A_1.a8(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Antidote
				});
			}
			return true;
		}
		vr a_10 = new vr(new ap9(c5x.h.b.aa()), null, "Противоядие не повлияло на {0}", new Color?(adi.m), null);
		bey.a(a_10, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_10);
		return false;
	}
}
