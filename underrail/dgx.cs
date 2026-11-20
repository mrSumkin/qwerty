using System;
using System.Runtime.Serialization;

// Token: 0x020011FA RID: 4602
[eiz("PLMT")]
[Serializable]
public sealed class dgx : uo, ISerializable
{
	// Token: 0x060062D3 RID: 25299 RVA: 0x002AB950 File Offset: 0x002A9B50
	private dgx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062D4 RID: 25300 RVA: 0x002AB95C File Offset: 0x002A9B5C
	protected override string rm()
	{
		return "xpbl_PlasmaMineActivate";
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x002AB964 File Offset: 0x002A9B64
	protected override string rn()
	{
		return "plasma mine";
	}

	// Token: 0x060062D6 RID: 25302 RVA: 0x002AB96C File Offset: 0x002A9B6C
	protected override string ro()
	{
		return bby.a();
	}

	// Token: 0x060062D7 RID: 25303 RVA: 0x002AB974 File Offset: 0x002A9B74
	protected override string aj6()
	{
		return "EmpBlast";
	}

	// Token: 0x060062D8 RID: 25304 RVA: 0x002AB97C File Offset: 0x002A9B7C
	protected override float rs()
	{
		return aju.bd;
	}

	// Token: 0x060062D9 RID: 25305 RVA: 0x002AB984 File Offset: 0x002A9B84
	protected override int aj7()
	{
		return c18.h();
	}

	// Token: 0x060062DA RID: 25306 RVA: 0x002AB98C File Offset: 0x002A9B8C
	protected override b6a rp()
	{
		return new e14();
	}

	// Token: 0x060062DB RID: 25307 RVA: 0x002AB994 File Offset: 0x002A9B94
	protected override blv rq()
	{
		return bby.f();
	}

	// Token: 0x060062DC RID: 25308 RVA: 0x002AB99C File Offset: 0x002A9B9C
	protected override double rr()
	{
		return (double)bby.e();
	}

	// Token: 0x060062DD RID: 25309 RVA: 0x002AB9A4 File Offset: 0x002A9BA4
	public dgx(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}
}
