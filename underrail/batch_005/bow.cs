using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000971 RID: 2417
[eiz("DCSFT")]
[Serializable]
public sealed class bow : bdw, ISerializable
{
	// Token: 0x06003ABF RID: 15039 RVA: 0x0015C664 File Offset: 0x0015A864
	private bow(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AC0 RID: 15040 RVA: 0x0015C66C File Offset: 0x0015A86C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AC1 RID: 15041 RVA: 0x0015C670 File Offset: 0x0015A870
	public bow()
	{
	}

	// Token: 0x06003AC2 RID: 15042 RVA: 0x0015C678 File Offset: 0x0015A878
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && serviceOrThrow != null)
		{
			aud aud = A_0.n("dc-de2");
			if (aud != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_dc_flcom_died", new bool?(false)).Value)
			{
				e5g.b(aud);
				c5x c5x = new ar7(new Guid("0d58b6dc-792d-43a2-be71-85ff3a196699"), aud).ao() as c5x;
				if (c5x == null)
				{
					serviceOrThrow.aqu().r()["npc_dc_flcom_died"] = true;
					return;
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "dc-de2_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				bu6 service = bpo.GetService<bu6>();
				if (service != null && service.aq2() >= GameDifficulty.Dominating)
				{
					foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
					{
						if (d4n.b != null && !d4n.b.aa().b(d8o.e) && d4n.b.aa().FactionId == asp.ch)
						{
							if (d4n.b.aa().Id == "faccom")
							{
								brt a_2 = new brt();
								d4n.b.aa().StatusEffects.a(a_2, false, false, false);
							}
							else if (cuo.a.Next(0, 101) >= 50)
							{
								if (d4n.b.aa().PsiAbilities.a() > 0)
								{
									edc a_3 = new edc();
									d4n.b.aa().StatusEffects.a(a_3, false, false, false);
								}
								else if (d4n.b.aa().Offense.u().TypedDefinition.e() == btz.g)
								{
									bta a_4 = new bta();
									d4n.b.aa().StatusEffects.a(a_4, false, false, false);
								}
								else if (cuo.a.Next(0, 101) >= 50)
								{
									mr a_5 = new mr();
									d4n.b.aa().StatusEffects.a(a_5, false, false, false);
								}
								else
								{
									brt a_6 = new brt();
									d4n.b.aa().StatusEffects.a(a_6, false, false, false);
								}
							}
						}
					}
				}
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				cky cky = bv.abu(asp.a, asp.ch);
				if (cky != null && cky.a == h.a)
				{
					serviceOrThrow.aqu().r()["faction_faceless_deepCaverns_wasHostile"] = true;
					bv.a(asp.ch, asp.a, h.c, null, true, false, false);
				}
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.aa().c(asp.a);
				}
				bpo.GetServiceOrThrow<ps>().am3("Dc_FacelessAfterTchortBattle");
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2.h.b != null && c5x2.h.b.aa().FactionId == asp.e6 && !c5x2.h.b.aa().Dead)
					{
						c5x2.w();
						c5x2.an();
					}
				}
			}
		}
	}
}
