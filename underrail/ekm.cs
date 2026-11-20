using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02001750 RID: 5968
[eiz("T17")]
[Serializable]
public sealed class ekm : a6k, ISerializable
{
	// Token: 0x06008089 RID: 32905 RVA: 0x003648E4 File Offset: 0x00362AE4
	private ekm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600808A RID: 32906 RVA: 0x003648F0 File Offset: 0x00362AF0
	public ekm()
	{
	}

	// Token: 0x0600808B RID: 32907 RVA: 0x003648FC File Offset: 0x00362AFC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
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
		dvv item = es2.a(new Vector3(base.vg().q().Location.X, base.vg().q().Location.Y, base.vg().q().Size.Z / 2f), ak2.Location.a(), ak2.Area, "Flare", null, out b0b);
		if (b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(new a4s(new bfq("net", "NetThrow"), null, new ar7(b0b), null));
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(ekm.a.a.a))) as c5x;
			if (c5x != null)
			{
				qy.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "NetFall"), null, new ar7(c5x), null));
				qy.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Flare"), null, new ar7(c5x), null));
			}
			qy.ad().Add(new a4s(new blt("Locale\\Object\\Items\\Flare", new bt4(ak2.Area.y8(), ak2.Location.a() + new Vector3(0.25f, 0.35f, 0f)), null), null, null, null));
			awb item2 = new awb(ak2, new ekm.b(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
			qy.ad().Add(item2);
			eu8 item3 = new eu8(base.vg().q(), d8o.g, ak2, base.vg().e().g() + 5, d0u.b, null);
			qy.ad().Add(item3);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x02001751 RID: 5969
	[eiz("T17a")]
	[Serializable]
	public class b : cci, ISerializable
	{
		// Token: 0x0600808C RID: 32908 RVA: 0x00364C28 File Offset: 0x00362E28
		protected b(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("T17a:P", typeof(eu7));
			di7.ReadList<Guid>("T17a:AE", ref this.b, A_0);
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("T17a:IR", typeof(EntityAspectReference<amc, amc>));
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x00364C98 File Offset: 0x00362E98
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("T17a:P", this.a);
			di7.WriteList<Guid>("T17a:AE", this.b, info);
			info.AddValue("T17a:IR", this.c);
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x00364CD0 File Offset: 0x00362ED0
		public b(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.c = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x0600808F RID: 32911 RVA: 0x00364CFC File Offset: 0x00362EFC
		public void cq(aud A_0, Point A_1, float A_2)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && c5x.h.b != null && !this.b.Contains(b0b.qe()))
					{
						this.a(c5x.h.b);
						this.b.Add(c5x.qe());
					}
				}
			}
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x00364DC4 File Offset: 0x00362FC4
		private void a(amc A_0)
		{
			A_0.u();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (this.c.ao() != null && this.a.b8() != null && A_0.aa().a(serviceOrThrow.aqu().ac(), this.a.b8().FactionId) == h.a)
			{
				awq.a(this.c.ao(), A_0, true, true, null, true, true, false, false);
			}
		}

		// Token: 0x04003247 RID: 12871
		private eu7 a;

		// Token: 0x04003248 RID: 12872
		private List<Guid> b = new List<Guid>();

		// Token: 0x04003249 RID: 12873
		private EntityAspectReference<amc, amc> c;
	}

	// Token: 0x02001752 RID: 5970
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06008093 RID: 32915 RVA: 0x00364E54 File Offset: 0x00363054
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0400324A RID: 12874
		public static readonly ekm.a a = new ekm.a();

		// Token: 0x0400324B RID: 12875
		public static Func<b0b, bool> b;
	}
}
