using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000A41 RID: 2625
[eiz("XPBLMUPMMRS")]
[Serializable]
public sealed class a8d : bdw, ISerializable
{
	// Token: 0x06003E37 RID: 15927 RVA: 0x00176D70 File Offset: 0x00174F70
	private a8d(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x00176D78 File Offset: 0x00174F78
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E39 RID: 15929 RVA: 0x00176D7C File Offset: 0x00174F7C
	public a8d()
	{
	}

	// Token: 0x06003E3A RID: 15930 RVA: 0x00176D84 File Offset: 0x00174F84
	public void av(c1a A_0, cyt A_1)
	{
		bv9 bv = A_1.ac() as bv9;
		if (bv != null)
		{
			cky cky = bv.abu(asp.fm, asp.a);
			if (cky != null && cky.a == h.a)
			{
				foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.fm)
						{
							c5x.h.b.aa().c(asp.a);
						}
					}
				}
				A_1.r()["loc_xpbl_b7_mutiesAttackedByPlayer"] = true;
			}
			bv.a(asp.fm, asp.a, h.c, null, true, false, false);
		}
		bool flag = A_1.r().GetPrimitivePropertyValue<bool>("faction_xpbl_blackLakeMuties_eradicated", new bool?(false)).Value;
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_mu_wesley_died", new bool?(false)).Value;
		bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_mu_doctorM_died", new bool?(false)).Value;
		bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_mu_frank_died", new bool?(false)).Value;
		bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_refuge", new bool?(false)).Value;
		int num = 0;
		if (!flag)
		{
			if (!value2 && !(new ar7(new Guid("8a7c5aa6-3f8b-43fc-b0ef-49fb4eece7d0"), A_0.n("xpbl_b7_1")).ao() is c5x))
			{
				A_1.r()["npc_xpbl_mu_doctorM_died"] = true;
			}
			if (!value3 && !(new ar7(new Guid("ab58fa84-d8df-4287-8af4-291e36a1bd17"), A_0.n("xpbl_b7")).ao() is c5x))
			{
				A_1.r()["npc_xpbl_mu_frank_died"] = true;
			}
			foreach (aud aud2 in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b2 in Enumerable.ToList<b0b>(aud2.Entities))
				{
					c5x c5x2 = (c5x)b0b2;
					if (c5x2.h.b != null && c5x2.h.b.aa().FactionId == asp.fm && c5x2.h.b.am() != "mdog" && !c5x2.h.b.am().Contains("mutated_human"))
					{
						num++;
					}
				}
			}
			if (num < 5)
			{
				flag = true;
			}
			foreach (aud aud3 in Enumerable.ToList<aud>(A_0.Areas))
			{
				if (!flag)
				{
					e5g.a(aud3);
				}
				foreach (b0b b0b3 in Enumerable.ToList<b0b>(aud3.Entities))
				{
					c5x c5x3 = (c5x)b0b3;
					if (c5x3.h.b != null && c5x3.h.b.aa().FactionId == asp.fm)
					{
						if (flag)
						{
							c5x3.w();
							c5x3.an();
						}
						else if (c5x3.t.b != null)
						{
							if (c5x3.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay) != null)
							{
								a0l.a(c5x3, A_0.g(c5x3.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b()).Name, true);
							}
							else if (c5x3.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k) != null && Enumerable.Any<string>(c5x3.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k)))
							{
								a0l.a(c5x3, A_0.g(Enumerable.FirstOrDefault<string>(c5x3.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k))).Name, true);
							}
							if (c5x3.t.b.y6().GetClassPropertyValue<string>(ddq.bc) != null)
							{
								c5x3.t.b.y6().RemoveProperty(ddq.bc);
							}
						}
					}
				}
			}
			if (!flag)
			{
				A_1.r()["loc_mu_allowedInside"] = true;
				A_1.r()["loc_mu_allowedElevator"] = true;
				c5x c5x4 = new ar7(new Guid("bfb974e8-7f66-470b-9ebd-1bf3a9d7d97e"), A_0.n("xpbl_b7")).ao() as c5x;
				csd csd = A_0.g("mutieGuard_playerMutantArrives");
				if (c5x4 != null)
				{
					a0l.a(c5x4, csd.Name, true);
					if (c5x4.t.b != null)
					{
						c5x4.t.b.y6()[ddq.ay] = new bt4(csd.Name);
					}
				}
				else
				{
					c5x c5x5 = vq.a("Creatures\\GenericHumans\\MutieGuard", csd, false);
					if (c5x5 != null)
					{
						bn5 bn = c5x5.GetAspect<j7>() as bn5;
						if (bn == null)
						{
							bn = new bn5(c5x5);
							c5x5.SetAspect<j7>(bn);
						}
						bn.b("support\\xpbl\\mu_entrance");
						bn.a(true);
						bn.b(true);
						bn.a("guard");
						if (c5x5.h.b != null)
						{
							b2d b2d = new b2d();
							b2d.na(14);
							b2d.nc(20);
							b2d.d(60);
							foreach (coh coh in b2d.np())
							{
								if (coh is cd1)
								{
									euf.a(coh, null);
									c5x5.h.b.aa().Gear.j()[WeaponKey.Primary].a(coh as cd1, true);
								}
								else
								{
									c5x5.h.b.aa().Bag.z3(coh, true);
								}
							}
							c5x5.h.b.a("mghscavle2");
							c5x5.h.b.aa().FactionId = asp.fm;
						}
						if (c5x5.t.b != null)
						{
							c5x5.t.b.y6()[ddq.ay] = new bt4(csd.Name);
						}
						A_1.r()["loc_mu_newMutieGuardGuid"] = c5x5.qe();
					}
				}
				foreach (c5x c5x6 in new List<c5x>
				{
					new ar7(new Guid("db454d88-5f35-4ddb-a5fe-b7a2a6787f19"), A_0.n("xpbl_b7_1")).ao() as c5x,
					new ar7(new Guid("2b13bb0a-1446-4746-a3a8-4f44dadb4d61"), A_0.n("xpbl_b7_1")).ao() as c5x,
					new ar7(new Guid("45286e7e-d477-4480-98c1-e3acae9ee7b7"), A_0.n("xpbl_b7")).ao() as c5x
				})
				{
					if (c5x6 != null)
					{
						cnb cnb = c5x6.GetAspect<bim>() as cnb;
						if (cnb != null && cnb.q())
						{
							cnb.d(false);
						}
						d2b aspect = c5x6.GetAspect<d2b>();
						if (aspect != null && !aspect.n())
						{
							aspect.e(true);
						}
					}
				}
				c5x c5x7 = new ar7(new Guid("a724bedb-b74e-40a4-981e-2dc3654729b0"), A_0.n("xpbl_b7_1")).ao() as c5x;
				if (c5x7 != null)
				{
					bb2 bb = c5x7.GetAspect<bim>() as bb2;
					if (bb != null)
					{
						bb.a(20);
					}
					a7c a7c = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(A_0.n("xpbl_b7_1").Triggers, new Func<ya, bool>(a8d.a.a.a))) as a7c;
					if (a7c != null)
					{
						aq7 aq = Enumerable.FirstOrDefault<cze>(a7c.i()) as aq7;
						if (aq != null)
						{
							aq.a(20);
						}
					}
				}
			}
		}
		if (value4)
		{
			c5x c5x8 = new ar7(new Guid("5530751e-3a9a-4d30-8988-514fd9c18ef2"), A_0.n("xpbl_b7")).ao() as c5x;
			if (c5x8 != null && c5x8.t.b != null)
			{
				if (!flag)
				{
					if (!value)
					{
						c5x8.t.b.y6()[ddq.ay] = new bt4("kirill_wesley");
					}
					else if (!value2)
					{
						c5x8.t.b.y6()[ddq.ay] = new bt4("kirill_doctor");
					}
					else
					{
						c5x8.t.b.y6()[ddq.ay] = new bt4("kirill_front");
					}
				}
				else
				{
					c5x8.t.b.y6()[ddq.ay] = new bt4("kirill_mutiesEradicated");
				}
			}
		}
		c5x c5x9 = new ar7(new Guid("a33d3aeb-7ed4-401e-b6d5-9ad227ffde33"), A_0.n("xpbl_b7")).ao() as c5x;
		if (c5x9 != null)
		{
			d85 d = c5x9.GetAspect<bim>() as d85;
			if (d != null)
			{
				d.a().Clear();
				d.a().Add("Хорошо пахнет.");
			}
		}
	}

	// Token: 0x02000A42 RID: 2626
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003E3D RID: 15933 RVA: 0x00177968 File Offset: 0x00175B68
		internal bool a(ya A_0)
		{
			return A_0.Name == "SetDexterityCheckSkill";
		}

		// Token: 0x04001BB1 RID: 7089
		public static readonly a8d.a a = new a8d.a();

		// Token: 0x04001BB2 RID: 7090
		public static Func<ya, bool> b;
	}
}
