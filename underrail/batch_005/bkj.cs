using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001742 RID: 5954
[eiz("TC00")]
[Serializable]
public abstract class bkj : a6k, ISerializable
{
	// Token: 0x06008054 RID: 32852 RVA: 0x00363294 File Offset: 0x00361494
	protected bkj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008055 RID: 32853
	protected abstract string om();

	// Token: 0x06008056 RID: 32854 RVA: 0x003632A0 File Offset: 0x003614A0
	public bkj()
	{
	}

	// Token: 0x06008057 RID: 32855 RVA: 0x003632AC File Offset: 0x003614AC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || ak.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.c(base.vg().e().b8(), a_);
		ak1 ak2 = awq.a(this, ak, a_2, true);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q().Location + new Vector3(0f, 0f, 0.5f), ak2.Location.a(), ak2.Area, "Caltrops", null, out b0b);
		if (b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(new a4s(new bfq("throw", "GrenadeThrow"), null, new ar7(base.vg().q()), null));
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.c.Values, new Func<b0b, bool>(bkj.b.a.a))) as c5x;
			if (c5x != null)
			{
				List<auv> list = qy.ad();
				aud a_3 = c5x.Area;
				Vector3 a_4 = c5x.Location;
				string a_5 = "Smoke";
				int a_6 = 1;
				double maxValue = double.MaxValue;
				float? a_7 = dz6.b();
				list.Add(new au0(a_3, a_4, a_5, a_6, maxValue, null, null, a_7));
				qy.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "CaltropsFall"), null, new ar7(c5x), null));
			}
			awb awb = new awb(ak2, new bkj.a(this), null, (float)base.vg().e().g(), null, null, false);
			awb.b(100.0);
			awb item2 = awb;
			qy.ad().Add(item2);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06008058 RID: 32856
	protected abstract arn on(c5x A_0, amc A_1, int A_2);

	// Token: 0x0200174D RID: 5965
	private new sealed class a : cci
	{
		// Token: 0x06008081 RID: 32897 RVA: 0x003646AC File Offset: 0x003628AC
		public a(bkj A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06008082 RID: 32898 RVA: 0x003646C0 File Offset: 0x003628C0
		public void cq(aud A_0, Point A_1, float A_2)
		{
			ak1 ak = A_0.a(A_1);
			if (ak != null && !aw1.a(ak, true, null, l9.a))
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.c.Values, new Func<b0b, bool>(bkj.a.a.a.a))) as c5x;
				if (c5x != null)
				{
					c5x.an();
				}
				c5x c5x2 = new c5x();
				c5x2.Layer = aju.x;
				c5x2.VisualPriority = 100;
				c5x2.IsGround = true;
				c5x2.Size = new Vector3(1f, 1f, 0.15f);
				c5x2.Location = A_1.a();
				c5x2.TileFormationModifiers.s3(11);
				int num = d05.a(1, (int)(5f - A_2 * 2f) + cuo.a.Next(2), 5);
				int x = cuo.a.Next(3);
				int y = num - 1;
				c5x2.SetAspect<cd0>(new cd0(c5x2)
				{
					a = string.Format("Objects\\Caltrops\\{0}", this.a.om()),
					b = new Point(x, y)
				});
				arn aspect = this.a.on(c5x2, this.a.vg().q().h.b, num);
				c5x2.SetAspect<arn>(aspect);
				A_0.a(c5x2);
				ee7 ee = null;
				List<ya> list = ak.a(typeof(ee7));
				if (list != null)
				{
					ee = (Enumerable.FirstOrDefault<ya>(list) as ee7);
				}
				if (ee != null)
				{
					ee.a = new ar7(c5x2);
					return;
				}
				A_0.b(new ee7(c5x2)
				{
					Location = ak.Location,
					Size = new esj(1, 1),
					Layer = aju.x
				});
			}
		}

		// Token: 0x04003242 RID: 12866
		private bkj a;

		// Token: 0x0200174E RID: 5966
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06008085 RID: 32901 RVA: 0x003648BC File Offset: 0x00362ABC
			internal bool a(b0b A_0)
			{
				return A_0.GetAspect<arn>() != null;
			}

			// Token: 0x04003243 RID: 12867
			public static readonly bkj.a.a a = new bkj.a.a();

			// Token: 0x04003244 RID: 12868
			public static Func<b0b, bool> b;
		}
	}

	// Token: 0x0200174F RID: 5967
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06008088 RID: 32904 RVA: 0x003648DC File Offset: 0x00362ADC
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04003245 RID: 12869
		public static readonly bkj.b a = new bkj.b();

		// Token: 0x04003246 RID: 12870
		public static Func<b0b, bool> b;
	}
}
