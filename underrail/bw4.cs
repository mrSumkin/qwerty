using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000BB6 RID: 2998
[euj]
public sealed class bw4
{
	// Token: 0x06004465 RID: 17509 RVA: 0x001B4F4C File Offset: 0x001B314C
	[ayh("XPHWGJES")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null)
		{
			if (c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.ba] = false;
			}
			if (c5x.h.b != null)
			{
				c5x.h.b.aa().Cooldowns.a(e5b.d);
			}
		}
	}

	// Token: 0x06004466 RID: 17510 RVA: 0x001B4FDC File Offset: 0x001B31DC
	[ayh("XPHWGJWAL")]
	public void p(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null && c5x.t.b != null)
		{
			this.a(A_0.Area, true);
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			List<string> list = new List<string>();
			double num = 15.0;
			foreach (csd csd in c5x.Zone.Waypoints)
			{
				if (csd.Name.StartsWith("global:xphw_gunslinger:") && !csd.Name.Substring(23).ToLower().StartsWith("from") && !csd.Name.Substring(23).ToLower().StartsWith("railcar") && !csd.Name.Substring(23).ToLower().StartsWith("rift_xphw_exobase_out"))
				{
					ak1 ak = csd.Area.b((int)csd.Location.X, (int)csd.Location.Y);
					if (ak != null && c5x.Area == ak.Area && aw1.a(c5x, ak) <= num)
					{
						int? num2 = this.a(c5x, ak);
						if (num2 != null)
						{
							int? num3 = num2;
							double? num4 = (num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null;
							double num5 = num * 4.0;
							if (num4.GetValueOrDefault() <= num5 & num4 != null)
							{
								dictionary.Add(csd.Name.Substring(23), num2.Value);
							}
						}
					}
				}
			}
			if (Enumerable.Any<KeyValuePair<string, int>>(dictionary))
			{
				string key = Enumerable.First<KeyValuePair<string, int>>(Enumerable.OrderBy<KeyValuePair<string, int>, int>(dictionary, new Func<KeyValuePair<string, int>, int>(bw4.a.a.a))).Key;
				int value = Enumerable.First<KeyValuePair<string, int>>(Enumerable.OrderBy<KeyValuePair<string, int>, int>(dictionary, new Func<KeyValuePair<string, int>, int>(bw4.a.a.b))).Value;
				foreach (csd csd2 in c5x.Zone.Waypoints)
				{
					if (csd2.Name.StartsWith("xphw_gunslinger_" + key))
					{
						list.Add(csd2.Name);
					}
				}
				if (Enumerable.Any<string>(list))
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null)
					{
						serviceOrThrow.aqu().r()[c29.c] = key;
						serviceOrThrow.aqu().r()[c29.b] = serviceOrThrow.aqw().y8();
					}
					if (list.Count == 1)
					{
						string a_ = Enumerable.FirstOrDefault<string>(list);
						c5x.t.b.y6()[ddq.ay] = new bt4(a_);
						if (this.a(a_))
						{
							c5x.t.b.y6()[ddq.w] = CharacterState.Operating;
						}
					}
					else if (list.Count > 1)
					{
						c5x.t.b.y6()[ddq.k] = cuo.ShuffleList<string>(list, null);
						c5x.t.b.y6()[ddq.l] = cuo.a.Next(3, 8) * 1000;
						c5x.t.b.y6()[ddq.n] = true;
						List<string> list2 = new List<string>();
						foreach (string text in list)
						{
							if (this.a(text))
							{
								list2.Add(text);
							}
						}
						if (Enumerable.Any<string>(list2))
						{
							c5x.t.b.y6()[ddq.o] = CharacterState.Operating;
							c5x.t.b.y6()[ddq.s] = 10;
							c5x.t.b.y6()[ddq.v] = list2;
						}
					}
					if (value >= 30)
					{
						d7o.a(Xphw_GunslingerCommentCodeEnum.Wait_FarSpot_Repeatable, false, false);
						return;
					}
					d7o.a(Xphw_GunslingerCommentCodeEnum.Wait_CloseSpot_Repeatable, false, false);
					return;
				}
			}
			d7o.a(Xphw_GunslingerCommentCodeEnum.Wait_DefaultSpot_Repeatable, false, false);
		}
	}

	// Token: 0x06004467 RID: 17511 RVA: 0x001B5528 File Offset: 0x001B3728
	[ayh("XPHWGJCPC")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a(A_0.Area, false);
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x001B5538 File Offset: 0x001B3738
	[ayh("XPHWGJSAC")]
	public void l(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().AttributesBase |= d8o.u;
		}
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x001B5598 File Offset: 0x001B3798
	[ayh("XPHWGJRFAW")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null && c5x.t.b != null)
		{
			this.a(c5x.Area, false);
			if (!c5x.t.b.y6().HasProperty(ddq.b0))
			{
				c5x.t.b.y6()[ddq.b0] = 4;
			}
			c5x.t.b.y6().RemoveProperty(c29.p);
		}
	}

	// Token: 0x0600446A RID: 17514 RVA: 0x001B5640 File Offset: 0x001B3840
	[ayh("XPHWGJKESO")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null)
		{
			if (c5x.h.b != null && c5x.h.b.aa().Gear.h().Item != null)
			{
				c5x.h.b.aa().Defense.a(true);
			}
			if (c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.br] = TimeSpan.MaxValue;
			}
		}
	}

	// Token: 0x0600446B RID: 17515 RVA: 0x001B56F4 File Offset: 0x001B38F4
	[ayh("XPHWGJGDDT")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 == null || A_2 == null)
		{
			return;
		}
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x == null)
		{
			return;
		}
		object obj;
		if (A_2.TryGetValue("dialog", out obj))
		{
			azm azm = obj as azm;
			object obj2;
			if (azm != null && A_2.TryGetValue("node", out obj2))
			{
				ad7 ad = obj2 as ad7;
				if (ad != null)
				{
					d7o.a(azm, ad, c5x);
				}
			}
		}
	}

	// Token: 0x0600446C RID: 17516 RVA: 0x001B577C File Offset: 0x001B397C
	[ayh("XPHWGJCIT")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null && c5x.h.b != null && c5x.t.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				coh classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<coh>(c29.j);
				if (c5x.t.b.y6().GetPrimitivePropertyValue<bool>(c29.k, new bool?(false)).Value)
				{
					serviceOrThrow.aqu().v().Bag.z3(classPropertyValue, true);
					c5x.h.b.aa().a(classPropertyValue);
					a7v.a(new bou(classPropertyValue));
				}
				else if (classPropertyValue != null)
				{
					c5x.h.b.aa().Bag.z3(classPropertyValue, true);
					serviceOrThrow.aqu().v().a(classPropertyValue);
					a7v.a(new aub(classPropertyValue));
				}
				c5x.t.b.y6().RemoveProperty(c29.j);
				c5x.t.b.y6().RemoveProperty(c29.k);
			}
		}
	}

	// Token: 0x0600446D RID: 17517 RVA: 0x001B58E8 File Offset: 0x001B3AE8
	[ayh("XPHWGJRAPI")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null)
			{
				return;
			}
			foreach (coh coh in Enumerable.ToList<coh>(Enumerable.Concat<coh>(c5x.h.b.aa().Bag.z2(), c5x.h.b.aa().Gear.i())))
			{
				if (!(coh.Definition is a54) && !(coh.Definition is sz) && !(coh is cgk) && !(coh is k7) && coh.Stealable && coh.Lootable)
				{
					serviceOrThrow.aqu().v().Bag.z3(coh, true);
					c5x.h.b.aa().a(coh);
					a7v.a(new bou(coh));
				}
			}
		}
	}

	// Token: 0x0600446E RID: 17518 RVA: 0x001B5A50 File Offset: 0x001B3C50
	[ayh("XPHWGJSTTP")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				coh coh = c5x.h.b.aa().a("gunslingersPistol", true);
				if (coh != null)
				{
					serviceOrThrow.aqu().v().Bag.z3(coh, true);
					c5x.h.b.aa().a(coh);
					a7v.a(new bou(coh));
					coh coh2 = c5x.h.b.aa().a("plot.gunslingersEnergyPistolInactive", false);
					if (coh2 != null)
					{
						c5x.h.b.aa().a(coh2);
					}
				}
			}
		}
	}

	// Token: 0x0600446F RID: 17519 RVA: 0x001B5B44 File Offset: 0x001B3D44
	[ayh("XPHWGJSP")]
	public void m(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_1 != null)
		{
			Vector3 a_ = A_0.Location;
			Vector3 a_2 = A_1.Location;
			Vector2? z = A_0.z;
			Vector2? z2 = A_1.z;
			A_1.Location = a_;
			A_1.z = null;
			A_0.Location = a_2;
			A_0.z = null;
			A_0.z = z;
			A_1.z = z2;
			if (!A_1.IsPlayer)
			{
				A_1.VisualDirection = bnx.a(A_1.Location, A_0.Location);
			}
			else
			{
				A_0.VisualDirection = bnx.a(A_0.Location, A_1.Location);
			}
			A_0.ah();
			A_1.ah();
		}
	}

	// Token: 0x06004470 RID: 17520 RVA: 0x001B5BF8 File Offset: 0x001B3DF8
	[ayh("XPHWGJUM")]
	public void o(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
		if (c5x != null)
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			foreach (coh coh in Enumerable.ToList<coh>(c5x.h.b.aa().Bag.z2()))
			{
				if (coh.Definition != null && coh.Definition is dgn && d7o.a(coh.Definition.a5()))
				{
					c3n c3n = dgk.a(Enumerable.FirstOrDefault<aia>(coh.Definition.a2()).CapabilityFullTypeName);
					if (c3n != null)
					{
						foreach (string a_ in Enumerable.ToList<string>(c3n.CooldownCodes))
						{
							c5x.h.b.aa().Cooldowns.a(a_);
						}
						eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(c5x.h.b)), coh) as eu7;
						if (eu != null && eu.yw())
						{
							ad5 item = cp.a(eu, c5x, c5x);
							awx.ad().Add(item);
							awx.ad().Add(new bm3(100));
						}
					}
				}
			}
			if (Enumerable.Any<auv>(awx.ad()))
			{
				List<int> classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<List<int>>(c29.l);
				if (classPropertyValue != null && !classPropertyValue.Contains(103))
				{
					d7o.a(Xphw_GunslingerCommentCodeEnum.Medicine_FirstBuff, false, false);
				}
				else
				{
					d7o.a(Xphw_GunslingerCommentCodeEnum.Medicine_Repeatable, false, false);
				}
				c5x.i.b.b(awx, atp.a);
			}
		}
	}

	// Token: 0x06004471 RID: 17521 RVA: 0x001B5E3C File Offset: 0x001B403C
	[ayh("XPHWGJTC-Cloning")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		d7o.a(Xphw_GunslingerCommentCodeEnum.Lore_Cloning, false, false);
	}

	// Token: 0x06004472 RID: 17522 RVA: 0x001B5E4C File Offset: 0x001B404C
	[ayh("XPHWGJTC-GrenadeFreeze")]
	public void k(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		d7o.a(Xphw_GunslingerCommentCodeEnum.Combat_GrenadeFreeze, false, false);
	}

	// Token: 0x06004473 RID: 17523 RVA: 0x001B5E5C File Offset: 0x001B405C
	[ayh("XPHWGJTC-Heartbeat")]
	public void n(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null)
		{
			return;
		}
		bm6 b = A_1.t.b;
		if (b == null)
		{
			return;
		}
		HashSet<r0> hashSet = b.b(bpo.GetServiceOrThrow<d02>());
		if (hashSet == null || hashSet.Count == 0)
		{
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab2(new List<string>
				{
					"gunslingerObservable"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Area.y8() == A_1.Area.y8())
					{
						r0 r = new r0(A_1.Area.c(), c5x.Location.a().b());
						if (hashSet.Contains(r))
						{
							a3f aspect = c5x.GetAspect<a3f>();
							if (aspect != null && aspect.a().HasProperty("CommentCode") && !aspect.a().HasProperty("Disabled"))
							{
								string classPropertyValue = aspect.a().GetClassPropertyValue<string>("ConditionProperty");
								if (classPropertyValue == null || !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(classPropertyValue, new bool?(false)).Value)
								{
									object propertyValue = aspect.a().GetPropertyValue("CommentCode");
									if (propertyValue is Xphw_GunslingerCommentCodeEnum)
									{
										Xphw_GunslingerCommentCodeEnum a_ = (Xphw_GunslingerCommentCodeEnum)propertyValue;
										bool value = aspect.a().GetPrimitivePropertyValue<bool>("RetryComment", new bool?(false)).Value;
										d7o.a(a_, value, false);
									}
								}
								if (c5x.h.b != null)
								{
									aspect.a()["Disabled"] = true;
								}
								else
								{
									c5x.w();
									c5x.an();
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004474 RID: 17524 RVA: 0x001B6090 File Offset: 0x001B4290
	[ayh("XPHWGJPIC")]
	public void j(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			c5x c5x = new ar7(c29.a, service.aqu().v().b().Area).ao() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.h.b.aa().IsInControl)
			{
				cky cky = (service.aqu().ac() as bv9).abu(asp.go, asp.a);
				if (cky != null && cky.a != global::h.a)
				{
					blk blk = new bzv(c5x.t.b.y6()).c(A_0.qe());
					object obj;
					if (blk != null && blk.b() && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
					{
						bq8 bq = obj as bq8;
						if (bq != null)
						{
							bq.set_Item("GunslingerPresent", true);
						}
					}
				}
			}
		}
	}

	// Token: 0x06004475 RID: 17525 RVA: 0x001B61A8 File Offset: 0x001B43A8
	private void a(aud A_0, bool A_1 = false)
	{
		c5x c5x = new ar7(c29.a, A_0).ao() as c5x;
		if (c5x != null)
		{
			c5x.t.b.y6().RemoveProperty(ddq.k);
			c5x.t.b.y6().RemoveProperty(ddq.l);
			c5x.t.b.y6().RemoveProperty(ddq.ay);
			c5x.t.b.y6().RemoveProperty(ddq.w);
			c5x.t.b.y6().RemoveProperty(ddq.y);
			c5x.t.b.y6().RemoveProperty(ddq.n);
			c5x.t.b.y6().RemoveProperty(ddq.o);
			c5x.t.b.y6().RemoveProperty(ddq.s);
			c5x.t.b.y6().RemoveProperty(ddq.v);
			if (A_1)
			{
				c5x.t.b.y6().RemoveProperty(ddq.bz);
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					serviceOrThrow.aqu().r()["npc_xphw_gunslinger_followPlayer"] = false;
				}
			}
		}
	}

	// Token: 0x06004476 RID: 17526 RVA: 0x001B6314 File Offset: 0x001B4514
	private int? a(c5x A_0, ak1 A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null && A_0.Zone.n(A_0.Area.y8()) != null && A_1 != null)
		{
			ale aspect = A_0.GetAspect<ale>();
			if (aspect != null)
			{
				fk fk = new fk(aspect, A_1, null, false, 0);
				fk.l();
				czp czp = fk.g();
				czp.n.a = false;
				czp.p = true;
				czp.q = false;
				d25 d = czp.l as d25;
				if (d == null)
				{
					d = new d25();
					czp.l = d;
				}
				d.b = true;
				d.c = false;
				c5w c5w = bpo.GetServiceOrThrow<wu>().aki(czp, aspect.a8().Playfield.PathProcessor, eso.d);
				c5w.au1();
				if (c5w.aus().Count / 4 < 16)
				{
					foreach (yz yz in c5w.aus())
					{
						if ((double)bnx.a(new Point((int)yz.a.a.X / 4, (int)yz.a.a.Y / 4), A_1.Location) < 2.0)
						{
							return new int?(c5w.aus().Count);
						}
					}
				}
				return null;
			}
		}
		return null;
	}

	// Token: 0x06004477 RID: 17527 RVA: 0x001B64BC File Offset: 0x001B46BC
	private bool a(string A_0)
	{
		return A_0.Contains("animated");
	}

	// Token: 0x02000BB7 RID: 2999
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600447B RID: 17531 RVA: 0x001B64F0 File Offset: 0x001B46F0
		internal int a(KeyValuePair<string, int> A_0)
		{
			return A_0.Value;
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x001B64FC File Offset: 0x001B46FC
		internal int b(KeyValuePair<string, int> A_0)
		{
			return A_0.Value;
		}

		// Token: 0x04001C5A RID: 7258
		public static readonly bw4.a a = new bw4.a();

		// Token: 0x04001C5B RID: 7259
		public static Func<KeyValuePair<string, int>, int> b;

		// Token: 0x04001C5C RID: 7260
		public static Func<KeyValuePair<string, int>, int> c;
	}
}
