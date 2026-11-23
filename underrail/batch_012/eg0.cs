using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Game.Data;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000776 RID: 1910
public sealed class eg0 : c86
{
	// Token: 0x06003068 RID: 12392 RVA: 0x00128E5C File Offset: 0x0012705C
	public override bym aiy(b0b A_0, dnn A_1, e6d A_2, a44 A_3)
	{
		c5x c5x = (c5x)A_0;
		if (!A_1.i.a && A_1.h.a != edg.a && c5x.ag != null && A_0.Area != null && !A_0.Area.b((int)A_0.Location.X + c5x.ag.Value.X, (int)A_0.Location.Y + c5x.ag.Value.Y).a(dm9.b))
		{
			return null;
		}
		if (!A_3.b && c5x.d)
		{
			return null;
		}
		b4h b = c5x.r.b;
		if (b != null && !b.j() && !A_1.i.a)
		{
			return null;
		}
		a7m a7m = (a7m)A_1;
		mv mv = a7m as mv;
		d69 d = A_1 as d69;
		if (d != null)
		{
			djr aspect = c5x.GetAspect<djr>();
			if (aspect != null && aspect.a())
			{
				ay0 aspect2 = c5x.GetAspect<ay0>();
				if (aspect2 != null && aspect2.a() == MapNodeState.Revealed && c5x.o.b != null)
				{
					c5x.o.b.b = new Point(c5x.o.b.b.X, (d.an2() == c5x) ? 1 : 0);
				}
			}
		}
		e5q e5q = null;
		amc b2 = c5x.h.b;
		if (b2 != null && !A_3.b && !b2.ae())
		{
			return null;
		}
		if (b2 != null && !b2.a7())
		{
			if ((A_3.b || b2.ae()) && b2 != null)
			{
				e5q = this.a(a7m, c5x, b2, A_2);
			}
		}
		else if (c5x.p.b != null)
		{
			e5q = this.a(a7m, c5x, c5x.p.b, A_3);
		}
		else if (c5x.q.b != null)
		{
			e5q = this.a(a7m, c5x, c5x.q.b, A_3);
		}
		else
		{
			cd0 b3 = c5x.o.b;
			if (b3 != null)
			{
				e5q = this.a(a7m, c5x, b3, A_3);
			}
		}
		if (e5q != null && b2 != null && b2.a7() && mv != null && !mv.l && mv.m && mv.o != null)
		{
			blk blk = eg0.a(b2, mv.o);
			if (blk != null)
			{
				e5q.d = new cem?(blk.a().f());
				e5q.e = blk.a().c();
				e5q.g = b2.aa().Truesighted;
			}
		}
		if (e5q != null && (c5x.g & e2b.c) == e2b.c)
		{
			float? ae = c5x.ae;
			float num = 0f;
			if (!(ae.GetValueOrDefault() == num & ae != null) && mv != null)
			{
				u2 b4 = c5x.n.b;
				if (b4 != null)
				{
					List<ud> list = b4.xw();
					if (list != null && list.Count > 0)
					{
						HashSet<string> hashSet = new HashSet<string>();
						foreach (ud ud in list)
						{
							if (ud.a != null)
							{
								am4 am = mv.a(ud);
								if (am != null && (am.ib() || !hashSet.Contains(ud.a)))
								{
									am.b7(mv, this, new b3u(mv, e5q), ud.b);
									hashSet.Add(ud.a);
								}
							}
						}
					}
				}
			}
		}
		if (e5q != null)
		{
			e5q.e = e5q.f;
			if ((c5x.g & e2b.b) == e2b.b)
			{
				su b5 = c5x.l.b;
				if (b5 != null && b5.m())
				{
					this.a(e5q, b5, b2, a7m, mv);
				}
			}
			if (mv != null && !mv.l)
			{
				if (mv.p != null && mv.p.b == A_0)
				{
					a2f a2f = this.a(mv, "Meta\\TargetMarker", new Point(dcl.a(), 0), null, true);
					if (a2f != null && a2f.d != null)
					{
						a2f.e = new Color?(dcl.a(mv.p.c));
						a2f.h = new float?(0.6f);
						a2f.a = "marker";
						e5q.a(0, a2f);
					}
				}
				if (mv.q != null && mv.q.a == A_0)
				{
					a2f a2f2 = this.a(mv, "Meta\\SelectionMarker", new Point(0, 0), null, true);
					if (a2f2 != null && a2f2.d != null)
					{
						a2f2.e = new Color?(adi.ae[mv.q.b]);
						a2f2.h = new float?(0.6f);
						a2f2.a = "selection";
						e5q.a(0, a2f2);
					}
				}
			}
			eg0.a(e5q, A_2, a7m);
			if (d != null)
			{
				this.a(e5q, d);
			}
			if (a7m.i.a && a7m.i.e)
			{
				this.a(e5q, a7m);
			}
		}
		return e5q;
	}

