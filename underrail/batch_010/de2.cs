using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006E8 RID: 1768
[eiz("L52")]
[Serializable]
public sealed class de2 : cpr, ISerializable
{
	// Token: 0x06002D8D RID: 11661 RVA: 0x001037B0 File Offset: 0x001019B0
	private de2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("L52:L");
		this.b = A_0.GetString("L52:B");
	}

	// Token: 0x06002D8E RID: 11662 RVA: 0x001037DC File Offset: 0x001019DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("L52:L", this.a);
		info.AddValue("L52:B", this.b);
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x00103808 File Offset: 0x00101A08
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002D90 RID: 11664 RVA: 0x00103810 File Offset: 0x00101A10
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D91 RID: 11665 RVA: 0x0010381C File Offset: 0x00101A1C
	public string b()
	{
		return this.b;
	}

	// Token: 0x06002D92 RID: 11666 RVA: 0x00103824 File Offset: 0x00101A24
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002D93 RID: 11667 RVA: 0x00103830 File Offset: 0x00101A30
	public de2()
	{
	}

	// Token: 0x06002D94 RID: 11668 RVA: 0x0010383C File Offset: 0x00101A3C
	public override aw4 a1()
	{
		de2 de = new de2();
		this.rg(de);
		return de;
	}

	// Token: 0x06002D95 RID: 11669 RVA: 0x00103858 File Offset: 0x00101A58
	protected override c8d wx(int A_0)
	{
		bdd bdd = d79.Get<bdd>();
		if (bdd != null)
		{
			int num = y8.a(A_0);
			int a_ = y8.a(A_0);
			fv fv = base.a(this.a, num);
			fv fv2 = zp.d(y8.a(A_0), this.b);
			if (fv != null && fv2 != null)
			{
				fv.QualityLevel = num;
				fv2.QualityLevel = a_;
				fv value = de2.a(A_0);
				fv value2 = de2.a(A_0);
				fv value3 = de2.a(A_0);
				return bdd.a(null, new Dictionary<string, coh>
				{
					{
						bdd.b,
						fv
					},
					{
						bdd.a,
						fv2
					},
					{
						bdd.c,
						value
					},
					{
						bdd.d,
						value2
					},
					{
						bdd.e,
						value3
					}
				}).a() as c8d;
			}
		}
		return null;
	}

	// Token: 0x06002D96 RID: 11670 RVA: 0x00103938 File Offset: 0x00101B38
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		de2 de = A_0 as de2;
		de.a = this.a;
		de.b = this.b;
	}

	// Token: 0x06002D97 RID: 11671 RVA: 0x00103960 File Offset: 0x00101B60
	private new static fv a(int A_0)
	{
		int a_ = y8.a(A_0);
		fv fv = zp.a(a_, 0.2);
		if (fv != null)
		{
			fv.QualityLevel = a_;
		}
		return fv;
	}

	// Token: 0x040019BC RID: 6588
	private new string a;

	// Token: 0x040019BD RID: 6589
	private string b;
}
