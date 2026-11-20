using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000BC6 RID: 3014
[euj]
public class a61
{
	// Token: 0x0600450E RID: 17678 RVA: 0x001C133C File Offset: 0x001BF53C
	[ayh("OJYCFSF")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		aud aud = cze.a(null, A_0, A_1, A_2);
		if (aud != null && aud.Zone != null)
		{
			d60 d = aud.Zone.a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"strongFire"
				});
				if (list != null && list.Count > 0)
				{
					foreach (b0b b0b in list)
					{
						foreach (ak1 a_ in b0b.l)
						{
							dd5.a(null, a_, 100.0, int.MaxValue, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600450F RID: 17679 RVA: 0x001C1438 File Offset: 0x001BF638
	[ayh("OJYCSFA")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a(A_0);
	}

	// Token: 0x06004510 RID: 17680 RVA: 0x001C1444 File Offset: 0x001BF644
	[ayh("OJYCSFT")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service == null || service.aqu() == null)
		{
			return;
		}
		TimeSpan timeSpan = service.aqu().o();
		if (this.a != null && (timeSpan - this.a.Value).TotalSeconds < 1.0)
		{
			return;
		}
		this.a = new TimeSpan?(timeSpan);
		this.a(A_0);
	}

	// Token: 0x06004511 RID: 17681 RVA: 0x001C14C0 File Offset: 0x001BF6C0
	private void a(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			int a_ = Convert.ToInt32(1000.0 + (double)A_0.h.b.aa().Defense.q().zm() * 0.25);
			cwt cwt = new cwt();
			cwt.j = new ap9(A_0.h.b.aa());
			cwt.l = true;
			cwt.f.Add(new csk(DamageType.Heat, a_));
			cwt.k = "Fire";
			cwt.q = false;
			cwt.b = true;
			cwt.c = new bool?(false);
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.w = true;
			A_0.h.b.aa().Defense.a(cwt);
		}
	}

	// Token: 0x06004512 RID: 17682 RVA: 0x001C15A8 File Offset: 0x001BF7A8
	[ayh("OJYCKSJL")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		aud aud = cze.a(null, A_0, A_1, A_2);
		if (aud != null && aud.Zone != null)
		{
			aud = aud.Zone.n("xpbl_ojyc3");
			if (aud == null)
			{
				return;
			}
			c5x c5x = null;
			foreach (b0b b0b in aud.Entities)
			{
				wv wv = b0b.GetAspect<bim>() as wv;
				if (wv != null && wv.g() != null && wv.g().ah() == "xpbl_scrapJet" && b0b.Location.X >= 13f && b0b.Location.Y >= 4f && b0b.Location.X <= 35f && b0b.Location.Y <= 14f)
				{
					c5x = (b0b as c5x);
					break;
				}
			}
			if (c5x != null)
			{
				wv wv2 = c5x.GetAspect<bim>() as wv;
				if (wv2 != null)
				{
					if (wv2.g().ap().z2().Count > 0)
					{
						csd a_ = A_0.Zone.g("scrapJetLootSpawn");
						c5x c5x2 = vq.a("Objects\\Containers\\Remains\\DroppedItem", a_, false);
						if (c5x2 != null)
						{
							c7j c7j = new c7j(c5x2);
							c5x2.SetAspect<bim>(c7j);
							if (c7j != null)
							{
								c7j.ItemContainer.z2().AddRange(wv2.g().ap().z2());
								c7j.c("BackpackOpen");
								c7j.d("BackpackClose");
								c5x.w();
								c5x.an();
								return;
							}
						}
					}
					else
					{
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}

	// Token: 0x04001C69 RID: 7273
	private TimeSpan? a;
}
