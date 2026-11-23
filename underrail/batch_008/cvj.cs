using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020016D6 RID: 5846
[eiz("ESK")]
[Serializable]
public sealed class cvj : a6k, ISerializable
{
	// Token: 0x06007F3B RID: 32571 RVA: 0x0035DA40 File Offset: 0x0035BC40
	private cvj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F3C RID: 32572 RVA: 0x0035DA4C File Offset: 0x0035BC4C
	public cvj()
	{
	}

	// Token: 0x06007F3D RID: 32573 RVA: 0x0035DA58 File Offset: 0x0035BC58
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null && b.aa().SpecialStates.b)
			{
				c5x a_ = c5x;
				string a_2 = "EscapeBondsB";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = false;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				c5x a_7 = c5x;
				string a_8 = "EscapeBondsF";
				int a_9 = 1;
				double maxValue2 = double.MaxValue;
				bool a_10 = false;
				bool a_11 = true;
				a_6 = dz6.b();
				boj.a(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false);
				List<els> list = new List<els>();
				foreach (els els in b.aa().StatusEffects.d())
				{
					if (Enumerable.Any<ap0>(Enumerable.OfType<ap0>(els.StaticEffects)))
					{
						list.Add(els);
					}
				}
				foreach (els a_12 in list)
				{
					b.aa().StatusEffects.d(a_12);
				}
				bmj.a(base.vg().q(), new d53("Выпутывание!", adi.o, "EscapeBonds", false));
				vr a_13 = new vr(new ap9(base.vg().e().b8()), null, "{0} выпутывается.", new Color?(adi.n), null);
				bey.a(a_13, base.vg().e().b8(), base.vg().q().h.b);
				a7v.a(a_13);
				int num = base.vg().e().b8().GetSpecializationValue<cor>(true) * cor.a;
				if (num > 0)
				{
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						d4n d4n = service.ahu(base.vg().e().b8());
						if (d4n != null && d4n == service.ahe())
						{
							d4n.d += (double)num;
							if (base.vg().q() != null)
							{
								bmj.a(base.vg().q(), new d53(string.Format("+{0} ед. передвижения{1}", num, (num > 1) ? "" : ""), adi.ao, "Избавление от пут", false));
								vr a_14 = new vr(new ap9(base.vg().e().b8()), null, string.Concat(new string[]
								{
									"{0} восстановлено ",
									num.ToString(),
									" ед. передвижения",
									(num > 1) ? "" : "",
									" план побега."
								}), new Color?(adi.ao), null);
								bey.a(a_14, base.vg().e().b8(), base.vg().q().GetAspect<amc>());
								a7v.a(a_14);
							}
						}
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
