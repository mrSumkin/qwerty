using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001ABF RID: 6847
[eiz("SMKSE")]
[Serializable]
public sealed class eys : els, ISerializable
{
	// Token: 0x06009471 RID: 38001 RVA: 0x003A6480 File Offset: 0x003A4680
	private eys(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009472 RID: 38002 RVA: 0x003A648C File Offset: 0x003A468C
	public eys(int A_0) : base(eys.a, "Курево", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Food.22";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new emn(eys.d));
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Constitution.ToString(), -eys.e));
	}

	// Token: 0x06009473 RID: 38003 RVA: 0x003A6500 File Offset: 0x003A4700
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Smoking", new object[]
		{
			eys.d,
			eys.e
		});
	}

	// Token: 0x04003913 RID: 14611
	public new static readonly string a = "smoking";

	// Token: 0x04003914 RID: 14612
	public static readonly int b = 2;

	// Token: 0x04003915 RID: 14613
	public new static readonly int c = eys.b * 60 * 1000;

	// Token: 0x04003916 RID: 14614
	public new static readonly int d = 3;

	// Token: 0x04003917 RID: 14615
	public new static readonly int e = 1;
}
