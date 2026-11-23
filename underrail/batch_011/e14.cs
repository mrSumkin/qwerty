using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x0200168D RID: 5773
[eiz("PLAC")]
[Serializable]
public sealed class e14 : h3, ISerializable, b6a
{
	// Token: 0x06007DE3 RID: 32227 RVA: 0x0035394C File Offset: 0x00351B4C
	private e14(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("PLAC:AE", ref this.b, A_0);
		this.c = (A_0.GetValue("PLAC:FD", typeof(a1q)) as a1q?);
		this.d = (A_0.GetValue("PLAC:MD", typeof(a1q)) as a1q?);
		this.e = A_0.GetString("PLAC:M");
		this.f = A_0.GetBoolean("PLAC:T");
		this.g = (Guid)A_0.GetValue("PLAC:I", typeof(Guid));
	}

	// Token: 0x06007DE4 RID: 32228 RVA: 0x00353A0C File Offset: 0x00351C0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("PLAC:AE", this.b, info);
		info.AddValue("PLAC:FD", this.c);
		info.AddValue("PLAC:MD", this.d);
		info.AddValue("PLAC:M", this.e);
		info.AddValue("PLAC:T", this.f);
		info.AddValue("PLAC:I", this.g);
	}

	// Token: 0x06007DE5 RID: 32229 RVA: 0x00353A98 File Offset: 0x00351C98
	public string tx()
	{
		return this.e;
	}

	// Token: 0x06007DE6 RID: 32230 RVA: 0x00353AA0 File Offset: 0x00351CA0
	public void ty(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06007DE7 RID: 32231 RVA: 0x00353AAC File Offset: 0x00351CAC
	public bool tz()
	{
		return this.f;
	}

	// Token: 0x06007DE8 RID: 32232 RVA: 0x00353AB4 File Offset: 0x00351CB4
	public void t0(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06007DE9 RID: 32233 RVA: 0x00353AC0 File Offset: 0x00351CC0
	public e14()
	{
		this.g = Guid.NewGuid();
	}

	// Token: 0x06007DEA RID: 32234 RVA: 0x00353AE0 File Offset: 0x00351CE0
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (this.c == null)
		{
			this.a();
		}
		if (A_2 == 0f)
		{
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "PlasmaExplosion_Center";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = dz6.b();
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
		}
		else
		{
			Vector3 a_6 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_7 = null;
			string a_8 = "PlasmaExplosion_Spread";
			int a_9 = 1;
			double maxValue2 = double.MaxValue;
			float? a_5 = dz6.b();
			boj.a(A_0, a_6, a_7, a_8, a_9, maxValue2, null, null, a_5, null);
		}
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null)
					{
						if (c5x.h.b != null && !this.b.Contains(b0b.qe()))
						{
							this.a(c5x.h.b, A_2);
							this.b.Add(c5x.qe());
						}
						if (c5x.y.b != null)
						{
							c5x.y.b.a(null);
							this.b.Add(c5x.qe());
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DEB RID: 32235 RVA: 0x00353CD0 File Offset: 0x00351ED0
	private void a()
	{
		int a_ = c18.a(base.d());
		this.c = new a1q?(c18.p(a_));
		this.d = new a1q?(c18.o(a_));
	}

	// Token: 0x06007DEC RID: 32236 RVA: 0x00353D0C File Offset: 0x00351F0C
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (base.c() != null && !A_0.a8().IsPlayer)
			{
				bool flag;
				if (this.f)
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
					awq.a(base.c(), A_0, !this.f, true, null, true, !this.f, false, false);
				}
			}
			A_0.u();
			double num;
			if (A_1 > 1f)
			{
				num = Math.Min(c18.az, (double)(A_1 - 1f) * c18.a2);
			}
			else
			{
				num = 0.0;
			}
			double a_ = 0.0;
			if (!this.f && base.c() != null)
			{
				a_ = c18.a(base.c().aa());
			}
			bool flag2 = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
			cwt cwt = new cwt();
			cwt.af = this.g;
			cwt.f.Add(euf.a(this.d.Value, (1.0 - num) * (double)(flag2 ? 2 : 1)));
			cwt.f.Add(euf.a(this.c.Value, (1.0 - num) * (double)(flag2 ? 2 : 1)));
			cwt.b = true;
			cwt.e = flag2;
			cwt.q = true;
			if (base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.k = ((this.e != null) ? this.e : "плазменная граната");
			cwt.ad["IsTrap"] = this.f;
			cwt.ad["IsGrenade"] = !this.f;
			cwt.ad["IsExplosion"] = true;
			A_0.aa().Defense.a(cwt);
		}
	}

	// Token: 0x040031E8 RID: 12776
	private new static Random a = new Random();

	// Token: 0x040031E9 RID: 12777
	private List<Guid> b = new List<Guid>();

	// Token: 0x040031EA RID: 12778
	private a1q? c;

	// Token: 0x040031EB RID: 12779
	private a1q? d;

	// Token: 0x040031EC RID: 12780
	private string e;

	// Token: 0x040031ED RID: 12781
	private bool f;

	// Token: 0x040031EE RID: 12782
	private Guid g;
}
