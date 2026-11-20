using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200167D RID: 5757
[eiz("TGGA")]
[Serializable]
public sealed class cfi : a6k, ISerializable
{
	// Token: 0x06007D8B RID: 32139 RVA: 0x0034EEB4 File Offset: 0x0034D0B4
	private cfi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("TGGA:P");
		this.c = A_0.GetString("TGGA:G");
		this.b = A_0.GetString("TGGA:C");
		this.d = A_0.GetInt32("TGGA:D");
	}

	// Token: 0x06007D8C RID: 32140 RVA: 0x0034EF10 File Offset: 0x0034D110
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TGGA:P", this.a);
		info.AddValue("TGGA:G", this.c);
		info.AddValue("TGGA:C", this.b);
		info.AddValue("TGGA:D", this.d);
	}

	// Token: 0x06007D8D RID: 32141 RVA: 0x0034EF6C File Offset: 0x0034D16C
	public cfi(string A_0, string A_1, string A_2, int A_3)
	{
		this.a = A_0;
		this.b = A_2;
		this.c = A_1;
		this.d = A_3;
	}

	// Token: 0x06007D8E RID: 32142 RVA: 0x0034EF94 File Offset: 0x0034D194
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || string.IsNullOrEmpty(this.a) || string.IsNullOrEmpty(this.c) || string.IsNullOrEmpty(this.b))
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
		dvv dvv = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), this.a, out b0b, null, null, true, 0.5f, null);
		if (dvv != null && b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(dvv);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(cfi.a.a.a))) as c5x;
			if (!aw1.a(ak2, false, null, l9.b))
			{
				if (c5x != null)
				{
					qy.ad().Add(new a4s(new bfq("GrenadeWaterSplash"), null, new ar7(c5x), null));
				}
				qy.ad().Add(new kt(new edx(ak2)));
			}
			else
			{
				if (c5x != null)
				{
					bfq bfq = new bfq();
					bfq.b("grenade" + Guid.NewGuid().ToString());
					bfq.c("GasGrenadeLand");
					bfq.a(bvl.c);
					qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				}
				c5x c5x2 = vq.a("objects\\items\\" + this.c, false);
				c5x2.TileFormationModifiers.s3(12);
				if (c5x2 != null)
				{
					coh coh = base.vg().e().b9() as coh;
					if (coh != null && coh.Definition != null)
					{
						c5x2.q(coh.Definition.az());
					}
					c5x2.Location = ak2.Location.a();
					c5x2.Layer = aju.x;
					yp aspect = new yp(c5x2, base.vg().e().b8().FactionId);
					c5x2.SetAspect<bim>(aspect);
					dxv aspect2 = new dxv(c5x2, this.b, base.vg().e().b8().FactionId);
					c5x2.SetAspect<dxv>(aspect2);
					dm dm = new dm(c5x2);
					dm.d().Add(new dft(this.d));
					c5x2.SetAspect<dm>(dm);
					if (c5x2.i.b == null)
					{
						ny aspect3 = new ny(c5x2);
						c5x2.SetAspect<ny>(aspect3);
					}
					qy.ad().Add(new a4s(new bk6(ak2.Area, c5x2), null, null, null));
				}
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04003196 RID: 12694
	private new string a;

	// Token: 0x04003197 RID: 12695
	private string b;

	// Token: 0x04003198 RID: 12696
	private string c;

	// Token: 0x04003199 RID: 12697
	private int d;

	// Token: 0x0200167E RID: 5758
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007D91 RID: 32145 RVA: 0x0034F360 File Offset: 0x0034D560
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0400319A RID: 12698
		public static readonly cfi.a a = new cfi.a();

		// Token: 0x0400319B RID: 12699
		public static Func<b0b, bool> b;
	}
}
