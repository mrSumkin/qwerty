using System;
using System.Runtime.Serialization;

// Token: 0x020019EA RID: 6634
[eiz("MPSSLEF")]
[Serializable]
public sealed class n8 : dts, d7s, bdr, ISerializable
{
	// Token: 0x06008EBA RID: 36538 RVA: 0x003963A4 File Offset: 0x003945A4
	private n8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008EBB RID: 36539 RVA: 0x003963B0 File Offset: 0x003945B0
	public n8()
	{
	}

	// Token: 0x06008EBC RID: 36540 RVA: 0x003963B8 File Offset: 0x003945B8
	public n8(int A_0) : base(A_0)
	{
	}

	// Token: 0x06008EBD RID: 36541 RVA: 0x003963C4 File Offset: 0x003945C4
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			A_0.a().Offense.aj += base.c();
		}
	}

	// Token: 0x06008EBE RID: 36542 RVA: 0x00396400 File Offset: 0x00394600
	public void cn(d3e A_0)
	{
		n8 n = A_0 as n8;
		if (n != null)
		{
			base.a(base.c() + n.c());
		}
	}

	// Token: 0x06008EBF RID: 36543 RVA: 0x00396430 File Offset: 0x00394630
	public bool co(d3e A_0)
	{
		return A_0 is n8;
	}

	// Token: 0x06008EC0 RID: 36544 RVA: 0x0039643C File Offset: 0x0039463C
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyPsiSlots_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyPsiSlots_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06008EC1 RID: 36545 RVA: 0x00396498 File Offset: 0x00394698
	public override d3e b3()
	{
		n8 n = new n8();
		this.xx(n);
		return n;
	}
}
