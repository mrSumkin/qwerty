using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200147B RID: 5243
[eiz("SUD1")]
[Serializable]
public sealed class adv : a6k, ISerializable
{
	// Token: 0x0600764F RID: 30287 RVA: 0x003203C0 File Offset: 0x0031E5C0
	private adv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007650 RID: 30288 RVA: 0x003203CC File Offset: 0x0031E5CC
	public adv()
	{
	}

	// Token: 0x06007651 RID: 30289 RVA: 0x003203D4 File Offset: 0x0031E5D4
	public static bool a(c5x A_0, c5x A_1, bool A_2)
	{
		ak1 ak = Enumerable.FirstOrDefault<ak1>(A_1.l);
		if (ak != null)
		{
			ak1 ak2 = A_0.Area.a(A_0.aj().a());
			if (ak2 != null)
			{
				Point a_;
				if (ak2.Location.X > ak.Location.X)
				{
					a_ = new Point(-1, 0);
				}
				else if (ak2.Location.X < ak.Location.X)
				{
					a_ = new Point(1, 0);
				}
				else if (ak2.Location.Y > ak.Location.Y)
				{
					a_ = new Point(0, -1);
				}
				else
				{
					a_ = new Point(0, 1);
				}
				ak1 ak3 = ak.Area.a(d05.a(ak.Location, a_, false));
				if (ak3 != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak3.Entities, new Func<b0b, bool>(adv.a.a.a))) as c5x;
					if (c5x != null)
					{
						ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
						adv adv = new adv();
						bx5 bx = new bx5(A_0);
						bx.l(new EventHandler<EventArgs>(adv.a));
						A_0.i.b.a(bx, atp.a, true, false);
						serviceOrThrow.ana(c5x, adv, A_2 ? b14.c : b14.b, 5, null, null);
						c3g aspect = A_1.GetAspect<c3g>();
						if (aspect != null)
						{
							aspect.a(A_0.h.b);
						}
						return true;
					}
				}
			}
		}
		if (A_0.IsPlayer)
		{
			bmj.a(A_0, new d53("Не удалось!", adi.l, null, false));
		}
		return false;
	}

	// Token: 0x06007652 RID: 30290 RVA: 0x0032059C File Offset: 0x0031E79C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		bool a_ = false;
		int num = cqp.a(base.vg().e());
		if (num > 0)
		{
			coh coh = base.vg().e().b9() as coh;
			if (coh != null && coh.Battery >= (double)num)
			{
				a_ = true;
			}
		}
		if (adv.a(base.vg().q(), c5x, a_))
		{
			coh coh2 = base.vg().e().b9() as coh;
			if (coh2 != null && coh2.Battery >= (double)num)
			{
				coh2.Battery -= (double)num;
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007653 RID: 30291 RVA: 0x0032069C File Offset: 0x0031E89C
	[dcc("SUD1:mOIC")]
	private void a(object A_0, EventArgs A_1)
	{
		if (A_0 is bx5)
		{
			bpo.GetServiceOrThrow<ps>().anb(this);
		}
	}

	// Token: 0x0200147C RID: 5244
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007656 RID: 30294 RVA: 0x003206C8 File Offset: 0x0031E8C8
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0400303D RID: 12349
		public static readonly adv.a a = new adv.a();

		// Token: 0x0400303E RID: 12350
		public static Func<b0b, bool> b;
	}
}
