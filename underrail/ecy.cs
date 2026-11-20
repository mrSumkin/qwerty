using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006E7 RID: 1767
[eiz("L53")]
[Serializable]
public sealed class ecy : y8, ISerializable
{
	// Token: 0x06002D85 RID: 11653 RVA: 0x00103644 File Offset: 0x00101844
	private ecy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("L53:A");
	}

	// Token: 0x06002D86 RID: 11654 RVA: 0x00103660 File Offset: 0x00101860
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("L53:A", this.a);
	}

	// Token: 0x06002D87 RID: 11655 RVA: 0x0010367C File Offset: 0x0010187C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002D88 RID: 11656 RVA: 0x00103684 File Offset: 0x00101884
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D89 RID: 11657 RVA: 0x00103690 File Offset: 0x00101890
	public ecy()
	{
	}

	// Token: 0x06002D8A RID: 11658 RVA: 0x0010369C File Offset: 0x0010189C
	public override aw4 a1()
	{
		ecy ecy = new ecy();
		this.rg(ecy);
		return ecy;
	}

	// Token: 0x06002D8B RID: 11659 RVA: 0x001036B8 File Offset: 0x001018B8
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		dae dae = d79.Get<dae>();
		if (dae != null)
		{
			int a_ = base.i();
			int a_2 = y8.a(a_);
			int a_3 = y8.a(a_);
			fv fv = zp.d(a_2, this.a);
			fv fv2 = zp.a(a_3);
			fv fv3 = y8.a("armors\\visor", null);
			if (fv != null && fv2 != null && fv3 != null)
			{
				fv.QualityLevel = a_2;
				fv2.QualityLevel = a_3;
				k7 k = dae.a(null, new Dictionary<string, coh>
				{
					{
						dae.a,
						fv
					},
					{
						dae.b,
						fv2
					},
					{
						dae.c,
						fv3
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

	// Token: 0x06002D8C RID: 11660 RVA: 0x00103794 File Offset: 0x00101994
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		(A_0 as ecy).a = this.a;
	}

	// Token: 0x040019BB RID: 6587
	private new string a;
}
