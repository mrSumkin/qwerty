using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006E2 RID: 1762
[eiz("R51")]
[Serializable]
public sealed class by2 : cpr, ISerializable
{
	// Token: 0x06002D60 RID: 11616 RVA: 0x00102CB4 File Offset: 0x00100EB4
	private by2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("R51:P", typeof(bool?)) as bool?);
		this.b = (A_0.GetValue("R51:O", typeof(bool?)) as bool?);
		this.c = A_0.GetString("R51:L");
		this.d = A_0.GetString("R51:B");
	}

	// Token: 0x06002D61 RID: 11617 RVA: 0x00102D38 File Offset: 0x00100F38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R51:P", this.a);
		info.AddValue("R51:O", this.b);
		info.AddValue("R51:L", this.c);
		info.AddValue("R51:B", this.d);
	}

	// Token: 0x06002D62 RID: 11618 RVA: 0x00102D9C File Offset: 0x00100F9C
	public bool? d()
	{
		return this.a;
	}

	// Token: 0x06002D63 RID: 11619 RVA: 0x00102DA4 File Offset: 0x00100FA4
	public void b(bool? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D64 RID: 11620 RVA: 0x00102DB0 File Offset: 0x00100FB0
	public bool? b()
	{
		return this.b;
	}

	// Token: 0x06002D65 RID: 11621 RVA: 0x00102DB8 File Offset: 0x00100FB8
	public void a(bool? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002D66 RID: 11622 RVA: 0x00102DC4 File Offset: 0x00100FC4
	public string c()
	{
		return this.c;
	}

	// Token: 0x06002D67 RID: 11623 RVA: 0x00102DCC File Offset: 0x00100FCC
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002D68 RID: 11624 RVA: 0x00102DD8 File Offset: 0x00100FD8
	public string a()
	{
		return this.d;
	}

	// Token: 0x06002D69 RID: 11625 RVA: 0x00102DE0 File Offset: 0x00100FE0
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002D6A RID: 11626 RVA: 0x00102DEC File Offset: 0x00100FEC
	public by2()
	{
	}

	// Token: 0x06002D6B RID: 11627 RVA: 0x00102DF8 File Offset: 0x00100FF8
	public override aw4 a1()
	{
		by2 by = new by2();
		this.rg(by);
		return by;
	}

	// Token: 0x06002D6C RID: 11628 RVA: 0x00102E14 File Offset: 0x00101014
	protected override c8d wx(int A_0)
	{
		cz2 cz = d79.Get<cz2>();
		if (cz != null)
		{
			int num = y8.a(A_0);
			int a_ = y8.a(A_0);
			fv fv = base.a(this.c, num);
			fv fv2 = zp.a(y8.a(A_0), this.d);
			if (fv != null && fv2 != null)
			{
				fv.QualityLevel = num;
				fv2.QualityLevel = a_;
				bool flag = this.a.GetValueOrDefault() || (this.a == null && zp.a.NextDouble() < 0.35);
				bool flag2 = this.b.GetValueOrDefault() || (this.a == null && zp.a.NextDouble() < 0.25);
				fv fv3 = null;
				fv fv4 = null;
				if (flag)
				{
					fv3 = zp.d(num, null);
					if (fv3 != null)
					{
						fv3.QualityLevel = y8.a(A_0);
					}
				}
				if (flag2)
				{
					fv4 = zp.b(num, null);
					if (fv4 != null)
					{
						fv4.QualityLevel = y8.a(A_0);
					}
				}
				return cz.a(null, new Dictionary<string, coh>
				{
					{
						cz2.a,
						fv
					},
					{
						cz2.b,
						fv2
					},
					{
						cz2.c,
						fv3
					},
					{
						cz2.d,
						fv4
					}
				}).a() as c8d;
			}
		}
		return null;
	}

	// Token: 0x06002D6D RID: 11629 RVA: 0x00102F9C File Offset: 0x0010119C
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		by2 by = A_0 as by2;
		by.c = this.c;
		by.d = this.d;
		by.b = this.b;
		by.a = this.a;
	}

	// Token: 0x040019B0 RID: 6576
	private new bool? a;

	// Token: 0x040019B1 RID: 6577
	private bool? b;

	// Token: 0x040019B2 RID: 6578
	private string c;

	// Token: 0x040019B3 RID: 6579
	private string d;
}
