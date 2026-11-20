using System;
using System.Runtime.Serialization;

// Token: 0x02001257 RID: 4695
[eiz("LESC")]
[Serializable]
public sealed class bfx : bak
{
	// Token: 0x0600657F RID: 25983 RVA: 0x002B378C File Offset: 0x002B198C
	private bfx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("LESC:L");
	}

	// Token: 0x06006580 RID: 25984 RVA: 0x002B37A8 File Offset: 0x002B19A8
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("LESC:L", this.a);
	}

	// Token: 0x06006581 RID: 25985 RVA: 0x002B37C4 File Offset: 0x002B19C4
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06006582 RID: 25986 RVA: 0x002B37CC File Offset: 0x002B19CC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006583 RID: 25987 RVA: 0x002B37D8 File Offset: 0x002B19D8
	public bfx()
	{
	}

	// Token: 0x06006584 RID: 25988 RVA: 0x002B37E0 File Offset: 0x002B19E0
	public override string ji()
	{
		return base.ji() + (this.a ? "locked" : "unlocked");
	}

	// Token: 0x06006585 RID: 25989 RVA: 0x002B3808 File Offset: 0x002B1A08
	protected override bool xu(c5x A_0, e2f A_1)
	{
		d2b aspect = A_0.GetAspect<d2b>();
		return (aspect != null && aspect.n()) == this.a;
	}

	// Token: 0x04002A41 RID: 10817
	private bool a;
}
