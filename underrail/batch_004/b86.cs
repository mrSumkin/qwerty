using System;
using System.Runtime.Serialization;

// Token: 0x020019A6 RID: 6566
[eiz("PIHE")]
[dn2("pneumaticImpact")]
[Serializable]
public sealed class b86 : buu, ISerializable
{
	// Token: 0x06008C2B RID: 35883 RVA: 0x00390D5C File Offset: 0x0038EF5C
	private b86(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C2C RID: 35884 RVA: 0x00390D68 File Offset: 0x0038EF68
	public b86()
	{
	}

	// Token: 0x06008C2D RID: 35885 RVA: 0x00390D74 File Offset: 0x0038EF74
	public override string e1(edm A_0)
	{
		int num = b86.c(A_0);
		double num2 = b86.b(A_0);
		int a_ = b86.a(A_0);
		return string.Format("Каждый четвёртый удар наносит дополнительно {0}% урона и ошеломляет цель на срок до {1}. Затрачивает {2} энергии.", (int)(num2 * 100.0), l4.a(a_, false), num);
	}

	// Token: 0x06008C2E RID: 35886 RVA: 0x00390DC0 File Offset: 0x0038EFC0
	public static int c(edm A_0)
	{
		return 3 + A_0.Power / 8;
	}

	// Token: 0x06008C2F RID: 35887 RVA: 0x00390DCC File Offset: 0x0038EFCC
	public static double b(edm A_0)
	{
		return 1.5 + (double)A_0.Power / 100.0;
	}

	// Token: 0x06008C30 RID: 35888 RVA: 0x00390DEC File Offset: 0x0038EFEC
	public new static int a(edm A_0)
	{
		return 2 + A_0.Power / 50;
	}
}
