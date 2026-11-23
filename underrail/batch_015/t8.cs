using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D8F RID: 3471
[e79("Xpbl_Tarla_PushRock")]
public sealed class t8 : dgy
{
	// Token: 0x06004B54 RID: 19284 RVA: 0x00208588 File Offset: 0x00206788
	public t8()
	{
		t8.a a = new t8.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.c = a.b.Area;
				a.d = a.a.aqw().n("xpbl_tarla7_down");
				if (a.c != null)
				{
					t8.b b = new t8.b();
					b.c = a;
					b.a = (new ar7(new Guid("4a60034f-81cd-4a79-82f4-b4d343c12f59"), b.c.b.Area).ao() as c5x);
					b.b = (new ar7(new Guid("c110a879-4646-4b91-8a6c-e01aa3a54529"), b.c.b.Area).ao() as c5x);
					to to = b.c.a.aqu().v().BaseAbilities.b("Strength");
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(b.c.b));
					s.a(new bt4("PushRock"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.ChannelPsi);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(b.c.b));
					bb.b(3);
					array2[num2] = bb;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx = new egx();
					egx.a("Ну же!");
					array3[num3] = new ace(egx)
					{
						TargetRef = new ar7(b.c.b)
					};
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.ChannelPsi);
					bb2.a(atp.a);
					bb2.IsAsync = false;
					bb2.a(new ar7(b.c.b));
					bb2.b(3);
					array4[num4] = bb2;
					base.a(array4);
					if (to.g() >= 9 && b.a != null)
					{
						btm[] array5 = new btm[1];
						int num5 = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(b.c.c));
						array5[num5] = dva;
						base.a(array5);
						if (b.c.d != null)
						{
							btm[] array6 = new btm[1];
							int num6 = 0;
							dva dva2 = new dva(null, null, null, null, null);
							dva2.a(new Func<e6d, bool>(b.c.b));
							array6[num6] = dva2;
							base.a(array6);
						}
						btm[] array7 = new btm[1];
						int num7 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(b.b));
						array7[num7] = dva3;
						base.a(array7);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						a5 a2 = new a5();
						a2.a(new ar7(b.a));
						a2.c(false);
						array8[num8] = a2;
						base.a(array8);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array9 = new btm[1];
						int num9 = 0;
						dva dva4 = new dva(null, null, null, null, null);
						dva4.a(new Func<e6d, bool>(b.a));
						array9[num9] = dva4;
						base.a(array9);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array10 = new btm[1];
						int num10 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(b.c.b));
						s2.a(new bt4("StandBack"));
						s2.IsAsync = true;
						s2.a(true);
						array10[num10] = s2;
						base.a(array10);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array11 = new btm[1];
						int num11 = 0;
						dva dva5 = new dva(null, null, null, null, null);
						dva5.a(new Func<e6d, bool>(b.c.a));
						array11[num11] = dva5;
						base.a(array11);
						b.c.a.aqu().r()["xpbl_tarla_rockPushed"] = true;
					}
					else
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array12 = new btm[1];
						int num12 = 0;
						egx egx2 = new egx();
						egx2.a("Гадство.");
						array12[num12] = new ace(egx2)
						{
							TargetRef = new ar7(b.c.b)
						};
						base.a(array12);
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D90 RID: 3472
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B56 RID: 19286 RVA: 0x00208B20 File Offset: 0x00206D20
		internal bool c(e6d A_0)
		{
			Vector3 a_ = this.c.b(5, 2).Location.a() + new Vector3(-0.3f + (float)cuo.a.NextDouble() * 0.6f, -0.3f + (float)cuo.a.NextDouble() * 0.6f, 0.3f + (float)cuo.a.NextDouble() * 0.4f);
			c5x c5x = new ar7(new Guid("083e4685-4ab7-4d7f-9b83-abe99f641315"), this.b.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.c().a("DestructableRocksDestroyed");
			}
			no no = new no();
			no.a(new e6z(this.b.Area));
			no.a("Smoke");
			no.a(a_);
			no.a(1);
			no.a(2147483647.0);
			no.ym(null, null, null);
			c5x c5x2 = new ar7(new Guid("082b377b-2480-46c6-be97-48674be07d00"), this.b.Area).ao() as c5x;
			if (c5x2 != null)
			{
				bb2 bb = c5x2.GetAspect<bim>() as bb2;
				if (bb != null)
				{
					List<cze> list = bb.s();
					int index = 1;
					doj doj = new doj();
					doj.a(60);
					list[index] = doj;
				}
			}
			return true;
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x00208C74 File Offset: 0x00206E74
		internal bool b(e6d A_0)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.d.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && c5x.Location.X == 20f && c5x.Location.Y == 8f)
				{
					c5x.h.b.aa().a(null, null, false);
				}
			}
			c5x c5x2 = new ar7(new Guid("4e5593e3-0f47-4c4e-bca6-d3213929fea4"), this.b.Area).ao() as c5x;
			if (c5x2 != null)
			{
				a0l.a(c5x2, "RockFall", true);
				c5x2.ah();
			}
			return true;
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x00208D6C File Offset: 0x00206F6C
		internal bool a(e6d A_0)
		{
			int num = 1;
			d60 d = this.c.Zone.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"tarla_spiders"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null)
					{
						a0l.a(c5x, "moveSpider" + num.ToString(), true);
						num++;
					}
				}
			}
			return true;
		}

		// Token: 0x04001E3D RID: 7741
		public cnk a;

		// Token: 0x04001E3E RID: 7742
		public c5x b;

		// Token: 0x04001E3F RID: 7743
		public aud c;

		// Token: 0x04001E40 RID: 7744
		public aud d;
	}

	// Token: 0x02000D91 RID: 3473
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B5A RID: 19290 RVA: 0x00208E18 File Offset: 0x00207018
		internal bool b(e6d A_0)
		{
			this.a.TileFormationModifiers.c();
			this.a.z();
			this.b.TileFormationModifiers.c();
			this.b.z();
			a0l.a(this.a, "RockFalls", true);
			this.a.ah();
			return true;
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00208E78 File Offset: 0x00207078
		internal bool a(e6d A_0)
		{
			this.b.TileFormationModifiers = new bjp(new byte[]
			{
				1
			});
			this.b.z();
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ane(1000, null, null, null, null, null);
			}
			if (this.c.a.aqu().v() != null && this.c.b != null)
			{
				this.c.b.c().a("EarthquakeShort");
			}
			dwc dwc = new dwc();
			dwc.a(new Guid("262312de-60c4-4f93-a026-5bc918455e78"));
			dwc.a(new bt4("DispatchSpiders"));
			dwc.ym(this.c.b, null, null);
			return true;
		}

		// Token: 0x04001E41 RID: 7745
		public c5x a;

		// Token: 0x04001E42 RID: 7746
		public c5x b;

		// Token: 0x04001E43 RID: 7747
		public t8.a c;
	}
}
