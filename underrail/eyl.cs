using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001683 RID: 5763
[eiz("CGA")]
[Serializable]
public sealed class eyl : h3, ISerializable, b6a, dib
{
	// Token: 0x06007DAA RID: 32170 RVA: 0x0034FF58 File Offset: 0x0034E158
	private eyl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("CGA:AE", ref this.a, A_0);
		this.b = (a1q)A_0.GetValue("CGA:FD", typeof(a1q));
		this.c = (a1q)A_0.GetValue("CGA:MD", typeof(a1q));
		this.d = (a1q)A_0.GetValue("CGA:CFD", typeof(a1q));
		this.e = (a1q)A_0.GetValue("CGA:CMD", typeof(a1q));
		this.f = A_0.GetString("CGA:M");
		this.g = A_0.GetBoolean("CGA:T");
		this.i = (Guid)A_0.GetValue("CGA:I", typeof(Guid));
		this.h = (A_0.GetValue("CGA:GL", typeof(WeaponSubtype?)) as WeaponSubtype?);
		this.j = (A_0.GetValue("CGA:CB", typeof(enp)) as enp);
		this.k = (A_0.GetValue("CGA:AP", typeof(ekt)) as ekt);
	}

	// Token: 0x06007DAB RID: 32171 RVA: 0x003500B0 File Offset: 0x0034E2B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("CGA:AE", this.a, info);
		info.AddValue("CGA:FD", this.b);
		info.AddValue("CGA:MD", this.c);
		info.AddValue("CGA:CFD", this.d);
		info.AddValue("CGA:CMD", this.e);
		info.AddValue("CGA:M", this.f);
		info.AddValue("CGA:T", this.g);
		info.AddValue("CGA:I", this.i);
		info.AddValue("CGA:GL", this.h);
		info.AddValue("CGA:CB", this.j);
		info.AddValue("CGA:AP", this.k);
	}

	// Token: 0x06007DAC RID: 32172 RVA: 0x003501A0 File Offset: 0x0034E3A0
	public string tx()
	{
		return this.f;
	}

	// Token: 0x06007DAD RID: 32173 RVA: 0x003501A8 File Offset: 0x0034E3A8
	public void ty(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06007DAE RID: 32174 RVA: 0x003501B4 File Offset: 0x0034E3B4
	public bool tz()
	{
		return this.g;
	}

	// Token: 0x06007DAF RID: 32175 RVA: 0x003501BC File Offset: 0x0034E3BC
	public void t0(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06007DB0 RID: 32176 RVA: 0x003501C8 File Offset: 0x0034E3C8
	[CompilerGenerated]
	public Point[] avb()
	{
		return this.l;
	}

	// Token: 0x06007DB1 RID: 32177 RVA: 0x003501D0 File Offset: 0x0034E3D0
	[CompilerGenerated]
	public void avc(Point[] A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06007DB2 RID: 32178 RVA: 0x003501DC File Offset: 0x0034E3DC
	public eyl()
	{
		this.i = Guid.NewGuid();
	}

	// Token: 0x06007DB3 RID: 32179 RVA: 0x003501FC File Offset: 0x0034E3FC
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		ak1 ak = A_0.b(A_1.X, A_1.Y);
		if (ak == null || A_0 == null || A_0.Zone == null)
		{
			return;
		}
		List<Point> list = null;
		int value = (int)base.a(A_1);
		float value2 = 0.75f;
		int i = 8;
		if (A_2 == 0f)
		{
			if (this.avb() != null && this.avb().Length != 0)
			{
				list = new List<Point>();
				while (i > 0)
				{
					List<Point> list2 = new List<Point>(this.avb());
					while (list2.Count > 0 && i > 0)
					{
						int index = cuo.a.Next(list2.Count);
						Point item = list2[index];
						list2.RemoveAt(index);
						list.Add(item);
						i--;
					}
				}
			}
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "ExplosionFrag_C_Flame";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? num = dz6.b();
			float? num2 = new float?(value2);
			int? num3 = null;
			int? a_5 = num3;
			float? a_6 = num2;
			float? a_7 = num;
			num3 = null;
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num3);
			boj.c(A_0, A_1);
			if (list == null)
			{
				goto IL_51C;
			}
			using (List<Point>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Point a_8 = enumerator.Current;
					ak1 ak2 = A_0.a(a_8);
					if (ak2 != null)
					{
						qy qy = new qy();
						qy.b(false);
						qy.c(false);
						qy.ad().Add(new bm3(dz6.b(100 + cuo.a.Next(200))));
						b0b b0b;
						dvv item2 = es2.a(A_1.a() + new Vector3(0.5f, 0.5f, 0f), a_8.a() + new Vector3(0.5f, 0.5f, 0f), A_0, "Xphw_ClusterGrenade", null, out b0b);
						if (b0b != null)
						{
							qy.ad().Add(item2);
							c7 c = new c7(b0b, false, false, true, false);
							c.a(true);
							qy.ad().Add(c);
							c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(eyl.a.a.a))) as c5x;
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
									bfq.c(bby.g());
									bfq.a(bvl.c);
									qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
								}
								e3n e3n = new e3n();
								e3n.b = new a1q?(this.b);
								e3n.c = new a1q?(this.c);
								e3n.f = this.h;
								e3n.ty(this.tx());
								e3n.e(base.d());
								e3n.g(base.f());
								e3n.i(base.h());
								e3n.h = this.j;
								e3n.i = this.k;
								e3n.a(true);
								blv blv = bby.i();
								ak1 a_9 = ak2;
								cci a_10 = e3n;
								ae8? a_11 = (blv != null) ? new ae8?(blv.a.Light) : null;
								float a_12 = 1f;
								string a_13 = null;
								num2 = null;
								awb awb = new awb(a_9, a_10, a_11, a_12, a_13, num2, false);
								awb.b((double)bby.h());
								awb.r = true;
								if (blv != null && blv.a != null)
								{
									awb.c(blv.b);
									awb.b(blv.c);
									awb.a(blv.d);
								}
								qy.ad().Add(awb);
								qy.ad().Add(new cn9(new edx(ak2), (double)aju.a6));
							}
							A_0.Zone.ActionManager.g9(qy, atp.a);
							dz6.a(qy);
						}
					}
				}
				goto IL_51C;
			}
		}
		if (A_2 != 2f && A_2 == 1f)
		{
			Vector3 a_14 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_15 = null;
			string a_16 = "ExplosionFrag_O_Flame";
			int a_17 = 1;
			double maxValue2 = double.MaxValue;
			float? num2 = dz6.b();
			int? num3 = new int?(value);
			float? num = new float?(value2);
			boj.a(A_0, a_14, a_15, a_16, a_17, maxValue2, null, num, num2, num3);
		}
		IL_51C:
		if (base.d() != null && A_2 < 2f && ak != null)
		{
			foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x2 = b0b2 as c5x;
				if (c5x2 != null)
				{
					if (c5x2.h.b != null && !this.a.Contains(b0b2.qe()))
					{
						this.a(c5x2.h.b, A_2);
						this.a.Add(c5x2.qe());
					}
					if (c5x2.y.b != null)
					{
						c5x2.y.b.a(null);
						this.a.Add(c5x2.qe());
					}
				}
			}
		}
	}

	// Token: 0x06007DB4 RID: 32180 RVA: 0x00350848 File Offset: 0x0034EA48
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (base.c() != null && !A_0.a8().IsPlayer)
			{
				bool flag;
				if (this.g)
				{
					ZoneControlLevel zoneControlLevel;
					if (!A_0.aa().Passive)
					{
						zoneControlLevel = eir.a(A_0.a8().Zone, A_0.aa().FactionId);
					}
					else
					{
						zoneControlLevel = ZoneControlLevel.Uncontrolled;
					}
					flag = (zoneControlLevel > ZoneControlLevel.Uncontrolled);
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					awq.a(base.c(), A_0, !this.g, true, null, true, !this.g, false, false);
				}
			}
			A_0.u();
			double a_ = 0.0;
			double num = 1.0;
			double ak = 0.0;
			double num2 = 0.0;
			double num3 = 1.0;
			if (this.k != null)
			{
				xo xo = this.k.a(base.c(), A_0);
				a_ = xo.a;
				num = xo.b;
				num2 = xo.c;
				ak = xo.d;
				num3 = xo.e;
			}
			else if (!this.g && base.c() != null)
			{
				a_ = c18.a(base.c().aa());
			}
			bool flag2 = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
			double num4 = num3 * (1.0 + num2);
			if (flag2)
			{
				num4 *= 1.0 + num;
			}
			cwt cwt = new cwt();
			cwt.af = this.i;
			cwt.f.Add(euf.a(this.d, num4));
			cwt.b = true;
			cwt.e = flag2;
			cwt.q = true;
			cwt.ak = ak;
			if (base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			cwt.h = ImpactSpeed.High;
			cwt.k = ((this.f != null) ? this.f : "кассетная граната");
			cwt.ad["IsTrap"] = this.g;
			cwt.ad["IsGrenade"] = !this.g;
			cwt.ad["IsExplosion"] = true;
			cwt.ae = this.h;
			cru a_2 = A_0.aa().Defense.a(cwt);
			bps a_3 = null;
			bvd bvd = this.j as bvd;
			if (bvd != null)
			{
				a_3 = new bps();
				bvd.mm(base.c(), A_0, cwt, a_2, a_3);
			}
			else if (this.j != null)
			{
				this.j.af(base.c(), A_0, cwt, a_2);
			}
			cwt cwt2 = new cwt();
			cwt2.af = this.i;
			cwt2.f.Add(euf.a(this.e, num4));
			cwt2.b = true;
			cwt2.e = flag2;
			cwt2.q = true;
			cwt2.ak = ak;
			if (base.d().b8() != null)
			{
				cwt2.i = new ap9(base.d().b8());
			}
			cwt2.h = ImpactSpeed.High;
			cwt2.k = ((this.f != null) ? this.f : "кассетная граната");
			cwt2.ad["IsTrap"] = this.g;
			cwt2.ad["IsGrenade"] = !this.g;
			cwt2.ad["IsExplosion"] = true;
			cwt2.ae = this.h;
			cru a_4 = A_0.aa().Defense.a(cwt2);
			if (bvd != null)
			{
				bvd.mm(base.c(), A_0, cwt2, a_4, a_3);
				return;
			}
			if (this.j != null)
			{
				this.j.af(base.c(), A_0, cwt2, a_4);
			}
		}
	}

	// Token: 0x040031AC RID: 12716
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040031AD RID: 12717
	public a1q b;

	// Token: 0x040031AE RID: 12718
	public a1q c;

	// Token: 0x040031AF RID: 12719
	public a1q d;

	// Token: 0x040031B0 RID: 12720
	public a1q e;

	// Token: 0x040031B1 RID: 12721
	private string f;

	// Token: 0x040031B2 RID: 12722
	private bool g;

	// Token: 0x040031B3 RID: 12723
	public WeaponSubtype? h;

	// Token: 0x040031B4 RID: 12724
	private Guid i;

	// Token: 0x040031B5 RID: 12725
	public enp j;

	// Token: 0x040031B6 RID: 12726
	public ekt k;

	// Token: 0x040031B7 RID: 12727
	[CompilerGenerated]
	private Point[] l;

	// Token: 0x02001684 RID: 5764
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007DB7 RID: 32183 RVA: 0x00350CAC File Offset: 0x0034EEAC
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040031B8 RID: 12728
		public static readonly eyl.a a = new eyl.a();

		// Token: 0x040031B9 RID: 12729
		public static Func<b0b, bool> b;
	}
}
