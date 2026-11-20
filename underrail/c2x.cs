using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020012BB RID: 4795
[eiz("CSEA")]
[Serializable]
public sealed class c2x : Aspect<c5x>, ISerializable, cmm, chb
{
	// Token: 0x060069A9 RID: 27049 RVA: 0x002C8B18 File Offset: 0x002C6D18
	private c2x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("CSEA:R", typeof(TimeSpan?)) as TimeSpan?);
		this.c = (TimeSpan)A_0.GetValue("CSEA:C", typeof(TimeSpan));
		this.d = A_0.GetDouble("CSEA:A");
		this.e = (A_0.GetValue("CSEA:S", typeof(ar7)) as ar7);
		this.f = A_0.GetBoolean("CSEA:T");
		this.g = A_0.GetBoolean("CSEA:K");
		this.h = A_0.GetString("CSEA:CR");
		this.i = A_0.GetBoolean("CSEA:M");
		if (ell.a() >= 353)
		{
			this.j = A_0.GetInt32("CSEA:H");
		}
		else
		{
			this.j = 100;
		}
		if (ell.a() >= 530)
		{
			this.k = (A_0.GetValue("CSEA:D", typeof(HorizontalDirection?)) as HorizontalDirection?);
		}
	}

	// Token: 0x060069AA RID: 27050 RVA: 0x002C8C5C File Offset: 0x002C6E5C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSEA:R", this.b);
		info.AddValue("CSEA:C", this.c);
		info.AddValue("CSEA:A", this.d);
		info.AddValue("CSEA:S", this.e);
		info.AddValue("CSEA:T", this.f);
		info.AddValue("CSEA:K", this.g);
		info.AddValue("CSEA:CR", this.h);
		info.AddValue("CSEA:M", this.i);
		info.AddValue("CSEA:H", this.j);
		info.AddValue("CSEA:D", this.k);
	}

	// Token: 0x060069AB RID: 27051 RVA: 0x002C8D2C File Offset: 0x002C6F2C
	public TimeSpan? h()
	{
		return this.b;
	}

	// Token: 0x060069AC RID: 27052 RVA: 0x002C8D34 File Offset: 0x002C6F34
	public void a(TimeSpan? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060069AD RID: 27053 RVA: 0x002C8D40 File Offset: 0x002C6F40
	public string k()
	{
		return this.h;
	}

	// Token: 0x060069AE RID: 27054 RVA: 0x002C8D48 File Offset: 0x002C6F48
	public void a(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060069AF RID: 27055 RVA: 0x002C8D54 File Offset: 0x002C6F54
	public bool i()
	{
		return this.i;
	}

	// Token: 0x060069B0 RID: 27056 RVA: 0x002C8D5C File Offset: 0x002C6F5C
	public void a(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060069B1 RID: 27057 RVA: 0x002C8D68 File Offset: 0x002C6F68
	public int j()
	{
		return this.j;
	}

	// Token: 0x060069B2 RID: 27058 RVA: 0x002C8D70 File Offset: 0x002C6F70
	public void b(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060069B3 RID: 27059 RVA: 0x002C8D7C File Offset: 0x002C6F7C
	public c2x(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060069B4 RID: 27060 RVA: 0x002C8D9C File Offset: 0x002C6F9C
	public void r7(eds A_0)
	{
		this.f();
		if (this.f && (this.e == null || this.e.ao() == null))
		{
			this.g = true;
			this.e = null;
			this.c = TimeSpan.Zero;
			this.k = new HorizontalDirection?((HorizontalDirection)cuo.a.Next(8));
		}
		if (!dz6.e())
		{
			this.a(A_0.b);
			this.d += A_0.b.TotalMilliseconds;
			if (this.d > 1500.0)
			{
				this.g();
				this.d = 0.0;
			}
		}
		this.e();
	}

	// Token: 0x060069B5 RID: 27061 RVA: 0x002C8E64 File Offset: 0x002C7064
	public void c()
	{
		this.g();
		this.d = 0.0;
	}

	// Token: 0x060069B6 RID: 27062 RVA: 0x002C8E7C File Offset: 0x002C707C
	public void c9(TimeSpan A_0)
	{
		this.a(A_0);
	}

	// Token: 0x060069B7 RID: 27063 RVA: 0x002C8E88 File Offset: 0x002C7088
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060069B8 RID: 27064 RVA: 0x002C8E8C File Offset: 0x002C708C
	public bool a(int? A_0 = null, bool A_1 = true)
	{
		bool result = false;
		this.f();
		if (!this.f && !this.g)
		{
			if (A_0 != null)
			{
				int num = this.a(A_0.Value);
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x != null && c5x.Area == base.a8().Area && serviceOrThrow.aqu().v().SpecialStates.g && serviceOrThrow.aqu().v().Skills.Get<a2n>().g() >= num)
					{
						return false;
					}
				}
			}
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null && !aw1.a(null, ak, false, null))
			{
				this.f = true;
				c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\creatures\\" + this.h);
				if (c5k != null)
				{
					c5x c5x2 = c5k.a(null, false) as c5x;
					if (c5x2 != null)
					{
						this.f();
						this.b();
						c5x2.Location = base.a8().Location;
						c5x2.Layer = aju.x;
						c5x2.h.b.ap = new CharacterState?(CharacterState.Custom2);
						c5x2.h.b.aq = new int?(0);
						c5x2.t.b.a(false);
						base.a8().Area.a(c5x2);
						this.e = new ar7(c5x2);
						c5x c5x3 = new c5x();
						c5x3.Size = new Vector3(1f, 1f, 1f);
						c5x3.TileFormationModifiers.s3(1);
						c5x3.Location = ak.Location.a();
						c5x3.VisualDirection = this.k.Value;
						base.a8().Area.a(c5x3);
						awx awx = new awx();
						awx awx2 = awx;
						awx2.a(awx2.kh() | (m7.b | m7.k));
						awx.b(false);
						awx.c(false);
						awx.a(false);
						if (A_1)
						{
							awx.ad().Add(new a4s(new bfq("xpbl_CrabUnburrow"), null, new ar7(c5x2), null));
						}
						awx.ad().Add(new au0(c5x2.Area, c5x2.Location, "xpbl_CrabSand", 1, double.MaxValue, null, null, null));
						awx.ad().Add(new e4t(c5x2.h.b, CharacterState.Custom2, dz6.b(100), 0, null, 1));
						awx.ad().Add(new a4s(new epw(null), null, new ar7(c5x2), null));
						awx.ad().Add(new a4s(new b16(null), null, new ar7(c5x2), null));
						awx.ad().Add(new c7(c5x3, false, false, true, false));
						awx.ad().Add(new a4s(new clv(true), null, new ar7(c5x2), null));
						c5x2.i.b.b(awx, atp.a);
						result = true;
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
								c5x c5x4 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.c.Values, new Func<b0b, bool>(c2x.a.a.a))) as c5x;
								if (c5x4 != null)
								{
									c5x4.GetAspect<c2x>().a(new int?(int.MaxValue), false);
								}
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060069B9 RID: 27065 RVA: 0x002C9320 File Offset: 0x002C7520
	private int a(int A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			Random random = new Random(base.a8().qe().GetHashCode() / 2 + serviceOrThrow.aqu().l() / 2);
			double num = 0.75 + Math.Pow(random.NextDouble(), 1.75) * 1.75;
			return (int)((double)A_0 * num);
		}
		return A_0;
	}

	// Token: 0x060069BA RID: 27066 RVA: 0x002C93A0 File Offset: 0x002C75A0
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

	// Token: 0x060069BB RID: 27067 RVA: 0x002C9410 File Offset: 0x002C7610
	private void g()
	{
		if (!this.i && !this.f && !this.g)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == base.a8().Area && aw1.b(c5x, base.a8()) <= 4.0)
				{
					ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
					if (ak != null && ak.b(dm9.b))
					{
						this.a(new int?(this.j), true);
					}
				}
			}
		}
	}

	// Token: 0x060069BC RID: 27068 RVA: 0x002C94E8 File Offset: 0x002C76E8
	private void f()
	{
		if (this.k == null)
		{
			this.k = new HorizontalDirection?((HorizontalDirection)cuo.a.Next(8));
		}
	}

	// Token: 0x060069BD RID: 27069 RVA: 0x002C9514 File Offset: 0x002C7714
	private void e()
	{
		if (!this.f)
		{
			d60 d = base.a8().Zone.a();
			if (d != null)
			{
				string text = this.a();
				c5x c5x = d.ab5(text) as c5x;
				if (c5x == null && !string.IsNullOrEmpty(this.h))
				{
					int x = 0;
					Dictionary<string, int> dictionary = new Dictionary<string, int>();
					dictionary["xpbl\\giantcrab"] = 0;
					dictionary["xpbl\\colossalcrab"] = 1;
					dictionary["xpbl\\psicrab"] = 2;
					dictionary.TryGetValue(this.h.ToLowerInvariant(), out x);
					this.f();
					c5x c5x2 = new c5x();
					c5x2.Location = base.a8().Location;
					c5x2.Size = new Vector3(1f, 1f, 0.1f);
					c5x2.IsFloor = true;
					c5x2.VisualPriority = 100;
					c5x2.Layer = aju.x;
					c5x2.SetAspect<cd0>(new a2o(c5x2)
					{
						a = "Floor\\xpbl_BassaltHiddenCrabs",
						b = new Point(x, 0)
					});
					c5x2.b(text);
					base.a8().Area.a(c5x2);
					c5x2.VisualDirection = this.k.Value;
					c5x = c5x2;
				}
				c5x.ae = this.d();
			}
		}
	}

	// Token: 0x060069BE RID: 27070 RVA: 0x002C966C File Offset: 0x002C786C
	private float? d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().BaseAbilities.Perception < 8)
		{
			return new float?(Math.Max(0.3f, 1f - (float)(8 - serviceOrThrow.aqu().v().BaseAbilities.Perception) * 0.1f));
		}
		return null;
	}

	// Token: 0x060069BF RID: 27071 RVA: 0x002C96F4 File Offset: 0x002C78F4
	private void b()
	{
		d60 d = base.a8().Zone.a();
		if (d != null)
		{
			string a_ = this.a();
			c5x c5x = d.ab5(a_) as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}

	// Token: 0x060069C0 RID: 27072 RVA: 0x002C9740 File Offset: 0x002C7940
	private string a()
	{
		return string.Format("CrabSpawnerCue_{0}", base.a8().qe());
	}

	// Token: 0x04002B84 RID: 11140
	private const int a = 1500;

	// Token: 0x04002B85 RID: 11141
	private TimeSpan? b;

	// Token: 0x04002B86 RID: 11142
	private TimeSpan c;

	// Token: 0x04002B87 RID: 11143
	private double d;

	// Token: 0x04002B88 RID: 11144
	private ar7 e;

	// Token: 0x04002B89 RID: 11145
	private bool f;

	// Token: 0x04002B8A RID: 11146
	private bool g;

	// Token: 0x04002B8B RID: 11147
	private string h = "Xpbl\\GiantCrab";

	// Token: 0x04002B8C RID: 11148
	private bool i;

	// Token: 0x04002B8D RID: 11149
	private int j = 100;

	// Token: 0x04002B8E RID: 11150
	private HorizontalDirection? k;

	// Token: 0x020012BC RID: 4796
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060069C3 RID: 27075 RVA: 0x002C9770 File Offset: 0x002C7970
		internal bool a(b0b A_0)
		{
			return A_0.GetAspect<c2x>() != null;
		}

		// Token: 0x04002B8F RID: 11151
		public static readonly c2x.a a = new c2x.a();

		// Token: 0x04002B90 RID: 11152
		public static Func<b0b, bool> b;
	}
}
