using System;
using System.Runtime.Serialization;

// Token: 0x02001A2C RID: 6700
[eiz("B60")]
[dn2("bleedingWound")]
[Serializable]
public sealed class mi : buu, ISerializable
{
	// Token: 0x0600911D RID: 37149 RVA: 0x0039C308 File Offset: 0x0039A508
	private mi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600911E RID: 37150 RVA: 0x0039C318 File Offset: 0x0039A518
	public override string e1(edm A_0)
	{
		int num = mi.b(A_0) / d0u.b;
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% нанести кровоточащую рану, причиняющую дополнительно {1}% урона в течение {2} ход{3}.", new object[]
			{
				(int)(A_0.Chance * 100.0),
				A_0.Power,
				num,
				(num > 1) ? "ов" : ""
			});
		}
		return string.Format("Нанести кровоточащую рану, причиняющую дополнительно {0}% урона в течение {1} ход{2}.", A_0.Power, num, (num > 1) ? "ов" : "");
	}

	// Token: 0x0600911F RID: 37151 RVA: 0x0039C3D4 File Offset: 0x0039A5D4
	public static int b(edm A_0)
	{
		return 3 * d0u.b;
	}

	// Token: 0x06009120 RID: 37152 RVA: 0x0039C3E0 File Offset: 0x0039A5E0
	public new static double a(edm A_0)
	{
		return (double)A_0.Power / 100.0;
	}

	// Token: 0x06009121 RID: 37153 RVA: 0x0039C3F4 File Offset: 0x0039A5F4
	public mi()
	{
	}

	// Token: 0x04003822 RID: 14370
	public new static readonly string a = "bleedingWound";
}
