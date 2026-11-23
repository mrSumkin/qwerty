using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02000F86 RID: 3974
[eiz("SFRGSCEA")]
[Serializable]
public sealed class asr : Aspect<c5x>, c98
{
	// Token: 0x060050E9 RID: 20713 RVA: 0x00246CFC File Offset: 0x00244EFC
	private asr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("SFRGSCEA:L", typeof(Guid));
	}

	// Token: 0x060050EA RID: 20714 RVA: 0x00246D28 File Offset: 0x00244F28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SFRGSCEA:L", this.a);
	}

	// Token: 0x060050EB RID: 20715 RVA: 0x00246D48 File Offset: 0x00244F48
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x060050EC RID: 20716 RVA: 0x00246D50 File Offset: 0x00244F50
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060050ED RID: 20717 RVA: 0x00246D5C File Offset: 0x00244F5C
	public asr(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060050EE RID: 20718 RVA: 0x00246D68 File Offset: 0x00244F68
	public void r7(eds A_0)
	{
		if (this.a != Guid.Empty && base.a8().p.b != null && base.a8().p.b.a.Count >= 2)
		{
			cd0 cd = base.a8().p.b.a[1];
			if (this.b == null)
			{
				c5x c5x = new ar7(this.a, base.a8().Area).ao() as c5x;
				if (c5x != null)
				{
					this.b = c5x.GetAspect<d2b>();
				}
			}
			if (this.b != null)
			{
				if (this.b.n())
				{
					cd.b = new Point(cd.b.X, 5);
					return;
				}
				cd.b = new Point(cd.b.X, 4);
			}
		}
	}

	// Token: 0x0400212A RID: 8490
	private Guid a;

	// Token: 0x0400212B RID: 8491
	[NonSerialized]
	private d2b b;
}
