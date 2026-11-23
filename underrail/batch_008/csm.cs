using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Data;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200076E RID: 1902
public sealed class csm : dzt
{
	// Token: 0x0600301C RID: 12316 RVA: 0x00124BE4 File Offset: 0x00122DE4
	public void v5(cp9 A_0, b3u A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num;
		int num2;
		int num3;
		int num4;
		int num5;
		int height;
		if (serviceOrThrow.aq1().b().l() == InterfaceElementSize2.Huge)
		{
			num = 200;
			num2 = 34;
			num3 = 18;
			num4 = 20;
			num5 = 12;
			height = 35;
			this.g = new Point(1, 168);
			this.f = new Vector2(64f, 32f);
		}
		else if (serviceOrThrow.aq1().b().l() == InterfaceElementSize2.ExtraLarge)
		{
			num = 160;
			num2 = 30;
			num3 = 16;
			num4 = 17;
			num5 = 10;
			height = 30;
			this.g = new Point(1, 142);
			this.f = new Vector2(48f, 24f);
		}
		else if (serviceOrThrow.aq1().b().l() == InterfaceElementSize2.Large)
		{
			num = 120;
			num2 = 27;
			num3 = 14;
			num4 = 14;
			num5 = 8;
			height = 25;
			this.f = new Vector2(32f, 16f);
			this.g = Point.Zero;
		}
		else
		{
			num = 100;
			num2 = 20;
			num3 = 9;
			num4 = 9;
			num5 = 5;
			height = 18;
			this.f = new Vector2(32f, 16f);
			this.g = Point.Zero;
		}
		mv mv = A_1.a as mv;
		if (mv.l)
		{
			return;
		}
		c5x c5x = A_1.b.b as c5x;
		bool flag = (c5x.g & e2b.a) == e2b.a;
		if (flag && c5x.h.b.aa().Ethereal)
		{
			return;
		}
		e5q e5q = (e5q)A_1.b;
		if (!e5q.a && !flag && !e5q.b && e5q.d == null)
		{
			return;
		}
		ps service = bpo.GetService<ps>();
		if (service != null && !service.ale() && !service.ald())
		{
			return;
		}
		bool flag2 = e5q.b != mv.o && mv.m && e5q.d != null;
		bool flag3 = false;
		ad5 ad = null;
		if (flag)
		{
			ad = (c5x.i.b.a() as ad5);
			if (ad == null)
			{
				dtb dtb = c5x.i.b.a() as dtb;
				if (dtb != null)
				{
					ad = (dtb.aa() as ad5);
				}
			}
			if (ad != null && (ad.aa() is pl || (ad.aa() is d5g && (ad.aa() as d5g).aa() is boa)))
			{
				flag3 = true;
			}
		}
		cmh cmh;
		if (mv.r != null)
		{
			cmh = mv.r.ai0(c5x);
		}
		else
		{
			cmh = null;
		}
		bool flag4 = false;
		if (e5q.a || flag3 || flag2 || cmh != null)
		{
			ey0.a(mv, e5q);
			flag4 = true;
			int num6 = e5q.i;
			int? num7 = null;
			dwt aspect = c5x.GetAspect<dwt>();
			if (aspect != null && aspect.a != null)
			{
				num7 = aspect.a;
			}
			else if (c5x.h.b != null && c5x.h.b.g != null && c5x.h.b.g.f != 0)
			{
				num7 = new int?(c5x.h.b.g.f);
			}
			if (num7 != null)
			{
				double num8 = 1.0 / Math.Pow(1.075, (double)(mv.y - 1f));
				int y = e5q.o.Value.Y;
				int? num9 = num7;
				float? num10 = (num9 != null) ? new float?((float)num9.GetValueOrDefault()) : null;
				float p = e5q.p;
				num6 = y - (int)(((num10 != null) ? new double?((double)(num10.GetValueOrDefault() * p)) : null) * num8 * (double)mv.y).Value;
			}
			num6 -= num2 / 2;
			if (cmh != null && mv.ad)
			{
				csm.a(mv, A_0, cmh, num6, e5q.m);
			}
			string text = c5x.LocalizedName ?? string.Empty;
			int num11 = (int)Math.Max((float)num, ci7.f().MeasureString(text).X) + (int)csm.a.X * 2;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			if (e5q.a && !(c5x.s.b is cnb))
			{
				bbw aspect2 = c5x.GetAspect<bbw>();
				if (aspect2 != null)
				{
					Vector2 vector = new Vector2((float)((int)((float)e5q.l - csm.c.X + (float)aspect2.ta().X)), (float)((int)((float)e5q.n - csm.c.Y / 2f + (float)aspect2.ta().Y)));
					A_0.b().w5(ci7.k(), vector, new Rectangle?(new Rectangle(0, 0, (int)csm.c.X, (int)csm.c.Y)), Color.White * 0.75f);
					if (aspect2.s6() > 0 && aspect2.s8() > 0.0)
					{
						double num12 = aspect2.s8() / (double)aspect2.s6();
						int num13 = (int)Math.Max(1.0, Math.Ceiling((double)csm.c.Y * num12));
						A_0.b().w5(ci7.k(), vector + new Vector2(0f, (float)((int)csm.c.Y - num13)), new Rectangle?(new Rectangle((int)csm.c.X, Math.Max(0, (int)csm.c.Y - num13), (int)csm.c.X, num13)), Color.White * 0.75f);
					}
					wv wv = c5x.GetAspect<bim>() as wv;
					if (wv != null)
					{
						Vector2 vector2 = new Vector2((float)((int)((float)e5q.l - csm.d.X - 47f)), (float)((int)((float)e5q.n - csm.d.Y / 2f)));
						A_0.b().w5(ci7.j(), vector2, new Rectangle?(new Rectangle(0, 0, (int)csm.c.X, (int)csm.c.Y)), Color.White * 0.55f);
						if (wv.e() > 0 && wv.h() > 0.0)
						{
							double num14 = wv.h() / (double)wv.e();
							int num15 = (int)Math.Max(1.0, Math.Ceiling((double)csm.d.Y * num14));
							A_0.b().w5(ci7.j(), vector2 + new Vector2(0f, (float)((int)csm.d.Y - num15)), new Rectangle?(new Rectangle((int)csm.d.X, Math.Max(0, (int)csm.d.Y - num15), (int)csm.d.X, num15)), Color.White * 0.75f);
						}
					}
				}
				if (flag)
				{
					IBoundVariable<float> boundVariable = new csm.a(c5x.h.b.aa().Defense);
					flag5 = (boundVariable != null && boundVariable.zm() > 0f);
					flag6 = (c5x.h.b.aa().Vehicle != null);
					flag7 = c5x.h.b.aa().PsiEmpathy;
					if (flag5)
					{
						num6 -= num3 / 2;
					}
					if (flag6)
					{
						num6 -= num4 / 2;
					}
					Rectangle a_ = new Rectangle(e5q.m - num11 / 2, num6, num11, num2);
					IBoundVariable<float> boundVariable2 = c5x.h.b.aa().Defense.q();
					float a_2;
					if (boundVariable2.zm() != 0f)
					{
						a_2 = boundVariable2.zo() / boundVariable2.zm();
					}
					else
					{
						a_2 = 0f;
					}
					h key = c5x.h.b.aa().a(serviceOrThrow.aqu().ac(), asp.a);
					Color a_3;
					Color white;
					if (c5x.h.b.aa().Passive)
					{
						a_3 = Color.SandyBrown;
						white = Color.White;
					}
					else
					{
						a_3 = adi.ae[key];
						white = Color.White;
					}
					eap.a(A_0, a_, text, csm.a + new Vector2(0f, (float)egg.b(ci7.e())), ci7.f(), a_3, a_2, white);
					if (flag5)
					{
						Rectangle a_4 = new Rectangle(e5q.m - num11 / 2, num6 + num2, num11, num3);
						float a_5 = boundVariable.zo() / boundVariable.zm();
						eap.a(A_0, a_4, null, Vector2.Zero, null, adi.al, a_5, Color.White);
					}
					if (flag6)
					{
						Rectangle a_6 = new Rectangle(e5q.m - num11 / 2, num6 + num2, num11, num4);
						float a_7 = (float)Math.Min(1.0, c5x.h.b.aa().Vehicle.ag() / (double)Math.Max(1, c5x.h.b.aa().Vehicle.v()));
						eap.a(A_0, a_6, null, Vector2.Zero, null, Color.White, a_7, Color.White);
					}
					if (flag7)
					{
						Rectangle a_8 = new Rectangle(e5q.m - num11 / 2, num6 + num2 + (flag5 ? num3 : 0) + (flag6 ? num4 : 0), num11, num5);
						float a_9 = c5x.h.b.aa().Offense.aa().zo() / Math.Max(1f, c5x.h.b.aa().Offense.aa().zm());
						eap.a(A_0, a_8, null, Vector2.Zero, null, adi.f, a_9, Color.White);
					}
					if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
					{
						amc aspect3 = serviceOrThrow.aqu().v().b().GetAspect<amc>();
						if (aspect3 != null && aspect3.aa().Feats.Contains<dbe>() && awq.a(aspect3, c5x.h.b, serviceOrThrow.aqu().v().Offense.u()))
						{
							Vector2 a_10 = new Vector2((float)(a_.Location.X - 20), (float)a_.Location.Y);
							if (flag2)
							{
								a_10.X -= this.f.X;
							}
							A_0.b().w5(ci7.i(), a_10, new Rectangle?(new Rectangle(0, 119, 19, 22)), adi.d * 0.7f);
						}
					}
				}
				else
				{
					Vector2 vector3 = ci7.f().MeasureString(text);
					Color lightGray;
					if (c5x.r.b != null)
					{
						lightGray = adi.g;
					}
					else
					{
						c7j c7j = c5x.s.b as c7j;
						if (c7j != null && c7j.Inspected)
						{
							lightGray = new Color(160, 160, 160);
						}
						else
						{
							lightGray = Color.LightGray;
						}
					}
					Vector2 a_11 = new Vector2((float)e5q.m - vector3.X / 2f, (float)num6 + csm.a.Y + (float)egg.b(ci7.e()));
					A_0.b().xb(ci7.f(), text, a_11, lightGray);
				}
			}
			if (flag3)
			{
				string text2 = (ad.aa() as afq).vg().e().b(ad.h());
				int num16 = (int)Math.Max((float)num11, ci7.f().MeasureString(text2).X) + (int)csm.a.X * 2;
				Rectangle a_12 = new Rectangle(e5q.m - num16 / 2, num6 + num2 + (flag5 ? num3 : 0) + (flag7 ? num5 : 0) + (flag6 ? num4 : 0), num16, height);
				pl pl = ad.aa() as pl;
				float num17 = 1f;
				if (pl != null)
				{
					if (pl.f() != 0)
					{
						num17 = (float)(pl.e() / (double)pl.f());
					}
				}
				else
				{
					boa boa = (ad.aa() as d5g).aa() as boa;
					if (boa.ChannellingTime != 0)
					{
						num17 = 1f - (float)(boa.TimePassed / (double)boa.ChannellingTime);
					}
				}
				if (num17 > 1f)
				{
					num17 = 1f;
				}
				eap.a(A_0, a_12, text2, csm.b + new Vector2(0f, (float)egg.b(ci7.e())), ci7.f(), csm.e, num17, Color.White);
			}
			if (flag2)
			{
				bool flag8 = false;
				Vector2 vector4;
				if (e5q.a)
				{
					vector4 = new Vector2((float)(e5q.m - num11 / 2) - this.f.X - 3f, (float)(num6 + 2));
				}
				else
				{
					vector4 = new Vector2((float)e5q.m - this.f.X / 2f, (float)num6);
				}
				Color color;
				if (e5q.g)
				{
					color = Color.Silver;
				}
				else
				{
					if (mv.ab != null && flag)
					{
						flag8 = (bui.a(c5x.h.b.aa().Detection, mv.ab.Skills.Get<a2n>().g()) && !c5x.h.b.aa().SpecialStates.c && !c5x.h.b.aa().SpecialStates.j);
					}
					if (flag8)
					{
						color = adi.aj[cem.d];
					}
					else
					{
						color = adi.aj[e5q.d.Value];
					}
				}
				if (!e5q.g && !flag8)
				{
					double num18 = e5q.e / aiy.b3[e5q.d.Value];
					int num19 = (int)((double)this.f.Y * (1.0 - num18));
					A_0.b().w5(ci7.i(), vector4 + new Vector2(0f, (float)num19), new Rectangle?(new Rectangle(this.g.X + (int)this.f.X, this.g.Y + num19, (int)this.f.X, (int)this.f.Y - num19)), color * 0.4f);
				}
				else
				{
					float scale = (float)Math.Abs(mv.d() % 17 - 8) / 8f * 0.75f;
					A_0.b().w5(ci7.i(), vector4, new Rectangle?(new Rectangle(this.g.X + (int)this.f.X, this.g.Y, (int)this.f.X, (int)this.f.Y)), color * scale);
				}
				A_0.b().w5(ci7.i(), vector4, new Rectangle?(new Rectangle(this.g.X, this.g.Y, (int)this.f.X, (int)this.f.Y)), color);
			}
		}
		if (flag && e5q.h != null)
		{
			if (!flag4)
			{
				ey0.a(mv, e5q);
			}
			int num20 = e5q.i;
			if (c5x.h.b != null && c5x.h.b.g != null && c5x.h.b.g.f != 0)
			{
				num20 = e5q.o.Value.Y - (int)((float)c5x.h.b.g.f * e5q.p * mv.y);
			}
			num20 -= num2 / 2;
			int num21 = dcl.a();
			Rectangle a_13 = new Rectangle(e5q.m - 48, num20, 96, 48);
			Rectangle value = new Rectangle(96 * num21, 144, 96, 48);
			A_0.b().w6(ci7.m(), a_13, new Rectangle?(value), adi.ai[e5q.h.Value] * 0.6f);
		}
	}

