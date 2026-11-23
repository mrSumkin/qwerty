using System;
using System.Runtime.Serialization;

// Token: 0x02001A69 RID: 6761
[eiz("FFWSE")]
[Serializable]
public sealed class ey6 : els, ISerializable
{
	// Token: 0x060092DD RID: 37597 RVA: 0x003A03F4 File Offset: 0x0039E5F4
	private ey6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x060092DE RID: 37598 RVA: 0x003A0400 File Offset: 0x0039E600
	public override bool Visible
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060092DF RID: 37599 RVA: 0x003A0408 File Offset: 0x0039E608
	public ey6() : base(ey6.a, "Работа ног", ci8.a)
	{
		base.Duration = 1;
		base.Icon = "Misc.0";
		base.Stacking = axm.b;
		base.MaxStacks = int.MaxValue;
	}

	// Token: 0x060092E0 RID: 37600 RVA: 0x003A044C File Offset: 0x0039E64C
	public override string cb(ll A_0)
	{
		return string.Empty;
	}

	// Token: 0x04003864 RID: 14436
	public new static readonly string a = "fancyFootwork";
}
