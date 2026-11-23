using System;
using System.Runtime.Serialization;

// Token: 0x02001AC1 RID: 6849
[eiz("HYPA")]
[Serializable]
public sealed class bek : els, ISerializable
{
	// Token: 0x0600947D RID: 38013 RVA: 0x003A6628 File Offset: 0x003A4828
	private bek(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600947E RID: 38014 RVA: 0x003A6634 File Offset: 0x003A4834
	public bek(int A_0, int A_1) : base(bek.a, "Гипералергик", ci8.c)
	{
		base.Icon = "Status.99";
		base.Duration = A_0;
		base.Power = A_1;
		base.Stacking = axm.b;
	}

	// Token: 0x0600947F RID: 38015 RVA: 0x003A6674 File Offset: 0x003A4874
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Hyperallergenic", new object[]
		{
			base.Power,
			l4.a(bek.b, false)
		});
	}

	// Token: 0x0400391A RID: 14618
	public new static readonly string a = "hyperallergenic";

	// Token: 0x0400391B RID: 14619
	public static readonly int b = 3;

	// Token: 0x0400391C RID: 14620
	public new static readonly int c = 10;
}