	// Token: 0x06003069 RID: 12393 RVA: 0x00129448 File Offset: 0x00127648
	internal static f6 a(cne A_0, dnn A_1, string A_2, Point A_3, string A_4, bool A_5)
	{
		if (A_2 == null)
		{
			return null;
		}
		eva eva = A_1.x.a(A_2);
		if (eva != null)
		{
			Point point = A_3;
			if (point.X > eva.g.X)
			{
				point.X = eva.g.X;
			}
			if (point.Y > eva.g.Y)
			{
				point.Y = eva.g.Y;
			}
			f6 f = new f6();
			if (A_5)
			{
				if (A_4 != null)
				{
					string text = eva.b + (A_4 ?? string.Empty);
					Texture2D texture2D = A_0.us(text, new double?(mv.b));
					if (texture2D == null)
					{
						text = eva.b;
						texture2D = A_0.us(eva.b, new double?(mv.b));
					}
					if (texture2D != null)
					{
						f.d = new e4m(texture2D, text);
					}
				}
				else
				{
					Texture2D texture2D2 = A_0.us(eva.b, new double?(mv.b));
					if (texture2D2 != null)
					{
						f.d = new e4m(texture2D2, eva.b);
					}
				}
			}
			f.j = eva.f;
			f.c = new Rectangle(eva.e.X + point.X * eva.c.X, eva.e.Y + point.Y * eva.c.Y, eva.c.X, eva.c.Y);
			return f;
		}
		return null;
	}

	// Token: 0x0600306A RID: 12394 RVA: 0x001295E4 File Offset: 0x001277E4
	private f6 a(dnn A_0, cd0 A_1, bool A_2)
	{
		if (!A_1.h || A_0.i.e)
		{
			Point point = A_1.oc(A_2);
			if (point.X >= 0 && point.Y >= 0)
			{
				f6 f = this.a(A_0, A_1.a, point, null, string.IsNullOrEmpty(A_1.e));
				if (f != null)
				{
					f.e = A_1.c;
					if (A_1.g == null)
					{
						if (A_1.c != null)
						{
							f.f = 1f;
						}
					}
					else
					{
						f.f = A_1.g.Value;
					}
					f.g = A_1.f;
					f.h = A_1.d;
					f.a = (f.g == 0f);
					if (!string.IsNullOrEmpty(A_1.e))
					{
						Texture2D resource = base.b().GetResource<Texture2D>(A_1.e, null);
						if (resource != null)
						{
							e4m e4m = f.d as e4m;
							if (e4m != null)
							{
								e4m.a = resource;
							}
							else
							{
								f.d = new e4m(resource, A_1.e);
							}
						}
						else
						{
							f.d = null;
						}
					}
				}
				return f;
			}
		}
		return null;
	}

	// Token: 0x0600306B RID: 12395 RVA: 0x00129738 File Offset: 0x00127938
	private f6 a(dnn A_0, string A_1, Point A_2, string A_3, bool A_4)
	{
		return eg0.a(base.b(), A_0, A_1, A_2, A_3, A_4);
	}

