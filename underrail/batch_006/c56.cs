using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000CBC RID: 3260
[e79("Xpbl_KirillLab3_KirillArrivesToFightMuties")]
public sealed class c56 : dgy
{
	// Token: 0x0600496B RID: 18795 RVA: 0x001E7944 File Offset: 0x001E5B44
	public c56()
	{
		c56.a a = new c56.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null && a.a.aqw() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.b.i.b.a(true, false);
				a.c = (new ar7(new Guid("5530751e-3a9a-4d30-8988-514fd9c18ef2"), a.b.Area).ao() as c5x);
				c5x c5x = new ar7(new Guid("efbb0fc2-e2fc-47da-8ea9-656d261693d5"), a.b.Area).ao() as c5x;
				a.e = (new ar7(new Guid("9600112e-daa5-453d-b9bc-2b45a76e2982"), a.b.Area).ao() as c5x);
				a.f = (new ar7(new Guid("6901d7bc-787b-4ddf-8e50-5d20204b4eb0"), a.b.Area).ao() as c5x);
				a.a.aqu().r()["loc_xpbl_kirillBattleStarted"] = true;
				if (c5x != null)
				{
					c5x.an();
				}
				bv9 bv = a.a.aqu().ac() as bv9;
				if (bv != null)
				{
					bv.a(asp.gn, asp.a, h.a, null, true, true, false);
				}
				a.d = new List<a1q>();
				a.d.Add(new a1q(DamageType.Heat, 1000, 1500));
				List<b0b> list = a.b.Zone.a().ab4(new string[]
				{
					"xpbl_kirillLab3_acidValve"
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2.s.b != null)
						{
							c5x2.s.b.g(true);
						}
					}
				}
				if (a.c != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					e25 e = new e25();
					e.a(true);
					e.a("xpbl_kirillLab3");
					e.a(7f);
					e.a(new Guid?(new Guid("cb843fe7-ddc9-4c69-a35b-b293c3a1f689")));
					array2[num2] = new ace(e)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					kw kw = new kw();
					kw.a(new bt4("FromLadder"));
					kw.a(true);
					array3[num3] = kw;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array4[num4] = c8s;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx = new egx();
					egx.a("Где вы, мои маленькие крысы?");
					array5[num5] = new ace(egx)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx2 = new egx();
					egx2.a("Мои наглые маленькие крысы, осмеливающиеся кусать руку, которая вас кормит.");
					egx2.a(true);
					array6[num6] = new ace(egx2)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx3 = new egx();
					egx3.a("Ваша расплата пришла.");
					egx3.a(true);
					array7[num7] = new ace(egx3)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.ChannelPsi);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.c));
					bb.b(3);
					array8[num8] = bb;
					base.a(array8);
					btm[] array9 = new btm[1];
					int num9 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.Custom1);
					bb2.a(atp.a);
					bb2.IsAsync = true;
					bb2.a(new ar7(a.c));
					bb2.b(1);
					array9[num9] = bb2;
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.4))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					c6w c6w = new c6w();
					c6w.a(new ar7(a.c));
					c6w.IsAsync = false;
					c6w.a = new Func<auv>(a.a);
					array10[num10] = c6w;
					base.a(array10);
					btm[] array11 = new btm[1];
					int num11 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.b));
					array11[num11] = dva;
					base.a(array11);
					btm[] array12 = new btm[1];
					int num12 = 0;
					e2l e2l = new e2l();
					e2l.a("xpbl_kirillLab2");
					e2l.a(new aoh());
					array12[num12] = new ace(e2l);
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					e25 e2 = new e25();
					e2.a(false);
					e2.a("xpbl_kirillLab3");
					e2.a(0f);
					e2.a(new Guid?(new Guid("cb843fe7-ddc9-4c69-a35b-b293c3a1f689")));
					array13[num13] = new ace(e2)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array13);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000CBD RID: 3261
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600496D RID: 18797 RVA: 0x001E7FEC File Offset: 0x001E61EC
		internal bool a(e6d A_0)
		{
			a0l.a(this.c, "FromLadder", true);
			if (!this.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_betrayed", new bool?(false)).Value)
			{
				a0l.a(this.b, "player_ready", true);
				c5x c5x = new ar7(new Guid("d4dd539d-3f2e-40cd-aed5-eba77c0bc2f8"), this.b.Area).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("d98137b9-99eb-4833-aab5-8cbd6f77f6ad"), this.b.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("0c0404f7-ab36-4376-99e0-4cd1f15b9ad5"), this.b.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("5c1e5cfc-622a-44e0-8394-f0760434d9a0"), this.b.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("ed4c482b-8631-4eba-95f3-fa47c4f254bd"), this.b.Area).ao() as c5x;
				if (c5x != null)
				{
					a0l.a(c5x, "global:xpbl_juraj", true);
				}
				if (c5x2 != null)
				{
					a0l.a(c5x2, "global:xpbl_lars", true);
				}
				if (c5x3 != null)
				{
					a0l.a(c5x3, "global:xpbl_gritz", true);
				}
				if (c5x4 != null)
				{
					a0l.a(c5x4, "global:xpbl_senna", true);
				}
				if (c5x5 != null)
				{
					a0l.a(c5x5, "global:xpbl_ven", true);
				}
			}
			List<string> value = new List<string>
			{
				"Kirill_p1",
				"Kirill_p4",
				"Kirill_p2",
				"Kirill_p3",
				"Kirill_p4",
				"Kirill_p5"
			};
			if (this.a.aqu().ae() == GameDifficulty.Easy)
			{
				this.c.t.b.y6()[ddq.l] = 5000;
			}
			if (this.a.aqu().ae() == GameDifficulty.Normal)
			{
				this.c.t.b.y6()[ddq.l] = 4000;
			}
			if (this.a.aqu().ae() == GameDifficulty.Hard)
			{
				value = new List<string>
				{
					"Kirill_p1",
					"Kirill_p4",
					"Kirill_p2",
					"Kirill_p3",
					"Kirill_p3a",
					"Kirill_p4",
					"Kirill_p5"
				};
				this.c.t.b.y6()[ddq.l] = 3000;
			}
			if (this.a.aqu().ae() == GameDifficulty.Dominating)
			{
				value = new List<string>
				{
					"Kirill_p1",
					"Kirill_p4",
					"Kirill_p2",
					"Kirill_p3",
					"Kirill_p3a",
					"Kirill_p4",
					"Kirill_p5",
					"Kirill_p5a"
				};
				this.c.t.b.y6()[ddq.l] = 2000;
			}
			this.c.t.b.y6().RemoveProperty(ddq.ay);
			this.c.t.b.y6()[ddq.k] = value;
			return true;
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x001E839C File Offset: 0x001E659C
		internal auv a()
		{
			awx awx = new awx();
			awx.ad().Add(new a4s(new ai2(this.d, 1, 1000), new ar7(this.c), new ar7(this.c), null));
			awx.ad().Add(new bm3(350));
			awx.ad().Add(new a4s(new bi7(true), new ar7(this.c), null, null));
			return awx;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x001E8420 File Offset: 0x001E6620
		internal bool b(e6d A_0)
		{
			if (this.e != null && this.f != null && this.e.s != null)
			{
				this.e.s.b.g(false);
				this.e.o.b.b = new Point(2, 1);
				this.f.o.b.b = new Point(3, 1);
			}
			return true;
		}

		// Token: 0x04001D0B RID: 7435
		public cnk a;

		// Token: 0x04001D0C RID: 7436
		public c5x b;

		// Token: 0x04001D0D RID: 7437
		public c5x c;

		// Token: 0x04001D0E RID: 7438
		public List<a1q> d;

		// Token: 0x04001D0F RID: 7439
		public c5x e;

		// Token: 0x04001D10 RID: 7440
		public c5x f;
	}
}