	// Token: 0x0600301D RID: 12317 RVA: 0x00125E7C File Offset: 0x0012407C
	private static void a(mv A_0, cp9 A_1, cmh A_2, int A_3, int A_4)
	{
		int num = A_0.s.b().w().b();
		TimeSpan totalGameTime = A_0.t.a().TotalGameTime;
		foreach (a7b a7b in A_2.c())
		{
			double num2 = a7b.a(totalGameTime, (double)num);
			float scale = (float)((num2 > 0.7) ? (1.0 - (num2 - 0.7) / 0.3) : 1.0);
			string text = a7b.b().si() ? ci7.c() : ci7.d();
			SpriteFont systemAsset = ci7.GetSystemAsset<SpriteFont>(text);
			int num3 = egg.b(text);
			c3i c3i;
			if (a7b.b().sf() != null)
			{
				c3i = ejh.b(a7b.b().sf(), A_1.a);
			}
			else
			{
				c3i = null;
			}
			int num4 = (int)systemAsset.MeasureString(a7b.b().sg()).X;
			Vector2 vector = new Vector2((float)(A_4 - num4 / 2), (float)((double)A_3 - 80.0 * num2 + (double)num3));
			A_1.b().xb(systemAsset, a7b.b().sg(), vector, a7b.b().sh() * scale);
			if (c3i != null)
			{
				Rectangle a_ = new Rectangle((int)(vector.X + (float)num4), (int)vector.Y - num3, systemAsset.LineSpacing, systemAsset.LineSpacing);
				c3i.a(A_1, a_, Color.White, 0, null);
			}
		}
	}

