using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D36 RID: 3382
[e79("Cc_TchortistsAttack")]
public sealed class c6q : dgy
{
	// Token: 0x06004A75 RID: 19061 RVA: 0x001F9B8C File Offset: 0x001F7D8C
	public c6q()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c6q.a a = new c6q.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				c6q.b b = new c6q.b();
				b.f = a;
				b.a = (new ar7(new Guid("ae737bd0-a149-478c-a49d-83d4c64fea1a"), b.f.a.Area).ao() as c5x);
				b.b = (new ar7(new Guid("c75ac081-c7ef-4c11-ac49-20f297b95d69"), b.f.a.Area).ao() as c5x);
				b.c = new ar7();
				b.d = new ar7();
				b.e = new ar7();
				if (b.a != null && b.b != null)
				{
					serviceOrThrow.aqu().r()["global_sawTchoristsSnatchCube"] = true;
					serviceOrThrow.aqu().r()["loc_cc_knowTchortists"] = true;
					serviceOrThrow.aqu().a(new bw0("cc_s1", new an(), 1));
					serviceOrThrow.aqu().a(new bw0("cc_rf3", new eqd(), 0));
					List<string> list = new List<string>();
					for (int i = 1; i <= 23; i++)
					{
						list.Add("cc" + i.ToString());
					}
					list.Add("CC_utility");
					list.Add("CC_passage");
					list.Add("CC_abandoned");
					list.Add("CC_cityEnter");
					list.Add("CC_Warehouse");
					list.Add("CC_DOCK");
					foreach (string a_ in list)
					{
						serviceOrThrow.aqu().a(new bw0(a_, new dut(), 1));
					}
					serviceOrThrow.aqz().atb("infiltrateChurchOfTchort", true);
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(b.f.a));
					array[num] = dva;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("it3"));
					kw.a(false);
					kw.IsAsync = false;
					array2[num2] = kw;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					if (b.a.t.b != null && b.a.t.b.b(b.f.a.h.b, false))
					{
						btm[] array3 = new btm[1];
						int num3 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(b.e));
						array3[num3] = dva2;
						base.a(array3);
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s = new s5();
						s.a(new ar7(b.a));
						s.a(new bt4("greet"));
						s.IsAsync = false;
						s.a(true);
						array4[num4] = s;
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_cc_ct_researchFacility_started", new bool?(false)).Value)
						{
							btm[] array5 = new btm[1];
							int num5 = 0;
							egx egx = new egx();
							egx.a("Наконец-то вы здесь...");
							array5[num5] = new ace(egx)
							{
								TargetRef = new ar7(b.a)
							};
							base.a(array5);
						}
						else
						{
							btm[] array6 = new btm[1];
							int num6 = 0;
							egx egx2 = new egx();
							egx2.a("Вам сюда нельзя...");
							array6[num6] = new ace(egx2)
							{
								TargetRef = new ar7(b.a)
							};
							base.a(array6);
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
					}
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(b.f.b));
					array7[num7] = dva3;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(b.d));
					array8[num8] = dva4;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(b.i));
					array9[num9] = dva5;
					base.a(array9);
					btm[] array10 = new btm[1];
					int num10 = 0;
					s5 s2 = new s5();
					s2.a(b.c);
					s2.a(new bt4("it1"));
					s2.IsAsync = true;
					s2.a(true);
					array10[num10] = s2;
					base.a(array10);
					btm[] array11 = new btm[1];
					int num11 = 0;
					s5 s3 = new s5();
					s3.a(b.d);
					s3.a(new bt4("it2"));
					s3.IsAsync = true;
					s3.a(true);
					array11[num11] = s3;
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					egx egx3 = new egx();
					egx3.a("Вы ещё кто такие?");
					array12[num12] = new ace(egx3)
					{
						TargetRef = new ar7(b.b)
					};
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(b.h));
					array13[num13] = dva6;
					base.a(array13);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array14 = new btm[1];
					int num14 = 0;
					egx egx4 = new egx();
					egx4.a("Нет, пожалуйста!..");
					array14[num14] = new ace(egx4)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array14);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.5))
					});
					btm[] array15 = new btm[1];
					int num15 = 0;
					dva dva7 = new dva(null, null, null, null, null);
					dva7.a(new Func<e6d, bool>(b.g));
					array15[num15] = dva7;
					base.a(array15);
					btm[] array16 = new btm[1];
					int num16 = 0;
					s5 s4 = new s5();
					s4.a(b.e);
					s4.a(new bt4("it3"));
					s4.IsAsync = false;
					s4.a(true);
					array16[num16] = s4;
					base.a(array16);
					btm[] array17 = new btm[1];
					int num17 = 0;
					dva dva8 = new dva(null, null, null, null, null);
					dva8.a(new Func<e6d, bool>(b.f));
					array17[num17] = dva8;
					base.a(array17);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array18 = new btm[1];
					int num18 = 0;
					bb8 bb = new bb8();
					bb.a(b.e);
					bb.a(CharacterState.OperateShort);
					array18[num18] = bb;
					base.a(array18);
					base.a(new btm[]
					{
						new ace(new rp(1))
						{
							TargetRef = new ar7(new Guid("e892f94c-1256-4583-8e6c-3f2e7d341e5b"), b.f.a.Area)
						}
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array19 = new btm[1];
					int num19 = 0;
					dva dva9 = new dva(null, null, null, null, null);
					dva9.a(new Func<e6d, bool>(b.b));
					array19[num19] = dva9;
					base.a(array19);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array20 = new btm[1];
					int num20 = 0;
					s5 s5 = new s5();
					s5.a(b.e);
					s5.a(new bt4("tch1"));
					s5.IsAsync = true;
					s5.a(true);
					array20[num20] = s5;
					base.a(array20);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array21 = new btm[1];
					int num21 = 0;
					dva dva10 = new dva(null, null, null, null, null);
					dva10.a(new Func<e6d, bool>(b.a));
					array21[num21] = dva10;
					base.a(array21);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array22 = new btm[1];
					int num22 = 0;
					dva dva11 = new dva(null, null, null, null, null);
					dva11.a(new Func<e6d, bool>(b.c));
					array22[num22] = dva11;
					base.a(array22);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array23 = new btm[1];
					int num23 = 0;
					a5 a2 = new a5();
					a2.a(b.c);
					array23[num23] = a2;
					base.a(array23);
					btm[] array24 = new btm[1];
					int num24 = 0;
					a5 a3 = new a5();
					a3.a(b.d);
					array24[num24] = a3;
					base.a(array24);
					btm[] array25 = new btm[1];
					int num25 = 0;
					a5 a4 = new a5();
					a4.a(b.e);
					array25[num25] = a4;
					base.a(array25);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D37 RID: 3383
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A77 RID: 19063 RVA: 0x001FA58C File Offset: 0x001F878C
		internal bool a(e6d A_0)
		{
			this.a.i.b.a(true, false);
			return true;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x001FA5A8 File Offset: 0x001F87A8
		internal bool b(e6d A_0)
		{
			this.a.c().a("DestructableRocksDestroyed");
			int a_ = 3;
			for (int i = 2; i <= 3; i++)
			{
				ak1 ak = this.a.Area.b(i, a_);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						if (b0b.Layer == aju.x)
						{
							b0b.w();
							b0b.an();
						}
					}
					for (int j = 0; j <= cuo.a.Next(3); j++)
					{
						Vector3 a_2 = ak.Location.a() + new Vector3(-0.3f + (float)cuo.a.NextDouble() * 0.6f, -0.3f + (float)cuo.a.NextDouble() * 0.6f, 0.3f + (float)cuo.a.NextDouble() * 0.4f);
						no no = new no();
						no.a(new e6z(this.a.Area));
						no.a("Smoke");
						no.a(a_2);
						no.a(1);
						no.a(2147483647.0);
						no.ym(null, null, null);
						no no2 = new no();
						no2.a(new e6z(this.a.Area));
						no2.a("DestructableRocksExplosion");
						no2.a(a_2);
						no2.a(1);
						no2.a(2147483647.0);
						no2.ym(null, null, null);
					}
					c5x c5x = new c5x();
					c5x.Location = new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0.1f);
					c5x.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x.Layer = 1;
					c5x.IsGround = true;
					c5x.SetAspect<cd0>(new cd0(c5x)
					{
						a = "Objects\\Obstacles\\USDebris",
						b = new Point(i - 1, 0)
					});
					this.a.Area.a(c5x);
				}
			}
			aud aud = this.a.Zone.n("cc_rf3f");
			if (aud != null)
			{
				a_ = 14;
				for (int k = 10; k <= 13; k++)
				{
					ak1 ak2 = aud.b(k, a_);
					if (ak2 != null)
					{
						foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.Entities))
						{
							if (b0b2.Layer == aju.x)
							{
								b0b2.w();
								b0b2.an();
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x04001DC0 RID: 7616
		public c5x a;
	}

	// Token: 0x02000D38 RID: 3384
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A7A RID: 19066 RVA: 0x001FA8CC File Offset: 0x001F8ACC
		internal bool e(e6d A_0)
		{
			aw1.b(this.f.a, this.a, false);
			return true;
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x001FA8E8 File Offset: 0x001F8AE8
		internal bool d(e6d A_0)
		{
			aw1.b(this.a, this.f.a.Area.b(2, 3), false);
			aw1.b(this.b, this.f.a.Area.b(2, 3), false);
			aw1.b(this.f.a, this.f.a.Area.b(2, 3), false);
			return true;
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x001FA964 File Offset: 0x001F8B64
		internal bool i(e6d A_0)
		{
			c5x c5x = vq.a("creatures\\generichumans\\TchortistMissionary", this.f.a.Zone.g("tch1"), false);
			c5x.t.b.a("none");
			this.c.a(c5x);
			c5x c5x2 = vq.a("creatures\\generichumans\\TchortistMissionary", this.f.a.Zone.g("tch2"), false);
			c5x2.t.b.a("none");
			this.d.a(c5x2);
			return true;
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x001FAA00 File Offset: 0x001F8C00
		internal bool h(e6d A_0)
		{
			c5x c5x = this.c.ao() as c5x;
			c5x c5x2 = this.d.ao() as c5x;
			if (c5x != null && c5x2 != null)
			{
				c3n c3n = dgk.Get<dzs>();
				if (c3n != null)
				{
					c5x[] array = new c5x[]
					{
						c5x,
						c5x2
					};
					c5x[] array2 = new c5x[]
					{
						this.b,
						this.a
					};
					for (int i = 0; i < 2; i++)
					{
						eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(array[i].h.b)), null) as eu7;
						if (eu != null && eu.yw())
						{
							cp.b(eu, array[i], array2[i]);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x001FAADC File Offset: 0x001F8CDC
		internal bool g(e6d A_0)
		{
			c5x c5x = vq.a("creatures\\generichumans\\TchortistMissionary", this.f.a.Zone.g("tch1"), false);
			c5x.t.b.a("none");
			this.e.a(c5x);
			return true;
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x001FAB34 File Offset: 0x001F8D34
		internal bool f(e6d A_0)
		{
			aw1.b(this.f.a, this.e.ao(), false);
			return true;
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x001FAB54 File Offset: 0x001F8D54
		internal bool b(e6d A_0)
		{
			aw1.b(this.e.ao(), this.f.a, false);
			return true;
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x001FAB74 File Offset: 0x001F8D74
		internal bool a(e6d A_0)
		{
			(this.c.ao() as c5x).k.b.a(this.f.a.Zone.g("tch1").Tile, double.MaxValue, int.MaxValue, 0, true);
			return true;
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x001FABD4 File Offset: 0x001F8DD4
		internal bool c(e6d A_0)
		{
			(this.d.ao() as c5x).k.b.a(this.f.a.Zone.g("tch1").Tile, double.MaxValue, int.MaxValue, 0, true);
			return true;
		}

		// Token: 0x04001DC1 RID: 7617
		public c5x a;

		// Token: 0x04001DC2 RID: 7618
		public c5x b;

		// Token: 0x04001DC3 RID: 7619
		public ar7 c;

		// Token: 0x04001DC4 RID: 7620
		public ar7 d;

		// Token: 0x04001DC5 RID: 7621
		public ar7 e;

		// Token: 0x04001DC6 RID: 7622
		public c6q.a f;
	}
}
