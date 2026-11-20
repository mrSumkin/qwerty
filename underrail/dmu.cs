using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200127B RID: 4731
[eiz("VPEEA")]
[Serializable]
public sealed class dmu : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x060066C7 RID: 26311 RVA: 0x002BAA0C File Offset: 0x002B8C0C
	private dmu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("VPEEA:I");
	}

	// Token: 0x060066C8 RID: 26312 RVA: 0x002BAA38 File Offset: 0x002B8C38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VPEEA:I", this.b);
	}

	// Token: 0x060066C9 RID: 26313 RVA: 0x002BAA54 File Offset: 0x002B8C54
	public double a()
	{
		return this.b;
	}

	// Token: 0x060066CA RID: 26314 RVA: 0x002BAA5C File Offset: 0x002B8C5C
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060066CB RID: 26315 RVA: 0x002BAA68 File Offset: 0x002B8C68
	public dmu(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066CC RID: 26316 RVA: 0x002BAA80 File Offset: 0x002B8C80
	public void r7(eds A_0)
	{
		if ((this.c += A_0.b.TotalMilliseconds) > (double)dmu.a)
		{
			this.c -= (double)dmu.a;
			if (this.b > 0.0)
			{
				int a_ = Convert.ToInt32((double)(dmu.a / 50) * this.b);
				float a_2 = Convert.ToSingle(0.5 + 0.5 * this.b);
				Convert.ToSingle(1.0 + 1.0 * this.b);
				aex.a(base.a8().Area, base.a8().Location, a_, dmu.a, a_2, 1f, false, true);
			}
		}
	}

	// Token: 0x04002AA1 RID: 10913
	private static readonly int a = 200;

	// Token: 0x04002AA2 RID: 10914
	private double b = 1.0;

	// Token: 0x04002AA3 RID: 10915
	[NonSerialized]
	private double c;
}
