using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.Space;

// Token: 0x02000C62 RID: 3170
[eiz("LE2")]
[Serializable]
public class c5x : b0b, ISerializable, eh7, dke
{
	// Token: 0x0600472C RID: 18220 RVA: 0x001D5FA8 File Offset: 0x001D41A8
	protected c5x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.ac = A_0.GetInt32("LE2:AVD");
			this.ad = (Color?)A_0.GetValue("LE2:CO", typeof(Color?));
			this.ae = (float?)A_0.GetValue("LE2:AO", typeof(float?));
			this.af = (float?)A_0.GetValue("LE2:SO", typeof(float?));
			if (ell.b() >= 5)
			{
				di7.ReadEvent<c1>("LE2:AVDC", ref this.ah, A_0);
			}
			else
			{
				this.ah = (EventHandler<c1>)A_0.GetValue("LE2:AVDC", typeof(EventHandler<c1>));
			}
			if (ell.a() >= 18)
			{
				this.ab = (e2b)A_0.GetValue("LE2:CF", typeof(e2b));
			}
			if (ell.a() >= 490)
			{
				this.ag = (A_0.GetValue("LE2:D", typeof(Point?)) as Point?);
				return;
			}
		}
		else
		{
			this.ac = A_0.GetInt32("_AxonometricVisualDirection");
			this.ad = (A_0.GetValue("_ColorOverride", typeof(Color?)) as Color?);
			this.ae = (A_0.GetValue("_AlphaOverride", typeof(float?)) as float?);
			this.ah = (A_0.GetValue("e_AxonometricVisualDirectionChanged", typeof(EventHandler<c1>)) as EventHandler<c1>);
		}
	}

	// Token: 0x0600472D RID: 18221 RVA: 0x001D6158 File Offset: 0x001D4358
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LE2:AVD", this.ac);
		info.AddValue("LE2:CO", this.ad);
		info.AddValue("LE2:AO", this.ae);
		info.AddValue("LE2:SO", this.af);
		di7.WriteEvent<c1>("LE2:AVDC", this.ah, info);
		info.AddValue("LE2:CF", this.ab);
		info.AddValue("LE2:D", this.ag);
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x0600472E RID: 18222 RVA: 0x001D6200 File Offset: 0x001D4400
	public bool IsPlayer
	{
		get
		{
			return (this.g & e2b.d) > (e2b)0;
		}
	}

	// Token: 0x0600472F RID: 18223 RVA: 0x001D6210 File Offset: 0x001D4410
	[CompilerGenerated]
	public new void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ah;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004730 RID: 18224 RVA: 0x001D6248 File Offset: 0x001D4448
	[CompilerGenerated]
	public new void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ah;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004731 RID: 18225 RVA: 0x001D6280 File Offset: 0x001D4480
	public c5x()
	{
		this.f();
	}

	// Token: 0x06004732 RID: 18226 RVA: 0x001D6290 File Offset: 0x001D4490
	public c5x(Guid A_0) : base(A_0, null)
	{
		this.f();
	}

	// Token: 0x06004733 RID: 18227 RVA: 0x001D62A0 File Offset: 0x001D44A0
	private new void f()
	{
		this.ac = (int)this.e();
		this.k();
	}

	// Token: 0x06004734 RID: 18228 RVA: 0x001D62B8 File Offset: 0x001D44B8
	public void k()
	{
		if (this.o == null)
		{
			this.o = new QuickAspectAccessor<cd0>(this);
		}
		this.o.b();
		if (this.p == null)
		{
			this.p = new QuickAspectAccessor<alv>(this);
		}
		this.p.b();
		if (this.q == null)
		{
			this.q = new QuickAspectAccessor<ka>(this);
		}
		this.q.b();
		if (this.h == null)
		{
			this.h = new QuickAspectAccessor<amc>(this);
		}
		this.h.b();
		if (this.i == null)
		{
			this.i = new QuickAspectAccessor<ny>(this);
		}
		this.i.b();
		if (this.j == null)
		{
			this.j = new QuickAspectAccessor<mj>(this);
		}
		this.j.b();
		if (this.k == null)
		{
			this.k = new QuickAspectAccessor<ale>(this);
		}
		this.k.b();
		if (this.l == null)
		{
			this.l = new QuickAspectAccessor<su>(this);
		}
		this.l.b();
		if (this.m == null)
		{
			this.m = new QuickAspectAccessor<j7>(this);
		}
		this.m.b();
		if (this.n == null)
		{
			this.n = new QuickAspectAccessor<u2>(this);
		}
		this.n.b();
		if (this.r == null)
		{
			this.r = new QuickAspectAccessor<b4h>(this);
		}
		this.r.b();
		if (this.s == null)
		{
			this.s = new QuickAspectAccessor<bim>(this);
		}
		this.s.b();
		if (this.t == null)
		{
			this.t = new QuickAspectAccessor<bm6>(this);
		}
		this.t.b();
		if (this.u == null)
		{
			this.u = new QuickAspectAccessor<c0s>(this);
		}
		this.u.b();
		if (this.v == null)
		{
			this.v = new QuickAspectAccessor<aru>(this);
		}
		this.v.b();
		if (this.w == null)
		{
			this.w = new QuickAspectAccessor<b8b>(this);
		}
		this.w.b();
		if (this.x == null)
		{
			this.x = new QuickAspectAccessor<dqv>(this);
		}
		this.x.b();
		if (this.y == null)
		{
			this.y = new QuickAspectAccessor<anc>(this);
		}
		this.y.b();
		if (this.z == null)
		{
			this.z = new QuickAspectAccessor<b30>(this);
		}
		this.z.b();
	}

	// Token: 0x06004735 RID: 18229 RVA: 0x001D654C File Offset: 0x001D474C
	private new HorizontalDirection e()
	{
		return a63.b(base.VisualDirection);
	}

	// Token: 0x06004736 RID: 18230 RVA: 0x001D655C File Offset: 0x001D475C
	private new void d()
	{
		a6p aspect = base.GetAspect<a6p>();
		if (aspect != null)
		{
			aspect.mx();
		}
		if (c5x.a != null && c5x.b == null && base.Zone != null)
		{
			TimeSpan? primitivePropertyValue = base.Zone.CustomProperties.GetPrimitivePropertyValue<TimeSpan>(a46.b, null);
			if (primitivePropertyValue != null)
			{
				c5x.b = new bool?(true);
				c5x.c = c5x.a - primitivePropertyValue;
			}
			else
			{
				c5x.b = new bool?(false);
			}
		}
		foreach (cn7 cn in base.Aspects)
		{
			if (c5x.b != null && c5x.b.Value)
			{
				cmm cmm = cn as cmm;
				try
				{
					if (cmm != null)
					{
						cmm.c9(c5x.c.Value);
					}
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to synchronize aspect {0} on entity {1}.", new object[]
					{
						cn.GetType().Name,
						this.ToString()
					});
				}
			}
			bp1 bp = cn as bp1;
			try
			{
				if (bp != null && bp != aspect)
				{
					bp.mx();
				}
			}
			catch (Exception a_2)
			{
				dux.a(LogSeverity.Error, a_2, "Failed to initialize aspect {0} on entity {1}.", new object[]
				{
					cn.GetType().Name,
					this.ToString()
				});
			}
			chb chb = cn as chb;
			if (chb != null)
			{
				dz6.b(chb);
			}
		}
		if (!this.IsPlayer && this.h.b != null && base.y8() != null && new string(Enumerable.ToArray<char>(Enumerable.Reverse<char>(base.y8()))).Equals("oigreS"))
		{
			this.h.b.aa().Name = new string(Enumerable.ToArray<char>(Enumerable.Reverse<char>("draziW eht oigreS")));
			base.q(new string(Enumerable.ToArray<char>(Enumerable.Reverse<char>("draziW eht oigreS"))));
		}
	}

	// Token: 0x06004737 RID: 18231 RVA: 0x001D682C File Offset: 0x001D4A2C
	private void c()
	{
		foreach (cn7 cn in base.Aspects)
		{
			if (c5x.a != null)
			{
				cmm cmm = cn as cmm;
				if (cmm != null)
				{
					cmm.da(c5x.a.Value);
				}
			}
			bp1 bp = cn as bp1;
			if (bp != null)
			{
				bp.my();
			}
			chb chb = cn as chb;
			if (chb != null)
			{
				dz6.a(chb);
			}
		}
	}

	// Token: 0x06004738 RID: 18232 RVA: 0x001D68D0 File Offset: 0x001D4AD0
	private new void b()
	{
		if (this.j == cgy.b)
		{
			if (this.aa == null)
			{
				if (Enumerable.Any<c98>(Enumerable.OfType<c98>(base.Aspects)))
				{
					this.aa = new b05(this);
					base.Zone.ActionManager.g9(this.aa, atp.a);
					return;
				}
			}
			else if (!Enumerable.Any<c98>(Enumerable.OfType<c98>(base.Aspects)))
			{
				this.aa.j();
				this.aa = null;
			}
		}
	}

	// Token: 0x06004739 RID: 18233 RVA: 0x001D6954 File Offset: 0x001D4B54
	private new void a()
	{
		if (this.aa != null)
		{
			this.aa.j();
			this.aa = null;
		}
	}

	// Token: 0x0600473A RID: 18234 RVA: 0x001D6974 File Offset: 0x001D4B74
	protected override void ai8()
	{
		this.k();
	}

	// Token: 0x0600473B RID: 18235 RVA: 0x001D697C File Offset: 0x001D4B7C
	protected override void ai9(bool A_0)
	{
		this.g |= this.ab;
		this.k();
		this.d();
		this.b();
	}

	// Token: 0x0600473C RID: 18236 RVA: 0x001D69A4 File Offset: 0x001D4BA4
	protected override void aja(bool A_0)
	{
		this.c();
		this.a();
	}

	// Token: 0x0600473D RID: 18237 RVA: 0x001D69B4 File Offset: 0x001D4BB4
	protected override void ajb(object A_0, EventArgs A_1)
	{
		base.ajb(A_0, A_1);
		this.b();
	}

	// Token: 0x0600473E RID: 18238 RVA: 0x001D69C4 File Offset: 0x001D4BC4
	protected override void ajc(object A_0, EventArgs A_1)
	{
		base.ajc(A_0, A_1);
	}

	// Token: 0x0600473F RID: 18239 RVA: 0x001D69D0 File Offset: 0x001D4BD0
	protected override void ajd(object A_0, EventArgs A_1)
	{
		base.ajd(A_0, A_1);
		if (this.i != null && this.i.b != null)
		{
			this.i.b.a(true, false);
		}
	}

	// Token: 0x06004740 RID: 18240 RVA: 0x001D6A0C File Offset: 0x001D4C0C
	protected override void aje(cn7 A_0)
	{
		base.aje(A_0);
		if (base.Initialized)
		{
			bp1 bp = A_0 as bp1;
			if (bp != null)
			{
				bp.mx();
			}
			chb chb = A_0 as chb;
			if (chb != null)
			{
				dz6.b(chb);
			}
		}
		if (A_0 is c98)
		{
			this.b();
		}
	}

	// Token: 0x06004741 RID: 18241 RVA: 0x001D6A64 File Offset: 0x001D4C64
	protected override void ajf(cn7 A_0)
	{
		bp1 bp = A_0 as bp1;
		if (bp != null)
		{
			bp.my();
		}
		chb chb = A_0 as chb;
		if (chb != null)
		{
			dz6.a(chb);
		}
		base.ajf(A_0);
		if (A_0 is c98)
		{
			this.b();
		}
	}

	// Token: 0x06004742 RID: 18242 RVA: 0x001D6AB0 File Offset: 0x001D4CB0
	protected override Color ajg()
	{
		if (this.ag != null && base.Area != null)
		{
			ak1 ak = base.Area.b((int)base.Location.X + this.ag.Value.X, (int)base.Location.Y + this.ag.Value.Y);
			if (ak != null)
			{
				return ak.Lightning;
			}
		}
		return base.ajg();
	}

	// Token: 0x06004743 RID: 18243 RVA: 0x001D6B34 File Offset: 0x001D4D34
	public new double l()
	{
		return bui.a(base.Lightning);
	}

	// Token: 0x06004744 RID: 18244 RVA: 0x001D6B44 File Offset: 0x001D4D44
	public override void ajh()
	{
		base.ajh();
		foreach (b0w b0w in Enumerable.OfType<b0w>(base.Aspects))
		{
			b0w.qa();
		}
	}

	// Token: 0x06004745 RID: 18245 RVA: 0x001D6BA4 File Offset: 0x001D4DA4
	public override void aji()
	{
		base.aji();
		foreach (b0w b0w in Enumerable.OfType<b0w>(base.Aspects))
		{
			b0w.v2();
		}
	}

	// Token: 0x06004746 RID: 18246 RVA: 0x001D6C04 File Offset: 0x001D4E04
	public override void ajj()
	{
		base.ajj();
		foreach (b0w b0w in Enumerable.OfType<b0w>(base.Aspects))
		{
			b0w.v3();
		}
	}

	// Token: 0x06004747 RID: 18247 RVA: 0x001D6C64 File Offset: 0x001D4E64
	public override void ajk(float A_0)
	{
		base.ajk(A_0);
		if (this.o != null && this.o.b != null)
		{
			this.o.b.d = new float?(A_0);
			return;
		}
		if (this.p != null && this.p.b != null)
		{
			foreach (cd0 cd in this.p.b.a)
			{
				cd.d = new float?(A_0);
			}
		}
	}

	// Token: 0x06004748 RID: 18248 RVA: 0x001D6D20 File Offset: 0x001D4F20
	public override float? ajl()
	{
		float? num = null;
		if (this.o != null && this.o.b != null)
		{
			num = this.o.b.d;
		}
		else if (this.p != null && this.p.b != null)
		{
			foreach (cd0 cd in this.p.b.a)
			{
				float num2 = (cd.d != null) ? cd.d.Value : 1f;
				if (num == null || num.Value < num2)
				{
					num = new float?(num2);
				}
			}
		}
		if (this.ae != null)
		{
			if (num != null)
			{
				float? num3 = num;
				float num4 = (float)1;
				if (!(num3.GetValueOrDefault() == num4 & num3 != null))
				{
					return new float?(num.Value * this.ae.Value);
				}
			}
			return new float?(this.ae.Value);
		}
		return num;
	}

	// Token: 0x06004749 RID: 18249 RVA: 0x001D6E7C File Offset: 0x001D507C
	public override void ajm(b0b A_0)
	{
		base.ajm(A_0);
		foreach (b0w b0w in Enumerable.OfType<b0w>(base.Aspects))
		{
			b0w.p9(A_0);
		}
	}

	// Token: 0x0600474A RID: 18250 RVA: 0x001D6EDC File Offset: 0x001D50DC
	public new ax1 j()
	{
		if (base.Zone != null)
		{
			return base.Zone.GetAddon<ax1>();
		}
		return null;
	}

	// Token: 0x0600474B RID: 18251 RVA: 0x001D6EF8 File Offset: 0x001D50F8
	public new bool d(e2b A_0)
	{
		return (this.g & A_0) > (e2b)0;
	}

	// Token: 0x0600474C RID: 18252 RVA: 0x001D6F08 File Offset: 0x001D5108
	public bool c(e2b A_0)
	{
		return (this.g & A_0) == A_0;
	}

	// Token: 0x0600474D RID: 18253 RVA: 0x001D6F18 File Offset: 0x001D5118
	public new void b(e2b A_0)
	{
		this.g |= A_0;
	}

	// Token: 0x0600474E RID: 18254 RVA: 0x001D6F28 File Offset: 0x001D5128
	public new void a(e2b A_0)
	{
		this.g &= ~A_0;
	}

	// Token: 0x0600474F RID: 18255 RVA: 0x001D6F3C File Offset: 0x001D513C
	public new void h()
	{
		aud a_ = base.Area;
		base.w();
		base.an();
		if (pp.b != null && pp.b.aqu() != null && base.GetAspect<dqv>() != null)
		{
			pp.b.aru(this, a_);
		}
	}

	// Token: 0x06004750 RID: 18256 RVA: 0x001D6F90 File Offset: 0x001D5190
	public esj i()
	{
		esj result;
		if (this.z != null)
		{
			result = new esj((int)Math.Ceiling((double)base.Size.X) * 4 - 1, (int)Math.Ceiling((double)base.Size.Y) * 4 - 1);
		}
		else
		{
			result = new esj(4, 4);
		}
		return result;
	}

	// Token: 0x06004751 RID: 18257 RVA: 0x001D6FF0 File Offset: 0x001D51F0
	protected sealed override void ajn(object A_0, c1 A_1)
	{
		int num = (int)this.e();
		if (num != this.ac)
		{
			int num2 = this.ac;
			this.ac = num;
			if (this.ah != null)
			{
				this.ah(this, new c1(num2, this.ac));
			}
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06004752 RID: 18258 RVA: 0x001D704C File Offset: 0x001D524C
	efk eh7.Character
	{
		get
		{
			if (this.h != null && this.h.b != null)
			{
				return this.h.b.aa();
			}
			return null;
		}
	}

	// Token: 0x06004753 RID: 18259 RVA: 0x001D707C File Offset: 0x001D527C
	int dke.n()
	{
		if (this.s != null && this.s.b != null)
		{
			return this.s.b.p;
		}
		return 0;
	}

	// Token: 0x06004754 RID: 18260 RVA: 0x001D70AC File Offset: 0x001D52AC
	string dke.g()
	{
		if (this.s != null && this.s.b != null)
		{
			return this.s.b.q;
		}
		return "Using";
	}

	// Token: 0x06004755 RID: 18261 RVA: 0x001D70E0 File Offset: 0x001D52E0
	public override void ajo()
	{
		ny aspect = base.GetAspect<ny>();
		if (aspect != null)
		{
			aspect.a(true, false);
		}
	}

	// Token: 0x06004756 RID: 18262 RVA: 0x001D7104 File Offset: 0x001D5304
	public new bsf a(string A_0)
	{
		if (base.RaysEmitters != null && base.RaysEmitters.Count > 0)
		{
			foreach (ejt ejt in base.RaysEmitters)
			{
				bsf bsf = ejt as bsf;
				if (bsf != null && bsf.Definition != null && bsf.Definition.Name == A_0)
				{
					return bsf;
				}
			}
		}
		return null;
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06004757 RID: 18263 RVA: 0x001D71A8 File Offset: 0x001D53A8
	public string LocalizedName
	{
		get
		{
			if (global::aji.a == null)
			{
				return this.b;
			}
			string text = qv.b("EntityNames/" + this.b);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return this.b;
		}
	}

	// Token: 0x04001C73 RID: 7283
	public new static TimeSpan? a;

	// Token: 0x04001C74 RID: 7284
	public new static bool? b;

	// Token: 0x04001C75 RID: 7285
	public new static TimeSpan? c;

	// Token: 0x04001C76 RID: 7286
	[NonSerialized]
	public new bool d;

	// Token: 0x04001C77 RID: 7287
	[NonSerialized]
	public new bool e;

	// Token: 0x04001C78 RID: 7288
	[NonSerialized]
	public new bool f;

	// Token: 0x04001C79 RID: 7289
	[NonSerialized]
	public new e2b g;

	// Token: 0x04001C7A RID: 7290
	[NonSerialized]
	public new QuickAspectAccessor<amc> h;

	// Token: 0x04001C7B RID: 7291
	[NonSerialized]
	public new QuickAspectAccessor<ny> i;

	// Token: 0x04001C7C RID: 7292
	[NonSerialized]
	public new QuickAspectAccessor<mj> j;

	// Token: 0x04001C7D RID: 7293
	[NonSerialized]
	public QuickAspectAccessor<ale> k;

	// Token: 0x04001C7E RID: 7294
	[NonSerialized]
	public new QuickAspectAccessor<su> l;

	// Token: 0x04001C7F RID: 7295
	[NonSerialized]
	public new QuickAspectAccessor<j7> m;

	// Token: 0x04001C80 RID: 7296
	[NonSerialized]
	public QuickAspectAccessor<u2> n;

	// Token: 0x04001C81 RID: 7297
	[NonSerialized]
	public QuickAspectAccessor<cd0> o;

	// Token: 0x04001C82 RID: 7298
	[NonSerialized]
	public QuickAspectAccessor<alv> p;

	// Token: 0x04001C83 RID: 7299
	[NonSerialized]
	public QuickAspectAccessor<ka> q;

	// Token: 0x04001C84 RID: 7300
	[NonSerialized]
	public new QuickAspectAccessor<b4h> r;

	// Token: 0x04001C85 RID: 7301
	[NonSerialized]
	public new QuickAspectAccessor<bim> s;

	// Token: 0x04001C86 RID: 7302
	[NonSerialized]
	public new QuickAspectAccessor<bm6> t;

	// Token: 0x04001C87 RID: 7303
	[NonSerialized]
	public new QuickAspectAccessor<c0s> u;

	// Token: 0x04001C88 RID: 7304
	[NonSerialized]
	public new QuickAspectAccessor<aru> v;

	// Token: 0x04001C89 RID: 7305
	[NonSerialized]
	public new QuickAspectAccessor<b8b> w;

	// Token: 0x04001C8A RID: 7306
	[NonSerialized]
	public new QuickAspectAccessor<dqv> x;

	// Token: 0x04001C8B RID: 7307
	[NonSerialized]
	public new QuickAspectAccessor<anc> y;

	// Token: 0x04001C8C RID: 7308
	[NonSerialized]
	public new QuickAspectAccessor<b30> z;

	// Token: 0x04001C8D RID: 7309
	[NonSerialized]
	private new b05 aa;

	// Token: 0x04001C8E RID: 7310
	public e2b ab;

	// Token: 0x04001C8F RID: 7311
	public new int ac;

	// Token: 0x04001C90 RID: 7312
	public new Color? ad;

	// Token: 0x04001C91 RID: 7313
	public new float? ae;

	// Token: 0x04001C92 RID: 7314
	public float? af;

	// Token: 0x04001C93 RID: 7315
	public Point? ag;

	// Token: 0x04001C94 RID: 7316
	[CompilerGenerated]
	private new EventHandler<c1> ah;
}
