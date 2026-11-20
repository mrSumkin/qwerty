using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200167F RID: 5759
[eiz("TGA")]
[Serializable]
public sealed class cqu : a6k, ISerializable
{
	// Token: 0x06007D92 RID: 32146 RVA: 0x0034F36C File Offset: 0x0034D56C
	private cqu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("TGA:P");
			this.b = (blv)A_0.GetValue("TGA:L", typeof(blv));
			this.c = (cuu)A_0.GetValue("TGA:A", typeof(cuu));
			this.d = A_0.GetInt32("TGA:NPD");
			this.e = A_0.GetString("TGA:SFX");
			this.f = A_0.GetString("TGA:V");
			if (ell.a() >= 245)
			{
				di7.ReadArray<CombatSpeakEvent>("TGA:S", ref this.g, A_0);
			}
			if (ell.a() >= 297)
			{
				this.h = A_0.GetDouble("TGA:E");
			}
			if (ell.a() >= 610)
			{
				this.i = A_0.GetBoolean("TGA:CD");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(cqu))
			{
				this.a = A_0.GetString("_Projectile");
				this.b = (blv)A_0.GetValue("_Light", typeof(blv));
				this.c = (cuu)A_0.GetValue("_Actuator", typeof(cuu));
				this.d = A_0.GetInt32("_NovaPhaseDuration");
				return;
			}
			this.a = A_0.GetString("ThrowGrenadeAction+_Projectile");
			this.b = (blv)A_0.GetValue("ThrowGrenadeAction+_Light", typeof(blv));
			this.c = (cuu)A_0.GetValue("ThrowGrenadeAction+_Actuator", typeof(cuu));
			this.d = A_0.GetInt32("ThrowGrenadeAction+_NovaPhaseDuration");
		}
	}

	// Token: 0x06007D93 RID: 32147 RVA: 0x0034F550 File Offset: 0x0034D750
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TGA:P", this.a);
		info.AddValue("TGA:L", this.b);
		info.AddValue("TGA:A", this.c);
		info.AddValue("TGA:NPD", this.d);
		info.AddValue("TGA:SFX", this.e);
		info.AddValue("TGA:V", this.f);
		info.AddValue("TGA:E", this.h);
		di7.WriteArray<CombatSpeakEvent>("TGA:S", this.g, info);
		info.AddValue("TGA:CD", this.i);
	}

	// Token: 0x06007D94 RID: 32148 RVA: 0x0034F600 File Offset: 0x0034D800
	public cqu(string A_0, cuu A_1, int A_2, blv A_3 = null, string A_4 = null, string A_5 = null, CombatSpeakEvent[] A_6 = null, double A_7 = 0.0, bool A_8 = false)
	{
		this.d = A_2;
		this.a = A_0;
		this.c = A_1;
		this.b = A_3;
		this.e = A_4;
		this.f = A_5;
		this.g = A_6;
		this.h = A_7;
		this.i = A_8;
	}

	// Token: 0x06007D95 RID: 32149 RVA: 0x0034F658 File Offset: 0x0034D858
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || this.c == null || string.IsNullOrEmpty(this.a))
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.c(base.vg().e().b8(), a_);
		ak1 ak2 = awq.a(this, ak, a_2, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		if (base.vg().e().b8() != null)
		{
			base.vg().e().b8().FactionId;
		}
		brv brv = new brv();
		brv.c = new EntityAspectReference<amc, amc>(base.vg().q().h.b);
		aig[] array = new aig[]
		{
			brv
		};
		c5x a_3 = base.vg().q();
		Vector3 a_4 = ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f);
		string a_5 = this.a;
		aig[] a_6 = array;
		dvv dvv = es2.a(a_3, a_4, a_5, out b0b, null, a_6, true, 0.5f, null);
		if (dvv != null && b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(dvv);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(cqu.a.a.a))) as c5x;
			if (this.i && !aw1.a(ak2, false, null, l9.b))
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
					if (!string.IsNullOrEmpty(this.f))
					{
						no no = new no();
						no.a(this.f);
						no.a(c5x.Location);
						no.a(new e6z(c5x.Area));
						qy.ad().Add(new a4s(no, null, null, null));
					}
					if (!string.IsNullOrEmpty(this.e))
					{
						bfq bfq = new bfq();
						bfq.b("grenade" + Guid.NewGuid().ToString());
						bfq.c(this.e);
						bfq.a(bvl.c);
						qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
					}
				}
				this.c.e(base.vg().e());
				this.c.g(new EntityAspectReference<amc, amc>(base.vg().q().h.b));
				this.c.i(new edx(ak2));
				awb awb = new awb(ak2, this.c, (this.b != null) ? new ae8?(this.b.a.Light) : null, (float)base.vg().e().g(), null, null, false);
				awb.b((double)this.d);
				awb.r = true;
				if (this.b != null && this.b.a != null)
				{
					awb.c(this.b.b);
					awb.b(this.b.c);
					awb.a(this.b.d);
				}
				qy.ad().Add(awb);
				if (this.h > 0.0)
				{
					qy.ad().Add(new cn9(new edx(ak2), this.h));
				}
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			brv.b = new ActionReference<qy>(qy);
			if (this.g == null && this.g.Length != 0)
			{
				a20.a(base.vg().q(), null, this.g);
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x0400319C RID: 12700
	private new string a;

	// Token: 0x0400319D RID: 12701
	private blv b;

	// Token: 0x0400319E RID: 12702
	private cuu c;

	// Token: 0x0400319F RID: 12703
	private int d;

	// Token: 0x040031A0 RID: 12704
	private string e;

	// Token: 0x040031A1 RID: 12705
	private string f;

	// Token: 0x040031A2 RID: 12706
	private CombatSpeakEvent[] g;

	// Token: 0x040031A3 RID: 12707
	private double h;

	// Token: 0x040031A4 RID: 12708
	private new bool i;

	// Token: 0x02001680 RID: 5760
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007D98 RID: 32152 RVA: 0x0034FB2C File Offset: 0x0034DD2C
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040031A5 RID: 12709
		public static readonly cqu.a a = new cqu.a();

		// Token: 0x040031A6 RID: 12710
		public static Func<b0b, bool> b;
	}
}
