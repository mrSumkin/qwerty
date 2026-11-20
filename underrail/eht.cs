using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020016D5 RID: 5845
[eiz("BLZ")]
[Serializable]
public sealed class eht : a6k, ISerializable
{
	// Token: 0x06007F38 RID: 32568 RVA: 0x0035D884 File Offset: 0x0035BA84
	private eht(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F39 RID: 32569 RVA: 0x0035D890 File Offset: 0x0035BA90
	public eht()
	{
	}

	// Token: 0x06007F3A RID: 32570 RVA: 0x0035D898 File Offset: 0x0035BA98
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					d4n d4n = service.ahu(b.aa());
					if (d4n != null && (int)d4n.d >= cn3.c)
					{
						int num = Math.Min((int)d4n.d / cn3.c, cn3.a(base.vg().e()));
						d4n.c += (double)num;
						d4n.d = 0.0;
						c5x a_ = c5x;
						string a_2 = "SpeedUp";
						int a_3 = 3;
						double maxValue = double.MaxValue;
						bool a_4 = false;
						bool a_5 = true;
						float? a_6 = dz6.b();
						boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
						c5x.c().a("sprint", "Sprint", 1f, c9z.a, false, false);
						bmj.a(base.vg().q(), new d53(string.Format("+{0} очков действия", num), adi.ap, "Блиц", false));
						vr a_7 = new vr(new ap9(base.vg().e().b8()), null, "{0} получает " + num.ToString() + " очков действия.", new Color?(adi.ap), null);
						bey.a(a_7, base.vg().e().b8(), base.vg().q().h.b);
						a7v.a(a_7);
					}
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
