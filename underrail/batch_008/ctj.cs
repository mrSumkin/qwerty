using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200172D RID: 5933
[eiz("DELCA")]
[Serializable]
public sealed class ctj : a6k
{
	// Token: 0x0600801C RID: 32796 RVA: 0x003616B8 File Offset: 0x0035F8B8
	private ctj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600801D RID: 32797 RVA: 0x003616C4 File Offset: 0x0035F8C4
	public ctj()
	{
	}

	// Token: 0x0600801E RID: 32798 RVA: 0x003616D0 File Offset: 0x0035F8D0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = null;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_up-lw_chargesSet", new int?(0)).Value < 5)
			{
				text = "Прежде чем использовать детонатор, необходимо установить все пять зарядов.";
			}
			else
			{
				if (base.vg().q().Zone.y8().Equals("up-lw", StringComparison.OrdinalIgnoreCase))
				{
					cav cav = new cav();
					cav.a(2000);
					cav.ym(null, null, null);
					base.vg().q().c().a("EarthquakeShort");
					for (int i = 1; i <= 7; i++)
					{
						csd csd = base.vg().q().Zone.g("exp" + i.ToString());
						if (csd != null && csd.Tile != null)
						{
							c5x c5x = Enumerable.FirstOrDefault<b0b>(csd.Tile.c.Values) as c5x;
							if (c5x != null)
							{
								dm5 dm = new dm5();
								dm.s().Add(new a1q(DamageType.Mechanical, 500, 900));
								dm.s().Add(new a1q(DamageType.Heat, 500, 900));
								dm.c(true);
								dm.ym(null, c5x, null);
							}
						}
					}
					doq a_ = doq.a(Path.Combine(d5x.q(), "up-lw_l2") + ".uzl");
					base.vg().q().Zone.a(a_, 1, null);
					serviceOrThrow.aqu().r()["loc_up-lw_blownUp"] = true;
					base.vg().e().a(true);
					bool flag = false;
					if (base.vg().q().Area.y8().Equals("up-lw2", StringComparison.OrdinalIgnoreCase))
					{
						flag = true;
					}
					else
					{
						foreach (ak1 ak in base.vg().q().l)
						{
							if (ak != null && ak.Formation.c(2L))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						base.vg().q().Zone.ActionManager.g9(new a4s(new nb(), null, new ar7(base.vg().q()), null), atp.a);
					}
					d02 service = bpo.GetService<d02>();
					if (service == null)
					{
						goto IL_39D;
					}
					using (List<d4n>.Enumerator enumerator2 = service.ahl().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							d4n d4n = enumerator2.Current;
							if (d4n.b != null && !d4n.b.aa().Dead && !(d4n.b.aa() is e3q) && d4n.b.a8() != null && d4n.b.a8().Area != null && d4n.b.a8().Area.y8().Equals("up-lw2", StringComparison.OrdinalIgnoreCase))
							{
								base.vg().q().Zone.ActionManager.g9(new a4s(new nb(), null, new ar7(d4n.b.a8()), null), atp.a);
							}
						}
						goto IL_39D;
					}
				}
				text = "Вы слишком далеко от зарядов.";
			}
			IL_39D:
			if (!string.IsNullOrEmpty(text))
			{
				bmj.a(base.vg().q(), new d53(text, adi.h, null, false));
				a7v.a(new h0(text, null));
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
