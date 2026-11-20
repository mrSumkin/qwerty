using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020009B3 RID: 2483
[eiz("RCMBTTFD")]
[Serializable]
public sealed class dq8 : bdw, ISerializable
{
	// Token: 0x06003BC8 RID: 15304 RVA: 0x00161B10 File Offset: 0x0015FD10
	private dq8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BC9 RID: 15305 RVA: 0x00161B18 File Offset: 0x0015FD18
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BCA RID: 15306 RVA: 0x00161B1C File Offset: 0x0015FD1C
	public dq8()
	{
	}

	// Token: 0x06003BCB RID: 15307 RVA: 0x00161B28 File Offset: 0x0015FD28
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			serviceOrThrow.aqu().ac();
			aud aud = A_0.n("rc_shop2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("500d552b-b2b0-4197-b08c-16b7b810d604"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("845bc88c-b085-452c-af6f-27c35f013eee"), aud).ao() as c5x;
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rcshop_buzzerFreed", new bool?(false)).Value;
				if (c5x != null)
				{
					bm6 aspect = c5x.GetAspect<bm6>();
					if (!value)
					{
						serviceOrThrow.aqu().r()["loc_rcshop_buzzerFreed"] = true;
						serviceOrThrow.aqu().r()["npc_rc_buzzer_thanksForNotFreeingMe"] = true;
						serviceOrThrow.aqu().r()["npc_rcbuzzer_reactedToBeingFreed"] = true;
						d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("76003d73-4b5b-43f4-b1dc-2827d953297f")).ao();
						if (d2b != null)
						{
							d2b.a(true, false);
						}
						cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("76003d73-4b5b-43f4-b1dc-2827d953297f")).ao();
						if (cnb != null)
						{
							cnb.d(true);
						}
					}
					if (aspect != null)
					{
						aspect.y6()[ddq.ay] = new bt4("buzzer3");
					}
					a0l.a(c5x, "buzzer3", true);
					amc aspect2 = c5x.GetAspect<amc>();
					if (aspect2 != null && aspect2.aa().Skills.Get<ct7>().f() > 85)
					{
						dro dro = new dro();
						dro.na(14);
						dro.nc(20);
						dro.a("PlasmaDischarger");
						dro.d(3);
						foreach (coh coh in dro.np())
						{
							if (coh is cd1)
							{
								euf.a(coh, null);
								aspect2.aa().Gear.j()[WeaponKey.Secondary].a(coh as cd1, true);
							}
							else
							{
								aspect2.aa().Bag.z3(coh, true);
							}
						}
					}
				}
				if (c5x2 != null && c5x2.h.b != null && c5x2.h.b.aa().FactionId != asp.a3 && c5x2.h.b.aa().FactionId != asp.co)
				{
					if (c5x2.t.b != null)
					{
						new bzv(c5x2.t.b.y6()).e();
					}
					c5x2.h.b.aa().FactionId = asp.a3;
					clt a_ = new clt(0);
					c5x2.h.b.aa().StatusEffects.a(a_, false, false, false);
				}
			}
		}
	}
}
