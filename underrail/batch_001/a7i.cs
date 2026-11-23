using System;
using System.Runtime.Serialization;

// Token: 0x02001969 RID: 6505
[eiz("REF")]
[Serializable]
public sealed class a7i : wq, ISerializable
{
	// Token: 0x06008B3A RID: 35642 RVA: 0x0038ED7C File Offset: 0x0038CF7C
	private a7i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("RV1:A");
		if (ell.a() >= 670)
		{
			this.b = A_0.GetSingle("RV1:L");
		}
	}

	// Token: 0x06008B3B RID: 35643 RVA: 0x0038EDB8 File Offset: 0x0038CFB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RV1:A", this.a);
		info.AddValue("RV1:L", this.b);
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06008B3C RID: 35644 RVA: 0x0038EDE4 File Offset: 0x0038CFE4
	// (set) Token: 0x06008B3D RID: 35645 RVA: 0x0038EDEC File Offset: 0x0038CFEC
	public int Amount
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06008B3E RID: 35646 RVA: 0x0038EDF8 File Offset: 0x0038CFF8
	// (set) Token: 0x06008B3F RID: 35647 RVA: 0x0038EE00 File Offset: 0x0038D000
	public float Limit
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x06008B40 RID: 35648 RVA: 0x0038EE0C File Offset: 0x0038D00C
	public a7i()
	{
	}

	// Token: 0x06008B41 RID: 35649 RVA: 0x0038EE14 File Offset: 0x0038D014
	public a7i(int A_0, float A_1 = 0f)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06008B42 RID: 35650 RVA: 0x0038EE2C File Offset: 0x0038D02C
	public override void dk(ll A_0, int A_1)
	{
		this.dl(A_0, A_1);
	}

	// Token: 0x06008B43 RID: 35651 RVA: 0x0038EE38 File Offset: 0x0038D038
	public override void dl(ll A_0, int A_1)
	{
		if (A_0 != null && A_0.a() != null && !A_0.a().Dead && !A_0.a().SpecialStates.h)
		{
			A_0.a().Defense.a(this.a, null, null, true, false, false, new float?(this.b));
		}
	}

	// Token: 0x06008B44 RID: 35652 RVA: 0x0038EEA4 File Offset: 0x0038D0A4
	public override string dm()
	{
		if (this.b > 0f && this.b < 1f)
		{
			return qv.a("DynamicEffects/RegenerateLimited", new object[]
			{
				this.a,
				Convert.ToInt32(this.b * 100f)
			});
		}
		return qv.a("DynamicEffects/Regenerate", new object[]
		{
			this.a
		});
	}

	// Token: 0x06008B45 RID: 35653 RVA: 0x0038EF28 File Offset: 0x0038D128
	public override wq dn()
	{
		a7i a7i = new a7i();
		this.@do(a7i);
		return a7i;
	}

	// Token: 0x06008B46 RID: 35654 RVA: 0x0038EF44 File Offset: 0x0038D144
	protected override void @do(wq A_0)
	{
		base.@do(A_0);
		a7i a7i = (a7i)A_0;
		a7i.b = this.b;
		a7i.a = this.a;
	}

	// Token: 0x0400378F RID: 14223
	private int a;

	// Token: 0x04003790 RID: 14224
	private float b;
}
