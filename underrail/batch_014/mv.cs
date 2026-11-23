using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x02000771 RID: 1905
public sealed class mv : a7m, evy
{
	// Token: 0x06003039 RID: 12345 RVA: 0x00126280 File Offset: 0x00124480
	public override string es()
	{
		return this.eu();
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x00126288 File Offset: 0x00124488
	public new int d()
	{
		return this.e;
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x00126290 File Offset: 0x00124490
	public new double e()
	{
		return this.f;
	}

	// Token: 0x0600303C RID: 12348 RVA: 0x0012629C File Offset: 0x0012449C
	static mv()
	{
		mv.d[a5j.a] = Color.Yellow;
		mv.d[a5j.b] = new Color(0, 255, 0);
		mv.d[a5j.c] = Color.Red;
	}

	// Token: 0x0600303D RID: 12349 RVA: 0x001262F8 File Offset: 0x001244F8
	public mv(dbn A_0) : base(A_0)
	{
		this.b();
	}

	// Token: 0x0600303E RID: 12350 RVA: 0x00126314 File Offset: 0x00124514
	private void b()
	{
		li service = bpo.GetService<li>();
		this.k = new eg0();
		if (service != null)
		{
			base.a(service.j9());
			this.u = service.j9().a;
			this.y = new a23(this);
			this.p.Add(this.y);
			this.o.Add(new csm());
			this.o.Add(new a9k());
			this.a();
		}
		this.e.a = true;
		this.d.a(0.125f);
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x001263B4 File Offset: 0x001245B4
	private void a()
	{
		this.c.Add("IceBlock", new dj6());
		this.c.Add("Chilled", new bz0());
		this.c.Add("Stunned", new aed());
		this.c.Add("Dazed", new dhc());
		this.c.Add("AcidBlobEntanglement", new do5());
		this.c.Add("CorrosiveAcidBlobEntanglement", new ed5());
		this.c.Add("RustingAcidBlobEntanglement", new aum());
		this.c.Add("Stealth", new dvj());
		this.c.Add("Displacement", new a95());
		this.c.Add("Incapacitated", new by5());
		this.c.Add("NetEntanglement", new dle(false));
		this.c.Add("BarbedNetEntanglement", new dle(true));
		this.c.Add("StoneBolasEntanglement", new est());
		this.c.Add("Fear", new cyl());
		this.c.Add("Inhibited", new czs());
		this.c.Add("Burning", new ejm());
		this.c.Add("Pulsating", new bu());
		this.c.Add("Electricity", new bwj());
		this.c.Add("MetallineEnergization", new bjj());
		this.c.Add("EnergyShieldEmpowerment", new drs());
		this.c.Add("BearTrap", new agv());
		this.c.Add("HopperTrap", new ef7());
		this.c.Add("PoisonedBearTrap", new gi());
		this.c.Add("CaveEarPoisonBearTrap", new ae5());
		this.c.Add("CrawlerPoisonBearTrap", new z4());
		this.c.Add("BlindingPoisonBearTrap", new c58());
		this.c.Add("LeperPoisonBearTrap", new c9f());
		this.c.Add("HeartbreakPoisonBearTrap", new a29());
		this.c.Add("BlackDragonPoisonBearTrap", new dda());
		this.c.Add("SpiritPoisonBearTrap", new bi6());
		this.c.Add("Compass", new b66());
		this.c.Add("Smoking", new ay8());
		this.c.Add("Rage", new ahe());
		this.c.Add("WebEntanglement", new x7());
		this.c.Add("Immobilized", new a3j());
		this.c.Add("HeadTrap", new b56());
		this.c.Add("PseudoSpatialProjection", new bsw());
		this.c.Add("DisruptiveField", new ack());
		this.c.Add("Cryoshield", new dvs());
		this.c.Add("ShieldRecharging", new drc());
		this.c.Add("StaticElectricity", new dt7());
		this.c.Add("EntropicRecurrence", new fj());
		this.c.Add("Precognition", new hd());
		this.c.Add("Stasis", new cjs());
		this.c.Add("TemporalDistortion", new d7g());
		this.c.Add("ElectroshockAura", new eul());
		this.c.Add("Polarized", new egt());
		this.c.Add("VoidMist", new adp());
		this.c.Add("ScrambledAi", new e8g());
		this.c.Add("Charred", new c8p());
		this.c.Add("Chemhaze", new bvp());
		this.c.Add("WirelessChargingAura", new lw());
		this.c.Add("ColdLaserInterception", new bhj());
		this.c.Add("DesignatorLaser", new dpy());
		this.c.Add("IndustrialExoskeletonAura", new @as());
		this.c.Add("HolographicGlitch", new b3r());
		this.c.Add("FrostSpirit", new a4f());
		this.c.Add("PsychokineticChainLink", new abl());
		this.c.Add("TelekineticGrounding", new crh());
		this.c.Add("PsychosomaticPrey", new es0());
		this.c.Add("LaserDesignatedTarget", new diq());
	}

	// Token: 0x06003040 RID: 12352 RVA: 0x001268C4 File Offset: 0x00124AC4
	private void a(cp9 A_0)
	{
		if (this.x != null && this.x.a != null && this.y != null)
		{
			this.vs();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null)
				{
					Vector2 a_ = this.vq(c5x.Location.X, c5x.Location.Y, 0f) + this.u.b() * this.y;
					Texture2D resource = A_0.a.GetResource<Texture2D>("Locale\\Meta\\Blank", null);
					for (int i = 0; i < this.x.a.Count; i++)
					{
						eos eos = this.x.a[i];
						Vector2 vector = this.vq(eos.a.X / 4f, eos.a.Y / 4f, 0f);
						Vector2 vector2 = vector + this.u.b() * this.y;
						Color color = mv.d[eos.b];
						mv.a(A_0.b(), resource, 2f, color * 0.5f, a_, vector2);
						if (i == this.x.a.Count - 1)
						{
							this.y.d(A_0, vector, color * 0.1f, this);
							this.y.a(A_0, vector, color, this);
						}
						a_ = vector2;
					}
				}
			}
		}
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x00126A98 File Offset: 0x00124C98
	private static void a(ob A_0, Texture2D A_1, float A_2, Color A_3, Vector2 A_4, Vector2 A_5)
	{
		float a_ = (float)Math.Atan2((double)(A_5.Y - A_4.Y), (double)(A_5.X - A_4.X));
		float num = Vector2.Distance(A_4, A_5);
		A_0.w9(A_1, A_4, null, A_3, a_, Vector2.Zero, new Vector2(num, A_2), SpriteEffects.None, 0f);
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x00126AFC File Offset: 0x00124CFC
	public string eu()
	{
		if (!this.Enabled)
		{
			return TimelapseCursor.Impossible.ToString();
		}
		object obj = base.an2();
		if (obj == null)
		{
			obj = base.an1();
		}
		bi3 service = bpo.GetService<bi3>();
		if (service == null || service.aij() == null)
		{
			ps service2 = bpo.GetService<ps>();
			if (service2 != null)
			{
				object obj2 = null;
				if (base.an2() != null)
				{
					obj2 = base.an2();
				}
				else if (base.an1() != null)
				{
					obj2 = base.an1();
				}
				if (obj2 != null)
				{
					bad bad = service2.aln(obj2);
					if (bad != null)
					{
						TimelapseCursor? timelapseCursor = bad.eh(obj2);
						if (timelapseCursor != null)
						{
							return timelapseCursor.Value.ToString();
						}
					}
				}
			}
			return null;
		}
		if (service.aij().eg() == null || !service.aij().eg().cg(obj))
		{
			return TimelapseCursor.Impossible.ToString();
		}
		TimelapseCursor? timelapseCursor2 = service.aij().eh(obj);
		if (timelapseCursor2 != null)
		{
			return timelapseCursor2.Value.ToString();
		}
		return null;
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x00126C3C File Offset: 0x00124E3C
	public override void ag5(e6d A_0)
	{
		this.ab = null;
		this.t = A_0;
		this.aa = bpo.GetService<bi3>();
		ps service = bpo.GetService<ps>();
		cnk service2 = bpo.GetService<cnk>();
		if (service2 != null)
		{
			this.s = service2.aq1();
			this.ao = false;
			if (this.s != null)
			{
				this.ao = this.s.g().e;
			}
		}
		eg0 eg = this.k as eg0;
		if (eg != null)
		{
			eg0 eg2 = eg;
			bool? flag;
			if (service2 == null)
			{
				flag = null;
			}
			else
			{
				ls ls = service2.aq1();
				if (ls == null)
				{
					flag = null;
				}
				else
				{
					cnt cnt = ls.g();
					flag = ((cnt != null) ? new bool?(cnt.g) : null);
				}
			}
			bool? flag2 = flag;
			eg2.a = flag2.GetValueOrDefault(true);
		}
		if (service != null && !service.ak4())
		{
			this.r = service.alf();
		}
		this.v = false;
		this.x = null;
		if (service != null && service2 != null && service2.aqu() != null && service2.aqu().v() != null)
		{
			this.ab = service2.aqu().v();
			d02 service3 = bpo.GetService<d02>();
			if (service3 != null && service3.ahg())
			{
				this.v = true;
				d4n d4n = service3.ahu(service2.aqu().v());
				if (d4n != null && service3.ahe() == d4n && service3.ahi() == bh3.b)
				{
					this.x = service.alh().abk();
				}
			}
		}
		if (this.aa != null && this.ab != null && this.ab.b() != null)
		{
			this.ac = false;
			if (this.aa.aij() != null && this.aa.aij().eg() != null)
			{
				this.ac = this.aa.aij().eg().cg(this.ab.b());
			}
		}
		else
		{
			this.ac = true;
		}
		this.ac = A_0.c().IsKeyDown(d1o.a(Hotkey.ReverseHighlight));
		base.ag5(A_0);
	}

	// Token: 0x06003044 RID: 12356 RVA: 0x00126E90 File Offset: 0x00125090
	public override void iv(e6d A_0, cp9 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
		eg0 eg = this.k as eg0;
		if (eg != null)
		{
			eg0 eg2 = eg;
			bool? flag;
			if (serviceOrThrow == null)
			{
				flag = null;
			}
			else
			{
				ls ls = serviceOrThrow.aq1();
				if (ls == null)
				{
					flag = null;
				}
				else
				{
					cnt cnt = ls.g();
					flag = ((cnt != null) ? new bool?(cnt.g) : null);
				}
			}
			bool? flag2 = flag;
			eg2.a = flag2.GetValueOrDefault(true);
		}
		if (serviceOrThrow2 != null && !serviceOrThrow2.ak4() && (this.f += A_0.a().ElapsedGameTime.TotalMilliseconds) > 100.0)
		{
			this.e++;
			this.f = 0.0;
		}
		this.ar = (serviceOrThrow != null && serviceOrThrow.aq1() != null && serviceOrThrow.aq1().g().f == TimelapseShader.Advanced);
		this.w = (serviceOrThrow2.ale() && !this.l);
		this.z = new Dictionary<Point, ci8>();
		this.l = false;
		this.n = null;
		d4m service = bpo.GetService<d4m>();
		if (service != null && service.avo() is a5c)
		{
			this.l = true;
		}
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			this.j = ((!this.l && serviceOrThrow.aqu().v().Darkvision) || this.g);
			this.o = serviceOrThrow.aqu().v().b();
			this.m = serviceOrThrow.aqu().v().SpecialStates.g;
			if (serviceOrThrow.aqu().v().Gear.g().Item != null && !string.IsNullOrEmpty(serviceOrThrow.aqu().v().Gear.g().Item.fu().a5()) && serviceOrThrow.aqu().v().Gear.g().Item.fu().a5() == "perceptualIsolationHelmet")
			{
				this.k = true;
			}
			else
			{
				this.k = false;
			}
			if (!this.l)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.t.b != null)
				{
					this.n = new bzv(c5x.t.b.y6()).a();
				}
			}
		}
		else
		{
			this.m = false;
			this.j = false;
			this.k = false;
			this.c = null;
		}
		this.p = serviceOrThrow2.ak5();
		this.q = serviceOrThrow2.am4(A_0.a().ElapsedGameTime);
		this.ad = (serviceOrThrow2.ale() || serviceOrThrow2.ald());
		this.ae = (serviceOrThrow2.ale() && !this.l);
		base.iv(A_0, A_1);
		this.a(A_1);
	}

	// Token: 0x06003045 RID: 12357 RVA: 0x00127210 File Offset: 0x00125410
	public am4 a(ud A_0)
	{
		if (A_0 == null || A_0.a == null)
		{
			return null;
		}
		am4 result;
		this.c.TryGetValue(A_0.a, out result);
		return result;
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00127248 File Offset: 0x00125448
	public new void c()
	{
		base.b(null);
		base.c(null);
	}

	// Token: 0x06003047 RID: 12359 RVA: 0x0012725C File Offset: 0x0012545C
	public override bool iq(e08 A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		ebk ebk = A_0.a() as ebk;
		ps service = bpo.GetService<ps>();
		return service != null && ebk != null && A_0.c() is coh && service.alb().ye(ebk, A_0.c() as coh);
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x001272B8 File Offset: 0x001254B8
	protected override void ag6(object A_0, etu A_1)
	{
		base.ag6(A_0, A_1);
		coh a_ = A_1.b().c() as coh;
		ebk a_2 = A_1.b().a() as ebk;
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			c69.a(a_2, service.alb(), a_, false);
		}
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x0012730C File Offset: 0x0012550C
	protected override void ir(a2f A_0, Color A_1)
	{
		e5q e5q = (e5q)A_0.n;
		if (this.i != null)
		{
			Vector4 vector;
			if (A_0.e == null)
			{
				vector = Vector4.One;
			}
			else
			{
				vector = A_0.e.Value.ToVector4();
			}
			vector *= this.i.Value.ToVector4();
			Vector4 vector2 = A_1.ToVector4();
			vector = new Vector4(vector.X * Math.Min(1f, (A_0.f + vector2.X * (1f - A_0.f)) * A_0.g), vector.Y * Math.Min(1f, (A_0.f + vector2.Y * (1f - A_0.f)) * A_0.g), vector.Z * Math.Min(1f, (A_0.f + vector2.Z * (1f - A_0.f)) * A_0.g), vector.W * Math.Min(1f, A_0.f + vector2.W * (1f - A_0.f)));
			A_0.e = new Color?(new Color(vector));
			if (A_0.h != null)
			{
				A_0.e = new Color?(A_0.e.Value * A_0.h.Value);
				return;
			}
		}
		else if (this.k)
		{
			base.ir(A_0, A_1);
			if (A_0 is f6)
			{
				A_0.e = new Color?(new Color(0, 0, 0));
				return;
			}
		}
		else if (this.j && !this.h)
		{
			if (this.ar)
			{
				f6 f = A_0 as f6;
				if (f != null && f.a)
				{
					base.ir(A_0, A_1);
					return;
				}
				Vector4 vector3;
				if (A_0.e == null)
				{
					vector3 = Vector4.One;
				}
				else
				{
					vector3 = A_0.e.Value.ToVector4();
				}
				Color value = new Color(vector3);
				if (A_0.h != null)
				{
					A_0.e = new Color?(value * A_0.h.Value);
					return;
				}
				A_0.e = new Color?(value);
				return;
			}
			else
			{
				base.ir(A_0, A_1);
				f6 f2 = A_0 as f6;
				if (f2 != null && !f2.a)
				{
					Color value2 = A_0.e.Value;
					value2.G = byte.MaxValue;
					if (value2.B > 150)
					{
						value2.B = 100;
					}
					if (value2.R > 150)
					{
						value2.R = 100;
					}
					if (A_0.h != null)
					{
						A_0.e = new Color?(value2 * A_0.h.Value);
						return;
					}
					A_0.e = new Color?(value2);
					return;
				}
			}
		}
		else
		{
			base.ir(A_0, A_1);
		}
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x00127634 File Offset: 0x00125834
	protected override bool @is(b0b A_0, ak1 A_1)
	{
		c5x c5x = A_0 as c5x;
		if (c5x.TileFormationModifiers.c(8388608L))
		{
			return false;
		}
		dha aspect = c5x.GetAspect<dha>();
		if (aspect != null && aspect.i() != null)
		{
			return this.@is(aspect.i(), A_1);
		}
		return A_1.Formation.c(4L) || ((aspect == null || !aspect.e()) && A_1.Formation.c(2L) && (c5x.h.b == null || !c5x.h.b.aa().b(d8o.l)) && !(c5x.s.b is wv));
	}

	// Token: 0x0600304B RID: 12363 RVA: 0x0012770C File Offset: 0x0012590C
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		if (this.e != null && this.e.a)
		{
			KeyboardState state = Keyboard.GetState();
			if (state.IsKeyDown(Keys.LeftShift) || state.IsKeyDown(Keys.RightShift))
			{
				base.an9().uo((float)(A_1.c() / 120) * this.e.b);
				base.f();
				cnk cnk = ces.a();
				if (cnk != null)
				{
					cnk.aq9(base.an9().ua());
				}
			}
		}
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x001277A8 File Offset: 0x001259A8
	public override void iu(cp9 A_0, SpriteSortMode A_1, BlendState A_2, SamplerState A_3, DepthStencilState A_4, RasterizerState A_5)
	{
		bpo.GetService<cnk>();
		if (!this.ar)
		{
			base.iu(A_0, A_1, A_2, A_3, A_4, A_5);
			return;
		}
		Effect resource;
		if (this.h)
		{
			resource = A_0.a.GetResource<Effect>("Shaders\\ElectronicCameraShader", new double?((double)-1));
			Texture2D value = A_0.a.us("Gui\\NightvisionGrain", new double?((double)-1));
			EffectParameter effectParameter = resource.Parameters["NightvisionGrainTexture"];
			if (effectParameter != null)
			{
				effectParameter.SetValue(value);
			}
			EffectParameter effectParameter2 = resource.Parameters["PixelOffset"];
			if (effectParameter2 != null)
			{
				effectParameter2.SetValue(new Vector2((float)this.al, (float)this.am));
			}
		}
		else if (this.j)
		{
			int num = (int)((long)(new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds / 75.0) % 64L);
			int value2 = num % 4;
			int value3 = num / 4;
			Texture2D value4 = A_0.a.us("Gui\\NightvisionGrain", new double?((double)-1));
			resource = A_0.a.GetResource<Effect>("Shaders\\LocaleNightvisionShader", new double?((double)-1));
			EffectParameter effectParameter3 = resource.Parameters["NightvisionGrainTexture"];
			if (effectParameter3 != null)
			{
				effectParameter3.SetValue(value4);
			}
			EffectParameter effectParameter4 = resource.Parameters["GrainFrameX"];
			if (effectParameter4 != null)
			{
				effectParameter4.SetValue(value2);
			}
			EffectParameter effectParameter5 = resource.Parameters["GrainFrameY"];
			if (effectParameter5 != null)
			{
				effectParameter5.SetValue(value3);
			}
			EffectParameter effectParameter6 = resource.Parameters["PixelOffset"];
			if (effectParameter6 != null)
			{
				effectParameter6.SetValue(new Vector2((float)this.al, (float)this.am));
			}
		}
		else
		{
			resource = A_0.a.GetResource<Effect>("Shaders\\LocaleOmniShader", new double?((double)-1));
		}
		if (resource == null)
		{
			base.iu(A_0, A_1, A_2, A_3, A_4, A_5);
			return;
		}
		if (this.af == null)
		{
			this.af = new drl(A_0.c, 10000);
		}
		this.af.w3(A_1, A_2, A_3, A_4, A_5, resource);
		A_0.a(this.af);
	}

	// Token: 0x04001A59 RID: 6745
	private new const int a = 100;

	// Token: 0x04001A5A RID: 6746
	public new static readonly double b = 60000.0;

	// Token: 0x04001A5B RID: 6747
	public new Dictionary<string, am4> c = new Dictionary<string, am4>();

	// Token: 0x04001A5C RID: 6748
	public new static readonly Dictionary<a5j, Color> d = new Dictionary<a5j, Color>();

	// Token: 0x04001A5D RID: 6749
	private new int e;

	// Token: 0x04001A5E RID: 6750
	private new double f;

	// Token: 0x04001A5F RID: 6751
	public new bool g;

	// Token: 0x04001A60 RID: 6752
	public new bool h;

	// Token: 0x04001A61 RID: 6753
	public new Color? i;

	// Token: 0x04001A62 RID: 6754
	public new bool j;

	// Token: 0x04001A63 RID: 6755
	public new bool k;

	// Token: 0x04001A64 RID: 6756
	public new bool l;

	// Token: 0x04001A65 RID: 6757
	public new bool m;

	// Token: 0x04001A66 RID: 6758
	public new Dictionary<Guid, blk> n;

	// Token: 0x04001A67 RID: 6759
	public new b0b o;

	// Token: 0x04001A68 RID: 6760
	public new ado p;

	// Token: 0x04001A69 RID: 6761
	public new baa q;

	// Token: 0x04001A6A RID: 6762
	public new aje r;

	// Token: 0x04001A6B RID: 6763
	public ls s;

	// Token: 0x04001A6C RID: 6764
	public e6d t;

	// Token: 0x04001A6D RID: 6765
	public new esj u;

	// Token: 0x04001A6E RID: 6766
	public bool v;

	// Token: 0x04001A6F RID: 6767
	public bool w;

	// Token: 0x04001A70 RID: 6768
	private new ax4 x;

	// Token: 0x04001A71 RID: 6769
	private new a23 y;

	// Token: 0x04001A72 RID: 6770
	public Dictionary<Point, ci8> z;

	// Token: 0x04001A73 RID: 6771
	public bi3 aa;

	// Token: 0x04001A74 RID: 6772
	public au2 ab;

	// Token: 0x04001A75 RID: 6773
	public new bool ac;

	// Token: 0x04001A76 RID: 6774
	public bool ad;

	// Token: 0x04001A77 RID: 6775
	public bool ae;

	// Token: 0x04001A78 RID: 6776
	private new drl af;
}
