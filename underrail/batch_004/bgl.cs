using System;
using System.Runtime.Serialization;

// Token: 0x02001A11 RID: 6673
[eiz("MCC")]
[Serializable]
public sealed class bgl : dts, ISerializable, d7s, em0
{
	// Token: 0x06009030 RID: 36912 RVA: 0x00399A14 File Offset: 0x00397C14
	private bgl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009031 RID: 36913 RVA: 0x00399A20 File Offset: 0x00397C20
	public bgl()
	{
	}

	// Token: 0x06009032 RID: 36914 RVA: 0x00399A28 File Offset: 0x00397C28
	public bgl(int A_0) : base(A_0)
	{
	}

	// Token: 0x06009033 RID: 36915 RVA: 0x00399A34 File Offset: 0x00397C34
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		A_0.a().CarryCapacity += base.c();
	}

	// Token: 0x06009034 RID: 36916 RVA: 0x00399A64 File Offset: 0x00397C64
	public void cn(d3e A_0)
	{
		bgl bgl = A_0 as bgl;
		if (bgl != null)
		{
			base.a(base.c() + bgl.c());
		}
	}

	// Token: 0x06009035 RID: 36917 RVA: 0x00399A94 File Offset: 0x00397C94
	public bool co(d3e A_0)
	{
		bgl bgl = A_0 as bgl;
		return bgl != null && bgl.Condition == base.Condition;
	}

	// Token: 0x06009036 RID: 36918 RVA: 0x00399AC0 File Offset: 0x00397CC0
	public override string b2()
	{
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifyCarryCapacity_Decreased", new object[]
			{
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifyCarryCapacity_Increased", new object[]
		{
			base.c()
		});
	}

	// Token: 0x06009037 RID: 36919 RVA: 0x00399B1C File Offset: 0x00397D1C
	public override d3e b3()
	{
		bgl bgl = new bgl();
		this.xx(bgl);
		return bgl;
	}
}
