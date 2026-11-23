using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B63 RID: 2915
[eiz("LUXC6XSMB")]
[Serializable]
public sealed class e4f : cze, ISerializable
{
	// Token: 0x060042B3 RID: 17075 RVA: 0x0019E174 File Offset: 0x0019C374
	private e4f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042B4 RID: 17076 RVA: 0x0019E180 File Offset: 0x0019C380
	public e4f()
	{
	}

	// Token: 0x060042B5 RID: 17077 RVA: 0x0019E18C File Offset: 0x0019C38C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c1a c1a = serviceOrThrow.aqw();
			if (c1a != null)
			{
				bu6 service = bpo.GetService<bu6>();
				int num = 1;
				if (service != null)
				{
					num = (int)service.aq2();
				}
				List<csd> list = new List<csd>();
				foreach (csd csd in Enumerable.ToList<csd>(c1a.Waypoints))
				{
					if (csd.Name.StartsWith("spawnBeetle_"))
					{
						for (int i = 0; i <= num; i++)
						{
							if (csd.Name.EndsWith(i.ToString()))
							{
								list.Add(csd);
							}
						}
					}
				}
				foreach (csd csd2 in list)
				{
					if (csd2 != null)
					{
						c5x c5x = vq.a((num == 0 && cuo.a.Next(0, 101) < 50) ? "creatures\\PsiBeetle" : "creatures\\GreaterPsiBeetle", csd2, false);
						if (c5x != null && c5x.h.b != null && c5x.t.b != null)
						{
							c5x.h.b.aa().SpecialAbilities.b(dgk.Get<e5b>());
							c5x.h.b.aa().BaseSightRange = 7f;
							c5x.h.b.aa().Feats.d(typeof(c4y));
							c5x.h.b.aa().Skills.Get<a2n>().a(80);
							c5x.t.b.b("mistPsiBeetle");
							c5x.RemoveAspect<a6p>();
						}
					}
				}
				c5x a_ = new ar7(new Guid("4a0db8d5-5a97-4651-940b-6f5706d46610"), c1a.n("lux-c6x")).ao() as c5x;
				c5x a_2 = new ar7(new Guid("2ce88c79-25eb-4702-93c9-86aa70e425fd"), c1a.n("lux-c6x")).ao() as c5x;
				dtb dtb = new dtb();
				for (int j = 0; j < 12; j++)
				{
					if (j % 2 == 0)
					{
						List<auv> list2 = dtb.ad();
						bfq bfq = new bfq();
						bfq.a(bvl.c);
						bfq.b("beetles" + j.ToString());
						bfq.c("PsiBeetleChitter" + cuo.a.Next(1, 4).ToString());
						bfq.a(c9z.b);
						bfq.a(true);
						bfq.a(Math.Min(0.8f, 0.1f + (float)j * 0.07f));
						list2.Add(new a4s(bfq, null, new ar7(a_), null));
					}
					else
					{
						List<auv> list3 = dtb.ad();
						bfq bfq2 = new bfq();
						bfq2.a(bvl.c);
						bfq2.b("beetles" + j.ToString());
						bfq2.c("PsiBeetleChitter" + cuo.a.Next(1, 4).ToString());
						bfq2.a(c9z.b);
						bfq2.a(true);
						bfq2.a(Math.Min(0.8f, 0.1f + (float)j * 0.07f));
						list3.Add(new a4s(bfq2, null, new ar7(a_2), null));
					}
					dtb.ad().Add(new bm3(Math.Max(120, 1200 - j * 120)));
				}
				c1a.ActionManager.g9(dtb, atp.a);
			}
		}
	}
}
