using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006DE RID: 1758
[eiz("B17")]
[Serializable]
public sealed class b0h : y8, ISerializable
{
	// Token: 0x06002D3D RID: 11581 RVA: 0x00102470 File Offset: 0x00100670
	private b0h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 264)
		{
			this.a = A_0.GetBoolean("B17:L");
			this.b = A_0.GetBoolean("B17:M");
		}
	}

	// Token: 0x06002D3E RID: 11582 RVA: 0x001024AC File Offset: 0x001006AC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("B17:L", this.a);
		info.AddValue("B17:M", this.b);
	}

	// Token: 0x06002D3F RID: 11583 RVA: 0x001024D8 File Offset: 0x001006D8
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06002D40 RID: 11584 RVA: 0x001024E0 File Offset: 0x001006E0
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D41 RID: 11585 RVA: 0x001024EC File Offset: 0x001006EC
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06002D42 RID: 11586 RVA: 0x001024F4 File Offset: 0x001006F4
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x00102500 File Offset: 0x00100700
	public b0h()
	{
	}

	// Token: 0x06002D44 RID: 11588 RVA: 0x0010250C File Offset: 0x0010070C
	public override aw4 a1()
	{
		b0h b0h = new b0h();
		this.rg(b0h);
		return b0h;
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x00102528 File Offset: 0x00100728
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		aw7 aw = d79.Get<aw7>();
		if (aw != null)
		{
			int a_ = base.i();
			int num = y8.a(a_);
			int a_2 = y8.a(a_);
			fv fv = this.a(num);
			fv fv2 = zp.a(a_2);
			fv fv3 = y8.a("armors\\RubberSole", null);
			if (fv != null && fv2 != null && fv3 != null)
			{
				fv3.Stacks = 2;
				if (fv.TypedDefinition.i() == ms.d)
				{
					fv.QualityLevel = d05.a(1, num, 40);
				}
				else
				{
					fv.QualityLevel = num;
				}
				fv2.QualityLevel = a_2;
				int a_3 = y8.a(a_);
				fv fv4 = this.b(a_3);
				if (fv4 != null)
				{
					fv4.QualityLevel = a_3;
				}
				a12 a = aw.a(null, new Dictionary<string, coh>
				{
					{
						aw7.a,
						fv
					},
					{
						aw7.b,
						fv2
					},
					{
						aw7.c,
						fv3
					},
					{
						aw7.d,
						fv4
					}
				}).a() as a12;
				if (a != null)
				{
					list.Add(a);
				}
			}
		}
		return list;
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x00102660 File Offset: 0x00100860
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		b0h b0h = A_0 as b0h;
		b0h.a = this.a;
		b0h.b = this.b;
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x00102688 File Offset: 0x00100888
	private fv b(int A_0)
	{
		if (zp.a.NextDouble() >= 0.2)
		{
			return null;
		}
		if (A_0 >= 25 && zp.a.NextDouble() < 0.05)
		{
			return y8.a("Armors\\BootSpring", null);
		}
		return zp.a(A_0, 1.0);
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x001026F4 File Offset: 0x001008F4
	private fv a(int A_0)
	{
		if (((A_0 >= 35 && zp.a.NextDouble() < 0.25) || this.b) && !this.a)
		{
			return zp.d(A_0, null);
		}
		return zp.c(A_0, null);
	}

	// Token: 0x040019AC RID: 6572
	private new bool a;

	// Token: 0x040019AD RID: 6573
	private bool b;
}
