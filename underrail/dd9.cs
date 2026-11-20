using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012D3 RID: 4819
[eiz("GFE")]
[Serializable]
public sealed class dd9 : Aspect<c5x>, ISerializable, chb, cmm
{
	// Token: 0x06006A85 RID: 27269 RVA: 0x002CDBF8 File Offset: 0x002CBDF8
	private dd9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("GFE:L");
		this.b = A_0.GetString("GFE:O");
		this.c = (A_0.GetValue("GFE:B", typeof(Guid?)) as Guid?);
		this.d = A_0.GetDouble("GFE:C");
		this.e = A_0.GetBoolean("GFE:D");
		if (ell.a() >= 399)
		{
			this.f = A_0.GetDouble("GFE:S");
		}
		if (ell.a() >= 613)
		{
			this.g = A_0.GetBoolean("GFE:N");
		}
	}

	// Token: 0x06006A86 RID: 27270 RVA: 0x002CDCC8 File Offset: 0x002CBEC8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GFE:L", this.a);
		info.AddValue("GFE:O", this.b);
		info.AddValue("GFE:B", this.c);
		info.AddValue("GFE:C", this.d);
		info.AddValue("GFE:D", this.e);
		info.AddValue("GFE:S", this.f);
		info.AddValue("GFE:N", this.g);
	}

	// Token: 0x06006A87 RID: 27271 RVA: 0x002CDD5C File Offset: 0x002CBF5C
	public bool e()
	{
		return this.e;
	}

	// Token: 0x06006A88 RID: 27272 RVA: 0x002CDD64 File Offset: 0x002CBF64
	public bool f()
	{
		return this.g;
	}

	// Token: 0x06006A89 RID: 27273 RVA: 0x002CDD6C File Offset: 0x002CBF6C
	public void a(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006A8A RID: 27274 RVA: 0x002CDD78 File Offset: 0x002CBF78
	public dd9(c5x A_0, string A_1, Guid? A_2) : base(A_0)
	{
		this.b = A_1;
		this.c = A_2;
		this.d = (double)d0u.b;
	}

	// Token: 0x06006A8B RID: 27275 RVA: 0x002CDDAC File Offset: 0x002CBFAC
	public void b(double A_0)
	{
		if (!this.e)
		{
			this.a += A_0;
			this.a();
		}
	}

	// Token: 0x06006A8C RID: 27276 RVA: 0x002CDDD0 File Offset: 0x002CBFD0
	public void a(double A_0)
	{
		if (!this.e)
		{
			this.a -= A_0;
			this.a();
		}
	}

	// Token: 0x06006A8D RID: 27277 RVA: 0x002CDDF4 File Offset: 0x002CBFF4
	public void b()
	{
		ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
		ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
		if (ak != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && !c5x.h.b.aa().Passive && c5x.aj().a() == ak.Location)
				{
					int a_ = (int)Math.Min(3.0, this.a) + 1;
					a1q a_2 = c18.a(c5x.h.b.aa(), a_, false);
					cwt cwt = new cwt();
					cwt.i = new ap9("Fire", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.b : null);
					cwt.f.Add(euf.a(a_2, 1.0));
					cwt.l = true;
					cwt.v = "огонь";
					cwt.b = true;
					cwt.y = "{2} получает ";
					c5x.h.b.aa().Defense.a(cwt);
					if (zoneControlLevel != ZoneControlLevel.Uncontrolled && this.b == asp.a)
					{
						cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
						if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
						{
							awq.a(serviceOrThrow.aqu().v().b() as c5x, c5x, false, false, true, false, false, false);
						}
					}
					awq.a(c5x.h.b, true);
				}
				else if (c5x.y.b != null)
				{
					c5x.y.b.a(null);
				}
				ce1 aspect = c5x.GetAspect<ce1>();
				if (aspect != null)
				{
					aspect.n3(this.d());
				}
			}
			ak.Zone.ActionManager.g9(new eu8(base.a8(), d8o.g, ak, 5, d0u.b * 2, null), atp.a);
			List<ak1> list = aw1.c(ak);
			HashSet<c5x> hashSet = new HashSet<c5x>();
			foreach (ak1 ak2 in list)
			{
				foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.c.Values))
				{
					c5x c5x2 = (c5x)b0b2;
					if (!hashSet.Contains(c5x2))
					{
						anc aspect2 = c5x2.GetAspect<anc>();
						if (aspect2 != null)
						{
							hashSet.Add(c5x2);
							aspect2.a(null);
						}
					}
				}
			}
		}
		if (!this.g)
		{
			this.a(0.165 + cuo.a.NextDouble() * 0.07);
		}
	}

	// Token: 0x06006A8E RID: 27278 RVA: 0x002CE190 File Offset: 0x002CC390
	public void a(c5x A_0)
	{
		ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
		int a_ = (int)Math.Min(3.0, this.a) + 1;
		a1q a_2 = c18.a(A_0.h.b.aa(), a_, true);
		if (A_0.h.b != null && !A_0.h.b.aa().Passive)
		{
			cwt cwt = new cwt();
			cwt.i = new ap9("Fire", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.b : null);
			cwt.f.Add(euf.a(a_2, 1.0));
			cwt.l = true;
			cwt.v = "огонь";
			cwt.b = true;
			cwt.y = "{2} получает ";
			A_0.h.b.aa().Defense.a(cwt);
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && this.b == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
			awq.a(A_0.h.b, true);
		}
	}

	// Token: 0x06006A8F RID: 27279 RVA: 0x002CE314 File Offset: 0x002CC514
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if ((this.d -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.d += (double)d0u.b;
				this.b();
			}
		}
		else
		{
			this.d = (double)d0u.b;
		}
		if ((this.f -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			this.f += 1000.0;
			dd5.a(base.a8());
		}
	}

	// Token: 0x06006A90 RID: 27280 RVA: 0x002CE3C8 File Offset: 0x002CC5C8
	public void c()
	{
		this.b();
	}

	// Token: 0x06006A91 RID: 27281 RVA: 0x002CE3D0 File Offset: 0x002CC5D0
	public int d()
	{
		return d05.a(1, (int)this.a + 1, 4);
	}

	// Token: 0x06006A92 RID: 27282 RVA: 0x002CE3E4 File Offset: 0x002CC5E4
	public void c9(TimeSpan A_0)
	{
		if (!this.g)
		{
			double num = A_0.TotalMilliseconds;
			while (num > (double)d0u.b)
			{
				num -= (double)d0u.b;
				this.a(0.165 + cuo.a.NextDouble() * 0.07);
			}
		}
	}

	// Token: 0x06006A93 RID: 27283 RVA: 0x002CE440 File Offset: 0x002CC640
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006A94 RID: 27284 RVA: 0x002CE448 File Offset: 0x002CC648
	private bool a()
	{
		if (this.a > (double)c18.y)
		{
			this.a = (double)c18.y;
		}
		if (this.a <= 0.0 && base.a8().Zone != null)
		{
			this.a(0);
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				List<ya> list = ak.a(typeof(oe));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						oe oe = ya as oe;
						if (oe != null && oe.a() != null && oe.a().ao() == this)
						{
							oe.o();
						}
					}
				}
			}
			bool flag = a3i.a;
			if (base.a8().i.b != null)
			{
				base.a8().i.b.a(true, false);
			}
			if (flag)
			{
				if (this.c != null)
				{
					c5x c5x = base.a8().Area.a(this.c.Value) as c5x;
					if (c5x != null)
					{
						c5x.h();
					}
				}
				base.a8().h();
			}
			else
			{
				ah7 ah = base.a8().Zone.i("burningGround" + base.a8().qe().ToString());
				qy qy = new qy();
				if (ah != null)
				{
					qy.ad().Add(new fx(ah, ah.Light.c(), 0f, -0.00075f, true));
				}
				qy.ad().Add(new c7(base.a8(), true, true, false, false));
				if (this.c != null)
				{
					c5x c5x2 = new ar7(this.c.Value, base.a8().Area).ao() as c5x;
					if (c5x2 != null)
					{
						qy.ad().Add(new c7(c5x2, true, true, false, false));
					}
				}
				base.a8().Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
			this.e = true;
			return true;
		}
		int a_ = (int)Math.Min(3.0, this.a);
		this.a(a_);
		return false;
	}

	// Token: 0x06006A95 RID: 27285 RVA: 0x002CE6F8 File Offset: 0x002CC8F8
	private void a(int A_0)
	{
		if (base.a8() != null && base.a8().o != null && base.a8().o.b != null)
		{
			base.a8().c().a("горению", 0.4f + (float)(A_0 + 1) * 0.15f);
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, A_0);
			if (this.c != null)
			{
				c5x c5x = new ar7(this.c.Value, base.a8().Area).ao() as c5x;
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					if (aspect != null)
					{
						aspect.b = new Point(aspect.b.X, A_0);
					}
				}
			}
		}
		dxo aspect2 = base.a8().GetAspect<dxo>();
		if (aspect2 != null)
		{
			aspect2.a(aspect2.b(), 0.3f + (float)A_0 * 0.07f, 0.4f + (float)A_0 * 0.08f, 0.0004 + (double)A_0 * 7E-05);
		}
	}

	// Token: 0x04002BBF RID: 11199
	private double a = -0.1;

	// Token: 0x04002BC0 RID: 11200
	private string b;

	// Token: 0x04002BC1 RID: 11201
	private Guid? c;

	// Token: 0x04002BC2 RID: 11202
	private double d;

	// Token: 0x04002BC3 RID: 11203
	private bool e;

	// Token: 0x04002BC4 RID: 11204
	private double f;

	// Token: 0x04002BC5 RID: 11205
	private bool g;
}
