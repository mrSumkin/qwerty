using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001237 RID: 4663
[eiz("INSN")]
[Serializable]
public sealed class dh1 : c3r, ISerializable
{
	// Token: 0x0600648E RID: 25742 RVA: 0x002B1E74 File Offset: 0x002B0074
	private dh1(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("INSN:B");
		this.b = A_0.GetInt32("INSN:R");
		this.c = A_0.GetInt32("INSN:O");
	}

	// Token: 0x0600648F RID: 25743 RVA: 0x002B1EBC File Offset: 0x002B00BC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("INSN:B", this.a);
		info.AddValue("INSN:R", this.b);
		info.AddValue("INSN:O", this.c);
	}

	// Token: 0x06006490 RID: 25744 RVA: 0x002B1EF4 File Offset: 0x002B00F4
	public int a()
	{
		return this.a;
	}

	// Token: 0x06006491 RID: 25745 RVA: 0x002B1EFC File Offset: 0x002B00FC
	public int c()
	{
		return this.b;
	}

	// Token: 0x06006492 RID: 25746 RVA: 0x002B1F04 File Offset: 0x002B0104
	public int b()
	{
		return this.c;
	}

	// Token: 0x06006493 RID: 25747 RVA: 0x002B1F0C File Offset: 0x002B010C
	public string sf()
	{
		return null;
	}

	// Token: 0x06006494 RID: 25748 RVA: 0x002B1F14 File Offset: 0x002B0114
	public string sg()
	{
		if (this.c > 0)
		{
			return string.Format("Инициатива: {0} + {1} + {2} = {3}", new object[]
			{
				this.a,
				this.b,
				this.c,
				this.a + this.b + this.c
			});
		}
		if (this.c < 0)
		{
			return string.Format("Инициатива: {0} + {1} - {2} = {3}", new object[]
			{
				this.a,
				this.b,
				Math.Abs(this.c),
				this.a + this.b + this.c
			});
		}
		return string.Format("Инициатива: {0} + {1} = {2}", this.a, this.b, this.a + this.b);
	}

	// Token: 0x06006495 RID: 25749 RVA: 0x002B2020 File Offset: 0x002B0220
	public Color sh()
	{
		return Color.White;
	}

	// Token: 0x06006496 RID: 25750 RVA: 0x002B2028 File Offset: 0x002B0228
	public bool si()
	{
		return false;
	}

	// Token: 0x06006497 RID: 25751 RVA: 0x002B202C File Offset: 0x002B022C
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.Initiative;
	}

	// Token: 0x06006498 RID: 25752 RVA: 0x002B2034 File Offset: 0x002B0234
	public dh1(int A_0, int A_1, int A_2 = 0)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x04002A18 RID: 10776
	private int a;

	// Token: 0x04002A19 RID: 10777
	private int b;

	// Token: 0x04002A1A RID: 10778
	private int c;
}
