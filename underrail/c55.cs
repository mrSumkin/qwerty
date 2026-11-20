using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200112E RID: 4398
[euj]
public sealed class c55
{
	// Token: 0x06005E28 RID: 24104 RVA: 0x0027E0CC File Offset: 0x0027C2CC
	[ayh("CryoBarrel_Explode")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Area != null && A_1.Zone != null)
		{
			boj.a(A_1.Area, A_1.Location, null, "xphw_CryobarrelExplosion", 1, double.MaxValue, null, null, null, null);
			ak1 ak = Enumerable.FirstOrDefault<ak1>(A_1.l);
			if (ak == null)
			{
				return;
			}
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.Entities, new Func<b0b, bool>(c55.a.a.a))) as c5x;
			if (c5x != null)
			{
				c5x.c().a("CyrokinesisHit");
			}
			string a_ = null;
			if (A_2 != null && A_2.ContainsKey("killingBlow"))
			{
				cwt cwt = A_2["killingBlow"] as cwt;
				if (cwt != null && cwt.i != null)
				{
					a_ = cwt.i.b;
				}
			}
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			awb awb = new awb(ak, new c55.b(a_), null, 4f, null, null, false);
			awb.b(150.0);
			awb.r = true;
			qy.ad().Add(awb);
			A_1.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
	}

	// Token: 0x0200112F RID: 4399
	[eiz("CBEXAC")]
	[Serializable]
	public sealed class b : ISerializable, cci
	{
		// Token: 0x06005E2A RID: 24106 RVA: 0x0027E288 File Offset: 0x0027C488
		private b(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = A_0.GetString("CBEXAC:A");
			this.a = (A_0.GetValue("CBEXAC:P", typeof(HashSet<Guid>)) as HashSet<Guid>);
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0027E2D8 File Offset: 0x0027C4D8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("CBEXAC:A", this.b);
			info.AddValue("CBEXAC:P", this.a);
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x0027E2FC File Offset: 0x0027C4FC
		public b(string A_0)
		{
			this.b = A_0;
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x0027E31C File Offset: 0x0027C51C
		public void cq(aud A_0, Point A_1, float A_2)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak == null)
			{
				return;
			}
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "ColdHit";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = dz6.b();
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
			if (A_2 == 0f)
			{
				bpv.a("cryogas", (double)(3 + cuo.a.Next(2)), ak, this.b, true, false, new double?((double)350));
			}
			else if (A_2 < 2f)
			{
				bpv.a("cryogas", (double)(1 + cuo.a.Next(2)), ak, this.b, true, false, new double?((double)350));
			}
			if (!ak.Formation.c(2L))
			{
				int num;
				if (A_2 == 0f)
				{
					num = 3;
				}
				else if (A_2 < 2f)
				{
					num = cuo.a.Next(2, 4);
				}
				else if (A_2 < 4f)
				{
					num = cuo.a.Next(1, 3);
				}
				else
				{
					num = 1;
				}
				c5x c5x = vq.a("Floor\\IceFloor" + num.ToString(), ak.Zone, new bt4(ak.Area.y8(), ak.Location.a()), false);
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					if (aspect != null)
					{
						aspect.b.X = ((int)c5x.Location.X + (int)c5x.Location.Y % 3) % 3;
					}
					cm cm = new cm(c5x, (80 + cuo.a.Next(35)) * 100, true);
					cm.a(0.25);
					cm aspect2 = cm;
					c5x.SetAspect<cm>(aspect2);
				}
			}
			double num2 = 1.0 - (double)A_2 * 0.1;
			a1q a_6 = new a1q(DamageType.Cold, 25, 50);
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
			{
				c5x c5x2 = (c5x)b0b;
				if (!this.a.Contains(c5x2.qe()))
				{
					this.a.Add(c5x2.qe());
					if (c5x2.h.b != null)
					{
						double num3 = 0.05;
						euf.a(ref num3, null, c5x2.h.b.aa());
						cwt cwt = new cwt();
						cwt.i = new ap9("Крио взрыв", this.b);
						cwt.j = new ap9(c5x2.h.b.aa());
						cwt.l = true;
						cwt.b = true;
						cwt.e = (cuo.a.NextDouble() < num3);
						cwt.f.Add(euf.a(a_6, num2 * (double)(cwt.e ? 2 : 1)));
						cru cru = c5x2.h.b.aa().Defense.a(cwt);
						if (cru != null && cru.a != null && cru.a.Count > 0)
						{
							if (Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.a, new Func<csk, bool>(c55.b.a.a.b)), new Func<csk, int>(c55.b.a.a.a)) > 0)
							{
								awq.e(c5x2.h.b);
								double num4 = 1.0 - c5x2.h.b.aa().Defense.af()[DamageType.Cold].c();
								double num5 = 0.2;
								b34 b = Enumerable.FirstOrDefault<b34>(c5x2.h.b.aa().StatusEffects.Get<b34>());
								if (b != null)
								{
									num5 += (double)b.Stacks * 0.1;
								}
								bool flag = c5x2.h.b.aa().d(CharacterImmunities.Freeze);
								bool flag2 = c5x2.h.b.aa().d(CharacterImmunities.Chill);
								if (cuo.a.NextDouble() < num5 && (!flag || flag2))
								{
									if (flag || num4 <= 0.0)
									{
										etm a_7 = new etm(new ap9(c5x2.h.b.aa()), "заморозке");
										bey.a(a_7, null, c5x2.h.b.aa(), c5x2.h.b);
										a7v.a(a_7);
										bmj.a(c5x2, new ba0());
									}
									else
									{
										c5x2.c().a("cryostasis", "Cryostasis", 1f, c9z.a, false, false);
										d4l.a(c5x2);
										b34 b2 = Enumerable.FirstOrDefault<b34>(Enumerable.OfType<b34>(c5x2.h.b.aa().StatusEffects.d()));
										int num6 = 0;
										if (b2 != null)
										{
											num6 = b2.Stacks;
										}
										int num7 = (int)((double)((2 + num6) * d0u.b) * (1.0 - c5x2.h.b.aa().Defense.af()[DamageType.Cold].c()));
										if (num7 > 0)
										{
											if (!c5x2.h.b.aa().SpecialStates.a && !c5x2.h.b.aa().SpecialStates.h)
											{
												a20.a(c5x2, null, new CombatSpeakEvent[]
												{
													CombatSpeakEvent.Hit_Frozen
												});
											}
											dtb dtb = new dtb();
											dtb.ad().Add(new aro(c5x2.h.b));
											amd item = new amd(c5x2.h.b, new els[]
											{
												new a2(num7, null)
											});
											dtb.ad().Add(item);
											dtb.ad().Add(new eae("CAH_HandleFreezing", null, new ar7(c5x2), null));
											awq.b(dtb, c5x2.h.b);
											if (this.b == asp.a && !c5x2.IsPlayer)
											{
												cxc.a(eyy.bx);
											}
											vr a_8 = new vr(new ap9(c5x2.h.b.aa()), null, "{0}: заморозка.", new Color?(adi.j), null);
											bey.a(a_8, null, c5x2.h.b.aa(), c5x2.h.b);
											anw item2 = new anw(a_8);
											dtb.ad().Add(item2);
											c5x2.Zone.ActionManager.g9(dtb, atp.a);
											if (c5x2.t.b != null)
											{
												be9 item3 = new be9(c5x2.t.b);
												dtb.ad().Add(item3);
											}
											dz6.a(dtb);
										}
										else
										{
											c6f a_9 = new c6f(new ap9(c5x2.h.b.aa()), null, "криокинетической заморозке");
											bey.a(a_9, null, c5x2.h.b.aa(), c5x2.h.b);
											a7v.a(a_9);
											bmj.a(c5x2, new dym());
										}
									}
								}
								else if (flag2 || num4 <= 0.0)
								{
									etm a_10 = new etm(new ap9(c5x2.h.b.aa()), "эффекту переохлаждения");
									bey.a(a_10, null, c5x2.h.b.aa(), c5x2.h.b);
									a7v.a(a_10);
									bmj.a(c5x2, new ba0());
								}
								else
								{
									c5x2.h.b.aa().StatusEffects.a(new b34(h7.h, h7.i), false, false, false);
									awq.c(c5x2.h.b);
									if (!c5x2.h.b.aa().SpecialStates.a && !c5x2.h.b.aa().SpecialStates.h)
									{
										a20.a(c5x2, null, new CombatSpeakEvent[]
										{
											CombatSpeakEvent.Hit_Frost
										});
									}
									if (this.b == asp.a && !c5x2.IsPlayer)
									{
										cxc.a(eyy.bw);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x04002575 RID: 9589
		private HashSet<Guid> a = new HashSet<Guid>();

		// Token: 0x04002576 RID: 9590
		private string b;

		// Token: 0x02001130 RID: 4400
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06005E30 RID: 24112 RVA: 0x0027ECA8 File Offset: 0x0027CEA8
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Cold;
			}

			// Token: 0x06005E31 RID: 24113 RVA: 0x0027ECB4 File Offset: 0x0027CEB4
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04002577 RID: 9591
			public static readonly c55.b.a a = new c55.b.a();

			// Token: 0x04002578 RID: 9592
			public static Func<csk, bool> b;

			// Token: 0x04002579 RID: 9593
			public static Func<csk, int> c;
		}
	}

	// Token: 0x02001131 RID: 4401
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005E34 RID: 24116 RVA: 0x0027ECD4 File Offset: 0x0027CED4
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0400257A RID: 9594
		public static readonly c55.a a = new c55.a();

		// Token: 0x0400257B RID: 9595
		public static Func<b0b, bool> b;
	}
}