	// Token: 0x0600306C RID: 12396 RVA: 0x0012974C File Offset: 0x0012794C
	private e5q a(a7m A_0, c5x A_1, cd0 A_2, a44 A_3)
	{
		f6 f = this.a(A_0, A_2, A_3.b);
		dm6 p = c3s.a(A_1);
		if (f != null && f.d != null)
		{
			e5q e5q = new e5q();
			f.p = p;
			if (A_1.ad != null)
			{
				f.e = A_1.ad;
				f.f = 1f;
			}
			if (A_1.ae != null)
			{
				if (f.h != null)
				{
					f.h = f.h.Value * A_1.ae;
				}
				else
				{
					f.h = A_1.ae;
				}
			}
			f.l = A_2.i;
			e5q.b = A_1;
			e5q.a(f);
			e5q.f = (f.p == dm6.b);
			return e5q;
		}
		return null;
	}

	// Token: 0x0600306D RID: 12397 RVA: 0x00129854 File Offset: 0x00127A54
	private e5q a(a7m A_0, c5x A_1, alv A_2, a44 A_3)
	{
		dm6 dm = c3s.a(A_2.a8());
		e5q e5q = new e5q();
		e5q.b = A_1;
		e5q.f = (dm == dm6.b);
		if (A_2.a != null)
		{
			foreach (cd0 cd in A_2.a)
			{
				f6 f = this.a(A_0, cd, A_3.b);
				if (f != null && f.d != null)
				{
					f.p = dm;
					if (A_1.ad != null)
					{
						f.e = A_1.ad;
						f.f = 1f;
					}
					if (A_1.ae != null)
					{
						if (f.h != null)
						{
							f.h = f.h.Value * A_1.ae;
						}
						else
						{
							f.h = A_1.ae;
						}
					}
					f.l = cd.i;
					e5q.a(f);
				}
			}
		}
		if (e5q.a.Count > 0)
		{
			return e5q;
		}
		return null;
	}

	// Token: 0x0600306E RID: 12398 RVA: 0x001299DC File Offset: 0x00127BDC
	private e5q a(a7m A_0, c5x A_1, ka A_2, a44 A_3)
	{
		Point a_ = new Point(A_2.i(), 0);
		f6 f = this.a(A_0, A_2.g(), a_, null, false);
		if (f != null)
		{
			string text = A_2.f();
			Texture2D texture2D = base.b().us(text, new double?(mv.b));
			if (texture2D != null)
			{
				e4m e4m = f.d as e4m;
				if (e4m != null)
				{
					e4m.a = texture2D;
				}
				else
				{
					f.d = new e4m(texture2D, text);
				}
			}
			else
			{
				f.d = null;
			}
			dm6 p = c3s.a(A_1);
			if (f != null && f.d != null)
			{
				e5q e5q = new e5q();
				f.p = p;
				if (A_1.ad != null)
				{
					f.e = A_1.ad;
					f.f = 1f;
				}
				if (A_1.ae != null)
				{
					if (f.h != null)
					{
						f.h = f.h.Value * A_1.ae;
					}
					else
					{
						f.h = A_1.ae;
					}
				}
				e5q.b = A_1;
				e5q.a(f);
				e5q.f = (f.p == dm6.b);
				return e5q;
			}
		}
		return null;
	}

