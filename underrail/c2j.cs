using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001314 RID: 4884
[eiz("FEA")]
[a(typeof(cd0))]
[Serializable]
public sealed class c2j : cd0, ISerializable
{
	// Token: 0x06006D82 RID: 28034 RVA: 0x002DC200 File Offset: 0x002DA400
	private c2j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006D83 RID: 28035 RVA: 0x002DC20C File Offset: 0x002DA40C
	public c2j(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006D84 RID: 28036 RVA: 0x002DC218 File Offset: 0x002DA418
	public override void v2()
	{
		int num = this.b.Y * 9 + this.b.X;
		if (++num > 26)
		{
			num = 0;
		}
		this.b = new Point(num % 9, (num > 8) ? ((num > 17) ? 2 : 1) : 0);
	}

	// Token: 0x06006D85 RID: 28037 RVA: 0x002DC27C File Offset: 0x002DA47C
	public override void v3()
	{
		int num = this.b.Y * 9 + this.b.X;
		if (--num < 0)
		{
			num = 26;
		}
		this.b = new Point(num % 9, (num > 8) ? ((num > 17) ? 2 : 1) : 0);
	}
}
