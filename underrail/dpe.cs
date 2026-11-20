using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006E5 RID: 1765
[eiz("G02")]
[Serializable]
public sealed class dpe : y8, ISerializable
{
	// Token: 0x06002D78 RID: 11640 RVA: 0x0010332C File Offset: 0x0010152C
	private dpe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 671)
		{
			this.a = A_0.GetString("G02:L");
		}
	}

	// Token: 0x06002D79 RID: 11641 RVA: 0x00103358 File Offset: 0x00101558
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("G02:L", this.a);
	}

	// Token: 0x06002D7A RID: 11642 RVA: 0x00103374 File Offset: 0x00101574
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002D7B RID: 11643 RVA: 0x0010337C File Offset: 0x0010157C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D7C RID: 11644 RVA: 0x00103388 File Offset: 0x00101588
	public dpe()
	{
	}

	// Token: 0x06002D7D RID: 11645 RVA: 0x00103394 File Offset: 0x00101594
	public override aw4 a1()
	{
		dpe dpe = new dpe();
		this.rg(dpe);
		return dpe;
	}

	// Token: 0x06002D7E RID: 11646 RVA: 0x001033B0 File Offset: 0x001015B0
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		dpe dpe = A_0 as dpe;
		if (dpe != null)
		{
			dpe.a = this.a;
		}
	}

	// Token: 0x06002D7F RID: 11647 RVA: 0x001033E0 File Offset: 0x001015E0
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		bzh bzh = d79.Get<bzh>();
		if (bzh != null)
		{
			int a_ = base.i();
			int a_2 = y8.a(a_);
			fv fv = y8.a("armors\\GogglesFrame", null);
			fv fv2 = this.a(a_2);
			if (fv != null && fv2 != null)
			{
				if (!Enumerable.Any<b8w>(fv2.TypedDefinition.g(), new Func<b8w, bool>(dpe.a.a.a)))
				{
					fv2.QualityLevel = a_2;
				}
				fv fv3 = this.b(a_2);
				fv fv4 = null;
				if (fv3 != null)
				{
					int a_3 = y8.a(a_);
					fv4 = zp.b(a_3);
					fv4.QualityLevel = a_3;
				}
				k7 k = bzh.a(null, new Dictionary<string, coh>
				{
					{
						bzh.a,
						fv2
					},
					{
						bzh.b,
						fv
					},
					{
						bzh.c,
						fv3
					},
					{
						bzh.d,
						fv4
					}
				}).a() as k7;
				if (k != null)
				{
					list.Add(k);
				}
			}
		}
		return list;
	}

	// Token: 0x06002D80 RID: 11648 RVA: 0x0010350C File Offset: 0x0010170C
	private fv b(int A_0)
	{
		if (zp.a.NextDouble() < 0.25)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("ImageIntensifierTube", 35, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return y8.a("Armors\\" + text, null);
			}
		}
		return null;
	}

	// Token: 0x06002D81 RID: 11649 RVA: 0x00103574 File Offset: 0x00101774
	private fv a(int A_0)
	{
		string text;
		if (!string.IsNullOrEmpty(this.a))
		{
			text = this.a;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("AdaptiveLens", int.MinValue, int.MaxValue, 3);
			itemPoolForQuality.a("SeekerLens", int.MinValue, int.MaxValue, 3);
			itemPoolForQuality.a("SmartLens", 35, int.MaxValue, 2);
			itemPoolForQuality.a("MotionTrackingLens", 30, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Armors\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019B8 RID: 6584
	private new string a;

	// Token: 0x020006E6 RID: 1766
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06002D84 RID: 11652 RVA: 0x00103630 File Offset: 0x00101830
		internal bool a(b8w A_0)
		{
			return A_0.Factor >= 2f;
		}

		// Token: 0x040019B9 RID: 6585
		public static readonly dpe.a a = new dpe.a();

		// Token: 0x040019BA RID: 6586
		public static Func<b8w, bool> b;
	}
}