	// Token: 0x0600306F RID: 12399 RVA: 0x00129B50 File Offset: 0x00127D50
	private e5q a(a7m A_0, c5x A_1, amc A_2, e6d A_3)
	{
		cnk service = bpo.GetService<cnk>();
		A_2.b(null);
		mv mv = A_0 as mv;
		bool flag = false;
		if (mv != null && mv.n != null && !A_1.IsPlayer && A_2.aa().SpecialStates.g && !A_2.aa().c(d8o.u))
		{
			blk blk;
			mv.n.TryGetValue(A_1.qe(), out blk);
			if (blk == null || blk.a().f() == cem.a || blk.a().f() == cem.b)
			{
				return null;
			}
			if (blk.a().f() == cem.c)
			{
				flag = true;
			}
		}
		e5q e5q = new e5q();
		Point a_ = new Point(A_2.x(), A_2.a8().ac);
		if (A_2.e != null)
		{
			am5 am;
			A_2.e.TryGetValue(A_2.af(), out am);
			f6 f = this.a(A_0, "Creatures\\" + am.b, a_, null, true);
			if (f == null)
			{
				f = this.a(A_0, "Creatures\\" + A_2.f, a_, null, false);
			}
			if (this.a && f != null && f.d != null && A_2.g != null && !string.IsNullOrEmpty(A_2.g.h))
			{
				by8 by = new by8();
				by.e = f;
				by.d = f.d;
				f.d = by;
				string str;
				if (A_2.aa().Gender == Gender.Female)
				{
					str = string.Format("pl_f_{0}##base", A_2.g.h) + "\\" + am.b.Split(new char[]
					{
						'\\'
					}, StringSplitOptions.None)[1];
				}
				else
				{
					str = string.Format("pl_{0}##base", A_2.g.h) + "\\" + am.b.Split(new char[]
					{
						'\\'
					}, StringSplitOptions.None)[1];
				}
				f6 f2 = this.a(A_0, "Creatures\\" + str, a_, null, true);
				if (f2 != null)
				{
					by.f = f2;
				}
				if (A_2.aa().Offense.u().LoadedAmmo.Count > 0 && (string.Equals(A_2.g.h, "xphwrrpg7", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2.g.h, "xphwrrpg7rf", StringComparison.OrdinalIgnoreCase)))
				{
					string str2;
					if (A_2.aa().Gender == Gender.Female)
					{
						str2 = string.Format("pl_f_xphwrrpg70##base", A_2.g.h) + "\\" + am.b.Split(new char[]
						{
							'\\'
						}, StringSplitOptions.None)[1];
					}
					else
					{
						str2 = string.Format("pl_xphwrrpg70##base", A_2.g.h) + "\\" + am.b.Split(new char[]
						{
							'\\'
						}, StringSplitOptions.None)[1];
					}
					f6 f3 = this.a(A_0, "Creatures\\" + str2, a_, null, true);
					if (f3 != null)
					{
						by.g = f3;
					}
				}
			}
			if (A_2.ac())
			{
				f.s = true;
			}
			if (f != null)
			{
				bool flag2 = A_1.GetAspect<buf>() != null;
				if (service != null && service.aq1().b().k() == OutlinesOption.Never && ((mv != null && mv.v && mv.w) || A_0.an2() == A_2.a8()))
				{
					f.q = (!f.s && !flag2);
				}
				if (f.d == null)
				{
					string text = "Locale\\Creatures\\" + ((am != null) ? am.b : "Unresolved");
					Texture2D texture2D = base.b().us(text, new double?(mv.b));
					if (texture2D != null)
					{
						e4m e4m = f.d as e4m;
						if (e4m != null)
						{
							e4m.a = texture2D;
						}
						else
						{
							f.d = new e4m(texture2D, text);
						}
					}
					else
					{
						f.d = null;
					}
				}
				if (f.d != null)
				{
					if ((A_2.aa() is e3q && mv != null && !mv.ac) || A_2.aa().Ethereal)
					{
						f.p = dm6.a;
					}
					else
					{
						f.p = ((flag || A_2.aa().Dead) ? dm6.a : dm6.b);
					}
					if (A_1.ad != null)
					{
						f.e = A_1.ad;
						f.f = 1f;
					}
					else
					{
						if (A_2.an != null)
						{
							f.f = A_2.an.Value;
						}
						if (A_2.ao != null)
						{
							f.e = A_2.ao;
						}
					}
					f.h = A_1.ae;
					f.a = "b";
					f.a = A_2.aa().SpecialStates.g;
					f.l = new Vector2(A_2.am, A_2.al);
					e5q.a(f);
					e5q.e = true;
					e5q.b = A_1;
					e5q.f = (!flag && !A_2.aa().Dead);
					if (!flag && mv != null && !mv.l && mv.m && mv.o != null)
					{
						blk blk2 = eg0.a(A_2, mv.o);
						if (blk2 != null)
						{
							e5q.d = new cem?(blk2.a().f());
							e5q.e = blk2.a().c();
							e5q.g = A_2.aa().Truesighted;
						}
					}
					float? ae = A_1.ae;
					float num = 0f;
					if (!(ae.GetValueOrDefault() == num & ae != null) && am.c != null)
					{
						float num2 = Math.Max(0f, A_2.a8().Lightning.ToVector3().Length() - 0.35f) / 1.382f;
						float scaleFactor = Math.Max(0f, 4f - A_2.a8().Location.Z) / 4f;
						f6 f4 = this.a(A_0, "Meta\\Shadow", Point.Zero, null, true);
						f4.h = new float?(0.085f * num2);
						f4.l = f.l * am.c.Value * scaleFactor;
						f4.p = dm6.a;
						f4.a = "SHD";
						f4.t = true;
						if (A_1.ae != null)
						{
							f4.h *= A_1.ae.Value;
						}
						e5q.a(0, f4);
						for (int i = 1; i < 5; i++)
						{
							a2f a2f = f4.f5();
							a2f.l = f4.l * (1f + 0.13f * (float)(i + 1));
							e5q.a(0, a2f);
						}
					}
					if (!flag && mv != null && mv.z != null && mv.z.Count > 0)
					{
						foreach (ak1 ak in A_1.l)
						{
							ci8 value;
							if (mv.z.TryGetValue(ak.Location, out value))
							{
								e5q.h = new ci8?(value);
								break;
							}
						}
					}
					if (!flag && !A_2.aa().Ethereal && !A_2.aa().Dead && service != null && service.aq1().b().k() != OutlinesOption.Never && mv.w)
					{
						f6 f5 = (f6)f.f5();
						f5.b = true;
						f5.a = "o";
						f5.u = "Outline";
						f5.v = new Dictionary<string, object>();
						Color color = Color.Red;
						if (A_2.aa() is e3q)
						{
							color = Color.Gold;
						}
						else if (service.aqu() != null)
						{
							if (e5q.h != null || A_0.an2() == A_2.a8())
							{
								color = Color.White;
							}
							else
							{
								h key = A_2.aa().a(service.aqu().ac(), asp.a);
								if (A_2.aa().Passive)
								{
									color = Color.SandyBrown;
								}
								else
								{
									color = adi.ae[key];
								}
							}
						}
						else
						{
							color = Color.Green;
						}
						f5.v.Add("OutlineColor", color);
						if ((mv.v && service.aq1().b().k() == OutlinesOption.AlwaysInCombat) || (f.p == dm6.b && (e5q.h != null || A_0.an2() == A_2.a8())) || (service.aq1().b().k() != OutlinesOption.Never && (A_3.c().IsKeyDown(d1o.a(Hotkey.Highlight)) || A_3.c().IsKeyDown(d1o.a(Hotkey.ReverseHighlight)))))
						{
							by8 by2 = f.d as by8;
							if (by2 != null)
							{
								by8 by3 = f5.d as by8;
								if (by3 != null)
								{
									by2.j = true;
									by3.m = by2;
								}
							}
							e5q.a(f5);
						}
					}
					return e5q;
				}
			}
		}
		return null;
	}

