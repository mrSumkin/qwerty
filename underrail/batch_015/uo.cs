using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020011FB RID: 4603
[eiz("MT1")]
[Serializable]
public abstract class uo : cos, ISerializable
{
	// Token: 0x060062DE RID: 25310 RVA: 0x002AB9B0 File Offset: 0x002A9BB0
	protected uo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062DF RID: 25311
	protected abstract string rm();

	// Token: 0x060062E0 RID: 25312
	protected abstract string rn();

	// Token: 0x060062E1 RID: 25313
	protected abstract string ro();

	// Token: 0x060062E2 RID: 25314 RVA: 0x002AB9BC File Offset: 0x002A9BBC
	protected virtual string aj6()
	{
		return null;
	}

	// Token: 0x060062E3 RID: 25315 RVA: 0x002AB9C0 File Offset: 0x002A9BC0
	protected virtual float rs()
	{
		return 0f;
	}

	// Token: 0x060062E4 RID: 25316 RVA: 0x002AB9C8 File Offset: 0x002A9BC8
	protected virtual int aj7()
	{
		return c18.j();
	}

	// Token: 0x060062E5 RID: 25317 RVA: 0x002AB9D4 File Offset: 0x002A9BD4
	protected override bool kr(c5x A_0, c5x A_1, bool A_2)
	{
		if (A_1.l.Count > 0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(uo.a.a.a))) as c5x;
			if (c5x != null)
			{
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				if (!A_2)
				{
					c5x.c().a("activated", this.rm(), 1f, c9z.a, false, false);
					qy.ad().Add(new cw(A_1));
					qy.ad().Add(new bm3(dz6.b(500)));
				}
				if (!string.IsNullOrEmpty(this.aj6()))
				{
					no no = new no();
					no.a(this.aj6());
					no.a(c5x.Location);
					no.a(new e6z(c5x.Area));
					qy.ad().Add(new a4s(no, null, null, null));
				}
				bfq bfq = new bfq();
				bfq.b("mine" + Guid.NewGuid().ToString());
				bfq.c(this.ro());
				bfq.a(bvl.c);
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				if (this.rs() > 0f)
				{
					eym.a(qy, c5x, (double)this.rs());
				}
				amc a_ = base.f();
				ed2 ed = A_1.r.b as ed2;
				b6a b6a = this.rp();
				b6a.ty(this.rn());
				b6a.t0(true);
				b6a.e(new e5y(a_, base.TrapItem));
				b6a.g((ed != null) ? ed.e : null);
				blv blv = this.rq();
				awb awb = new awb(Enumerable.First<ak1>(A_1.l), b6a, (blv != null) ? new ae8?(blv.a.Light) : null, (float)this.aj7(), null, null, false);
				awb.r = true;
				awb.b(this.rr());
				if (blv != null && blv.a != null)
				{
					awb.c(blv.b);
					awb.b(blv.c);
					awb.a(blv.d);
				}
				qy.ad().Add(new c7(A_1, false, false, true, false));
				qy.ad().Add(awb);
				c5x.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060062E6 RID: 25318
	protected abstract double rr();

	// Token: 0x060062E7 RID: 25319
	protected abstract blv rq();

	// Token: 0x060062E8 RID: 25320
	protected abstract b6a rp();

	// Token: 0x060062E9 RID: 25321 RVA: 0x002ABCB4 File Offset: 0x002A9EB4
	protected uo(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0200120C RID: 4620
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006341 RID: 25409 RVA: 0x002ADBF0 File Offset: 0x002ABDF0
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040029D3 RID: 10707
		public static readonly uo.a a = new uo.a();

		// Token: 0x040029D4 RID: 10708
		public static Func<b0b, bool> b;
	}
}
