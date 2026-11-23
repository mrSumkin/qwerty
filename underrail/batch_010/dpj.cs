using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020012DB RID: 4827
[eiz("SFS")]
[Serializable]
public sealed class dpj : Aspect<c5x>, ISerializable, cmm
{
	// Token: 0x06006ABA RID: 27322 RVA: 0x002CF01C File Offset: 0x002CD21C
	private dpj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("SFS:R", typeof(TimeSpan?)) as TimeSpan?);
		this.c = (TimeSpan)A_0.GetValue("SFS:C", typeof(TimeSpan));
		this.d = A_0.GetDouble("SFS:A");
		this.e = (A_0.GetValue("SFS:S", typeof(ar7)) as ar7);
		this.f = A_0.GetBoolean("SFS:T");
		this.g = A_0.GetBoolean("SFS:K");
		if (ell.a() >= 150)
		{
			this.h = (Point)A_0.GetValue("SFS:L", typeof(Point));
		}
		if (ell.a() >= 351)
		{
			this.i = A_0.GetString("SFS:I");
			this.j = A_0.GetBoolean("SFS:M");
		}
		if (ell.a() >= 352)
		{
			this.k = A_0.GetInt32("SFS:H");
			return;
		}
		this.k = 40;
	}

	// Token: 0x06006ABB RID: 27323 RVA: 0x002CF168 File Offset: 0x002CD368
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SFS:R", this.b);
		info.AddValue("SFS:C", this.c);
		info.AddValue("SFS:A", this.d);
		info.AddValue("SFS:S", this.e);
		info.AddValue("SFS:T", this.f);
		info.AddValue("SFS:K", this.g);
		info.AddValue("SFS:L", this.h);
		info.AddValue("SFS:I", this.i);
		info.AddValue("SFS:M", this.j);
		info.AddValue("SFS:H", this.k);
	}

	// Token: 0x06006ABC RID: 27324 RVA: 0x002CF238 File Offset: 0x002CD438
	public TimeSpan? b()
	{
		return this.b;
	}

	// Token: 0x06006ABD RID: 27325 RVA: 0x002CF240 File Offset: 0x002CD440
	public void a(TimeSpan? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006ABE RID: 27326 RVA: 0x002CF24C File Offset: 0x002CD44C
	public Point h()
	{
		return this.h;
	}

	// Token: 0x06006ABF RID: 27327 RVA: 0x002CF254 File Offset: 0x002CD454
	public void a(Point A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006AC0 RID: 27328 RVA: 0x002CF260 File Offset: 0x002CD460
	public string g()
	{
		return this.i;
	}

	// Token: 0x06006AC1 RID: 27329 RVA: 0x002CF268 File Offset: 0x002CD468
	public void a(string A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006AC2 RID: 27330 RVA: 0x002CF274 File Offset: 0x002CD474
	public bool e()
	{
		return this.j;
	}

	// Token: 0x06006AC3 RID: 27331 RVA: 0x002CF27C File Offset: 0x002CD47C
	public void a(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06006AC4 RID: 27332 RVA: 0x002CF288 File Offset: 0x002CD488
	public int f()
	{
		return this.k;
	}

	// Token: 0x06006AC5 RID: 27333 RVA: 0x002CF290 File Offset: 0x002CD490
	public void a(int A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06006AC6 RID: 27334 RVA: 0x002CF29C File Offset: 0x002CD49C
	public dpj(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006AC7 RID: 27335 RVA: 0x002CF2BC File Offset: 0x002CD4BC
	public void r7(eds A_0)
	{
		if (this.f && (this.e == null || this.e.ao() == null))
		{
			this.g = true;
			this.f = false;
			this.e = null;
			this.c = TimeSpan.Zero;
		}
		this.a(A_0.b);
		this.d += A_0.b.TotalMilliseconds;
		if (this.d > 1500.0)
		{
			this.a();
			this.d = 0.0;
		}
	}

	// Token: 0x06006AC8 RID: 27336 RVA: 0x002CF35C File Offset: 0x002CD55C
	public void c9(TimeSpan A_0)
	{
		this.a(A_0);
	}

	// Token: 0x06006AC9 RID: 27337 RVA: 0x002CF368 File Offset: 0x002CD568
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006ACA RID: 27338 RVA: 0x002CF36C File Offset: 0x002CD56C
	public void d()
	{
		if (!this.f && !this.g)
		{
			ak1 ak = base.a8().Area.a(this.h);
			if (ak != null && !aw1.a(null, ak, false, null))
			{
				this.f = true;
				c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\creatures\\" + this.i);
				if (c5k != null)
				{
					c5x c5x = c5k.a(null, false) as c5x;
					if (c5x != null)
					{
						c5x.Location = base.a8().Location;
						c5x.Layer = aju.x;
						c5x.h.b.ap = new CharacterState?(CharacterState.Custom1);
						c5x.h.b.aq = new int?(0);
						c5x.t.b.a(false);
						if (base.a8().Area.y8() == "cc_g5")
						{
							c5x.h.b.aa().Attributes |= d8o.h;
							a6p aspect = c5x.GetAspect<a6p>();
							if (aspect != null)
							{
								aspect.d().Add("-attributes");
							}
						}
						base.a8().Area.a(c5x);
						this.e = new ar7(c5x);
						c5x c5x2 = new c5x();
						c5x2.Size = new Vector3(1f, 1f, 1f);
						c5x2.TileFormationModifiers.s3(1);
						c5x2.Location = ak.Location.a();
						base.a8().Area.a(c5x2);
						awx awx = new awx();
						awx.b(false);
						awx.c(false);
						awx.a(false);
						awx.ad().Add(new a4s(new bfq("SiphonerSplashOut"), null, new ar7(base.a8()), null));
						List<auv> list = awx.ad();
						aud a_ = base.a8().Area;
						Vector3 a_2 = base.a8().Location;
						string a_3 = "WaterSplash";
						int a_4 = 1;
						double maxValue = double.MaxValue;
						float? a_5 = dz6.b();
						list.Add(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5));
						List<auv> list2 = awx.ad();
						bpr bpr = new bpr(c5x.j.b, ak.Location.a(), new float?((float)8), null);
						bpr.a(false);
						list2.Add(bpr);
						awx.ad().Add(new a4s(new epw(null), null, new ar7(c5x), null));
						awx.ad().Add(new a4s(new b16(null), null, new ar7(c5x), null));
						awx.ad().Add(new a4s(new bfq("SiphonerLands"), null, new ar7(c5x), null));
						awx.ad().Add(new e4t(c5x.h.b, CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
						awx.ad().Add(new c7(c5x2, false, false, true, false));
						awx.ad().Add(new a4s(new clv(true), null, new ar7(c5x), null));
						c5x.i.b.b(awx, atp.a);
					}
				}
				for (int i = -3; i <= 3; i++)
				{
					for (int j = -3; j <= 3; j++)
					{
						if (i != 0 || j != 0)
						{
							ak1 ak2 = base.a8().Area.b((int)(base.a8().Location.X + (float)i), (int)(base.a8().Location.Y + (float)j));
							if (ak2 != null)
							{
								c5x c5x3 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.c.Values, new Func<b0b, bool>(dpj.a.a.a))) as c5x;
								if (c5x3 != null)
								{
									c5x3.GetAspect<dpj>().d();
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006ACB RID: 27339 RVA: 0x002CF7BC File Offset: 0x002CD9BC
	private void a(TimeSpan A_0)
	{
		if (this.g && this.b != null)
		{
			this.c += A_0;
			if (this.c >= this.b.Value)
			{
				this.f = false;
				this.g = false;
				this.c = TimeSpan.Zero;
			}
		}
	}

	// Token: 0x06006ACC RID: 27340 RVA: 0x002CF82C File Offset: 0x002CDA2C
	private void a()
	{
		if (!this.j && !this.f && !this.g)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == base.a8().Area && aw1.b(c5x, base.a8()) <= 5.0)
				{
					ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
					if (ak != null && ak.b(dm9.b) && (!serviceOrThrow.aqu().v().SpecialStates.g || serviceOrThrow.aqu().v().Skills.Get<a2n>().g() < this.k))
					{
						this.d();
					}
				}
			}
		}
	}

	// Token: 0x04002BD1 RID: 11217
	private const int a = 1500;

	// Token: 0x04002BD2 RID: 11218
	private TimeSpan? b;

	// Token: 0x04002BD3 RID: 11219
	private TimeSpan c;

	// Token: 0x04002BD4 RID: 11220
	private double d;

	// Token: 0x04002BD5 RID: 11221
	private ar7 e;

	// Token: 0x04002BD6 RID: 11222
	private bool f;

	// Token: 0x04002BD7 RID: 11223
	private bool g;

	// Token: 0x04002BD8 RID: 11224
	private Point h;

	// Token: 0x04002BD9 RID: 11225
	private string i = "Siphoner";

	// Token: 0x04002BDA RID: 11226
	private bool j;

	// Token: 0x04002BDB RID: 11227
	private int k = 40;

	// Token: 0x020012DC RID: 4828
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006ACF RID: 27343 RVA: 0x002CF948 File Offset: 0x002CDB48
		internal bool a(b0b A_0)
		{
			return A_0.GetAspect<dpj>() != null;
		}

		// Token: 0x04002BDC RID: 11228
		public static readonly dpj.a a = new dpj.a();

		// Token: 0x04002BDD RID: 11229
		public static Func<b0b, bool> b;
	}
}
