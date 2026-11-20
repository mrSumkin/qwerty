using System;
using System.Runtime.Serialization;

// Token: 0x02001A61 RID: 6753
[eiz("BWUAM")]
[Serializable]
public sealed class y0 : bns, ISerializable
{
	// Token: 0x0600929F RID: 37535 RVA: 0x0039FC74 File Offset: 0x0039DE74
	private y0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("BWUAM:R");
		this.b = A_0.GetInt32("BWUAM:S");
	}

	// Token: 0x060092A0 RID: 37536 RVA: 0x0039FCC4 File Offset: 0x0039DEC4
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("BWUAM:R", this.a);
		info.AddValue("BWUAM:S", this.b);
	}

	// Token: 0x060092A1 RID: 37537 RVA: 0x0039FCF0 File Offset: 0x0039DEF0
	public y0()
	{
	}

	// Token: 0x060092A2 RID: 37538 RVA: 0x0039FD10 File Offset: 0x0039DF10
	public override string h0(cd1 A_0)
	{
		return string.Format("При стрельбе очередью увеличивается количество дополнительных выстрелов на {0} (округлённое в меньшую сторону) до конца следующего хода. Также снижает затраты очков действия на стрельбу очередью в два раза. Складывается до {1} раз.", this.a, this.b);
	}

	// Token: 0x060092A3 RID: 37539 RVA: 0x0039FD38 File Offset: 0x0039DF38
	public override bns h1()
	{
		y0 y = new y0();
		this.h2(y);
		return y;
	}

	// Token: 0x060092A4 RID: 37540 RVA: 0x0039FD54 File Offset: 0x0039DF54
	protected override void h2(bns A_0)
	{
		base.h2(A_0);
		y0 y = A_0 as y0;
		if (y != null)
		{
			y.a = this.a;
			y.b = this.b;
		}
	}

	// Token: 0x0400385E RID: 14430
	public new double a = 1.0;

	// Token: 0x0400385F RID: 14431
	public int b = 3;
}
