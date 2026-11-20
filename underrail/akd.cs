using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A13 RID: 2579
[eiz("XPBLFUPA")]
[Serializable]
public sealed class akd : bdw, ISerializable
{
	// Token: 0x06003D63 RID: 15715 RVA: 0x0016D93C File Offset: 0x0016BB3C
	private akd(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D64 RID: 15716 RVA: 0x0016D944 File Offset: 0x0016BB44
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D65 RID: 15717 RVA: 0x0016D948 File Offset: 0x0016BB48
	public akd()
	{
	}

	// Token: 0x06003D66 RID: 15718 RVA: 0x0016D954 File Offset: 0x0016BB54
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_fu");
			aud aud2 = A_0.n("xpbl_fu_tunnel");
			if (serviceOrThrow != null)
			{
				doq a_;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackFailed", new bool?(false)).Value)
				{
					a_ = doq.a(Path.Combine(d5x.q(), "xpbl_fu_L3") + ".uzl");
					aud2.Zone.a(a_, 1, null);
					using (List<b0b>.Enumerator enumerator = Enumerable.ToList<b0b>(aud2.Entities).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							b0b b0b = enumerator.Current;
							c5x c5x = (c5x)b0b;
							if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.fr)
							{
								c5x.h.b.aa().a(null, null, false);
							}
						}
						goto IL_222;
					}
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value)
				{
					a_ = doq.a(Path.Combine(d5x.q(), "xpbl_fu_L2") + ".uzl");
					aud2.Zone.a(a_, 1, null);
					aud.Zone.a(a_, 1, null);
					c5x c5x2 = new ar7(new Guid("46ec2b51-8b38-45af-828c-167a8dd6b921"), aud2).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("cad74c10-7604-4168-9614-63166f01ecb3"), aud2).ao() as c5x;
					if (c5x2 != null)
					{
						c5x2.w();
						c5x2.an();
					}
					if (c5x3 != null)
					{
						c5x3.w();
						c5x3.an();
					}
					serviceOrThrow.aqu().r()["global_xpbl_aegisSecTroopersAvailable"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value - 3;
				}
				IL_222:
				a_ = doq.a(Path.Combine(d5x.q(), "xpbl_fu_L4") + ".uzl");
				aud.Zone.a(a_, 1, null);
				c5x c5x4 = new ar7(new Guid("975c4c3a-9615-4649-af9a-d9e6e92e6422"), aud).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("06613390-6066-4c9e-a29f-09137e027aea"), aud).ao() as c5x;
				if (c5x4 != null)
				{
					cd0 aspect = c5x4.GetAspect<cd0>();
					c5x4.TileFormationModifiers.c();
					c5x4.z();
					c5x4.VisualPriority = 1;
					if (aspect != null)
					{
						aspect.b.X = 3;
						aspect.b.Y = 0;
					}
				}
				if (c5x5 != null)
				{
					cd0 aspect2 = c5x5.GetAspect<cd0>();
					c5x5.TileFormationModifiers.c();
					c5x5.z();
					c5x5.VisualPriority = -1;
					if (aspect2 != null)
					{
						aspect2.b.X = 3;
						aspect2.b.Y = 0;
					}
				}
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
				{
					c5x c5x6 = new ar7(new Guid("e2d3c24a-ecec-4b83-bf89-21c26d511080"), aud2).ao() as c5x;
					c5x c5x7 = new ar7(new Guid("a26a1a52-2ba1-4a51-ad60-40a2f2a2b66e"), aud2).ao() as c5x;
					if (c5x6 != null)
					{
						cd0 aspect3 = c5x6.GetAspect<cd0>();
						c5x6.TileFormationModifiers.c();
						c5x6.z();
						if (aspect3 != null)
						{
							aspect3.b.X = 3;
							aspect3.b.Y = 0;
						}
					}
					if (c5x7 != null)
					{
						cd0 aspect4 = c5x7.GetAspect<cd0>();
						c5x7.TileFormationModifiers.c();
						c5x7.z();
						if (aspect4 != null)
						{
							aspect4.b.X = 3;
							aspect4.b.Y = 0;
						}
					}
				}
			}
		}
	}
}
