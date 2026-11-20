using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020016BB RID: 5819
[eiz("GWWSA")]
[Serializable]
public sealed class bkh : a6k, ISerializable
{
	// Token: 0x06007EE1 RID: 32481 RVA: 0x00359DD8 File Offset: 0x00357FD8
	private bkh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EE2 RID: 32482 RVA: 0x00359DE4 File Offset: 0x00357FE4
	public bkh()
	{
	}

	// Token: 0x06007EE3 RID: 32483 RVA: 0x00359DEC File Offset: 0x00357FEC
	protected override dc4 dt()
	{
		return base.dt();
	}

	// Token: 0x06007EE4 RID: 32484 RVA: 0x00359DF8 File Offset: 0x00357FF8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), c5x, "xpbl_SpitSpiderWebProjectile", 0.1f, out b0b, Vector3.Zero, null, true, 0.2f, new Vector3?(new Vector3(0f, 0f, -0.5f)));
		if (b0b != null && b0b.Zone != null)
		{
			bfq a_ = new bfq("AcidBlob");
			qy.ad().Add(new a4s(a_, null, new ar7(base.vg().q()), null));
			qy.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			qy.ad().Add(item2);
			bfq a_2 = new bfq("AcidBlobBigHit");
			qy.ad().Add(new a4s(a_2, null, new ar7(c5x), null));
			c5x a_3 = c5x;
			string a_4 = "xpbl_SpitSpiderWebSplash";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			bool a_6 = false;
			bool a_7 = true;
			float? a_8 = dz6.b();
			a7j item3 = new a7j(a_3, a_4, a_5, maxValue, a_6, a_7, new Vector3?(new Vector3(0f, 0f, 0.1f)), null, null, a_8, false, null);
			qy.ad().Add(item3);
			awq.a(qy, base.vg().q(), c5x, true, true);
			if (c5x.h.b.aa().d(CharacterImmunities.Root))
			{
				etm a_9 = new etm(new ap9(c5x.h.b.aa()), "обездвиживанию");
				bey.a(a_9, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				anw item4 = new anw(a_9);
				b8p item5 = new b8p(c5x, new ba0());
				qy.ad().Add(item4);
				qy.ad().Add(item5);
			}
			else
			{
				double a_10 = aw1.b(base.vg().q(), c5x);
				if (bkh.a(base.vg().e().b8(), c5x.h.b.aa(), a_10))
				{
					amd item6 = new amd(c5x.h.b, new els[]
					{
						new ata(adk.c * d0u.b, true)
					});
					qy.ad().Add(item6);
					vr a_11 = new vr(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "{0}: опутывание.", new Color?(adi.j), null);
					bey.a(a_11, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
					anw item7 = new anw(a_11);
					qy.ad().Add(item7);
				}
				else
				{
					bjq a_12 = new bjq(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "запутыванию в сети");
					bey.a(a_12, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
					anw item8 = new anw(a_12);
					qy.ad().Add(item8);
				}
			}
			ak1 ak = c5x.Area.a(c5x.aj().a());
			if (ak != null)
			{
				awb awb = new awb(ak, new bkh.a(), null, (float)base.vg().e().g(), null, null, false);
				awb.b(150.0);
				qy.ad().Add(awb);
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007EE5 RID: 32485 RVA: 0x0035A254 File Offset: 0x00358454
	private static bool a(efk A_0, efk A_1, double A_2)
	{
		double num = (double)byc.a(A_0);
		double num2;
		if (A_2 > 6.0)
		{
			num2 = Math.Max(0.6, 1.0 - (A_2 - 6.0) * 0.1);
		}
		else
		{
			num2 = 1.0;
		}
		return !euf.a(Math.Max(euf.a(Convert.ToInt32(num * num2), A_1), aiy.ae + 0.05 + (A_2 - 6.0) * 0.033)) && !euf.k(A_1);
	}

	// Token: 0x020016BC RID: 5820
	[eiz("GWWSAa")]
	[Serializable]
	private new sealed class a : cci, ISerializable
	{
		// Token: 0x06007EE6 RID: 32486 RVA: 0x0035A308 File Offset: 0x00358508
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x0035A310 File Offset: 0x00358510
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x0035A314 File Offset: 0x00358514
		public a()
		{
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x0035A320 File Offset: 0x00358520
		public void cq(aud A_0, Point A_1, float A_2)
		{
			if (A_0 != null)
			{
				ak1 ak = A_0.a(A_1);
				if (ak != null)
				{
					if (!aw1.a(ak, true, null, l9.a))
					{
						boj.a(A_0, ak.Location.a(), null, "xpbl_SpitSpiderWebGroundSplash", 1, double.MaxValue, null, null, null, null);
					}
					e6o.a(ak);
				}
			}
		}
	}
}