	// Token: 0x04001A4E RID: 6734
	private static readonly Vector2 a = new Vector2(3f, 2f);

	// Token: 0x04001A4F RID: 6735
	private static readonly Vector2 b = new Vector2(3f, 0f);

	// Token: 0x04001A50 RID: 6736
	private static readonly Vector2 c = new Vector2(5f, 59f);

	// Token: 0x04001A51 RID: 6737
	private static readonly Vector2 d = new Vector2(5f, 59f);

	// Token: 0x04001A52 RID: 6738
	private static readonly Color e = adi.a;

	// Token: 0x04001A53 RID: 6739
	private Vector2 f = new Vector2(32f, 16f);

	// Token: 0x04001A54 RID: 6740
	private Point g;

	// Token: 0x0200076F RID: 1903
	private sealed class a : IBoundVariable<float>
	{
		// Token: 0x06003020 RID: 12320 RVA: 0x001260EC File Offset: 0x001242EC
		public a(nw A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x001260FC File Offset: 0x001242FC
		public float zk()
		{
			return 0f;
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00126104 File Offset: 0x00124304
		public void zl(float A_0)
		{
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x00126108 File Offset: 0x00124308
		public float zm()
		{
			return (float)this.a.p();
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x00126118 File Offset: 0x00124318
		public void zn(float A_0)
		{
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x0012611C File Offset: 0x0012431C
		public float zo()
		{
			return (float)this.a.i5();
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x0012612C File Offset: 0x0012432C
		public void zp(float A_0)
		{
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00126130 File Offset: 0x00124330
		[CompilerGenerated]
		public void zq(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.b;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.b, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00126168 File Offset: 0x00124368
		[CompilerGenerated]
		public void zr(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.b;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.b, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x001261A0 File Offset: 0x001243A0
		[CompilerGenerated]
		public void zs(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.c;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x001261D8 File Offset: 0x001243D8
		[CompilerGenerated]
		public void zt(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.c;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00126210 File Offset: 0x00124410
		[CompilerGenerated]
		public void zu(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x00126248 File Offset: 0x00124448
		[CompilerGenerated]
		public void zv(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x04001A55 RID: 6741
		private nw a;

		// Token: 0x04001A56 RID: 6742
		[CompilerGenerated]
		private EventHandler<c1> b;

		// Token: 0x04001A57 RID: 6743
		[CompilerGenerated]
		private EventHandler<c1> c;

		// Token: 0x04001A58 RID: 6744
		[CompilerGenerated]
		private EventHandler<c1> d;
	}
}
