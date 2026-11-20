using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014BF RID: 5311
[eiz("PLM0")]
[Serializable]
public sealed class az5 : c11, ISerializable
{
	// Token: 0x06007752 RID: 30546 RVA: 0x00324D80 File Offset: 0x00322F80
	private az5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007753 RID: 30547 RVA: 0x00324D8C File Offset: 0x00322F8C
	public az5()
	{
	}

	// Token: 0x06007754 RID: 30548 RVA: 0x00324D94 File Offset: 0x00322F94
	protected override string de()
	{
		return "objects\\traps\\xpbl_plasmaMine";
	}

	// Token: 0x06007755 RID: 30549 RVA: 0x00324D9C File Offset: 0x00322F9C
	protected override string df()
	{
		return "xpbl_ArmPlasmaMine";
	}

	// Token: 0x06007756 RID: 30550 RVA: 0x00324DA4 File Offset: 0x00322FA4
	protected override string dg()
	{
		return "xpbl_DisarmPlasmaMine";
	}

	// Token: 0x06007757 RID: 30551 RVA: 0x00324DAC File Offset: 0x00322FAC
	protected override Point dh(coh A_0)
	{
		int num = 1;
		if (A_0 != null)
		{
			c4j c4j = A_0.Definition as c4j;
			if (c4j != null)
			{
				num = c4j.a7().GetPrimitivePropertyValue<int>("power", new int?(1)).Value;
			}
		}
		return new Point(0, num - 1);
	}

	// Token: 0x06007758 RID: 30552 RVA: 0x00324DFC File Offset: 0x00322FFC
	protected override string di()
	{
		return "Плазменная мина";
	}

	// Token: 0x06007759 RID: 30553 RVA: 0x00324E04 File Offset: 0x00323004
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new dgx(A_0, A_1);
	}

	// Token: 0x0600775A RID: 30554 RVA: 0x00324E10 File Offset: 0x00323010
	protected override Color tf()
	{
		return new Color(0, 255, 255);
	}

	// Token: 0x0600775B RID: 30555 RVA: 0x00324E24 File Offset: 0x00323024
	protected override Color tg()
	{
		return new Color(255, 0, 0);
	}
}
