using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006DF RID: 1759
[eiz("BG0")]
[Serializable]
public sealed class n : y8, ISerializable
{
	// Token: 0x06002D49 RID: 11593 RVA: 0x00102748 File Offset: 0x00100948
	private n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("BG0:F");
	}

	// Token: 0x06002D4A RID: 11594 RVA: 0x00102764 File Offset: 0x00100964
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BG0:F", this.a);
	}

	// Token: 0x06002D4B RID: 11595 RVA: 0x00102780 File Offset: 0x00100980
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002D4C RID: 11596 RVA: 0x00102788 File Offset: 0x00100988
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D4D RID: 11597 RVA: 0x00102794 File Offset: 0x00100994
	public n()
	{
	}

	// Token: 0x06002D4E RID: 11598 RVA: 0x001027A0 File Offset: 0x001009A0
	public override aw4 a1()
	{
		n n = new n();
		this.rg(n);
		return n;
	}

	// Token: 0x06002D4F RID: 11599 RVA: 0x001027BC File Offset: 0x001009BC
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		dhl dhl = d79.Get<dhl>();
		if (dhl != null)
		{
			int a_ = y8.a(base.i());
			fv fv = zp.b(a_, this.a);
			if (fv != null)
			{
				fv.QualityLevel = a_;
				list.Add(dhl.a(null, new Dictionary<string, coh>
				{
					{
						dhl.a,
						fv
					}
				}).a() as k7);
			}
		}
		return list;
	}

	// Token: 0x06002D50 RID: 11600 RVA: 0x00102830 File Offset: 0x00100A30
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		(A_0 as n).a = this.a;
	}

	// Token: 0x040019AE RID: 6574
	private new string a;
}
