using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Comm;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001430 RID: 5168
[eiz("CDA")]
[Serializable]
public sealed class d3q : b1z, evp, bgn, ISerializable
{
	// Token: 0x060073D5 RID: 29653 RVA: 0x0030ECB0 File Offset: 0x0030CEB0
	private d3q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("CDA:CR", typeof(EntityAspectReference<amc, amc>));
		this.c = A_0.GetDouble("CDA:T");
		this.d = A_0.GetInt32("CDA:DF");
		this.e = A_0.GetInt32("CDA:CDF");
		if (ell.a() >= 221)
		{
			this.f = (b7u)A_0.GetValue("CDA:D", typeof(b7u));
			return;
		}
		if (A_0.GetBoolean("CDA:SH"))
		{
			this.f = b7u.b;
			return;
		}
		this.f = b7u.a;
	}

	// Token: 0x060073D6 RID: 29654 RVA: 0x0030ED68 File Offset: 0x0030CF68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CDA:CR", this.b);
		info.AddValue("CDA:T", this.c);
		info.AddValue("CDA:DF", this.d);
		info.AddValue("CDA:CDF", this.e);
		info.AddValue("CDA:D", this.f);
	}

	// Token: 0x060073D7 RID: 29655 RVA: 0x0030EDD8 File Offset: 0x0030CFD8
	private amc c()
	{
		return this.b.ao();
	}

	// Token: 0x060073D8 RID: 29656 RVA: 0x0030EDE8 File Offset: 0x0030CFE8
	public override m7 kh()
	{
		return m7.b;
	}

	// Token: 0x060073D9 RID: 29657 RVA: 0x0030EDEC File Offset: 0x0030CFEC
	public int? tm()
	{
		return new int?(this.e);
	}

	// Token: 0x060073DA RID: 29658 RVA: 0x0030EDFC File Offset: 0x0030CFFC
	public CharacterState? q1()
	{
		if (this.f == b7u.d)
		{
			return new CharacterState?(CharacterState.Custom2);
		}
		return new CharacterState?(CharacterState.Die);
	}

	// Token: 0x060073DB RID: 29659 RVA: 0x0030EE18 File Offset: 0x0030D018
	public object fm()
	{
		return null;
	}

	// Token: 0x060073DC RID: 29660 RVA: 0x0030EE1C File Offset: 0x0030D01C
	public ci8? oi()
	{
		return null;
	}

	// Token: 0x060073DD RID: 29661 RVA: 0x0030EE34 File Offset: 0x0030D034
	public d3q(amc A_0, b7u A_1 = b7u.a)
	{
		this.b = new EntityAspectReference<amc, amc>(A_0);
		this.f = A_1;
	}

	// Token: 0x060073DE RID: 29662 RVA: 0x0030EE50 File Offset: 0x0030D050
	public bool sp()
	{
		return true;
	}

	// Token: 0x060073DF RID: 29663 RVA: 0x0030EE54 File Offset: 0x0030D054
	protected override dc4 dt()
	{
		if (this.c() == null || this.c().a8() == null)
		{
			return dc4.e;
		}
		dqv aspect = this.c().a8().GetAspect<dqv>();
		if (aspect != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().b().a(aspect.a()).a(true);
			}
		}
		this.e = 0;
		this.c = 0.0;
		if (this.f == b7u.b)
		{
			if (this.c().a8() == null)
			{
				return dc4.e;
			}
			this.a();
			c5x a_ = this.c().a8();
			string a_2 = "ColdHit";
			int a_3 = 1;
			double maxValue = double.MaxValue;
			bool a_4 = true;
			bool a_5 = false;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			this.b();
			return dc4.c;
		}
		else if (this.f == b7u.c)
		{
			if (this.c().a8() == null)
			{
				return dc4.e;
			}
			this.c().a8();
			c5x a_7 = this.c().a8();
			string a_8 = "Smoke";
			int a_9 = 1;
			double maxValue2 = double.MaxValue;
			bool a_10 = true;
			bool a_11 = false;
			float? a_6 = dz6.b();
			boj.a(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false);
			this.b();
			return dc4.c;
		}
		else if (this.f == b7u.d)
		{
			if (this.c() != null && this.c().aa().Vehicle != null)
			{
				this.d = this.c().e[CharacterState.Custom2].a;
				this.c().a8().c();
				c5x a_12 = this.c().a8();
				ak1 ak = Enumerable.FirstOrDefault<ak1>(this.c().a8().l);
				if (ak != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.c.Values, new Func<b0b, bool>(d3q.a.a.a))) as c5x;
					if (c5x != null)
					{
						a_12 = c5x;
					}
				}
				boj.a(this.c().a8(), "ExplosionSmall", 1, double.MaxValue, true, false, null, null, null, null, false);
				a_12.c().a(Guid.NewGuid().ToString(), "VehicleExplosion", 1f, c9z.a, false, false);
				return dc4.b;
			}
			return dc4.e;
		}
		else
		{
			if (this.c() != null)
			{
				this.c().aa().StatusEffects.c();
				this.d = this.c().e[CharacterState.Die].a;
				if (this.f == b7u.e && !this.c().aa().b(d8o.e))
				{
					this.c().aa().StatusEffects.a(new djy(), false, true, false);
				}
				List<string> list = this.c().ag().a().c();
				this.c().a8().c();
				c5x a_13 = this.c().a8();
				ak1 ak2 = Enumerable.FirstOrDefault<ak1>(this.c().a8().l);
				if (ak2 != null)
				{
					c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.c.Values, new Func<b0b, bool>(d3q.a.a.b))) as c5x;
					if (c5x2 != null)
					{
						a_13 = c5x2;
					}
				}
				foreach (string text in list)
				{
					a_13.c().a("death_" + text, text, 1f, c9z.a, false, false);
				}
				return dc4.b;
			}
			return dc4.e;
		}
	}

	// Token: 0x060073E0 RID: 29664 RVA: 0x0030F28C File Offset: 0x0030D48C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.c() == null)
		{
			return dc4.e;
		}
		if (this.d == 0 || (this.c += A_1.TotalMilliseconds) >= (double)dz6.b(cux.h))
		{
			this.c = 0.0;
			if (++this.e >= this.d)
			{
				this.b();
				return dc4.c;
			}
		}
		return dc4.b;
	}

	// Token: 0x060073E1 RID: 29665 RVA: 0x0030F30C File Offset: 0x0030D50C
	private void b()
	{
		if (this.c() == null || this.c().a8() == null || this.c().a8().j != cgy.b || this.c().a8().Area == null)
		{
			return;
		}
		bool flag = true;
		List<coh> list = asy.a(this.c().aa());
		if (this.c().aa().Vehicle != null && this.c().aa().Vehicle.ap().z2().Count > 0)
		{
			list.InsertRange(0, this.c().aa().Vehicle.ap().z2());
		}
		a3f aspect = this.c().a8().GetAspect<a3f>();
		if ((list.Count > 0 || this.c().ar() || this.a(this.c())) && !this.c().a1())
		{
			c5x c5x = null;
			if (this.f == b7u.d && this.c().aa().Vehicle != null && this.c().aa().Vehicle.an() != null)
			{
				try
				{
					c5x = new c5x();
					c5x.q(this.c().aa().Vehicle.an().d() + " (сломано)");
					etz etz = new etz(c5x);
					etz.b = new Point(0, this.c().a8().ac);
					etz.a = "Creatures\\" + this.c().g.a[CharacterState.Custom3].b;
					etz.c(this.c().g.a[CharacterState.Custom3].a);
					etz.d(225);
					c5x.SetAspect<cd0>(etz);
					c5x.VisualPriority = this.c().a8().VisualPriority;
					c5x.VisualDirection = this.c().a8().VisualDirection;
					c5x.Location = this.c().a8().Location;
					c5x.Size = this.c().a8().Size;
					c5x.Layer = aju.x;
					c5x.x = this.c().a8().x;
					c5x.y = this.c().a8().y;
					if (this.c().a8().k.b == null)
					{
						c5x.TileFormationModifiers = new bjp(this.c().a8().TileFormationModifiers.b);
					}
					c7j c7j = new c7j(c5x);
					c7j.g(false);
					c7j.c("JunkRummage");
					if (this.c().a8().GetAspect<abh>() != null || this.c().ab() || (aspect != null && aspect.a().GetPrimitivePropertyValue<bool>("AlwaysDespawnEmptyRemains", new bool?(false)).Value))
					{
						List<cze> list2 = c7j.p();
						d3y d3y = new d3y();
						d3y.a(true);
						list2.Add(d3y);
					}
					else
					{
						c7j.p().Add(new d3y());
					}
					c5x.SetAspect<bim>(c7j);
					this.c().a8().Area.a(c5x);
					Point point;
					Point point2;
					c5x.a(out point, out point2);
					if (point != point2)
					{
						c7j.c(0.5f);
					}
					for (int i = list.Count - 1; i >= 0; i--)
					{
						coh coh = list[i];
						bool value = coh.CustomProperties.GetPrimitivePropertyValue<bool>(vo.j, new bool?(false)).Value;
						bool value2 = coh.CustomProperties.GetPrimitivePropertyValue<bool>(vo.k, new bool?(false)).Value;
						if (value)
						{
							list.RemoveAt(i);
						}
						else if (!value2)
						{
							if (coh.Stacks > 1)
							{
								int num = Convert.ToInt32((double)coh.Stacks * cuo.a.NextDouble());
								if (num > 0)
								{
									coh.Stacks = num;
								}
								else
								{
									list.RemoveAt(i);
								}
							}
							else if (cuo.a.NextDouble() < 0.5)
							{
								list.RemoveAt(i);
							}
						}
					}
					int num2 = Convert.ToInt32((0.5 + cuo.a.NextDouble() * 0.5) * (double)this.c().aa().Vehicle.v() / 4.0);
					if (num2 > 0)
					{
						list.Add(new fv(new LibraryItemDefinitionProvider<a1k>("Components\\Scraps\\MetalScraps"))
						{
							Stacks = (int)Math.Ceiling(0.7 * (double)num2 * (0.8 + cuo.a.NextDouble() * 0.4))
						});
						list.Add(new fv(new LibraryItemDefinitionProvider<a1k>("Components\\Scraps\\ElectronicScraps"))
						{
							Stacks = (int)Math.Ceiling(0.3 * (double)num2 * (0.8 + cuo.a.NextDouble() * 0.4))
						});
					}
					foreach (agt item in this.c().aa().Vehicle.o().Values)
					{
						if (cuo.a.NextDouble() < 0.1)
						{
							list.Add(item);
						}
					}
					goto IL_10A5;
				}
				catch
				{
					goto IL_10A5;
				}
			}
			if ((this.f == b7u.a || this.f == b7u.e) && (this.c().ax() || this.a(this.c()) || this.c().aa().Vehicle != null))
			{
				try
				{
					a20.a(this.c().a8(), null, new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Dying
					});
					if (this.c().aa().Vehicle != null)
					{
						flag = false;
						this.c().aa().Vehicle.a(null);
						this.c().aa().Vehicle.ap().z2().Clear();
						this.c().aa().Vehicle.ap().z2().AddRange(list);
						c5x c5x2 = new c5x();
						c5x2.Size = new Vector3(1f, 1f, 1f);
						c5x2.VisualDirection = this.c().a8().VisualDirection;
						c5x2.Location = this.c().a8().Location;
						c5x2.x = true;
						c5x2.y = true;
						c5x2.TileFormationModifiers.s3(1);
						c5x2.Layer = aju.x;
						c5x2.z = new Vector2?(new Vector2(1f, 1f));
						etz etz2 = new etz(c5x2);
						etz2.d(225);
						etz2.c(8);
						c5x2.SetAspect<cd0>(etz2);
						wv wv = new wv(c5x2);
						wv.c(this.c().aa().Vehicle.ah() + "_Open");
						wv.d(this.c().aa().Vehicle.ah() + "_Close");
						wv.a(this.c().aa().Vehicle);
						wv.c(2.5f);
						wv.af2(true);
						wv.ps(d98.f);
						wv.a("Creatures\\" + this.c().g.a[CharacterState.Custom1].b);
						c5x2.SetAspect<bim>(wv);
						wv.d();
						ay2 aspect2 = new ay2(c5x2);
						c5x2.SetAspect<bbw>(aspect2);
						if (!string.IsNullOrEmpty(wv.g().f()) || wv.g().z() > 0)
						{
							d2b d2b = new d2b(c5x2);
							d2b.b(wv.g().f());
							d2b.a(wv.g().z());
							d2b.d(true);
							c5x2.SetAspect<d2b>(d2b);
						}
						HashSet<string> hashSet = new HashSet<string>();
						foreach (string text in wv.g().l())
						{
							hashSet.Add(text);
						}
						if (wv.g().ak())
						{
							hashSet.Add(this.c().aa().FactionId);
						}
						wv.a(c44.e);
						c3g c3g = new c3g(c5x2);
						c3g.d().AddRange(hashSet);
						c5x2.SetAspect<c3g>(c3g);
						this.c().a8().Area.a(c5x2);
					}
					else
					{
						c5x = new c5x();
						if (this.c().aa().b(d8o.b))
						{
							c5x.q(this.c().aa().Name + " - тело");
						}
						else if (!this.c().aa().b(d8o.e))
						{
							c5x.q(this.c().aa().Name + " - тело");
						}
						else
						{
							c5x.q("Останки");
						}
						CharacterState? characterState = null;
						if (aspect != null)
						{
							characterState = aspect.a().GetPrimitivePropertyValue<CharacterState>("CustomDeadAnimation", null);
						}
						if (characterState != null)
						{
							int a_ = 1;
							try
							{
								a_ = this.c().g.a[characterState.Value].a;
							}
							catch
							{
							}
							etz etz3 = new etz(c5x);
							etz3.d(225);
							etz3.a(true);
							etz3.c(a_);
							etz3.a = "Creatures\\" + this.c().g.a[characterState.Value].b;
							etz3.b = new Point(0, this.c().a8().ac);
							c5x.SetAspect<cd0>(etz3);
						}
						else
						{
							c5x.SetAspect<cd0>(new cd0(c5x)
							{
								b = new Point(this.c().g.a[CharacterState.Die].a - 1, this.c().a8().ac),
								a = "Creatures\\" + this.c().g.a[CharacterState.Die].b
							});
						}
						cd0 aspect3 = c5x.GetAspect<cd0>();
						if (this.f == b7u.e && !this.c().aa().b(d8o.e))
						{
							if (aspect3 != null)
							{
								aspect3.f = 0.2f;
							}
							alv aspect4 = c5x.GetAspect<alv>();
							if (aspect4 != null)
							{
								foreach (cd0 cd in aspect4.a)
								{
									cd.f = 0.2f;
								}
							}
							string text2 = "Effects\\";
							if (cuo.a.NextDouble() < 1.0)
							{
								text2 += "CitySmokeX";
							}
							else
							{
								text2 += "CitySmokeXS";
							}
							c5x c5x3 = vq.a(text2, this.c().a8().Zone, new bt4(this.c().a8().Area.y8(), this.c().a8().Location + new Vector3(0.6f, 0.2f, 0.2f)), false);
							if (c5x3 != null)
							{
								c5x3.x = this.c().a8().x;
								c5x3.Size = this.c().a8().Size;
								etz etz4 = c5x3.o.b as etz;
								if (etz4 != null)
								{
									etz4.a(true);
								}
								int a_2 = (int)(180000.0 * (0.75 + 0.5 * cuo.a.NextDouble()));
								cm aspect5 = new cm(c5x3, a_2, false);
								c5x3.SetAspect<cm>(aspect5);
							}
						}
						if (aspect3 != null)
						{
							if (this.c().am != 1f || this.c().al != 1f)
							{
								aspect3.i = new Vector2(this.c().am, this.c().al);
							}
							if (this.c().ao != null && this.f != b7u.e)
							{
								aspect3.c = this.c().ao;
							}
							if (this.c().an != null && this.f != b7u.e)
							{
								aspect3.g = this.c().an;
							}
							else
							{
								aspect3.g = new float?(0f);
							}
						}
						c5x.VisualPriority = this.c().a8().VisualPriority;
						c5x.VisualDirection = this.c().a8().VisualDirection;
						c5x.Location = this.c().a8().Location;
						c5x.Size = this.c().a8().Size;
						c5x.Layer = aju.x;
						c5x.x = this.c().a8().x;
						if (this.c().aa().Vehicle != null)
						{
							c5x.z = this.c().a8().z;
							c5x.y = this.c().a8().y;
						}
						if (this.c().a8().k.b == null)
						{
							c5x.TileFormationModifiers = new bjp(this.c().a8().TileFormationModifiers.b);
						}
						a3f a3f = new a3f(c5x);
						a3f.a()["CorpseSourceName"] = this.c().aa().Name;
						a3f.a()["CorpseSourceFaction"] = this.c().aa().FactionId;
						a3f.a()["IsCorpse"] = true;
						c5x.SetAspect<a3f>(a3f);
						c7j c7j2 = new c7j(c5x);
						c7j2.g(false);
						if (this.c().aa().b(d8o.b))
						{
							c7j2.c("BackpackOpen");
						}
						else if (this.c().an() == ai5.g)
						{
							c7j2.c("JunkRummage");
						}
						else if (this.c().an() == ai5.f)
						{
							c7j2.c("RocksRummage");
						}
						else
						{
							c7j2.c("CarcassOpen");
						}
						if (this.c().a8().GetAspect<abh>() != null || this.c().ab() || (aspect != null && aspect.a().GetPrimitivePropertyValue<bool>("AlwaysDespawnEmptyRemains", new bool?(false)).Value))
						{
							List<cze> list3 = c7j2.p();
							d3y d3y2 = new d3y();
							d3y2.a(true);
							list3.Add(d3y2);
						}
						else
						{
							c7j2.p().Add(new d3y());
						}
						c5x.SetAspect<bim>(c7j2);
						this.c().a8().Area.a(c5x);
						Point point3;
						Point point4;
						c5x.a(out point3, out point4);
						if (point3 != point4)
						{
							c7j2.c(0.5f);
						}
					}
				}
				catch
				{
				}
			}
			IL_10A5:
			if (c5x != null)
			{
				c5x.b("Corpse_" + this.c().a8().qe().ToString());
				c5x.b("FactionCorpse_" + this.c().aa().FactionId);
				if (c5x.s.b != null)
				{
					double? primitivePropertyValue = this.c().aa().CustomProperties.GetPrimitivePropertyValue<double>("up_CorpseUsageRange", null);
					if (primitivePropertyValue != null)
					{
						c5x.s.b.c((float)primitivePropertyValue.Value);
					}
				}
			}
			string a_3 = null;
			if (this.f == b7u.b)
			{
				a_3 = "IcyRemains";
			}
			else if (this.f == b7u.c)
			{
				a_3 = "Ashes";
			}
			if (flag)
			{
				new pq(list, a_3, this.f == b7u.a || this.f == b7u.e, (c5x != null) ? new ar7(c5x) : null).ym(null, this.c().a8(), a3f.a(this.c().a8()));
			}
		}
		this.c().a8().TileFormationModifiers.c();
		this.c().a8().z();
		dtb dtb = new dtb();
		if ((this.c().ax() || this.a(this.c())) && !this.c().a1() && this.c().an() == ai5.b && this.c().a8().k.b != null && (aspect == null || !aspect.a().GetPrimitivePropertyValue<bool>("BloodlessDeath", new bool?(false)).Value) && this.c().aa().Vehicle == null)
		{
			c5x c5x4 = vq.a("Floor\\BloodPool", this.c().a8().Zone, new bt4(this.c().a8().Area.y8(), this.c().a8().Location), false);
			if (c5x4 != null && c5x4.o.b != null)
			{
				if (this.f == b7u.e && !this.c().aa().b(d8o.e))
				{
					c5x4.o.b.f = 0.4f;
				}
				c5x4.o.b.b = new Point(0, cuo.a.Next(3));
				dqm dqm = new dqm(c5x4.o.b);
				dqm.b(0);
				dqm.c(7);
				dqm.a((double)dz6.b(100));
				dqm item2 = dqm;
				dtb.ad().Add(item2);
			}
		}
		if ((!this.c().aa().Passive && (!this.c().ax() || (list.Count <= 0 && !this.c().ar())) && !this.a(this.c()) && (this.f == b7u.a || this.f == b7u.e)) || this.c().a1())
		{
			ad6 ad = new ad6(this.c().a8());
			ad.b(1.0);
			ad.c(0.0);
			ad.a(dz6.a(0.002));
			dtb.ad().Add(ad);
		}
		else
		{
			this.c().a8().ae = new float?(0f);
		}
		Dictionary<string, object> dictionary = a3f.a(this.c().a8());
		foreach (cze cze in this.c().aj())
		{
			dictionary["deathType"] = this.f;
			cze.ym(null, this.c().a8(), dictionary);
		}
		c7 c = new c7(this.c().a8(), true, true, false, true);
		c.a(true);
		c7 item3 = c;
		dtb.ad().Add(item3);
		this.c().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
	}

	// Token: 0x060073E2 RID: 29666 RVA: 0x00310914 File Offset: 0x0030EB14
	private bool a(amc A_0)
	{
		return A_0.aa().c(d8o.b) && A_0.a8().GetAspect<abh>() == null && A_0.aa().FactionId != asp.d;
	}

	// Token: 0x060073E3 RID: 29667 RVA: 0x0031095C File Offset: 0x0030EB5C
	private void a()
	{
		c5x c5x = this.c().a8();
		c5x a_ = c5x;
		string a_2 = "ColdHit";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
		c5x.c().a("Shattering", "IceShattering", 1f, c9z.a, false, false);
		eym.a(c5x, (double)aju.bl);
		Vector3 vector = c5x.aj();
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					Vector3 vector2 = new Vector3(vector.X + (float)i, vector.Y + (float)j, 0f);
					Point point = vector2.a();
					if (point.X >= 0 && point.Y >= 0 && point.X < c5x.Area.Size.c && point.Y < c5x.Area.Size.d)
					{
						for (float num = 0f; num <= 2f; num += 0.66f)
						{
							vector2.Z = num;
							this.a(c5x.Area, vector2, new Vector3(vector.X, vector.Y, 2f * (float)d3q.a.NextDouble()));
						}
					}
				}
			}
		}
	}

	// Token: 0x060073E4 RID: 29668 RVA: 0x00310AF4 File Offset: 0x0030ECF4
	private void a(aud A_0, Vector3 A_1, Vector3 A_2)
	{
		Vector3.Distance(A_2, A_1);
		b0b b0b;
		auv item = es2.a(A_2, A_1, A_0, "IceChip", null, out b0b);
		cd0 aspect = b0b.GetAspect<cd0>();
		if (aspect != null)
		{
			aspect.b = new Point(d3q.a.Next(5), 0);
		}
		qy qy = new qy();
		qy.ad().Add(item);
		qy.ad().Add(new c7(b0b, false, false, true, false));
		A_0.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
	}

	// Token: 0x04002F5B RID: 12123
	private new static readonly Random a = new Random();

	// Token: 0x04002F5C RID: 12124
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002F5D RID: 12125
	private double c;

	// Token: 0x04002F5E RID: 12126
	private int d;

	// Token: 0x04002F5F RID: 12127
	private int e;

	// Token: 0x04002F60 RID: 12128
	private b7u f;

	// Token: 0x02001432 RID: 5170
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060073E9 RID: 29673 RVA: 0x00310BA0 File Offset: 0x0030EDA0
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x00310BA8 File Offset: 0x0030EDA8
		internal bool b(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04002F61 RID: 12129
		public static readonly d3q.a a = new d3q.a();

		// Token: 0x04002F62 RID: 12130
		public static Func<b0b, bool> b;

		// Token: 0x04002F63 RID: 12131
		public static Func<b0b, bool> c;
	}
}