	// Token: 0x06003070 RID: 12400 RVA: 0x0012A630 File Offset: 0x00128830
	private static blk a(amc A_0, b0b A_1)
	{
		bm6 b = A_0.a8().t.b;
		if (b != null)
		{
			blk result;
			new bzv(b.y6()).a().TryGetValue(A_1.qe(), out result);
			return result;
		}
		return null;
	}

	// Token: 0x06003071 RID: 12401 RVA: 0x0012A678 File Offset: 0x00128878
	private static void a(e5q A_0, e6d A_1, a7m A_2)
	{
		cnk cnk = ces.a();
		mv mv = A_2 as mv;
		c5x c5x = A_0.b as c5x;
		bool flag = c5x.z.b != null;
		if (mv == null || mv.w)
		{
			if (A_0.f && A_2.Enabled)
			{
				bool flag2 = c5x.GetAspect<buf>() != null;
				bool flag3 = c5x.s.b != null && c5x.s.b.k;
				if ((A_2.an2() != null && A_0.b == A_2.an2()) || A_0.h != null || A_1.c().IsKeyDown(d1o.a(Hotkey.Highlight)) || A_1.c().IsKeyDown(d1o.a(Hotkey.ReverseHighlight)))
				{
					A_0.a = !c5x.c(e2b.d);
					using (List<a2f>.Enumerator enumerator = A_0.a.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							a2f a2f = enumerator.Current;
							if ((!(a2f.a == "b") || cnk == null || cnk.aq1().b().k() == OutlinesOption.Never) && a2f.a != "marker" && a2f.a != "shield" && a2f.a != "SHD" && a2f.a != "d")
							{
								a2f.q = ((!a2f.s && !flag2) || flag);
								a2f.r = flag3;
							}
						}
						goto IL_3A8;
					}
				}
				if (flag3)
				{
					using (List<a2f>.Enumerator enumerator = A_0.a.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							a2f a2f2 = enumerator.Current;
							if (a2f2.a != "marker" && a2f2.a != "shield" && a2f2.a != "SHD")
							{
								a2f2.q = ((!a2f2.s && !flag2) || flag);
								a2f2.r = true;
							}
						}
						goto IL_3A8;
					}
				}
				if (!flag)
				{
					goto IL_3A8;
				}
				using (List<a2f>.Enumerator enumerator = A_0.a.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						a2f a2f3 = enumerator.Current;
						if (a2f3.a != "marker" && a2f3.a != "shield" && a2f3.a != "SHD")
						{
							a2f3.q = !a2f3.s;
						}
					}
					goto IL_3A8;
				}
			}
			if (flag)
			{
				foreach (a2f a2f4 in A_0.a)
				{
					if (a2f4.a != "marker" && a2f4.a != "shield" && a2f4.a != "SHD")
					{
						a2f4.q = !a2f4.s;
					}
				}
			}
		}
		IL_3A8:
		if (c5x.e)
		{
			A_0.b = true;
			A_0.e = true;
		}
		if (c5x.f)
		{
			A_0.c = true;
			A_0.e = true;
		}
	}

	// Token: 0x06003072 RID: 12402 RVA: 0x0012AA94 File Offset: 0x00128C94
	private void a(e5q A_0, d69 A_1)
	{
		a2f a2f = Enumerable.FirstOrDefault<a2f>(A_0.a);
		if (a2f != null)
		{
			dy9 aspect = A_0.b.GetAspect<dy9>();
			if (aspect != null)
			{
				if (aspect.b().Contains(A_1.e) || aspect.f().Contains(A_1.e))
				{
					a2f a2f2 = a2f.f5();
					a2f2.u = "MapOutline";
					A_0.a(a2f2);
				}
				A_0.f = true;
				a2f.p = dm6.b;
				if (aspect.a() != MapNodeState.Obscured)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().q().b(A_0.b) != null)
					{
						f6 f = this.a(A_1, "Maps\\Objects\\Notes", Point.Zero, null, true);
						f.p = dm6.b;
						A_0.a(f);
					}
				}
			}
			else if (A_0.b.GetAspect<djr>() != null)
			{
				A_0.f = true;
				a2f.p = dm6.b;
			}
			else
			{
				A_0.f = false;
				a2f.p = dm6.a;
			}
			dpp service = bpo.GetService<dpp>();
			if (service != null && service.u7() != null && A_0.b == service.u7())
			{
				a2f a2f3 = a2f.f5();
				a2f3.u = "MapHighlight";
				A_0.a(a2f3);
			}
		}
	}

	// Token: 0x06003073 RID: 12403 RVA: 0x0012ABF4 File Offset: 0x00128DF4
	private void a(e5q A_0, a7m A_1)
	{
		ln aspect = A_0.b.GetAspect<ln>();
		if (aspect != null)
		{
			int num = 0;
			if (aspect.a() != null || aspect.g() != null)
			{
				f6 f;
				if (aspect.a() != null)
				{
					f = this.a(A_1, "Meta\\Difficulty", new Point((int)aspect.a().Value, 0), null, true);
				}
				else
				{
					f = this.a(A_1, "Meta\\DifficultySymbols", new Point(1, 0), null, true);
				}
				f.q = true;
				A_0.a(f);
				f6 f2 = f;
				f2.j.X = f2.j.X + 23f;
				f6 f3 = this.a(A_1, "Meta\\DifficultySymbols", new Point(0, 0), null, true);
				f3.q = true;
				A_0.a(f3);
				f6 f4;
				if (aspect.g() != null)
				{
					f4 = this.a(A_1, "Meta\\Difficulty", new Point((int)aspect.g().Value, 0), null, true);
				}
				else
				{
					f4 = this.a(A_1, "Meta\\DifficultySymbols", new Point(1, 0), null, true);
				}
				f4.q = true;
				A_0.a(f4);
				f6 f5 = f4;
				f5.j.X = f5.j.X - 23f;
				num += 25;
			}
			if (!string.IsNullOrEmpty(aspect.d()))
			{
				f6 f6 = this.a(A_1, "Meta\\Dlc_" + aspect.d(), aspect.b() ? new Point(1, 0) : Point.Zero, null, true);
				f6.q = true;
				f6.j = new Vector2(f6.j.X, f6.j.Y + (float)num);
				A_0.a(f6);
				num += 25;
			}
			int num2 = 0;
			if (aspect.e() < 1.0 && aspect.f() != null)
			{
				num2 = 18;
			}
			if (aspect.e() < 1.0)
			{
				f6 f7 = this.a(A_1, "Meta\\ChanceSymbol", Point.Zero, null, true);
				f7.q = true;
				f7.j = new Vector2(f7.j.X + (float)num2, f7.j.Y + (float)num);
				A_0.a(f7);
			}
			if (aspect.f() != null)
			{
				if (aspect.e() < 1.0)
				{
					num2 -= 36;
				}
				f6 f8 = this.a(A_1, "Meta\\ConditionSymbol", Point.Zero, null, true);
				f8.q = true;
				f8.j = new Vector2(f8.j.X + (float)num2, f8.j.Y + (float)num);
				A_0.a(f8);
			}
		}
	}

	// Token: 0x06003074 RID: 12404 RVA: 0x0012AED8 File Offset: 0x001290D8
	private void a(bym A_0, su A_1, amc A_2, a7m A_3, mv A_4)
	{
		if (!string.IsNullOrEmpty(A_1.j()))
		{
			c5x c5x = A_0.b as c5x;
			if (c5x != null)
			{
				float? ae = c5x.ae;
				float num = 0f;
				if (!(ae.GetValueOrDefault() == num & ae != null))
				{
					string text = A_1.j();
					if (A_2 != null && !string.IsNullOrEmpty(A_2.a0()))
					{
						text = text + "_" + A_2.a0();
					}
					a2f a2f = base.b(A_3, Path.Combine("Shields", text), new Point(A_1.g(), 0), null, true);
					if (a2f != null)
					{
						a2f.a = "shield";
						a2f.e = new Color?(A_1.o());
						A_0.a.Add(a2f);
					}
					a2f a2f2 = base.b(A_3, Path.Combine("Shields", text), new Point(A_1.g(), 1), null, true);
					if (a2f2 != null)
					{
						a2f2.a = "shield";
						a2f2.e = new Color?(A_1.o());
						A_0.a.Insert(0, a2f2);
					}
				}
			}
		}
	}

	// Token: 0x04001AA1 RID: 6817
	public bool a;
}
