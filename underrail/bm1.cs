using System;
using System.Runtime.Serialization;

// Token: 0x02001A6A RID: 6762
[eiz("HNRSE")]
[Serializable]
public sealed class bm1 : els, ISerializable
{
	// Token: 0x060092E2 RID: 37602 RVA: 0x003A0460 File Offset: 0x0039E660
	private bm1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x060092E3 RID: 37603 RVA: 0x003A046C File Offset: 0x0039E66C
	public override bool Visible
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060092E4 RID: 37604 RVA: 0x003A0474 File Offset: 0x0039E674
	public bm1() : base(bm1.a, "Бей и беги", ci8.a)
	{
		base.Duration = 1;
		base.Icon = "Misc.0";
		base.Stacking = axm.b;
		base.MaxStacks = int.MaxValue;
	}

	// Token: 0x060092E5 RID: 37605 RVA: 0x003A04B8 File Offset: 0x0039E6B8
	public override string cb(ll A_0)
	{
		return string.Empty;
	}

	// Token: 0x04003865 RID: 14437
	public new static readonly string a = "hit&run";
}
